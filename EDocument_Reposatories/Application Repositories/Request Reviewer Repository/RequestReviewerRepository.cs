﻿using AutoMapper;
using Azure.Core;
using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using EDocument_Data.Models;
using EDocument_EF;
using EDocument_Reposatories.Generic_Reposatories;
using EDocument_Repositories.Application_Repositories.UserRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using System.Text;

namespace EDocument_Repositories.Application_Repositories.Request_Reviewer_Repository
{
    public class RequestReviewerRepository : GenericRepository<RequestReviewer>, IRequestReviewerRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public RequestReviewerRepository(ApplicationDbContext context, IUserRepository userRepository, IMapper mapper) : base(context)
        {
            _context = context;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DefinedRequestReviewer>> GetAllDefinedRequestReviewersAsync(long definedRequestId)
        {
            return await _context.DefinedRequestReviewers.Where(rr => rr.DefinedRequestId == definedRequestId).AsNoTracking().ToListAsync();
        }

        public async Task<List<ReviewersDetails>> GetAllRequestReviewersAsync(long requestId)
        {
            var reviewersDetails = new List<ReviewersDetails>();
            var stages = _context.RequestReviewers.Where(rr => rr.RequestId == requestId).AsEnumerable().DistinctBy(r => r.StageNumber).Select(rr => new { rr.StageNumber, rr.StageName, rr.Status, rr.ReviewedBy, rr.ReviewerNotes }).ToList();

            var availableReviewers = await _context.RequestReviewers.Include(rr => rr.Reviewer).AsNoTracking().Where(rr => rr.RequestId == requestId).ToListAsync();

            foreach (var stage in stages)
            {
                var stageDetails = new ReviewersDetails
                {
                    StageNumber = stage.StageNumber,
                    StageTitle = stage.StageName,
                    Status = (RequestStatus)Enum.Parse(typeof(RequestStatus), stage.Status),
                    ReviewedBy = stage.ReviewedBy,
                    ReviewerNotes = stage.ReviewerNotes
                };
                var assignedReviewers = new List<string>();

                foreach (var reviewer in availableReviewers)
                {
                    if (reviewer.StageNumber == stage.StageNumber)
                    {
                        assignedReviewers.Add(reviewer.Reviewer.FullName);
                    }
                }
                stageDetails.AssignedReviewers = assignedReviewers;
                reviewersDetails.Add(stageDetails);
            }

            return reviewersDetails.OrderBy(r => r.StageNumber).ToList();
        }

        public async Task<string> GetAllRequestReviewersEmailsByStageNumberAsync(long requestId, int stageNumber)
        {
            var requestReviewersIds = await _context.RequestReviewers.Where(rr => rr.RequestId == requestId && rr.StageNumber == stageNumber).Select(rr => rr.AssignedReviewerId).ToListAsync();

            var requestReviewersEmails = new StringBuilder();
            foreach (var reviewerId in requestReviewersIds)
            {
                requestReviewersEmails.Append($"{await _userRepository.GetUserEmailByIdAsync(reviewerId)};");
            }

            return requestReviewersEmails.ToString();
        }

        public async Task NominateReviewer(long requestId, string reviewerId, string naminatedBy)
        {
            var nominatedReviewer = await _context.RequestReviewers.FirstOrDefaultAsync(rr => rr.ReviewerType == ReviewerType.NominatedReviewer && rr.RequestId == requestId);
            if (nominatedReviewer != null)
            {
                nominatedReviewer.AssignedReviewerId = reviewerId;
                nominatedReviewer.ModifiedBy = naminatedBy;
            }
            _context.Update(nominatedReviewer);
            _context.SaveChanges();
        }

        public async Task BeginRequestCycle(long definedRequestId, long requestId, bool isNew)
        {
            var definedRequestReviewers = await GetAllDefinedRequestReviewersAsync(definedRequestId);

            var request = await _context.Requests.FirstOrDefaultAsync(r => r.Id == requestId);
            _mapper.Map(definedRequestReviewers, request?.RequestReviewers);

            foreach (var item in request?.RequestReviewers)
            {
                if(item.StageNumber == 1) 
                    item.Status = RequestStatus.Pending.ToString();

                if (isNew)
                {
                    item.Key = Guid.NewGuid().ToString();
                    item.RequestId = requestId;
                    item.CreatedBy = "E-Document";
                }
                else
                {
                    item.ModifiedBy = "E-Document";
                }
            }

            var firstReviewer = request?.RequestReviewers.FirstOrDefault(rr => rr.StageNumber == 1);

            if (firstReviewer != null)
            {
                switch (firstReviewer.ReviewerType)
                {
                    case ReviewerType.DirectManager:
                        firstReviewer.AssignedReviewerId = _userRepository.FindDirectManagerByIdAsync(request.CreatorId)?.Result.Value.Id;
                        break;

                    case ReviewerType.SectionHead:
                        firstReviewer.AssignedReviewerId = _userRepository.FindSectionHeadByIdAsync(request.CreatorId)?.Result.Value.Id;
                        break;

                    case ReviewerType.DepartmentManager:
                        firstReviewer.AssignedReviewerId = _userRepository.FindDepartmentManagerByIdAsync(request.CreatorId)?.Result.Value.Id;
                        break;

                    default:
                        break;
                }


                // Skip All Approval steps for the creator if he is one of the reviewers
                if (request.RequestReviewers.Any(r => r.AssignedReviewerId == request.CreatorId))
                {
                    foreach (var reviewer in request.RequestReviewers.Where(r => r.AssignedReviewerId == request.CreatorId))
                    {
                        reviewer.Status = RequestStatus.Approved.ToString();
                        reviewer.ReviewedBy = "E-Documnet";
                        reviewer.ReviewerNotes = "Automatically Approved By E-Document";
                    }
                }

                //Skip Approval step if the the first reviewer is also existing in advanced stages
                if (request.RequestReviewers.Any(r => r.AssignedReviewerId == firstReviewer?.AssignedReviewerId &&
                !r.StageNumber.Equals(1)&&
                r.Status!= RequestStatus.Approved.ToString()))
                {
                    firstReviewer.Status = RequestStatus.Approved.ToString();
                    firstReviewer.ReviewedBy = "E-Documnet";
                    firstReviewer.ReviewerNotes = "Automatically Approved By E-Document";
                }


               
            }

            //Proceed with approved stages
            foreach (var reviewer in request.RequestReviewers)
            {
                if (reviewer.Status == RequestStatus.Approved.ToString())
                {
                    request.CurrentStage++;
                }
                else
                {
                    break;
                }
            }

            //Change current reviewer status from none to pending
            request.RequestReviewers.Where(rr => rr.StageNumber == request.CurrentStage).ToList().ForEach(r => r.Status = RequestStatus.Pending.ToString());

            if (isNew)
            {
                _context.AddRange(request?.RequestReviewers);
            }
            else
            {
                _context.UpdateRange(request?.RequestReviewers);
            }

            _context.Update(request);
            _context.SaveChanges();
        }

        public async Task ApproveRequestAsync(ApproveRequestReviewerDto reviewingInfo, string reviewedBy)
        {
            var remainingRequestReviewers = await _context.RequestReviewers.Include(r => r.Request).Include(dr => dr.Request.DefinedRequest).Where(rr => rr.RequestId == reviewingInfo.RequestId && rr.StageNumber >= rr.Request.CurrentStage).ToListAsync();
            foreach (var reviewer in remainingRequestReviewers.Where(rr=>rr.StageNumber==rr.Request.CurrentStage))
            {
                reviewer.ReviewedBy = reviewedBy;
                reviewer.Status = RequestStatus.Approved.ToString();
                reviewer.ReviewerNotes = reviewingInfo.ReviewedNotes;
                reviewer.ModifiedBy = reviewedBy;
            }

            if (remainingRequestReviewers[0].Request.CurrentStage == remainingRequestReviewers[0].Request.DefinedRequest.ReviewersNumber)
            {
                remainingRequestReviewers[0].Request.Status = RequestStatus.Approved.ToString();
            }
            else
            {
                remainingRequestReviewers[0].Request.CurrentStage = remainingRequestReviewers[0].Request.CurrentStage+1;

                //Proceed with approved stages
                foreach (var reviewer in remainingRequestReviewers.OrderBy(r=>r.StageNumber).Where(rr => rr.StageNumber > rr.Request.CurrentStage))
                {
                    if (reviewer.Status == RequestStatus.Approved.ToString())
                    {
                        if (reviewer.Request.CurrentStage == reviewer.Request.DefinedRequest.ReviewersNumber)
                        {
                            reviewer.Request.Status = RequestStatus.Approved.ToString();
                            
                        }
                        else
                        {
                            reviewer.Request.CurrentStage++;
                            remainingRequestReviewers.Where(rr => rr.StageNumber == reviewer.Request.CurrentStage).ToList().ForEach(r => r.Status = RequestStatus.Pending.ToString());

                        }
                        break;
                    }
                   
                }

            }

            remainingRequestReviewers[0].Request.ModifiedBy = reviewedBy;

           // _context.RefundRequests.Include(r => r.Request.RequestReviewers).Where(r => r.Request.RequestReviewers.Any(rr => rr.Status.Contains("")));
            _context.RequestReviewers.UpdateRange(remainingRequestReviewers);
            _context.SaveChanges();
        }

        public async Task DeclineRequestAsync(DeclineRequestReviewerDto reviewingInfo, string reviewedBy)
        {
            var requestReviewers = await _context.RequestReviewers.Include(r => r.Request).Include(dr => dr.Request.DefinedRequest).Where(rr => rr.RequestId == reviewingInfo.RequestId && rr.StageNumber == rr.Request.CurrentStage).ToListAsync();
            foreach (var reviewer in requestReviewers)
            {
                reviewer.ReviewedBy = reviewedBy;
                reviewer.Status = RequestStatus.Declined.ToString();
                reviewer.ReviewerNotes = reviewingInfo.ReviewedNotes;
                reviewer.ModifiedBy = reviewedBy;
            }

            requestReviewers[0].Request.Status = RequestStatus.Declined.ToString();
            requestReviewers[0].Request.CurrentStage = 0;
            requestReviewers[0].Request.ModifiedBy = reviewedBy;

            _context.RequestReviewers.UpdateRange(requestReviewers);
            _context.SaveChanges();
        }
    }
}
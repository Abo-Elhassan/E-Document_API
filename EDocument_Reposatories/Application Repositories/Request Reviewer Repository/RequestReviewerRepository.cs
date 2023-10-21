﻿using AutoMapper;
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
                if (item.StageNumber == 1)
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

        public async Task<(bool IsSucceded, string? Message)> ApproveRequestAsync(ApproveRequestReviewerDto reviewingInfo, User reviewer)
        {
            (bool IsSucceded, string? Message) result = (false, null);

            var remainingRequestReviewers = await _context.RequestReviewers.Include(r => r.Request).Include(dr => dr.Request.DefinedRequest).Where(rr => rr.RequestId == reviewingInfo.RequestId && rr.StageNumber >= rr.Request.CurrentStage).ToListAsync();
           
            if (remainingRequestReviewers is null || remainingRequestReviewers.Count == 0)
            {
                result = (false, $"Request reviewers not found for this stage");
                return result;

            }
            else if (!remainingRequestReviewers.Any(rr => rr.StageNumber == rr.Request.CurrentStage && rr.AssignedReviewerId == reviewer.Id))
            {
                result = (false, $"user '{reviewer.Id}' is not the current reviewer for this request");
                return result;
            }
            //Record approving action for the current stage
            foreach (var requestReviewer in remainingRequestReviewers.Where(rr => rr.StageNumber == rr.Request.CurrentStage || rr.AssignedReviewerId == reviewer.Id))//Approve the current stage and the advanced stages for the same reviewer if exists
            {
                requestReviewer.ReviewedBy = reviewer.FullName;
                requestReviewer.Status = RequestStatus.Approved.ToString();
                requestReviewer.ReviewerNotes = reviewingInfo.ReviewedNotes;
                requestReviewer.ModifiedBy = reviewer.FullName;
            }

            //Check if the current stage is the last stage
            if (remainingRequestReviewers.FirstOrDefault()?.Request.CurrentStage == remainingRequestReviewers.FirstOrDefault()?.Request.DefinedRequest.ReviewersNumber)
            {
                remainingRequestReviewers.FirstOrDefault().Request.Status = RequestStatus.Approved.ToString();
            }
            else
            {

                foreach (var item in remainingRequestReviewers.Where(rr => rr.StageNumber >= rr.Request.CurrentStage).OrderBy(r=>r.StageNumber).DistinctBy(r=>r.StageNumber))
                {

                    if (item.Status == RequestStatus.Approved.ToString())  //Check the next stage if they are already approved automatically or not
                    {

                        if (item.Request.CurrentStage == item.Request.DefinedRequest.ReviewersNumber) // Check if the approved stage is the last stage
                        {
                            item.Request.Status = RequestStatus.Approved.ToString();
                            break;
                        }
                        else //Skip the approved stage, proceed to the next stage and change  reviewers status to pending
                        {
                            item.Request.CurrentStage++;
                            var nextReviewer = remainingRequestReviewers.FirstOrDefault(rr => rr.StageNumber == rr.Request.CurrentStage);

                            if(nextReviewer.Status==RequestStatus.None.ToString())
                                remainingRequestReviewers.Where(rr => rr.StageNumber == nextReviewer.Request.CurrentStage).ToList().ForEach(r => r.Status = RequestStatus.Pending.ToString());

                        }
                    }
                    else  //Change next reviewer status to pending
                    {
                        item.Request.CurrentStage++;
                        remainingRequestReviewers.Where(rr => rr.StageNumber == item.Request.CurrentStage).ToList().ForEach(r => r.Status = RequestStatus.Pending.ToString());

                    }

                }
            }

            remainingRequestReviewers.FirstOrDefault().Request.ModifiedBy = reviewer.FullName;
            _context.RequestReviewers.UpdateRange(remainingRequestReviewers);
            _context.SaveChanges();


            result.IsSucceded = true;
            return result;
        }

        public async Task<(bool IsSucceded, string? Message)> DeclineRequestAsync(DeclineRequestReviewerDto reviewingInfo, User reviewer)
        {

            (bool IsSucceded, string? Message) result = (false, null);


            var requestReviewers = await _context.RequestReviewers.Include(r => r.Request).Include(dr => dr.Request.DefinedRequest).Where(rr => rr.RequestId == reviewingInfo.RequestId && rr.StageNumber == rr.Request.CurrentStage).ToListAsync();
            if (requestReviewers is null ||requestReviewers.Count==0)
            {
                result = (false, $"Request reviewers not found for this stage");
                return result;

            }
            else if (!requestReviewers.Any(rr=>rr.AssignedReviewerId== reviewer.Id))
            {
                result = (false, $"user '{reviewer.Id}' is not the current reviewer for this request");
                return result;
            }

            foreach (var requestReviewer in requestReviewers)
            {
                requestReviewer.ReviewedBy = reviewer.FullName;
                requestReviewer.Status = RequestStatus.Declined.ToString();
                requestReviewer.ReviewerNotes = reviewingInfo.ReviewedNotes;
                requestReviewer.ModifiedBy = reviewer.FullName;
            }

            requestReviewers.FirstOrDefault().Request.Status = RequestStatus.Declined.ToString();
            requestReviewers.FirstOrDefault().Request.CurrentStage = 0;
            requestReviewers.FirstOrDefault().Request.ModifiedBy = reviewer.FullName;

            _context.RequestReviewers.UpdateRange(requestReviewers);
            _context.SaveChanges();

            result.IsSucceded = true;
            return result;
        }
    }
}
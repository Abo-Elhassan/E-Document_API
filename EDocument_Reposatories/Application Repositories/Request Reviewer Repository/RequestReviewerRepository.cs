using AutoMapper;
using Azure.Core;
using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Requests.PoRequest;
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

            return reviewersDetails.OrderBy(r=>r.StageNumber).ToList();
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

        public async Task BeginRequestCycle(long definedRequestId, long requestId)
        {
            var definedRequestReviewers = await GetAllDefinedRequestReviewersAsync(definedRequestId);
          


            var request = await _context.Requests.Include(r => r.RequestReviewers).FirstOrDefaultAsync(r => r.Id == requestId);
            _mapper.Map(definedRequestReviewers, request?.RequestReviewers);
            var firstReviewer = request?.RequestReviewers.FirstOrDefault(rr => rr.StageNumber == 1);

            request.CurrentStage=1;
            request.Status=RequestStatus.Pending.ToString();

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

                if (request.RequestReviewers.Any(r => r.AssignedReviewerId == firstReviewer?.AssignedReviewerId && !r.StageNumber.Equals(1)))
                {
                    request.CurrentStage++;
                    firstReviewer.Status = RequestStatus.Approved.ToString();
                    firstReviewer.ModifiedBy = "E-Documnet";
                }
            }

            _context.SaveChanges();
        }


        public async Task ApproveRequestAsync(RequestReviewerWriteDto reviewingInfo, string reviewedBy)
        {
            var requestReviewers = await _context.RequestReviewers.Include(r => r.Request).Include(dr => dr.Request.DefinedRequest).Where(rr => rr.RequestId== reviewingInfo.RequestId &&rr.StageNumber == rr.Request.CurrentStage).ToListAsync();
          
            foreach (var reviewer in requestReviewers)
            {
                reviewer.ReviewedBy = reviewedBy;
                reviewer.Status = RequestStatus.Approved.ToString();
                reviewer.ReviewerNotes = reviewingInfo.ReviewedNotes;
                reviewer.ModifiedBy = reviewedBy;
            }

            if (requestReviewers[0].Request.CurrentStage == requestReviewers[0].Request.DefinedRequest.ReviewersNumber)
            {
                requestReviewers[0].Request.Status = RequestStatus.Approved.ToString();
            }
            else
            {
                requestReviewers[0].Request.CurrentStage = requestReviewers[0].Request.CurrentStage+1;
            }

            requestReviewers[0].Request.ModifiedBy = reviewedBy;

            _context.RequestReviewers.UpdateRange(requestReviewers);
            _context.SaveChanges();
        }

        public async Task DeclineRequestAsync(RequestReviewerWriteDto reviewingInfo, string reviewedBy)
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
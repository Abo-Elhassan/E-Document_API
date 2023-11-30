using AutoMapper;
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
            var stages = _context.RequestReviewers.Where(rr => rr.RequestId == requestId).AsEnumerable().DistinctBy(r => r.StageNumber).Select(rr => new { rr.StageNumber, rr.StageName, rr.Status, rr.ReviewedBy, rr.ReviewerNotes, rr.ModifiedAt }).ToList();

            var availableReviewers = await _context.RequestReviewers.Include(rr => rr.Reviewer).AsNoTracking().Where(rr => rr.RequestId == requestId).ToListAsync();

            foreach (var stage in stages)
            {
                var stageDetails = new ReviewersDetails
                {
                    StageNumber = stage.StageNumber,
                    StageTitle = stage.StageName,
                    Status = (RequestStatus)Enum.Parse(typeof(RequestStatus), stage.Status),
                    ReviewedBy = stage.ReviewedBy,
                    ReviewerNotes = stage.ReviewerNotes,
                    ReviewedAt = stage.ReviewedBy != null ? stage.ModifiedAt : null
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

        /// <summary>
        /// Nominate request creator as last reviewer to close the request
        /// </summary>
        /// <param name="requestId">request id</param>
        /// <param name="creatorId">creator id</param>
        /// <remarks>
        ///
        /// </remarks>
        public async Task NominateReviewer(long requestId, string creatorId)
        {
            var nominatedReviewer = await _context.RequestReviewers.Where(rr => rr.RequestId == requestId).OrderBy(rr => rr.StageNumber).LastOrDefaultAsync(rr => rr.RequestId == requestId);
            if (nominatedReviewer != null)
            {
                nominatedReviewer.AssignedReviewerId = creatorId;
                _context.Update(nominatedReviewer);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Nominate reviewer which is defined as NominatedReviewer in DefinedRequestReviewer during request creation
        /// </summary>
        /// <param name="requestId">request id</param>
        /// <param name="reviewerId">reviewer id</param>
        /// <param name="nominatedBy">nominator name</param>
        /// <remarks>
        ///
        /// </remarks>
        public async Task NominateReviewer(long requestId, string reviewerId, string nominatedBy)
        {
            var nominatedReviewer = await _context.RequestReviewers.FirstOrDefaultAsync(rr => rr.ReviewerType == ReviewerType.NominatedReviewer && rr.RequestId == requestId);
            if (nominatedReviewer != null)
            {
                nominatedReviewer.AssignedReviewerId = reviewerId;
                nominatedReviewer.ModifiedBy = nominatedBy;
                _context.Update(nominatedReviewer);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Nominate reviewer which is defined as NominatedReviewer in DefinedRequestReviewer during request creation
        /// </summary>
        /// <param name="requestId">request id</param>
        /// <param name="oldReviewerId">old reviewer id</param>
        /// <param name="newReviewerId">new reviewer id</param>
        /// <param name="nominatedBy">nominator name</param>
        /// <remarks>
        ///
        /// </remarks>
        public async Task NominateReviewer(long requestId, string oldReviewerId, string newReviewerId, string nominatedBy)
        {
            var nominatedReviewer = await _context.RequestReviewers.FirstOrDefaultAsync(rr => rr.RequestId == requestId && rr.AssignedReviewerId == oldReviewerId);
            if (nominatedReviewer != null)
            {
                nominatedReviewer.AssignedReviewerId = newReviewerId;
                nominatedReviewer.ModifiedBy = nominatedBy;
                _context.Update(nominatedReviewer);
                _context.SaveChanges();
            }
        }

        public async Task BeginRequestCycle(long definedRequestId, long requestId, string requesterId, bool isNew)
        {
            var definedRequestReviewers = await GetAllDefinedRequestReviewersAsync(definedRequestId);

            var request = await _context.Requests.Include(r => r.RequestReviewers).Include(r => r.DefinedRequest).FirstOrDefaultAsync(r => r.Id == requestId);
            request.Status = RequestStatus.Pending.ToString();
            request.CurrentStage = 1;

            if (isNew)
                _mapper.Map(definedRequestReviewers, request?.RequestReviewers);

            var remainingReviewers = request.RequestReviewers.Where(rr => rr.StageNumber >= request.CurrentStage).ToList();

            foreach (var item in request?.RequestReviewers)
            {
                item.AssignedReviewerId = await CheckReviewerDelegation(item.AssignedReviewerId);

                if (isNew)
                {
                    item.Key = Guid.NewGuid().ToString();
                    item.RequestId = requestId;
                    item.CreatedBy = "E-Document";
                    item.CreatedAt = DateTime.Now;
                }
                else
                {
                    item.ReviewedBy = null;
                    item.ReviewerNotes = null;
                    item.Status = RequestStatus.None.ToString();
                    item.ModifiedBy = "E-Document";
                    item.ModifiedAt = DateTime.Now;
                }

                if (item.StageNumber == 1)
                    item.Status = RequestStatus.Pending.ToString();
            }

            await AssignDynamicReviewers(request, requesterId);

            SkipCreatorStagesAsReviewer(request);
            ProceedWorkflow(request, remainingReviewers, isApproval: false);

            _context.Update(request);
            _context.SaveChanges();
        }

        public async Task<(bool IsSucceded, string? Message)> ApproveRequestAsync(ApproveRequestReviewerDto reviewingInfo, User reviewer)
        {
            (bool IsSucceded, string? Message) result = (false, null);
            var request = await _context.Requests.Include(r => r.RequestReviewers).Include(r => r.DefinedRequest).FirstOrDefaultAsync(r => r.Id == reviewingInfo.RequestId);
            var remainingRequestReviewers = request.RequestReviewers.Where(rr => rr.StageNumber >= request.CurrentStage).ToList();

            if (remainingRequestReviewers is null || remainingRequestReviewers.Count == 0)
            {
                result = (false, $"Request reviewers not found for this stage or request is already approved");
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
                var reviewerNumbers = remainingRequestReviewers.Count(rr => rr.StageNumber == requestReviewer.StageNumber && rr.StageNumber != request.CurrentStage); //Check if the advanced stages have multiple reviewers to prevent automatic approve for them

                if (reviewerNumbers <= 1)
                {
                    requestReviewer.ReviewedBy = reviewer.FullName;
                    requestReviewer.Status = RequestStatus.Approved.ToString();
                    requestReviewer.ReviewerNotes = reviewingInfo.ReviewedNotes;
                    requestReviewer.ModifiedBy = reviewer.FullName;
                    requestReviewer.ModifiedAt = DateTime.Now;
                }
            }

            ProceedWorkflow(request, remainingRequestReviewers, isApproval: true);

            _context.Update(request);
            _context.SaveChanges();

            result.IsSucceded = true;
            return result;
        }

        public async Task<(bool IsSucceded, string? Message)> DeclineRequestAsync(DeclineRequestReviewerDto reviewingInfo, User reviewer)
        {
            (bool IsSucceded, string? Message) result = (false, null);
            var remainingRequestReviewers = await _context.RequestReviewers.Include(r => r.Request).Include(dr => dr.Request.DefinedRequest).Where(rr => rr.RequestId == reviewingInfo.RequestId && rr.StageNumber >= rr.Request.CurrentStage).ToListAsync();
            var requestReviewers = await _context.RequestReviewers.Include(r => r.Request).Include(dr => dr.Request.DefinedRequest).Where(rr => rr.RequestId == reviewingInfo.RequestId && rr.StageNumber == rr.Request.CurrentStage).ToListAsync();
            if (remainingRequestReviewers is null || remainingRequestReviewers.Count == 0)
            {
                result = (false, $"Request reviewers not found for this stage or request is already reviewed");
                return result;
            }
            else if (!requestReviewers.Any(rr => rr.AssignedReviewerId == reviewer.Id))
            {
                result = (false, $"user '{reviewer.Id}' is not the current reviewer for this request");
                return result;
            }

            remainingRequestReviewers.FirstOrDefault().Request.ModifiedBy = reviewer.FullName;
            remainingRequestReviewers.FirstOrDefault().Request.ModifiedAt = DateTime.Now;
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

        private async Task<string> CheckReviewerDelegation(string assignedReviewerId)
        {
            var assignedReviewer = await _context.Users.FindAsync(assignedReviewerId);

            return assignedReviewer?.DelegatedUntil > DateTime.Now ? assignedReviewer.DelegatedUserId : assignedReviewerId;
        }

        private void ProceedWorkflow(Request request, List<RequestReviewer> remainingRequestReviewers, bool isApproval)
        {
         
           
            if (request.CurrentStage == request.DefinedRequest.ReviewersNumber && isApproval) //Check if the current stage is the last stage
            {
                request.Status = RequestStatus.Approved.ToString();
            }
            else
            {
                foreach (var reviewer in remainingRequestReviewers.Where(rr => rr.StageNumber >= request.CurrentStage).OrderBy(rr => rr.StageNumber).DistinctBy(rr => rr.StageNumber))
                {
                    //Check the next stage if they are already approved automatically or not
                    if (reviewer.Status == RequestStatus.Approved.ToString() && request.CurrentStage == request.DefinedRequest.ReviewersNumber) // Check if the approved stage is the last stage
                    {
                        request.Status = RequestStatus.Approved.ToString();
                        break;
                    }
                    else if (reviewer.Status == RequestStatus.Approved.ToString()) //Skip the approved stage, proceed to the next stage and change reviewers status to pending
                    {
                        request.CurrentStage++;
                    }
                    else
                    {
                        remainingRequestReviewers.Where(rr => rr.StageNumber == request.CurrentStage).ToList().ForEach(r => r.Status = RequestStatus.Pending.ToString());
                        break;
                    }
                }
                
            }
        }

        private async Task AssignDynamicReviewers(Request request, string requesterId)
        {
            // Seed Reviewer Ids for Dynamic Reviewers
            foreach (var reviewer in request?.RequestReviewers)
            {
                if (reviewer.AssignedReviewerId is null)
                {
                    switch (reviewer.ReviewerType)
                    {
                        case ReviewerType.DirectManager:
                            reviewer.AssignedReviewerId = await CheckReviewerDelegation(_userRepository.FindDirectManagerByIdAsync(requesterId)?.Result.Value.Id);
                            break;

                        case ReviewerType.SectionHead:
                            reviewer.AssignedReviewerId = await CheckReviewerDelegation(_userRepository.FindSectionHeadByIdAsync(requesterId)?.Result.Value.Id);
                            break;

                        case ReviewerType.DepartmentManager:
                            reviewer.AssignedReviewerId = await CheckReviewerDelegation(_userRepository.FindDepartmentManagerByIdAsync(requesterId)?.Result.Value.Id);
                            break;

                        default:
                            break;
                    }
                }
            }
        }

        private void SkipCreatorStagesAsReviewer(Request request)
        {
            // Skip All Approval steps for the creator if he is one of the reviewers
            if (request.RequestReviewers.Any(r => r.AssignedReviewerId == request.CreatorId) && request.DefinedRequestId != DefinedRequestId.CCTV_Access && request.DefinedRequestId != DefinedRequestId.Access_Control && request.DefinedRequestId != DefinedRequestId.New_Item && request.DefinedRequestId != DefinedRequestId.Pr && request.DefinedRequestId != DefinedRequestId.Reschedule_PM_WO && request.DefinedRequestId != DefinedRequestId.PM_JP && request.DefinedRequestId != DefinedRequestId.Voucher) //Automatic approve for the creator should be prevented for Refund and  New Item and Pr Requests  and Multimedia request and Engineering requests as Some reviewers need to insert data in approve
            {
                var creatorStageNumbers = request.RequestReviewers.Where(rr => rr.AssignedReviewerId == request.CreatorId).Select(r => r.StageNumber).ToList(); //Select all stage numbers for the creator
                foreach (var reviewer in request.RequestReviewers.Where(rr => creatorStageNumbers.Any(s => rr.StageNumber == s)))
                {
                    reviewer.Status = RequestStatus.Approved.ToString();
                    reviewer.ReviewedBy = "E-Document";
                    reviewer.ModifiedAt = DateTime.Now;
                    reviewer.ReviewerNotes = "Automatically Approved By E-Document";
                }
            }
        }
    }
}
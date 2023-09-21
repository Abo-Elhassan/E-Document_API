using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_EF;
using EDocument_Reposatories.Generic_Reposatories;
using EDocument_Repositories.Application_Repositories.UserRepository;
using EDocument_Services.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Repositories.Application_Repositories.Request_Reviewer_Repository
{
    public class RequestReviewerRepository: GenericRepository<RequestReviewer>, IRequestReviewerRepository
    {
        private readonly ApplicationDbContext _context;

        public RequestReviewerRepository(ApplicationDbContext context):base(context) 
        {
            _context = context;
        }


        public async Task<IEnumerable<DefinedRequestReviewer>> GetDefinedRequestReviewersByIdAsync(long definedRequestId)
        {
            return await _context.DefinedRequestReviewers.Where(rr => rr.DefinedRequestId == definedRequestId).AsNoTracking().ToListAsync();
        }

        public async Task<List<ReviewersDetails>> GetRequestReviewersByIdAsync(long requestId)
        {
            var reviewersDetails = new List<ReviewersDetails>();
            var stages =  _context.RequestReviewers.Where(rr => rr.RequestId == requestId).AsEnumerable().DistinctBy(r=>r.StageNumber).Select(rr=>new { rr.StageNumber,rr.StageName, rr.Status,rr.ReviewedBy, rr.ReviewerNotes }).ToList();

            var availableReviewers =  await _context.RequestReviewers.Include(rr => rr.Reviewer).AsNoTracking().Where(rr => rr.RequestId == requestId).ToListAsync();

            foreach (var stage in stages)
            {
                var stageDetails = new ReviewersDetails 
                { 
                    StageNumber = stage.StageNumber,
                    StageTitle = stage.StageName, 
                    Status = stage.Status,
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
                stageDetails.AssignedReviewers= assignedReviewers;
                reviewersDetails.Add(stageDetails);

            }

            return reviewersDetails;
        }


        public async Task BeginRequestCycle(long definedRequestId, long requestId)
        {
            var request = await _context.Requests.Include(r => r.RequestReviewers).Include(dr => dr.DefinedRequest).FirstOrDefaultAsync(r => r.Id == requestId && r.RequestReviewers.All(rr => rr.StageNumber == r.CurrentStage));
            var requestReviewers = await GetRequestReviewersByIdAsync(requestId);
            var firstReviewer = requestReviewers.FirstOrDefault(rr => rr.StageNumber == 1);

            request.CurrentStage=1;



            //if (request.RequestReviewers.Any(r=>r.AssignedReviewerId== firstReviewer?.AssignedReviewerId))
            //{
            //    request.CurrentStage++;

            //}


            _context.SaveChanges();

        }

        public  async Task ApproveRequestAsync(RequestReviewerWriteDto reviewingInfo, string reviewedBy)
        {
            var request = await _context.Requests.Include(r => r.RequestReviewers).Include(dr=>dr.DefinedRequest).FirstOrDefaultAsync(r=> r.Id == reviewingInfo.RequestId && r.RequestReviewers.All(rr=>rr.StageNumber==r.CurrentStage));

            foreach (var reviewer in request!.RequestReviewers)
            {
                reviewer.ReviewedBy = reviewedBy;
                reviewer.Status = RequestStatus.Approved;
                reviewer.ReviewerNotes = reviewingInfo.ReviewedNotes;
                reviewer.ModifiedBy = reviewedBy;
            }

           

            if (request.CurrentStage ==request.DefinedRequest.ReviewersNumber)
            {
                request.Status = RequestStatus.Approved;
            }
            else
            {
                request.CurrentStage = request.CurrentStage++;
            }

            request.ModifiedBy = reviewedBy;

            _context.Requests.Update(request);
            _context.SaveChanges();
            
        }


        public async Task DeclineRequestAsync(RequestReviewerWriteDto reviewingInfo, string reviewedBy)
        {
            var request = await _context.Requests.Include(r => r.RequestReviewers).Include(dr => dr.DefinedRequest).FirstOrDefaultAsync(r => r.Id == reviewingInfo.RequestId && r.RequestReviewers.All(rr => rr.StageNumber == r.CurrentStage));

            foreach (var reviewer in request!.RequestReviewers)
            {
                reviewer.ReviewedBy = reviewedBy;
                reviewer.Status = RequestStatus.Declined;
                reviewer.ReviewerNotes = reviewingInfo.ReviewedNotes;
                reviewer.ModifiedBy = reviewedBy;
            }

            request.Status = RequestStatus.Declined;
            request.CurrentStage = 0; 
            request.ModifiedBy = reviewedBy;

            _context.Requests.Update(request);
            _context.SaveChanges();
        }
                                                                                

    }
}

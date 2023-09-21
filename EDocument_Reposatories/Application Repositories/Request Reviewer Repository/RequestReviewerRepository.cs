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


        public Task BeginRequestCycle(long definedRequestId, long requestId)
        {
            throw new NotImplementedException();
        }

        public Task ApproveRequest(long requestId)
        {
            throw new NotImplementedException();
        }


        public Task DeclineRequest(long requestId)
        {
            throw new NotImplementedException();
        }


    }
}

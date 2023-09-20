using EDocument_Data.Consts.Enums;
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

        public async Task<IEnumerable<DefinedRequestReviewer>> GetDefinedRequestReviewersAsync(long definedRequestId)
        {
            return await _context.DefinedRequestReviewers.Where(rr => rr.DefinedRequestId == definedRequestId).ToListAsync();
        }

        public async Task<IEnumerable<RequestReviewer>> GetRequestReviewersAsync(long requestId)
        {
            return await _context.RequestReviewers.Include(rr=>rr.Reviewer).Where(rr=>rr.RequestId== requestId).ToListAsync();
        }

    }
}

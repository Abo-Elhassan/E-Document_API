using EDocument_Data.Consts.Enums;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_EF;
using EDocument_Reposatories.Generic_Reposatories;
using EDocument_Services.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Repositories.Application_Repositories.Request_Repository
{
    public class RequestRepository<T>: IRequestRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public RequestRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

     

 
    }
}

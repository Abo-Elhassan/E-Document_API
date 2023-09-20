using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Filter;
using EDocument_Data.DTOs.Role;
using EDocument_Data.DTOs.User;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_EF;
using EDocument_Reposatories.Generic_Reposatories;
using EDocument_Repositories.Application_Repositories.Request_Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Repositories.Application_Repositories.RequestRepository.PoRequest_Repository
{
    public class PoRequestRepository: RequestRepository<PoRequest>, IPoRequestRepository 
    {
        private readonly ApplicationDbContext _context;

        public PoRequestRepository(ApplicationDbContext context) :base(context)
        {
            _context = context;

        }

    
    }
}

﻿using EDocument_Data.Models;
using EDocument_EF;
using EDocument_Reposatories.Generic_Reposatories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Repositories.Application_Repositories.UserRepository
{
    public class UserRepository :GenericRepository<User>, IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public UserRepository(ApplicationDbContext context,UserManager<User> userManager, RoleManager<Role> roleManager): base(context)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<(string Id, string Email)?> FindDepartmentManagerById(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user is null|| user.Department.ManagerId is null || GetUserEmailById(user.Department.Manager.Id).Result is null)  return null;

            string managerId = user.Department.ManagerId;
            string managerEmail = await GetUserEmailById(user.Department.Manager.Id) ??"";

            return (managerId, managerEmail);
        }

        public async Task<(string Id, string Email)?> FindDirectManagerById(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user is null || user.Manager.ManagerId is null || GetUserEmailById(user.Manager.Id).Result is null) return null;

            string managerId = user.Manager.ManagerId;
            string managerEmail = await GetUserEmailById(user.Manager.Id) ?? "";

            return (managerId, managerEmail);
        }

        public async Task<(string Id, string Email)?> FindSectionHeadById(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user is null || user.Section.HeadId is null || GetUserEmailById(user.Section.Head.Id).Result is null) return null;

            string managerId = user.Section.HeadId;
            string managerEmail = await GetUserEmailById(user.Section.Head.Id) ?? "";

            return (managerId, managerEmail);
        }

        public async Task<string?> GetUserEmailById(string id)
        {
            var email = "";
            var user = await _userManager.FindByIdAsync(id);

            if (user is null) return null;
     

            if (user.IsEmployee)
            {
                email = $"{user.UserName}@dpwsapps.com";
                
            }
            else
            {
                email = user.Email;
            }

           return email;
        }


    }
}

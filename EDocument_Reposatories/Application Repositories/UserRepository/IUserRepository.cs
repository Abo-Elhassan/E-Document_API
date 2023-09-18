using EDocument_Data.Models;
using EDocument_Reposatories.Generic_Reposatories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Repositories.Application_Repositories.UserRepository
{
    public interface IUserRepository: IGenericRepository<User>
    {
        Task<string?> GetUserEmailByUsername(string username);
        Task<(string Id, string Email)?> FindDirectManagerById(string id);
        Task<(string Id, string Email)?> FindSectionHeadById(string id);
        Task<(string Id, string Email)?> FindDepartmentManagerById(string id);
        
    }
}

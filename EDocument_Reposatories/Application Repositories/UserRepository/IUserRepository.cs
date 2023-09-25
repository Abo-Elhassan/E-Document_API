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
        Task<(string Id, string Email)?> FindDirectManagerByIdAsync(string id);
        Task<(string Id, string Email)?> FindSectionHeadByIdAsync(string id);
        Task<(string Id, string Email)?> FindDepartmentManagerByIdAsync(string id);
        Task<string?> GetUserEmailByIdAsync(string id);


    }
}

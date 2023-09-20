using EDocument_Data.Consts.Enums;
using EDocument_Data.Models.Shared;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Reposatories.Generic_Reposatories
{
    public interface IGenericRepository<T> where T : class
    {
        T? GetById(long id);
        T? GetById(string id);


        Task<T?> GetByIdAsync(long id);
        Task<T?> GetByIdAsync(string id);


        IEnumerable<T> GetAll(string[]? includes = null);

        Task<IEnumerable<T>> GetAllAsync(string[]? includes = null);



        T? Find(Expression<Func<T, bool>>? criteria=null, string[]? includes = null);

        Task<T?> FindAsync(Expression<Func<T, bool>>? criteria = null, string[]? includes = null);



        (int TotalCount, IEnumerable<T> PaginatedData) FindAll(Expression<Func<T, bool>>? criteria,  string[]? includes = null, int? skip = null, int? take = null, Expression<Func<T, object>>? orderBy = null, OrderBy? orderByDirection = null, DateFilter[]? dateFilters = null);
        (int TotalCount, IEnumerable<T> PaginatedData) FindAll(Dictionary<string, string>? filters, string? createdBy=null,  string[]? includes = null, int? skip = null, int? take = null, string? orderBy =  null, OrderBy? orderByDirection = null, DateFilter[]? dateFilters = null);
        (int TotalCount, IEnumerable<T> PaginatedData) FindAll(string filterValue, string? createdBy = null, string[]? includes = null, int? skip = null, int? take = null, string? orderBy = null, OrderBy? orderByDirection = null, DateFilter[]? dateFilters = null);

        Task<(int TotalCount, IEnumerable<T> PaginatedData)> FindAllAsync(Expression<Func<T, bool>>? criteria,  string[]? includes = null, int? skip = null, int? take = null, Expression<Func<T, object>>? orderBy = null, OrderBy? orderByDirection = null, DateFilter[]? dateFilters = null);
        Task<(int TotalCount, IEnumerable<T> PaginatedData)> FindAllAsync(Dictionary<string, string>? filters, string? createdBy = null, string[]? includes = null, int? skip = null, int? take = null, string? orderBy = null, OrderBy? orderByDirection = null, DateFilter[]? dateFilters = null);
        Task<(int TotalCount, IEnumerable<T> PaginatedData)> FindAllAsync(string filterValue, string? createdBy = null, string[]? includes = null, int? skip = null, int? take = null, string? orderBy = null, OrderBy? orderByDirection = null, DateFilter[]? dateFilters = null);

        int Count();
        int Count(Expression<Func<T, bool>> criteria);
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<T, bool>> criteria);


        T Add(T entity);
        Task<T> AddAsync(T entity);
        IEnumerable<T> AddRange(IEnumerable<T> entities);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);


        T Update(T entity);


        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);




        Task<T?> FindRequestAsync(long requestId, string expression, string[]? includes = null);

        Task<(int TotalCount, IEnumerable<T> PaginatedData)> FindAllRequestsAsync(string userId, RequestPermission permission, string? reviewingExpression = null, string[]? includes = null, Dictionary<string, string>? filters = null, int? skip = null, int? take = null, string? orderBy = null, OrderBy? orderByDirection = null, DateFilter[]? dateFilters = null);


    }
}

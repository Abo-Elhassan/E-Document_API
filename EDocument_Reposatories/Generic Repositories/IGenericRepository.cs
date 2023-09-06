using EDocument_Data.Consts.Enums;
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



        T? Find(Expression<Func<T, bool>> criteria, string[]? includes = null);

        Task<T?> FindAsync(Expression<Func<T, bool>> criteria, string[]? includes = null);



        IEnumerable<T> FindAll(Expression<Func<T, bool>> criteria, string[]? includes = null, int? skip = null, int? take = null, Expression<Func<T, object>>? orderBy = null, OrderBy? orderByDirection = null);
        IEnumerable<T> FindAll(Dictionary<string, string> filters, string[]? includes = null, int? skip = null, int? take = null, string? orderBy =  null, OrderBy? orderByDirection = null);
        IEnumerable<T> FindAll(string filterValue, string[]? includes = null, int? skip = null, int? take = null, string? orderBy = null, OrderBy? orderByDirection = null);

        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria, string[]? includes = null, int? skip = null, int? take = null, Expression<Func<T, object>>? orderBy = null, OrderBy? orderByDirection = null);
        Task<IEnumerable<T>> FindAllAsync(Dictionary<string, string> filters, string[]? includes = null, int? skip = null, int? take = null, string? orderBy = null, OrderBy? orderByDirection = null);
        Task<IEnumerable<T>> FindAllAsync(string filterValue, string[]? includes = null, int? skip = null, int? take = null, string? orderBy = null, OrderBy? orderByDirection = null);


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
    
    }
}

using EDocument_Data.Consts.Enums;
using EDocument_EF;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EDocument_Reposatories.Generic_Reposatories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public virtual T? GetById(long id)
        {
            var entity = _context.Set<T>().Find(id);

            if (entity!=null)
            {
                _context.Entry<T>(entity).State = EntityState.Detached;
            }
            
            return entity;
        }

        public virtual T? GetById(string id)
        {
            var entity = _context.Set<T>().Find(id);

            if (entity != null)
            {
                _context.Entry<T>(entity).State = EntityState.Detached;
            }

            return entity;
        }


        public virtual async Task<T?> GetByIdAsync(long id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if (entity != null)
            {
                _context.Entry<T>(entity).State = EntityState.Detached;
            }

            return entity;
        }

        public virtual async Task<T?> GetByIdAsync(string id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if (entity != null)
            {
                _context.Entry<T>(entity).State = EntityState.Detached;
            }

            return entity;
        }



        public virtual IEnumerable<T> GetAll(string[]? includes = null)
        {
            IQueryable<T> query = _context.Set<T>().AsNoTracking();

            if (includes != null)
            {
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }
            }
            return query.ToList();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync(string[]? includes = null)
        {
            IQueryable<T> query = _context.Set<T>().AsNoTracking();

            if (includes != null)
            {
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }
            }
            return await query.ToListAsync();
        }



        public virtual T? Find(Expression<Func<T, bool>> criteria, string[]? includes = null)
        {
            IQueryable<T> query = _context.Set<T>().AsNoTracking();

            if (includes != null)
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }

            return query.SingleOrDefault(criteria);
        }

        public virtual async Task<T?> FindAsync(Expression<Func<T, bool>> criteria, string[]? includes = null)
        {
            IQueryable<T> query = _context.Set<T>().AsNoTracking();

            if (includes != null)
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }

            return await query.SingleOrDefaultAsync(criteria);
        }



        public IEnumerable<T> FindAll(Expression<Func<T, bool>> criteria, string[]? includes = null, int? skip = null, int? take = null, Expression<Func<T, object>>? orderBy = null, OrderBy? orderByDirection = null)
        {
            IQueryable<T> query = _context.Set<T>().AsNoTracking();

            if (includes != null)
            {
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }
            }

            query = query.Where(criteria);

            if (skip.HasValue && take.HasValue)
            {
                query = query.Skip(skip.Value).Take(take.Value);
            }

            if (orderBy != null && orderByDirection != null)
            {
                if (orderByDirection == OrderBy.Asc)
                {
                    query = query.OrderBy(orderBy);
                }
                else
                {
                    query = query.OrderByDescending(orderBy);
                }
            }

            return query.ToList();
        }

        public IEnumerable<T> FindAll(Dictionary<string, string> filters, string[]? includes = null, int? skip = null, int? take = null, string? orderBy = null, OrderBy? orderByDirection = null)
        {
            IQueryable<T> query = _context.Set<T>().AsNoTracking();

            if (includes != null)
            {
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }
            }

            if (filters != null && filters.Count > 0)
            {
                foreach (var filter in filters)
                {
                    var ColumnName = filter.Key;
                    var ColumnValue = filter.Value;

                    var property = typeof(T).GetProperty(ColumnName);
                    if (property != null && property.PropertyType==typeof(string))
                    {
                        query = query.Where($"{ColumnName}.Contains(@0)",ColumnValue);
                    }
                }
            }
           

            if (skip.HasValue && take.HasValue)
            {
                query = query.Skip(skip.Value).Take(take.Value);
            }

            if (orderBy != null && orderByDirection != null)
            {
                var sortDirection = orderByDirection == OrderBy.Asc ? OrderBy.Asc : OrderBy.Desc;

                query = query.OrderBy($"{orderBy} {sortDirection}");
            }

            return query.ToList();
        }

        public IEnumerable<T> FindAll(string filterValue, string[]? includes = null, int? skip = null, int? take = null, string? orderBy = null, OrderBy? orderByDirection = null)
        {


            IQueryable<T> query = _context.Set<T>().AsNoTracking();

            if (includes != null)
            {
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }
            }

            var properties = typeof(T).GetProperties();

            if (!string.IsNullOrEmpty(filterValue))
            {

                string dynamicFilter = string.Join(" OR ", properties
                    .Where(property => property.PropertyType == typeof(string))
                .Select(property => $"{property.Name}.Contains(@0)"));

                query = query.Where(dynamicFilter, filterValue);
               
            }


            if (skip.HasValue && take.HasValue)
            {
                query = query.Skip(skip.Value).Take(take.Value);
            }

            if (orderBy != null && orderByDirection != null)
            {
                var sortDirection = orderByDirection == OrderBy.Asc ? OrderBy.Asc : OrderBy.Desc;

                query = query.OrderBy($"{orderBy} {sortDirection}");
            }

            return query.ToList();
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria, string[]? includes = null, int? skip = null, int? take = null, Expression<Func<T, object>>? orderBy = null, OrderBy? orderByDirection = null)
        {
            IQueryable<T> query = _context.Set<T>();

            if (includes != null)
            {
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }
            }

            query = query.Where(criteria);

            if (skip.HasValue && take.HasValue)
            {
                query = query.Skip(skip.Value).Take(take.Value);
            }

            if (orderBy != null && orderByDirection != null)
            {
                if (orderByDirection == OrderBy.Asc)
                {
                    query = query.OrderBy(orderBy);
                }
                else
                {
                    query = query.OrderByDescending(orderBy);
                }
            }

            return await query.ToListAsync();
        }

        public Task<IEnumerable<T>> FindAllAsync(Dictionary<string, string> filters, string[]? includes = null, int? skip = null, int? take = null, string? orderBy = null, OrderBy? orderByDirection = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> FindAllAsync(string filterValue, string[]? includes = null, int? skip = null, int? take = null, string? orderBy = null, OrderBy? orderByDirection = null)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            return _context.Set<T>().Count();
        }

        public int Count(Expression<Func<T, bool>> criteria)
        {
            return _context.Set<T>().Count(criteria);
        }

        public async Task<int> CountAsync()
        {
            return await _context.Set<T>().CountAsync();
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> criteria)
        {
            return await _context.Set<T>().CountAsync(criteria);
        }

        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);

            return entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return entity;
        }

        public IEnumerable<T> AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
            return entities;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await _context.Set<T>().AddRangeAsync(entities);
            return entities;
        }

        public T Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
    }
}
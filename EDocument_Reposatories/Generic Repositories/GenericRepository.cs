using EDocument_Data.Consts.Enums;
using EDocument_Data.Models.Shared;
using EDocument_EF;
using EDocument_Services.Helpers;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

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
            return entity;
        }

        public virtual T? GetById(string id)
        {
            var entity = _context.Set<T>().Find(id);

            return entity;
        }

        public virtual async Task<T?> GetByIdAsync(long id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            return entity;
        }

        public virtual async Task<T?> GetByIdAsync(string id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            return entity;
        }

        public virtual IEnumerable<T> GetAll(string[]? includes = null)
        {
            IQueryable<T> query = _context.Set<T>();

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
            IQueryable<T> query = _context.Set<T>();

            if (includes != null)
            {
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }
            }
            return await query.ToListAsync();
        }

        public virtual T? Find(Expression<Func<T, bool>>? criteria = null, string[]? includes = null)
        {
            IQueryable<T> query = _context.Set<T>();

            if (includes != null)
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }

            if (criteria != null)
            {
                return query.SingleOrDefault(criteria);
            }
            else
            {
                return query.SingleOrDefault();
            }
        }

        public virtual async Task<T?> FindAsync(Expression<Func<T, bool>>? criteria = null, string[]? includes = null)
        {
            IQueryable<T> query = _context.Set<T>();

            if (includes != null)
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }

            if (criteria != null)
            {
                return await query.SingleOrDefaultAsync(criteria);
            }
            else
            {
                return await query.SingleOrDefaultAsync();
            }
        }

        public virtual IEnumerable<T> FindAll(Expression<Func<T, bool>> criteria, string[]? includes = null)
        {
            IQueryable<T> query = _context.Set<T>();

            if (includes != null)
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }

            return query.Where(criteria).ToList();
        }

        public virtual (int TotalCount, IEnumerable<T> PaginatedData) FindAll(Expression<Func<T, bool>>? criteria, string[]? includes = null, int? skip = null, int? take = null, Expression<Func<T, object>>? orderBy = null, OrderBy? orderByDirection = null, DateFilter[]? dateFilters = null)
        {
            (int TotalCount, IEnumerable<T> PaginatedData) result;

            IQueryable<T> query = _context.Set<T>().AsNoTracking();

            #region Include Tables

            if (includes != null)
            {
                foreach (var item in includes)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        query = query.Include(item);
                    }
                }
            }

            #endregion Include Tables

            #region Apply General Filter

            if (criteria != null)
            {
                query = query.Where(criteria);
            }

            #endregion Apply General Filter

            #region Apply Date Filter

            if (dateFilters != null)
            {
                foreach (var filter in dateFilters)
                {
                    if (filter.From != null && filter.To != null)
                    {
                        var pascalCaseColumnName = Utilities.ConvertColumnNameToPascalCase(filter.ColumnName);

                        var property = typeof(T).GetProperty(pascalCaseColumnName);
                        DateTime fromDate = DateTime.Parse(filter.From.ToString());
                        DateTime toDate = DateTime.Parse(filter.To.ToString());
                        var x = _context.PoRequests.Where(p => p.CreatedAt >= fromDate && p.CreatedAt <= toDate);
                        if (property != null)
                        {
                            query = query.Where($"{pascalCaseColumnName} >= @0 && {pascalCaseColumnName} <= @1", fromDate, toDate);
                        }
                    }

                }
            }

            #endregion Apply Date Filter

            result.TotalCount = query.Count();

            #region Apply Sorting

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

            #endregion Apply Sorting

            #region Apply Pagination

            if (skip.HasValue && take.HasValue)
            {
                query = query.Skip(skip.Value).Take(take.Value);
            }

            result.PaginatedData = query.ToList();

            #endregion Apply Pagination

            return result;
        }

        public virtual (int TotalCount, IEnumerable<T> PaginatedData) FindAll(Dictionary<string, string>? filters, string? createdBy = null, string[]? includes = null, int? skip = null, int? take = null, string? orderBy = null, OrderBy? orderByDirection = null, DateFilter[]? dateFilters = null)
        {
            var ColumnName = "";
            var ColumnValue = "";
            var expression = "";
            (int TotalCount, IEnumerable<T> PaginatedData) result;
            IQueryable<T> query = _context.Set<T>().AsNoTracking();

            #region Include Tables

            if (includes != null)
            {
                foreach (var item in includes)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        query = query.Include(item);
                    }
                }
            }

            #endregion Include Tables

            #region Apply General Filter

            if (createdBy != null)
            {
                query = query.Where($"CreatedBy ==@0", createdBy);
            }

            if (filters != null && filters.Count > 0)
            {
                filters = Utilities.ConvertKeysToPascalCase(filters);

                foreach (var filter in filters)
                {
                    ColumnName = filter.Key;
                    ColumnValue = filter.Value;

                    var property = typeof(T).GetProperty(ColumnName);
                    if (property != null && !string.IsNullOrEmpty(ColumnValue))
                    {
                        expression = property.PropertyType == typeof(string) ? $"{ColumnName}.Contains(@0)" : $"{ColumnName}.Equals(@0)";
                        query = query.Where(expression, property.PropertyType == typeof(string) ? ColumnValue : int.Parse(ColumnValue));
                    }
                }
            }

            #endregion Apply General Filter

            #region Apply Date Filter

            if (dateFilters != null)
            {
                foreach (var filter in dateFilters)
                {
                    if (filter.From != null && filter.To != null)
                    {
                        var pascalCaseColumnName = Utilities.ConvertColumnNameToPascalCase(filter.ColumnName);

                        var property = typeof(T).GetProperty(pascalCaseColumnName);
                        DateTime fromDate = DateTime.Parse(filter.From.ToString());
                        DateTime toDate = DateTime.Parse(filter.To.ToString());
                        var x = _context.PoRequests.Where(p => p.CreatedAt >= fromDate && p.CreatedAt <= toDate);
                        if (property != null)
                        {
                            query = query.Where($"{pascalCaseColumnName} >= @0 && {pascalCaseColumnName} <= @1", fromDate, toDate);
                        }
                    }

                }
            }

            #endregion Apply Date Filter

            result.TotalCount = query.Count();

            #region Apply Sorting

            if (orderBy != null && orderByDirection != null)
            {
                var sortDirection = orderByDirection == OrderBy.Asc ? OrderBy.Asc : OrderBy.Desc;
                orderBy = Utilities.ConvertColumnNameToPascalCase(orderBy);

                var property = typeof(T).GetProperty(orderBy);
                if (property != null)
                {
                    query = query.OrderBy($"{orderBy} {sortDirection}");
                }
            }

            #endregion Apply Sorting

            #region Apply Pagination

            if (skip.HasValue && take.HasValue)
            {
                query = query.Skip(skip.Value).Take(take.Value);
            }

            result.PaginatedData = query.ToList();

            #endregion Apply Pagination

            return result;
        }

        public virtual (int TotalCount, IEnumerable<T> PaginatedData) FindAll(string? filterValue = null, string? createdBy = null, string[]? includes = null, int? skip = null, int? take = null, string? orderBy = null, OrderBy? orderByDirection = null, DateFilter[]? dateFilters = null)
        {
            var dynamicFilter = "";
            (int TotalCount, IEnumerable<T> PaginatedData) result;
            IQueryable<T> query = _context.Set<T>().AsNoTracking();

            #region Include Tables

            if (includes != null)
            {
                foreach (var item in includes)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        query = query.Include(item);
                    }
                }
            }

            #endregion Include Tables

            #region Apply General Filter

            if (createdBy != null)
            {
                query = query.Where($"CreatedBy ==@0", createdBy);
            }
            var properties = typeof(T).GetProperties();

            if (!string.IsNullOrEmpty(filterValue))
            {
                dynamicFilter = string.Join(" OR ", properties.Where(p => p.PropertyType == typeof(string) || p.PropertyType == typeof(DateTime) || p.PropertyType == typeof(long) || p.PropertyType == typeof(float))
                .Select(property => property.PropertyType == typeof(string) ? $"{property.Name}.Contains(@0)" : $"{property.Name}.Equals(@0)"));
                query = query.Where(dynamicFilter, filterValue);
            }

            #endregion Apply General Filter

            #region Apply Date Filter

            if (dateFilters != null)
            {
                foreach (var filter in dateFilters)
                {
                    if (filter.From != null && filter.To != null)
                    {
                        var pascalCaseColumnName = Utilities.ConvertColumnNameToPascalCase(filter.ColumnName);

                        var property = typeof(T).GetProperty(pascalCaseColumnName);
                        DateTime fromDate = DateTime.Parse(filter.From.ToString());
                        DateTime toDate = DateTime.Parse(filter.To.ToString());
                        var x = _context.PoRequests.Where(p => p.CreatedAt >= fromDate && p.CreatedAt <= toDate);
                        if (property != null)
                        {
                            query = query.Where($"{pascalCaseColumnName} >= @0 && {pascalCaseColumnName} <= @1", fromDate, toDate);
                        }
                    }

                }
            }

            #endregion Apply Date Filter

            result.TotalCount = query.Count();

            #region Apply Sorting

            if (orderBy != null && orderByDirection != null)
            {
                var sortDirection = orderByDirection == OrderBy.Asc ? OrderBy.Asc : OrderBy.Desc;
                orderBy = Utilities.ConvertColumnNameToPascalCase(orderBy);

                var property = typeof(T).GetProperty(orderBy);
                if (property != null)
                {
                    query = query.OrderBy($"{orderBy} {sortDirection}");
                }
            }

            #endregion Apply Sorting

            #region Apply Pagination

            if (skip.HasValue && take.HasValue)
            {
                query = query.Skip(skip.Value).Take(take.Value);
            }
            result.PaginatedData = query.ToList();

            #endregion Apply Pagination

            return result;
        }

        public virtual async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria, string[]? includes = null)
        {
            IQueryable<T> query = _context.Set<T>();

            if (includes != null)
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }

            return await query.Where(criteria).ToListAsync();
        }
        public virtual async Task<(int TotalCount, IEnumerable<T> PaginatedData)> FindAllAsync(Expression<Func<T, bool>>? criteria, string[]? includes = null, int? skip = null, int? take = null, Expression<Func<T, object>>? orderBy = null, OrderBy? orderByDirection = null, DateFilter[]? dateFilters = null)
        {
            (int TotalCount, IEnumerable<T> PaginatedData) result;
            IQueryable<T> query = _context.Set<T>().AsNoTracking();

            #region Include Tables

            if (includes != null)
            {
                foreach (var item in includes)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        query = query.Include(item);
                    }
                }
            }

            #endregion Include Tables

            #region Apply General Filter

            if (criteria != null)
            {
                query = query.Where(criteria);
            }

            #endregion Apply General Filter

            #region Apply Date Filter

            if (dateFilters != null)
            {
                foreach (var filter in dateFilters)
                {
                    if (filter.From != null && filter.To != null)
                    {
                        var pascalCaseColumnName = Utilities.ConvertColumnNameToPascalCase(filter.ColumnName);

                        var property = typeof(T).GetProperty(pascalCaseColumnName);
                        DateTime fromDate = DateTime.Parse(filter.From.ToString());
                        DateTime toDate = DateTime.Parse(filter.To.ToString());
                        var x = _context.PoRequests.Where(p => p.CreatedAt >= fromDate && p.CreatedAt <= toDate);
                        if (property != null)
                        {
                            query = query.Where($"{pascalCaseColumnName} >= @0 && {pascalCaseColumnName} <= @1", fromDate, toDate);
                        }
                    }

                }
            }

            #endregion Apply Date Filter

            result.TotalCount = query.Count();

            #region Apply Sorting

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

            #endregion Apply Sorting

            #region Apply Pagination

            if (skip.HasValue && take.HasValue)
            {
                query = query.Skip(skip.Value).Take(take.Value);
            }

            result.PaginatedData = await query.ToListAsync();

            #endregion Apply Pagination

            return result;
        }

        public virtual async Task<(int TotalCount, IEnumerable<T> PaginatedData)> FindAllAsync(Dictionary<string, string>? filters, string? createdBy = null, string[]? includes = null, int? skip = null, int? take = null, string? orderBy = null, OrderBy? orderByDirection = null, DateFilter[]? dateFilters = null)
        {
            var ColumnName = "";
            var ColumnValue = "";
            var expression = "";
            (int TotalCount, IEnumerable<T> PaginatedData) result;

            IQueryable<T> query = _context.Set<T>().AsNoTracking();

            #region Include Tables

            if (includes != null)
            {
                foreach (var item in includes)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        query = query.Include(item);
                    }
                }
            }

            #endregion Include Tables

            #region Apply General Filter

            if (createdBy != null)
            {
                query = query.Where($"CreatedBy ==@0", createdBy);
            }

            if (filters != null && filters.Count > 0)
            {
                filters = Utilities.ConvertKeysToPascalCase(filters);

                foreach (var filter in filters)
                {
                    ColumnName = filter.Key;
                    ColumnValue = filter.Value;

                    var property = typeof(T).GetProperty(ColumnName);
                    if (property != null && !string.IsNullOrEmpty(ColumnValue))
                    {
                        expression = property.PropertyType == typeof(string) ? $"{ColumnName}.Contains(@0)" : $"{ColumnName}.Equals(@0)";
                        query = query.Where(expression, property.PropertyType == typeof(string) ? ColumnValue : int.Parse(ColumnValue));
                    }
                }
            }

            #endregion Apply General Filter

            #region Apply Date Filter

            if (dateFilters != null)
            {
                foreach (var filter in dateFilters)
                {
                    if (filter.From != null && filter.To != null)
                    {
                        var pascalCaseColumnName = Utilities.ConvertColumnNameToPascalCase(filter.ColumnName);

                        var property = typeof(T).GetProperty(pascalCaseColumnName);
                        DateTime fromDate = DateTime.Parse(filter.From.ToString());
                        DateTime toDate = DateTime.Parse(filter.To.ToString());
                        var x = _context.PoRequests.Where(p => p.CreatedAt >= fromDate && p.CreatedAt <= toDate);
                        if (property != null)
                        {
                            query = query.Where($"{pascalCaseColumnName} >= @0 && {pascalCaseColumnName} <= @1", fromDate, toDate);
                        }
                    }

                }
            }

            #endregion Apply Date Filter

            result.TotalCount = query.Count();

            #region Apply Sorting

            if (orderBy != null && orderByDirection != null)
            {
                var sortDirection = orderByDirection == OrderBy.Asc ? OrderBy.Asc : OrderBy.Desc;
                orderBy = Utilities.ConvertColumnNameToPascalCase(orderBy);

                var property = typeof(T).GetProperty(orderBy);
                if (property != null)
                {
                    query = query.OrderBy($"{orderBy} {sortDirection}");
                }
            }

            #endregion Apply Sorting

            #region Apply Pagination

            if (skip.HasValue && take.HasValue)
            {
                query = query.Skip(skip.Value).Take(take.Value);
            }

            result.PaginatedData = await query.ToListAsync();

            #endregion Apply Pagination

            return result;
        }

        public virtual async Task<(int TotalCount, IEnumerable<T> PaginatedData)> FindAllAsync(string? filterValue = null, string? createdBy = null, string[]? includes = null, int? skip = null, int? take = null, string? orderBy = null, OrderBy? orderByDirection = null, DateFilter[]? dateFilters = null)
        {
            var dynamicFilter = "";
            (int TotalCount, IEnumerable<T> PaginatedData) result;
            IQueryable<T> query = _context.Set<T>().AsNoTracking();

            #region Include Tables

            if (includes != null)
            {
                foreach (var item in includes)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        query = query.Include(item);
                    }
                }
            }

            #endregion Include Tables

            #region Apply General Filter

            if (createdBy != null)
            {
                query = query.Where($"CreatedBy ==@0", createdBy);
            }

            var properties = typeof(T).GetProperties();

            if (!string.IsNullOrEmpty(filterValue))
            {
                dynamicFilter = string.Join(" OR ", properties.Where(p => p.PropertyType == typeof(string) || p.PropertyType == typeof(DateTime) || p.PropertyType == typeof(long) || p.PropertyType == typeof(float))
                .Select(property => property.PropertyType == typeof(string) ? $"{property.Name}.Contains(@0)" : $"{property.Name}.Equals(@0)"));
                query = query.Where(dynamicFilter, filterValue);
            }

            #endregion Apply General Filter

            #region Apply Date Filter

            if (dateFilters != null)
            {
                foreach (var filter in dateFilters)
                {
                    if (filter.From != null && filter.To != null)
                    {
                        var pascalCaseColumnName = Utilities.ConvertColumnNameToPascalCase(filter.ColumnName);

                        var property = typeof(T).GetProperty(pascalCaseColumnName);
                        DateTime fromDate = DateTime.Parse(filter.From.ToString());
                        DateTime toDate = DateTime.Parse(filter.To.ToString());
                        var x = _context.PoRequests.Where(p => p.CreatedAt >= fromDate && p.CreatedAt <= toDate);
                        if (property != null)
                        {
                            query = query.Where($"{pascalCaseColumnName} >= @0 && {pascalCaseColumnName} <= @1", fromDate, toDate);
                        }
                    }

                }
            }

            #endregion Apply Date Filter

            result.TotalCount = query.Count();

            #region Apply Sorting

            if (orderBy != null && orderByDirection != null)
            {
                var sortDirection = orderByDirection == OrderBy.Asc ? OrderBy.Asc : OrderBy.Desc;
                orderBy = Utilities.ConvertColumnNameToPascalCase(orderBy);

                var property = typeof(T).GetProperty(orderBy);
                if (property != null)
                {
                    query = query.OrderBy($"{orderBy} {sortDirection}");
                }
            }

            #endregion Apply Sorting

            #region Apply Pagination

            if (skip.HasValue && take.HasValue)
            {
                query = query.Skip(skip.Value).Take(take.Value);
            }

            result.PaginatedData = await query.ToListAsync();

            #endregion Apply Pagination

            return result;
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

        public virtual async Task<T?> FindRequestAsync(long requestId, string expression, string[]? includes = null)
        {
            IQueryable<T> query = _context.Set<T>();

            #region Include Tables

            if (includes != null)
            {
                foreach (var item in includes)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        query = query.Include(item);
                    }
                }
            }

            #endregion Include Tables

            query = query.Where(expression, requestId);
            return await query.FirstOrDefaultAsync();
        }

        public virtual async Task<(int TotalCount, IEnumerable<T> PaginatedData)> FindAllRequestsAsync(string userId, string userCondition, string[]? includes = null, Dictionary<string, string>? filters = null, int? skip = null, int? take = null, string? orderBy = null, OrderBy? orderByDirection = null, DateFilter[]? dateFilters = null)
        {
            var ColumnName = "";
            var ColumnValue = "";
            var expression = "";
            (int TotalCount, IEnumerable<T> PaginatedData) result;

            IQueryable<T> query = _context.Set<T>().AsNoTracking();

            #region Include Tables

            if (includes != null)
            {
                foreach (var item in includes)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        query = query.Include(item);
                    }
                }
            }

            #endregion Include Tables

            #region Permission Filter

            query = query.Where(userCondition, userId);

            #endregion Permission Filter

            #region Apply General Filter


            if (filters != null && filters.Count > 0)
            {
                filters = Utilities.ConvertKeysToPascalCase(filters);

                foreach (var filter in filters)
                {
                    ColumnName = filter.Key;
                    ColumnValue = filter.Value;

                    var property = typeof(T).GetProperty(ColumnName);

                    if ((property != null || ColumnName == "Status") && !string.IsNullOrEmpty(ColumnValue))
                    {
                        if (ColumnName == "Status")
                        {
                            expression = $"Request.{ColumnName}.Contains(@0)";
                            query = query.Where(expression, ColumnValue);
                        }
                        else if(property != null)
                        {
                            expression = property.PropertyType == typeof(string) ? $"{ColumnName}.Contains(@0)" : $"{ColumnName}.Equals(@0)";
                            query = query.Where(expression, property.PropertyType == typeof(string) ? ColumnValue : int.Parse(ColumnValue));
                        }
                    }
                }
            }

            #endregion Apply General Filter

            #region Apply Date Filter

            if (dateFilters != null)
            {
                foreach (var filter in dateFilters)
                {
                    if (filter.From!=null&&filter.To!=null)
                    {
                        var pascalCaseColumnName = Utilities.ConvertColumnNameToPascalCase(filter.ColumnName);

                        var property = typeof(T).GetProperty(pascalCaseColumnName);
                        DateTime fromDate = DateTime.Parse(filter.From.ToString());
                        DateTime toDate = DateTime.Parse(filter.To.ToString());
                       var x=  _context.PoRequests.Where(p => p.CreatedAt >= fromDate && p.CreatedAt<=toDate );
                        if (property != null)
                        {
                            query = query.Where($"{pascalCaseColumnName} >= @0 && {pascalCaseColumnName} <= @1",fromDate,toDate);
                        }
                    }

                }
            }

            #endregion Apply Date Filter

            result.TotalCount = query.Count();

            #region Apply Sorting

            if (orderBy != null && orderByDirection != null)
            {
                var sortDirection = orderByDirection == OrderBy.Asc ? OrderBy.Asc : OrderBy.Desc;
                orderBy = Utilities.ConvertColumnNameToPascalCase(orderBy);

                var property = typeof(T).GetProperty(orderBy);
                if (property != null)
                {
                    query = query.OrderBy($"{orderBy} {sortDirection}");
                }
            }

            #endregion Apply Sorting

            #region Apply Pagination

            if (skip.HasValue && take.HasValue)
            {
                query = query.Skip(skip.Value).Take(take.Value);
            }

            result.PaginatedData = await query.ToListAsync();

            #endregion Apply Pagination

            return result;
        }

        public virtual async Task<(int TotalCount, IEnumerable<T> PaginatedData)> FindAllRequestsAsync(string userId, string userCondition, string[]? includes = null, string? filterValue = null, int? skip = null, int? take = null, string? orderBy = null, OrderBy? orderByDirection = null, DateFilter[]? dateFilters = null)
        {
            var dynamicFilter = "";
            (int TotalCount, IEnumerable<T> PaginatedData) result;

            IQueryable<T> query = _context.Set<T>().AsNoTracking();

            #region Include Tables

            if (includes != null)
            {
                foreach (var item in includes)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        query = query.Include(item);
                    }
                }
            }

            #endregion Include Tables

            #region Permission Filter

            query = query.Where(userCondition, userId);

            #endregion Permission Filter

            #region Apply General Filter

            var properties = typeof(T).GetProperties();

            if (!string.IsNullOrEmpty(filterValue))
            {
                dynamicFilter = string.Join(" OR ", properties.Where(p => p.PropertyType == typeof(string) || p.PropertyType == typeof(DateTime) || p.PropertyType == typeof(long) || p.PropertyType == typeof(float))
                .Select(property => property.PropertyType == typeof(string) ? $"{property.Name}.Contains(@0)" : $"{property.Name}.Equals(@0)"));
                query = query.Where(dynamicFilter, filterValue);
            }

            #endregion Apply General Filter

            #region Apply Date Filter

            if (dateFilters != null)
            {
                foreach (var filter in dateFilters)
                {
                    if (filter.From != null && filter.To != null)
                    {
                        var pascalCaseColumnName = Utilities.ConvertColumnNameToPascalCase(filter.ColumnName);

                        var property = typeof(T).GetProperty(pascalCaseColumnName);

                        if (property != null)
                        {
                            query = query.Where($"{pascalCaseColumnName} >= DateTime({filter.From?.Year}, {filter.From?.Month}, {filter.From?.Day}) && {filter.ColumnName} <= DateTime({filter.To?.Year}, {filter.To?.Month}, {filter.To?.Day})");
                        }
                    }

                }
            }

            #endregion Apply Date Filter

            result.TotalCount = query.Count();

            #region Apply Sorting

            if (orderBy != null && orderByDirection != null)
            {
                var sortDirection = orderByDirection == OrderBy.Asc ? OrderBy.Asc : OrderBy.Desc;
                orderBy = Utilities.ConvertColumnNameToPascalCase(orderBy);

                var property = typeof(T).GetProperty(orderBy);
                if (property != null)
                {
                    query = query.OrderBy($"{orderBy} {sortDirection}");
                }
            }

            #endregion Apply Sorting

            #region Apply Pagination

            if (skip.HasValue && take.HasValue)
            {
                query = query.Skip(skip.Value).Take(take.Value);
            }

            result.PaginatedData = await query.ToListAsync();

            #endregion Apply Pagination

            return result;
        }
    }
}
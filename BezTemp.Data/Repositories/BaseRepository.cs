using BezTemp.Data.IRepositories;
using BezTemp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BezTemp.Data.Repositories
{
    public class BaseRepository<TModel> : IBaseRepository<TModel> where TModel : BaseModel
    {
        private readonly AppDbContext _dbContext;
        protected readonly DbSet<TModel> ModelDbSets;

        public BaseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException();
            ModelDbSets = _dbContext.Set<TModel>();
        }

        public virtual void Dispose()
        {
            _dbContext?.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual void Add(TModel entity)
        {
            ModelDbSets.Add(entity);
        }

        public virtual void AddRange(IEnumerable<TModel> entities)
        {
            ModelDbSets.AddRange(entities);
        }
        public virtual async Task<IEnumerable<TModel>> GetAllAsync()
        {
            return await ModelDbSets.ToListAsync();
        }
        public virtual async Task<TModel> GetAsync(Expression<Func<TModel, bool>> predicate)
        {
            return await ModelDbSets.AsNoTracking().Where(predicate).FirstOrDefaultAsync();
        }

        public virtual async Task<IEnumerable<TModel>> GetListAsync(Expression<Func<TModel, bool>> predicate)
        {
            return await ModelDbSets.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual IQueryable<TModel> Queryable(Expression<Func<TModel, bool>> predicate)
        {
            return ModelDbSets.Where(predicate);
        }

        public virtual void Remove(TModel entity)
        {
            if (_dbContext.Entry(entity).State == EntityState.Detached) ModelDbSets.Attach(entity);
            ModelDbSets.Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<TModel> entities)
        {
            foreach (var entity in entities)
            {
                if (_dbContext.Entry(entity).State == EntityState.Detached) ModelDbSets.Attach(entity);
                ModelDbSets.Remove(entity);
            }
        }

        public virtual async Task<int> SaveShangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public virtual void Update(TModel entity)
        {
            ModelDbSets.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}

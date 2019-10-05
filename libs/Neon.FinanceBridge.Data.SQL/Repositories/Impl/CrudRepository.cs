using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Neon.FinanceBridge.Data.SQL.Entities;

namespace Neon.FinanceBridge.Data.SQL.Repositories.Impl
{
    public class CrudRepository<TContext> : ReadOnlyRepository<TContext>, ICrudRepository where TContext : DbContext
    {
        public CrudRepository(TContext context) : base(context)
        {
        }

        public virtual void Create<TEntity>(TEntity entity, string createdBy = null) where TEntity : class, IBaseEntity
        {
            entity.CreatedDate = DateTime.UtcNow;
            entity.CreatedBy = createdBy;
            context.Set<TEntity>().Add(entity);
        }

        public virtual void Update<TEntity>(TEntity entity, string modifiedBy = null) where TEntity : class, IBaseEntity
        {
            entity.ModifiedDate = DateTime.UtcNow;
            entity.ModifiedBy = modifiedBy;
            context.Set<TEntity>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete<TEntity>(object id) where TEntity : class, IBaseEntity
        {
            var entity = context.Set<TEntity>().Find(id);
            Delete(entity);
        }

        public virtual void Delete<TEntity>(TEntity entity) where TEntity : class, IBaseEntity
        {
            var dbSet = context.Set<TEntity>();
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }

        public virtual void Save()
        {
            context.SaveChanges();
        }

        public virtual Task SaveAsync()
        {
            return context.SaveChangesAsync();
        }
    }
}

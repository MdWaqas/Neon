using System.Threading.Tasks;
using Neon.FinanceBridge.Data.SQL.Entities;

namespace Neon.FinanceBridge.Data.SQL.Repositories
{
    public interface ICrudRepository : IReadOnlyRepository
    {
        void Create<TEntity>(TEntity entity, string createdBy = null) where TEntity : class, IBaseEntity;

        void Update<TEntity>(TEntity entity, string modifiedBy = null) where TEntity : class, IBaseEntity;

        void Delete<TEntity>(object id) where TEntity : class, IBaseEntity;

        void Delete<TEntity>(TEntity entity) where TEntity : class, IBaseEntity;

        void Save();

        Task SaveAsync();
    }
}
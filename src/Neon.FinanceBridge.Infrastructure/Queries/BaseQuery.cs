using System.Data;
namespace Neon.FinanceBridge.Infrastructure.Queries
{
    public class BaseQuery
    {
        protected readonly IDbConnection Connection;
        public BaseQuery(IDbConnection dbConnection)
        {
            Connection = dbConnection;
        }
    }
}

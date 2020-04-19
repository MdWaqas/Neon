using Dapper;
using Neon.FinanceBridge.Application.Queries;
using System.Collections.Generic;
using System.Data;
namespace Neon.FinanceBridge.Infrastructure.Queries
{
    public class BaseQuery: IBaseQuery
    {
        private readonly IDbConnection  connection;
        public BaseQuery(IDbConnection dbConnection)
        {
            this.connection = dbConnection;
        }
        public T GetById<T>(string sql, Dictionary<string,object> parameters = null)
        {
                return connection.QueryFirstOrDefault<T>(sql, parameters);
        }
        public IEnumerable<T> GetAll<T>(string sql, Dictionary<string, object> parameters = null)
        {
                return connection.Query<T>(sql, parameters);
        }
    }
}

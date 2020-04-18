using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using Neon.FinanceBridge.Application.Queries;
using Neon.FinanceBridge.Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Neon.FinanceBridge.Infrastructure.Queries
{
    public class BaseQuery : IBaseQuery
    {
        private readonly IDbConnection dbConnection;
        public BaseQuery(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public T GetById<T>(string sql, object parameters = null)
        {

            return dbConnection.QueryFirstOrDefault<T>(sql, parameters);
        }
        public IEnumerable<T> GetAll<T>(string tableName, object parameters = null)
        {
            return dbConnection.Query<T>(tableName, parameters);
        }
        //public T GetById<T>(string sql, object parameters = null)
        //{
        //    using (var connection = CreateConnection())
        //    {
        //        return connection.QueryFirstOrDefault<T>(sql, parameters);
        //    }
        //}

        //public IEnumerable<T> GetAll<T>(string sql, object parameters = null)
        //{
        //    using (var connection = CreateConnection())
        //    {
        //        return connection.Query<T>(sql, parameters);
        //    }
        //}


        //private IDbConnection CreateConnection()
        //{
        //    var connection = new SqlConnection(connectionString);
        //    return connection;
        //}
    }
}

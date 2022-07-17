using Dapper;
using Neon.FinanceBridge.Application.Queries.Store;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Neon.FinanceBridge.Infrastructure.Queries.Store
{
    public class StoreQueries : BaseQuery, IStoreQueries
    {
        public StoreQueries(IDbConnection dbConnection) : base(dbConnection)
        {
        }

        public IEnumerable<StoreViewModel> Get()
        {
            return Connection.Query<StoreViewModel>("SELECT Id,Name,Code,Logo,EmailAddress,Phone FROM dbo.Stores");
        }

        public StoreViewModel Get(int id)
        {
            return Connection.QuerySingle<StoreViewModel>($"SELECT Id,Name,Code,Logo,EmailAddress,Phone,RowVersion FROM dbo.Stores WHERE Id={id}");
        }
    }
}

using Neon.FinanceBridge.Application.Queries.Item;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace Neon.FinanceBridge.Infrastructure.Queries.Item
{
    public class ItemQueries : BaseQuery, IItemQueries
    {
        public ItemQueries(IDbConnection dbConnection) : base(dbConnection)
        {
        }
        public IEnumerable<ItemViewModel> Get()
        {
            return Connection.Query<ItemViewModel>("SELECT Id,Name,Quantity,AlertQuantity FROM dbo.Items");
        }

        public ItemViewModel Get(int id)
        {
            return Connection.QuerySingle<ItemViewModel>($"SELECT Id,Name,Quantity,AlertQuantity FROM dbo.Items WHERE Id={id}");
        }
    }
}

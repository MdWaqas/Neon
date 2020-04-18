using Dapper;
using Microsoft.Extensions.Options;
using Neon.FinanceBridge.Application.Queries;
using Neon.FinanceBridge.Application.Queries.Item;
using Neon.FinanceBridge.Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Neon.FinanceBridge.Infrastructure.Queries.Item
{
    public class ItemQueries : IItemQueries
    {
        private readonly IBaseQuery query;

        public ItemQueries(IBaseQuery query)
        {
            this.query = query;
        }
        public IEnumerable<ItemDTO> GetAllI()
        {

          return query.GetAll<ItemDTO>("SELECT Id,Name,Quantity,MinimumQuantity FROM dbo.Items");

        }

        public ItemDTO GetById(int id)
        {
            return query.GetById<ItemDTO>($"SELECT Id,Name,Quantity,MinimumQuantity FROM dbo.Items WHERE Id={id}");

        }
    }
}

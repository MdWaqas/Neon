using System;
using System.Collections.Generic;
using System.Text;

namespace Neon.FinanceBridge.Application.Queries.Item
{
    public interface IItemQueries
    {
        IEnumerable<ItemDTO> GetAllI();
       ItemDTO GetById(int id);

    }
}

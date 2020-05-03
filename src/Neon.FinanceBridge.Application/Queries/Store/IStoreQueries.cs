using System;
using System.Collections.Generic;
using System.Text;

namespace Neon.FinanceBridge.Application.Queries.Store
{
    public interface IStoreQueries
    {
        IEnumerable<StoreViewModel> Get();
        StoreViewModel Get(int id);
    }
}

using System.Collections.Generic;

namespace Neon.FinanceBridge.Application.Queries.Item
{
    public interface IItemQueries
    {
        IEnumerable<ItemViewModel> Get();
        ItemViewModel Get(int id);
    }
}

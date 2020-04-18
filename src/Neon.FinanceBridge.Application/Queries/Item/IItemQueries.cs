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
    public class ItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int MinimumQuantity { get; set; }
    }
}

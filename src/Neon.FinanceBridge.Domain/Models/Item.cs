using Neon.FinanceBridge.Data.SQL.Entities.Impl;

namespace Neon.FinanceBridge.Domain.Models
{
  public  class Item: BaseEntity<int>
    {
       
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int AlertQuantity { get; set; }
    }
}

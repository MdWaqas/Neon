using Neon.FinanceBridge.Data.SQL.Entities.Impl;

namespace Neon.FinanceBridge.Domain.Models
{
    public class User : BaseEntity<int>
    {
        public string Name { get; set; }
    }
}

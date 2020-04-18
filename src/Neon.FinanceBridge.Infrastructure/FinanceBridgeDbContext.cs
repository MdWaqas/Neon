using Microsoft.EntityFrameworkCore;
using Neon.FinanceBridge.Domain.Models;

namespace Neon.FinanceBridge.Infrastructure
{
    public class FinanceBridgeDbContext : DbContext
    {
        public FinanceBridgeDbContext(DbContextOptions<FinanceBridgeDbContext> options) : base(options)
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Neon.FinanceBridge.Domain.Models;

namespace Neon.FinanceBridge.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<User> Users { get; set; }
    }
}

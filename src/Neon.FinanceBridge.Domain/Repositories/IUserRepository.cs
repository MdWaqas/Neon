using System.Threading.Tasks;
using Neon.FinanceBridge.Domain.Models;

namespace Neon.FinanceBridge.Domain.Repositories
{
    public interface IUserRepository
    {
        Task Create(User user);
    }
}

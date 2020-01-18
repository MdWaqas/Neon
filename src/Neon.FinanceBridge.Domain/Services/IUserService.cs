using System.Collections.Generic;
using Neon.FinanceBridge.Domain.Models;

namespace Neon.FinanceBridge.Domain.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}

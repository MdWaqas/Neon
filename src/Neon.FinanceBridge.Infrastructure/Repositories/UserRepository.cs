using System;
using System.Threading.Tasks;
using Neon.FinanceBridge.Data.SQL.Repositories;
using Neon.FinanceBridge.Domain.Models;
using Neon.FinanceBridge.Domain.Repositories;

namespace Neon.FinanceBridge.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ICrudRepository repository;

        public UserRepository(ICrudRepository repository)
        {
            this.repository = repository;
        }

        public async Task Create(User user)
        {
            repository.Create(user);
            await repository.SaveAsync();
        }
    }
}

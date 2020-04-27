using System.Collections.Generic;
using Neon.FinanceBridge.Domain.Models;

namespace Neon.FinanceBridge.Domain.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(int id);
        void Add(Customer customer);
        void Update(Customer customer);
        void Remove(int id);
    }
}

using Neon.FinanceBridge.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neon.FinanceBridge.Domain.Services
{
   public interface IItemService
    {
        IEnumerable<Item> GetAll();
        Item GetById(int id);
        void Add(Item customer);
        void Update(Item customer);
        void Remove(int id);
    }
}

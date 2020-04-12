using System;
using System.Collections.Generic;
using System.Text;
using Neon.FinanceBridge.Data.SQL.Entities.Impl;

namespace Neon.FinanceBridge.Domain.Models
{
    public class Customer : BaseEntity<int>
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Email { get; protected set; }
        public string NIC { get; protected set; }
    }
}

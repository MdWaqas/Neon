using System;
using System.Collections.Generic;
using System.Text;

namespace Neon.FinanceBridge.Application.Commands.Customer
{
    public abstract class CustomerCommand
    {
        public int Id { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Email { get; protected set; }
        public string NIC { get; protected set; }
    }
}

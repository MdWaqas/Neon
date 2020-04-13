using System;
using System.Collections.Generic;
using System.Text;
using Neon.FinanceBridge.Common.Domain.Events;

namespace Neon.FinanceBridge.Application.Events
{
    public class CustomerAddedEvent : Event
    {
        public CustomerAddedEvent(int id, string firstName, string lastName, string email, string nic)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            NIC = nic;
            AggregateId = id;
        }
        public int Id { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string NIC { get; private set; }
    }
}

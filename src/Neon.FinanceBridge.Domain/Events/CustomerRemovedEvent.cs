using Neon.FinanceBridge.Common.Domain.Events;

namespace Neon.FinanceBridge.Domain.Events
{
    public class CustomerRemovedEvent : Event
    {
        public CustomerRemovedEvent(int id)
        {
            Id = id;
            AggregateId = id;
        }

        public int Id { get; set; }
    }
}
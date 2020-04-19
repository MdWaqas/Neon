using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Neon.FinanceBridge.Common.Domain.Events
{
    public abstract class Message : IRequest<bool>
    {
        public string MessageType { get; protected set; }
        public int AggregateId { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}

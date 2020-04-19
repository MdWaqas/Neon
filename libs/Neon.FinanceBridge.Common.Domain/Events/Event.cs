using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Neon.FinanceBridge.Common.Domain.Events
{
    public abstract class Event : Message, INotification
    {
        public DateTime Timestamp { get; private set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}

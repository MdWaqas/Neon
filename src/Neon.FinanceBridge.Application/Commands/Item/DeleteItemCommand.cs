using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neon.FinanceBridge.Application.Commands.Item
{
   public class DeleteItemCommand:IRequest<Unit>
    {
        public int Id { get; set; }
        public DeleteItemCommand(int id)
        {
            Id = id;
        }
    }
}

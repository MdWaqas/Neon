using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neon.FinanceBridge.Application.Commands.Store
{
   public class DeleteStoreCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public DeleteStoreCommand(int id)
        {
            Id = id;
        }
    }
}

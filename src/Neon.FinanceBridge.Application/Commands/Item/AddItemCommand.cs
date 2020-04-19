using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neon.FinanceBridge.Application.Commands.Item
{
   public class AddItemCommand:ItemCommand, IRequest<Unit>
    {
    }
}

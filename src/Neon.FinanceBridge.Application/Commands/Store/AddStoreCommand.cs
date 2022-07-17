using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neon.FinanceBridge.Application.Commands.Store
{
    public class AddStoreCommand : StoreCommand, IRequest<Unit>
    {
    }
}

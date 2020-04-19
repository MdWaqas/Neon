using MediatR;

namespace Neon.FinanceBridge.Application.Commands.Customer
{
    public class AddCustomerCommand : CustomerCommand, IRequest<Unit>
    {
        
    }
}
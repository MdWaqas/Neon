using MediatR;

namespace Neon.FinanceBridge.Application.Commands.Customer
{
    public class DeleteCustomerCommand : IRequest<Unit>
    {
        public int Id { get;  set; }
        public DeleteCustomerCommand(int id)
        {
            Id = id;
        }
    }
}
namespace Neon.FinanceBridge.Application.Commands.Customer
{
    public class DeleteCustomerCommand : CustomerCommand
    {
        public DeleteCustomerCommand(int id)
        {
            Id = id;
        }
    }
}
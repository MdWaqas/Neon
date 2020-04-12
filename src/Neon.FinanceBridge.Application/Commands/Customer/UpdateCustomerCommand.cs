namespace Neon.FinanceBridge.Application.Commands.Customer
{
    public class UpdateCustomerCommand : CustomerCommand
    {
        public UpdateCustomerCommand(int id, string firstName, string lastName, string email, string nic)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            NIC = nic;
        }
    }
}
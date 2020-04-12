namespace Neon.FinanceBridge.Application.Commands.Customer
{
    public class AddCustomerCommand : CustomerCommand
    {
        public AddCustomerCommand(string firstName, string lastName, string email, string nic)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            NIC = nic;
        }
    }
}
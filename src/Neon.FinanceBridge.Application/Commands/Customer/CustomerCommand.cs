namespace Neon.FinanceBridge.Application.Commands.Customer
{
    public abstract class CustomerCommand
    {
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string Email { get;  set; }
        public string NIC { get;  set; }
    }
}

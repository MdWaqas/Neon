using Neon.FinanceBridge.Application.Commands.Customer;

namespace Neon.FinanceBridge.Application.Validations.Customer
{
    public class AddCustomerValidations : CustomerValidations<AddCustomerCommand>
    {
        public AddCustomerValidations()
        {
            ValidateFirstName();
            ValidateLastName();
            ValidateEmail();
            ValidateNIC();
        }
    }
}

using FluentValidation;
using Neon.FinanceBridge.Application.Commands.Customer;

namespace Neon.FinanceBridge.Application.Validations.Customer
{
    public class UpdateCustomerValidations: CustomerValidations<UpdateCustomerCommand>
    {
        public UpdateCustomerValidations()
        {
            RuleFor(c => c.Id).GreaterThanOrEqualTo(1);
            ValidateFirstName();
            ValidateLastName();
            ValidateEmail();
            ValidateNIC();
        }
    }
}

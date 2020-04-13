using FluentValidation;
using Neon.FinanceBridge.Application.Commands.Customer;

namespace Neon.FinanceBridge.Application.Validations.Customer
{
    public class DeleteCustomerValidations : AbstractValidator<DeleteCustomerCommand>
    {
        public DeleteCustomerValidations()
        {
            RuleFor(c => c.Id).GreaterThanOrEqualTo(1);
        }
    }
}

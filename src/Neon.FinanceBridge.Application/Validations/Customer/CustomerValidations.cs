using FluentValidation;
using Neon.FinanceBridge.Application.Commands.Customer;

namespace Neon.FinanceBridge.Application.Validations.Customer
{
    public abstract class CustomerValidations<T> : AbstractValidator<T> where T : CustomerCommand
    {
        protected void ValidateFirstName()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("Please ensure you have entered the Firs tName")
                .Length(2, 100).WithMessage("The First Name must have between 2 and 100 characters");
        }

        protected void ValidateLastName()
        {
            RuleFor(c => c.LastName).NotEmpty().WithMessage("Please ensure you have entered the Last Name")
                .Length(2, 100).WithMessage("The Last Name must have between 2 and 100 characters");
        }

        protected void ValidateNIC()
        {
            RuleFor(c => c.NIC).NotEmpty().WithMessage("Please ensure you have entered the NIC")
                .Length(2, 15).WithMessage("The NIC must be 15 characters");
        }

        protected void ValidateEmail()
        {
            RuleFor(c => c.Email).NotEmpty().EmailAddress();
        }
    }
}

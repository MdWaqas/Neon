using FluentValidation;
using Neon.FinanceBridge.Application.Commands.Item;

namespace Neon.FinanceBridge.Application.Validations.Item
{
   public class DeleteItemValidations:AbstractValidator<DeleteItemCommand>
    {
        public DeleteItemValidations()
        {
            RuleFor(t => t.Id).GreaterThanOrEqualTo(1);
        }
    }
}

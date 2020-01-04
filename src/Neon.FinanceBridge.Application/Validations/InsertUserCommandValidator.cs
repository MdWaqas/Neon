using System.Linq;
using FluentValidation;
using Neon.FinanceBridge.Application.Commands;

namespace Neon.FinanceBridge.Application.Validations
{
    public class InsertUserCommandValidator : AbstractValidator<InsertUserCommand>
    {
        public InsertUserCommandValidator()
        {
            RuleFor(cmd => cmd.Name).NotEmpty();
            RuleForEach(cmd => cmd.Name).NotEmpty().WithMessage("User's name must not be empty.");
        }
    }
}

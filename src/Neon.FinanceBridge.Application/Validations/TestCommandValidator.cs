using System.Linq;
using FluentValidation;
using Neon.FinanceBridge.Application.Commands;

namespace Neon.FinanceBridge.Application.Validations
{
    class TestCommandValidator : AbstractValidator<TestCommand>
    {
        public TestCommandValidator()
        {
            RuleFor(cmd => cmd.TransactionIds).NotEmpty();
            RuleForEach(cmd => cmd.TransactionIds).NotEmpty().WithMessage("Transaction Id must not be empty.");
            RuleForEach(cmd => cmd.TransactionIds).MaximumLength(250);
            RuleFor(cmd => cmd.TransactionIds).Must(ids => ids == null || ids.Count() <= 100)
                .WithMessage("Maximum 100 Transaction Ids are allowed per request.");
        }
    }
}

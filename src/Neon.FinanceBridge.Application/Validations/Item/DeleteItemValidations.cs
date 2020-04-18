using FluentValidation;
using Neon.FinanceBridge.Application.Commands.Item;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neon.FinanceBridge.Application.Validations.Item
{
    class DeleteItemValidations:AbstractValidator<DeleteItemCommand>
    {
        public DeleteItemValidations()
        {
            RuleFor(t => t.Id).GreaterThanOrEqualTo(1);
        }
    }
}

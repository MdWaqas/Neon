using FluentValidation;
using Neon.FinanceBridge.Application.Commands.Store;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neon.FinanceBridge.Application.Validations.Store
{
    public class DeleteStoreValidations : AbstractValidator<DeleteStoreCommand>
    {
        public DeleteStoreValidations()
        {
            RuleFor(t => t.Id).GreaterThanOrEqualTo(1);
        }
    }
}

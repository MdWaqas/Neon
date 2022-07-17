using FluentValidation;
using Neon.FinanceBridge.Application.Commands.Store;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neon.FinanceBridge.Application.Validations.Store
{
    public abstract class StoreValidations<T> : AbstractValidator<T> where T : StoreCommand
    {
        protected void ValidateName()
        {
            RuleFor(t => t.Name).NotEmpty().WithMessage("Please ensure you have entered the item name")
                .Length(2, 15).WithMessage("The name must have between 2 and 15 charactors");
        }
    }
}

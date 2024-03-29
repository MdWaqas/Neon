﻿using FluentValidation;
using Neon.FinanceBridge.Application.Commands.Item;

namespace Neon.FinanceBridge.Application.Validations.Item
{
   public abstract class ItemValidations<T>:AbstractValidator<T> where T: ItemCommand
    {
        protected void ValidateName()
        {
            RuleFor(t => t.Name).NotEmpty().WithMessage("Please ensure you have entered the item name")
                .Length(2, 15).WithMessage("The name must have between 2 and 15 charactors");
        }
        protected void ValidateQuantity()
        {
            RuleFor(t => t.Quantity).GreaterThanOrEqualTo(0).WithMessage("Quantity must be greater than or equalto 0");
        }
    }
}

using Neon.FinanceBridge.Application.Commands.Item;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neon.FinanceBridge.Application.Validations.Item
{
   public class UpdateItemValidations:ItemValidations<UpdateItemCommand>
    {
        public UpdateItemValidations()
        {
            ValidateName();
            ValidateQuantity();
        }
    }
}

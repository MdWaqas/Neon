﻿using Neon.FinanceBridge.Application.Commands.Item;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neon.FinanceBridge.Application.Validations.Item
{
    class AddItemValidations:ItemValidations<AddItemCommand>
    {
        public AddItemValidations()
        {
            ValidateName();
            ValidateQuantity();
        }
    }
}

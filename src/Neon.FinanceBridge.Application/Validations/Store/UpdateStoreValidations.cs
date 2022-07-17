﻿using FluentValidation;
using Neon.FinanceBridge.Application.Commands.Store;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neon.FinanceBridge.Application.Validations.Store
{
    public class UpdateStoreValidations : StoreValidations<UpdateStoreCommand>
    {
        public UpdateStoreValidations()
        {
            ValidateName();
        }
    }
}

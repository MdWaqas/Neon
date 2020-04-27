using Neon.FinanceBridge.Application.Commands.Item;

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

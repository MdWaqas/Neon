using Neon.FinanceBridge.Application.Commands.Item;

namespace Neon.FinanceBridge.Application.Validations.Item
{
  public  class AddItemValidations:ItemValidations<AddItemCommand>
    {
        public AddItemValidations()
        {
            ValidateName();
            ValidateQuantity();
        }
    }
}

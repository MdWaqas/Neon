using MediatR;

namespace Neon.FinanceBridge.Application.Commands.Item
{
   public class AddItemCommand:ItemCommand, IRequest<Unit>
    {
    }
}

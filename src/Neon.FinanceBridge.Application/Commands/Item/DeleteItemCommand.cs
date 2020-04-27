using MediatR;

namespace Neon.FinanceBridge.Application.Commands.Item
{
   public class DeleteItemCommand:IRequest<Unit>
    {
        public int Id { get; set; }
        public DeleteItemCommand(int id)
        {
            Id = id;
        }
    }
}

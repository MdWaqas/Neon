using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using MediatR;

namespace Neon.FinanceBridge.Application.Commands.Customer
{
    public class UpdateCustomerCommand : CustomerCommand, IRequest<Unit>
    {
        [JsonIgnore]
        public int Id { get;  set; }
        
    }
}
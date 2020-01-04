using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using MediatR;
using Neon.FinanceBridge.Application.CommandResponses;

namespace Neon.FinanceBridge.Application.Commands
{
    public class InsertUserCommand: IRequest<InsertUserCommandResponse>
    {
        [Required]
        [DataMember]
        public string Name { get; set; }
    }
}

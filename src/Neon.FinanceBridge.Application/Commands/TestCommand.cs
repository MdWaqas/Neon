using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using MediatR;
using Neon.FinanceBridge.Application.CommandResponses;

namespace Neon.FinanceBridge.Application.Commands
{
    public class TestCommand: IRequest<TestCommandResponse>
    {
        [Required]
        [DataMember]
        public IEnumerable<string> TransactionIds { get; set; }
    }
}

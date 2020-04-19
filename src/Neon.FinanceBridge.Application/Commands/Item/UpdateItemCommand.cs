using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Neon.FinanceBridge.Application.Commands.Item
{
   public class UpdateItemCommand:ItemCommand, IRequest<Unit>
    {
        [JsonIgnore]
        public int Id { get; set; }
    }
}

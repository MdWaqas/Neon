using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Neon.FinanceBridge.Application.Commands.Store
{
   public class UpdateStoreCommand : StoreCommand, IRequest<Unit>
    {
        [JsonIgnore]
        public int Id { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Neon.FinanceBridge.Application.Commands.Store;
using Neon.FinanceBridge.Application.Queries.Store;

namespace Neon.FinanceBridge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : ApiController
    {
        private readonly IStoreQueries storeQueries;
        public StoresController(IMediator mediator, IStoreQueries storeQueries) : base(mediator)
        {
            this.storeQueries = storeQueries;
        }

        [HttpGet]
        public IEnumerable<StoreViewModel> Get()
        {
            return storeQueries.Get();
        }

        [HttpGet("{id}")]
        public StoreViewModel Get(int id)
        {
            return storeQueries.Get(id);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddStoreCommand cmd, CancellationToken cancellationToken)
        {
            await Mediator.Send(cmd, cancellationToken);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute]int id, [FromBody] UpdateStoreCommand cmd, CancellationToken cancellationToken)
        {
            cmd.Id = id;
            await Mediator.Send(cmd, cancellationToken);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute]int id, CancellationToken cancellationToken)
        {
            await Mediator.Send(new DeleteStoreCommand(id), cancellationToken);
            return Ok();
        }
    }
}

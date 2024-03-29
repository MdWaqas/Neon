﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Neon.FinanceBridge.Application.Commands.Item;
using Neon.FinanceBridge.Application.Queries.Item;

namespace Neon.FinanceBridge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ApiController
    {
        private readonly IItemQueries itemQueries;
        public ItemsController(IMediator mediator, IItemQueries itemQueries) : base(mediator)
        {
            this.itemQueries = itemQueries;
        }

        [HttpGet]
        public IEnumerable<ItemViewModel> Get()
        {
            return itemQueries.Get();
        }

        [HttpGet("{id}")]
        public ItemViewModel Get(int id)
        {
            return itemQueries.Get(id);

        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddItemCommand cmd, CancellationToken cancellationToken)
        {
            await Mediator.Send(cmd, cancellationToken);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute]int id, [FromBody] UpdateItemCommand cmd , CancellationToken cancellationToken)
        {
            cmd.Id = id;
            await Mediator.Send(cmd, cancellationToken);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute]int id,CancellationToken cancellationToken)
        {
            await Mediator.Send(new DeleteItemCommand(id), cancellationToken);
            return Ok();
        }
    }
}

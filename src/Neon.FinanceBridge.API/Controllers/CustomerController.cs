using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Neon.FinanceBridge.Application.Commands.Customer;
using Neon.FinanceBridge.Domain.Models;

namespace Neon.FinanceBridge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ApiController
    {

        public CustomerController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return null;
        }

        [HttpGet("{id}", Name = "Get")]
        public Customer Get(int id)
        {
            return null;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddCustomerCommand cmd, CancellationToken cancellationToken)
        {
            await Mediator.Send(cmd, cancellationToken);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute]int id, [FromBody] UpdateCustomerCommand cmd, CancellationToken cancellationToken)
        {
            cmd.Id = id;
            await Mediator.Send(cmd, cancellationToken);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute]int id, CancellationToken cancellationToken)
        {
            await Mediator.Send(new DeleteCustomerCommand(id), cancellationToken);
            return Ok();
        }
    }
}

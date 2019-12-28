using System.Net;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Neon.FinanceBridge.Application.CommandResponses;
using Neon.FinanceBridge.Application.Commands;
using Neon.FinanceBridge.Common;

namespace Neon.FinanceBridge.API.Controllers
{
    [ApiController]
    [Consumes("application/json")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(TraceableValidationProblemDetails), (int)HttpStatusCode.BadRequest)]
    [ProducesResponseType(typeof(ApiProblemDetails), (int)HttpStatusCode.InternalServerError)]
    [ProducesResponseType(typeof(ApiProblemDetails), (int)HttpStatusCode.ServiceUnavailable)]
    [ProducesResponseType(typeof(ApiProblemDetails), (int)HttpStatusCode.Forbidden)]
    [ProducesResponseType(typeof(ApiProblemDetails), (int)HttpStatusCode.Unauthorized)]
    [ProducesErrorResponseType(typeof(ApiProblemDetails))]
    public class RetransmitController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RetransmitController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CategoryAggregates")]
        [ProducesResponseType(typeof(TestCommandResponse),(int)HttpStatusCode.Accepted)]
        public async Task<TestCommandResponse> Post([FromBody] TestCommand cmd, CancellationToken cancellationToken)
        {
            var result= await _mediator.Send(cmd, cancellationToken);
            return result;
        }
    }
}

using System.Net;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Neon.FinanceBridge.Application.CommandHandlers;
using Neon.FinanceBridge.Application.Commands;
using Neon.FinanceBridge.Common;

namespace Neon.FinanceBridge.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(TraceableValidationProblemDetails), (int)HttpStatusCode.BadRequest)]
    [ProducesResponseType(typeof(ApiProblemDetails), (int)HttpStatusCode.InternalServerError)]
    [ProducesResponseType(typeof(ApiProblemDetails), (int)HttpStatusCode.ServiceUnavailable)]
    [ProducesResponseType(typeof(ApiProblemDetails), (int)HttpStatusCode.Forbidden)]
    [ProducesResponseType(typeof(ApiProblemDetails), (int)HttpStatusCode.Unauthorized)]
    [ProducesErrorResponseType(typeof(ApiProblemDetails))]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<InsertUserCommandHandler> _logger;

        public UsersController(IMediator mediator, ILogger<InsertUserCommandHandler> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost("Create")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public async Task<IActionResult> Post([FromBody] InsertUserCommand cmd, CancellationToken cancellationToken)
        {
            await _mediator.Send(cmd, cancellationToken);
            return Accepted();
        }
    }
}
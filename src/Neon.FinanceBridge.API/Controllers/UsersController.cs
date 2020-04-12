using System.Net;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] AuthenticateUserCommand cmd, CancellationToken cancellationToken)
        {
            var user = await _mediator.Send(cmd, cancellationToken);
            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });
            return Ok(user);
        }
    }
}
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Neon.FinanceBridge.Application.CommandHandlers;
using Neon.FinanceBridge.Application.Commands;
using Neon.FinanceBridge.Application.Commands.User;
using Neon.FinanceBridge.Common;

namespace Neon.FinanceBridge.API.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : ApiController
    {

        public UsersController(IMediator mediator) : base(mediator)
        {
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] AuthenticateUserCommand cmd, CancellationToken cancellationToken)
        {
            var user = await Mediator.Send(cmd, cancellationToken);
            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });
            return Ok(user);
        }
    }
}
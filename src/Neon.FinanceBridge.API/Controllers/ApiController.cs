using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    [Authorize]
    public class ApiController : ControllerBase
    {
        protected readonly IMediator Mediator;

        public ApiController(IMediator mediator)
        {
            Mediator = mediator;
        }
    }
}

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Neon.FinanceBridge.Application.Commands;
using Neon.FinanceBridge.Domain.Models;
using Neon.FinanceBridge.Domain.Services;
using Neon.FinanceBridge.Tracing;

namespace Neon.FinanceBridge.Application.CommandHandlers
{
    public class AuthenticateUserCommandHandler : BaseCommandHandler<AuthenticateUserCommandHandler, AuthenticateUserCommand, User>
    {
        private readonly IUserService userService;

        public AuthenticateUserCommandHandler(ILogger<BaseCommandHandler<AuthenticateUserCommandHandler, AuthenticateUserCommand, User>> logger, IDiagnosticSpanBuilder<BaseCommandHandler<AuthenticateUserCommandHandler, AuthenticateUserCommand, User>> diagnosticSpanBuilder, IUserService userService) : base(logger, diagnosticSpanBuilder)
        {
            this.userService = userService;
        }
        public override async Task<User> HandleCommand(AuthenticateUserCommand command, CancellationToken cancellationToken)
        {
            var user = userService.Authenticate(command.Username, command.Password);
            return user;

        }
    }
}

using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Neon.FinanceBridge.Application.Commands.User;
using Neon.FinanceBridge.Domain.Models;
using Neon.FinanceBridge.Domain.Services;

namespace Neon.FinanceBridge.Application.CommandHandlers
{
    public class AuthenticateUserCommandHandler : IRequestHandler<AuthenticateUserCommand, User>
    {
        private readonly IUserService userService;

        public AuthenticateUserCommandHandler(IUserService userService)
        {
            this.userService = userService;
        }

        public Task<User> Handle(AuthenticateUserCommand command, CancellationToken cancellationToken)
        {
            var user = userService.Authenticate(command.Username, command.Password);
            return Task.FromResult(user);
        }
    }
}

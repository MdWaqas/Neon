using System.ComponentModel.DataAnnotations;
using MediatR;

namespace Neon.FinanceBridge.Application.Commands.User
{
    public class AuthenticateUserCommand : IRequest<Domain.Models.User>
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

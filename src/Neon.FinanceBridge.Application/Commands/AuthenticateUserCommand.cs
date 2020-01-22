using System.ComponentModel.DataAnnotations;
using MediatR;
using Neon.FinanceBridge.Domain.Models;

namespace Neon.FinanceBridge.Application.Commands
{
    public class AuthenticateUserCommand : IRequest<User>
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

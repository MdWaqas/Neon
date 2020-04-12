using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Neon.FinanceBridge.Application.CommandResponses;
using Neon.FinanceBridge.Application.Commands;
using Neon.FinanceBridge.Domain.Models;
using Neon.FinanceBridge.Domain.Repositories;
using Neon.FinanceBridge.Tracing;

namespace Neon.FinanceBridge.Application.CommandHandlers
{
    //public class InsertUserCommandHandler : BaseCommandHandler<InsertUserCommandHandler, InsertUserCommand, InsertUserCommandResponse>
    //{
    //    private readonly IUserRepository repository;

    //    public InsertUserCommandHandler(
    //        ILogger<BaseCommandHandler<InsertUserCommandHandler, InsertUserCommand, InsertUserCommandResponse>> logger,
    //        IDiagnosticSpanBuilder<BaseCommandHandler<InsertUserCommandHandler, InsertUserCommand,
    //            InsertUserCommandResponse>> diagnosticSpanBuilder, IUserRepository repository) : base(logger,
    //        diagnosticSpanBuilder)
    //    {
    //        this.repository = repository;
    //    }

    //    public override async Task<InsertUserCommandResponse> HandleCommand(InsertUserCommand command, CancellationToken cancellationToken)
    //    {
    //        var user = new User { FirstName = command.Name };
    //        await repository.Create(user);
    //        return null;
    //    }
    //}
}

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Neon.FinanceBridge.Application.CommandResponses;
using Neon.FinanceBridge.Application.Commands;
using Neon.FinanceBridge.Tracing;

namespace Neon.FinanceBridge.Application.CommandHandlers
{
    public class TestCommandHandler : BaseCommandHandler<TestCommandHandler,TestCommand, TestCommandResponse>
    {
        public TestCommandHandler(ILogger<BaseCommandHandler<TestCommandHandler, TestCommand, TestCommandResponse>> logger, IDiagnosticSpanBuilder<BaseCommandHandler<TestCommandHandler, TestCommand, TestCommandResponse>> diagnosticSpanBuilder) : base(logger, diagnosticSpanBuilder)
        {
        }

        public override Task<TestCommandResponse> HandleCommand(TestCommand command, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}

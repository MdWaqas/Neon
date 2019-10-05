using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using Neon.FinanceBridge.Common.Utils;
using Neon.FinanceBridge.Tracing;

namespace Neon.FinanceBridge.Application.CommandHandlers
{
    /// <summary>
    /// Base class for all CommandHandlers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TRequest"></typeparam>
    /// <typeparam name="TResponse"></typeparam>
    public abstract class BaseCommandHandler<T, TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
        where T : IRequestHandler<TRequest, TResponse>
    {
        private readonly ILogger<BaseCommandHandler<T, TRequest, TResponse>> _logger;
        private readonly IDiagnosticSpanBuilder<BaseCommandHandler<T, TRequest, TResponse>> _diagnosticSpanBuilder;


        /// <inheritdoc />
        protected BaseCommandHandler(ILogger<BaseCommandHandler<T, TRequest, TResponse>> logger,
            IDiagnosticSpanBuilder<BaseCommandHandler<T, TRequest, TResponse>> diagnosticSpanBuilder)
        {
            Guard.AgainstNullArgument(nameof(logger), logger);
            Guard.AgainstNullArgument(nameof(diagnosticSpanBuilder), diagnosticSpanBuilder);
            _logger = logger;
            _diagnosticSpanBuilder = diagnosticSpanBuilder;
        }

        /// <inheritdoc />
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
        {
            using (_diagnosticSpanBuilder.Start(nameof(HandleCommand), request))
            {
                return await HandleCommand(request, cancellationToken);
            }
        }

        /// <summary>
        /// Process Command. 
        /// </summary>
        /// <param name="command"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public abstract Task<TResponse> HandleCommand(TRequest command, CancellationToken cancellationToken);
    }
}

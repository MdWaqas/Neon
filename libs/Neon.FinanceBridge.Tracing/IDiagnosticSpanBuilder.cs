using System.Collections.Immutable;
using System.Diagnostics;

namespace Neon.FinanceBridge.Tracing
{
    /// <summary>
    /// </summary>
    /// <typeparam name="TCategoryName">The type who's name is used for the DiagnosticSpan name.</typeparam>
    public interface IDiagnosticSpanBuilder<out TCategoryName>
    {
        DiagnosticListener Listener { get; }
        IDiagnosticSpan Start(string operationName, object payload, IImmutableDictionary<string, string> tags, IImmutableDictionary<string, string> baggage);

        IDiagnosticSpan Start(string operationName);

        IDiagnosticSpan Start(string operationName, object payload);

        IDiagnosticSpan Start(Activity activity, object payload, IImmutableDictionary<string, string> tags,
            IImmutableDictionary<string, string> baggage);

    }
}
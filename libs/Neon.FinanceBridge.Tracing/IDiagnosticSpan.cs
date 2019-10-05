using System;

namespace Neon.FinanceBridge.Tracing
{
    /// <inheritdoc />
    /// <summary>
    /// Represents a single Operation. 
    /// </summary>
    public interface IDiagnosticSpan : IDisposable
    {
        string Name { get; }

        /// <summary>Set a key:value tag on the span.</summary>
        /// <returns>This span instance, for chaining.</returns>
        IDiagnosticSpan SetTag(string key, string value);

        /// <summary>
        /// Sets a baggage item in the span Baggage is sent in-band with every subsequent local and remote calls,
        /// so this feature must be used with care.
        /// </summary>
        /// <returns>This span instance, for chaining.</returns>
        IDiagnosticSpan SetBaggageItem(string key, string value);

        /// <summary>The value of the baggage item identified by <paramref name="key"/>, or null if no such item could be found.</summary>
        string GetBaggageItem(string key);

        void Log<T>(T payload);
        void LogException<T>(T payload, Exception ex);
    }
}

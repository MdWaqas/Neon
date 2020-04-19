using System;
using System.Diagnostics;

namespace Neon.FinanceBridge.Tracing
{
    public class DiagnosticSpan : IDiagnosticSpan
    {
        private Activity _activity;
        public string Name { get; }
        public DiagnosticListener Listener { get; }

        private readonly object _lock = new object();

        public DiagnosticSpan(DiagnosticListener listener, Activity activity, string name)
        {
            _activity = activity;
            Name = name;
            Listener = listener;
        }


        public IDiagnosticSpan SetTag(string key, string value)
        {
            lock (_lock)
            {
                _activity.AddTag(key, value);
            }

            return this;
        }

        public IDiagnosticSpan SetBaggageItem(string key, string value)
        {
            lock (_lock)
            {
                _activity.AddBaggage(key, value);
            }

            return this;
        }

        public string GetBaggageItem(string key)
        {
            lock (_lock)
            {
                return _activity.GetBaggageItem(key);
            }
        }


        public void Log<T>(T payload)
        {
            LogInternal(new
            {
                Payload = payload
            });
        }

        public void LogException<T>(T payload, Exception ex)
        {
            LogInternal(new
            {
                Payload = payload,
                Exception = ex,
                IsError = true
            });
        }

        private void LogInternal<T>(T payload)
        {
            if (!Listener.IsEnabled() || !Listener.IsEnabled(Name)) return;
            Listener.Write(Name, payload);
        }

        private void Stop<T>(T payload)
        {
            if (_activity == null) return;
            lock (_lock)
            {
                Listener.StopActivity(_activity, payload);
            }
        }

        private void Stop()
        {
            if (_activity == null) return;
            lock (_lock)
            {
                Listener.StopActivity(_activity, null);
                _activity = null;
            }
        }

        public void Dispose()
        {
            Stop();
        }
    }
}
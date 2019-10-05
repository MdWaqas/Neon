using System.Collections.Immutable;
using System.Diagnostics;

namespace Neon.FinanceBridge.Tracing
{
    public class DiagnosticSpanBuilder<T> : IDiagnosticSpanBuilder<T>
    {
        public DiagnosticListener Listener { get; }
        public DiagnosticSpanBuilder(DiagnosticListener listener)
        {
            Listener = listener;
        }

        public IDiagnosticSpan Start(string operationName)
        {
            return Start(operationName, null, null, null);
        }


        public IDiagnosticSpan Start(string operationName, object payload)
        {
            return Start(operationName, payload, null, null);
        }

        public IDiagnosticSpan Start(Activity activity, object payload, IImmutableDictionary<string, string> tags, IImmutableDictionary<string, string> baggage)
        {
            var startName = activity.OperationName + ".Start";

            if (!Listener.IsEnabled() || !Listener.IsEnabled(activity.OperationName))
            {
                return new DiagnosticSpan(Listener, null, activity.OperationName);
            }

            PopulateTags(activity, tags);
            PopulateBaggage(activity, baggage);

            // in many cases activity start event is not interesting, 
            // in that case start activity without firing event
            if (Listener.IsEnabled(startName))
            {
                Listener.StartActivity(activity, payload);
            }
            else
            {
                activity.Start();
            }

            return new DiagnosticSpan(Listener, activity, activity.OperationName);
        }


        public IDiagnosticSpan Start(string operationName, object payload, IImmutableDictionary<string, string> tags, IImmutableDictionary<string, string> baggage)
        {
            //var name = Listener.Name + $".{operationName}";
            string name = BuildName(operationName);
            var startName = name + ".Start";

            if (!Listener.IsEnabled() || !Listener.IsEnabled(name))
            {
                return new DiagnosticSpan(Listener, null, name);
            }

            var activity = new Activity(name);
            PopulateTags(activity, tags);
            PopulateBaggage(activity, baggage);

            // in many cases activity start event is not interesting, 
            // in that case start activity without firing event
            if (Listener.IsEnabled(startName))
            {
                Listener.StartActivity(activity, payload);
            }
            else
            {
                activity.Start();
            }

            return new DiagnosticSpan(Listener, activity, name);
        }

        private static string BuildName(string operationName)
        {
            return string.Concat(typeof(T).Name, ".", operationName);
        }

        private static void PopulateTags(Activity activity, IImmutableDictionary<string, string> tags)
        {
            if (tags == null) return;
            foreach (var key in tags.Keys)
            {
                activity.AddTag(key, tags[key]);
            }
        }

        private static void PopulateBaggage(Activity activity, IImmutableDictionary<string, string> baggage)
        {
            if (baggage == null) return;
            foreach (var key in baggage.Keys)
            {
                activity.AddBaggage(key, baggage[key]);
            }
        }


    }
}
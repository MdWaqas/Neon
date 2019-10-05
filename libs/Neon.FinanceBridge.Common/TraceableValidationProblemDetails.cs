using Microsoft.AspNetCore.Mvc;

namespace Neon.FinanceBridge.Common
{
    public class TraceableValidationProblemDetails : ValidationProblemDetails
    {
        public string TraceId { get; set; }

        /// <summary>
        ///     Initializes a new instance of <see cref="TraceableValidationProblemDetails"/>.
        /// </summary>
        /// <param name="traceId"></param>
        public TraceableValidationProblemDetails(string traceId)
        {
            TraceId = traceId;
        }
    }
}

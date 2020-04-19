using Microsoft.AspNetCore.Mvc;

namespace Neon.FinanceBridge.Common
{
    public class ApiProblemDetails : ProblemDetails
    {
        public string TraceId { get; set; }
    }
}
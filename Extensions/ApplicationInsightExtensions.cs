using ApplicationInsights.RequestResponseLogging.Middlewares;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationInsights.RequestResponseLogging.Extensions
{
    /// <summary>
    /// Extensions for enabling request or response logging
    /// </summary>
    public static class ApplicationInsightExtensions
    {
        public static IApplicationBuilder UseRequestLogging(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestLoggingMiddleware>();
        }

        public static IApplicationBuilder UseResponseLogging(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ResponseLoggingMiddleware>();
        }
    }
}

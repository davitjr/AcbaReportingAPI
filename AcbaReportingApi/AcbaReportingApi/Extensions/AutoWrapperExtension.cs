using AutoWrapper;
using Microsoft.AspNetCore.Builder;

namespace AcbaReportsApi.Extensions
{
    public static class AutoWrapperExtension
    {
        public static void UseAutoWrapperWithConfigurations(this IApplicationBuilder app)
        {
            app.UseApiResponseAndExceptionWrapper(new AutoWrapperOptions { UseApiProblemDetailsException = true, IgnoreWrapForOkRequests = true, EnableExceptionLogging = true, EnableResponseLogging = false });
        }
    }
}

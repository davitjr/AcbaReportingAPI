using AcbaReportsApi.Application.Helpers;
using AcbaReportsApi.Application.Http;
using AcbaReportsApi.Application.Settings;
using AcbaReportsApi.Filters;
using AcbaReportsApi.Infrastructure.Services.Authorization;
using AcbaReportsApi.Infrastructure.Services.Template;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AcbaReportsApi.Extensions
{
    public static class DependencieInjectionExtension
    {
        public static void AddDependencieInjections(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<AcbaReportsApiOptions>(configuration.GetSection(nameof(AcbaReportsApiOptions)))
           .Configure<AcbaReportingServiceUrlOptions>(configuration.GetSection(nameof(AcbaReportingServiceUrlOptions)))
           .AddScoped<IHttpRequestSender, HttpRequestSender>()
           .AddSingleton<IProblemDetailsHelper, ProblemDetailsHelper>()
           .AddScoped<IHttpResponsePreCheck, HttpResponseChecker>()
           .AddScoped<IAcbaReportsService, AcbaReportsService>()
           .AddScoped<IXBSecurityService, XBSecurityService>()
           .AddScoped<IRenderReportHelper, RenderReportHelper>()
           .AddScoped<ISystemIOHelper, SystemIOHelper>()
           .AddScoped<IAsyncAuthorizationFilter, AuthFilter>();
        }
    }
}

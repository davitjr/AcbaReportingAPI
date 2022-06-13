using AcbaReportsApi.Application.Http;
using AcbaReportsApi.Application.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace AcbaReportsApi.Extensions
{
    public static class HttpClientExtension
    {
        public static void AddHttpClients(this IServiceCollection services, IConfiguration configuration)
        {
            AcbaReportingServiceUrlOptions acbaReportingServiceUrlOptions = configuration.GetSection(nameof(AcbaReportingServiceUrlOptions)).Get<AcbaReportingServiceUrlOptions>();
            services.AddHttpClient(nameof(HttpRequestSender), client =>
            {
                client.BaseAddress = new Uri(acbaReportingServiceUrlOptions.BaseUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }).ConfigurePrimaryHttpMessageHandler(() =>
            {
                HttpClientHandler httpClientHandler = new();
                httpClientHandler.Credentials = new CredentialCache { { new Uri(acbaReportingServiceUrlOptions.BaseUrl), "NTLM", CredentialCache.DefaultNetworkCredentials } };
                return httpClientHandler;
            });
        }
    }
}

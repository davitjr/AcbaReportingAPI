using AutoMapper;
using AcbaReportsApi.Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace AcbaReportsApi.Extensions
{
    public static class AutoMapperExtension
    {
        public static void AddAutoMapperConfigurations(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AcbaReportsMappingProfile));
        }
    }
}

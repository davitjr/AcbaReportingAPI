using AutoMapper;
using AcbaReportsApi.Application.DTOs.Report;
using AcbaReportsApi.Infrastructure.ServiceDTOs.AcbaReports;

namespace AcbaReportsApi.Mappings
{
    public class AcbaReportsMappingProfile : Profile
    {
        public AcbaReportsMappingProfile()
        {
            CreateMap<SSRSRequest, ServiceSSRSRequest>();
            CreateMap<ServiceSSRSResponse, SSRSResponse>();
        }
    }
}


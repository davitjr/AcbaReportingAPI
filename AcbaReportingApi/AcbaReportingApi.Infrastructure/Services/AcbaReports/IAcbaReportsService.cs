using AcbaReportsApi.Application.DTOs.Report;
using AcbaReportsApi.Infrastructure.ServiceDTOs.AcbaReports;
using System.Threading.Tasks;

namespace AcbaReportsApi.Infrastructure.Services.Template
{
    public interface IAcbaReportsService
    {
        Task<ServiceSSRSResponse> GetReportRequestAsync(SSRSRequest request);
    }
}
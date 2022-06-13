using System.IO;
using AcbaReportsApi.Application.Helpers;

namespace AcbaReportsApi.Infrastructure.ServiceDTOs.AcbaReports
{
    public class ServiceSSRSResponse
    {
        public byte[] ReportBuffer { get; set; }

        public ServiceSSRSResponse(byte[] response)
        {
            ReportBuffer = response;
        }
    }
}

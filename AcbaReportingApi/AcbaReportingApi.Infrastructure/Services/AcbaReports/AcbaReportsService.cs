using AcbaReportsApi.Application.DTOs.Report;
using AcbaReportsApi.Application.Helpers;
using AcbaReportsApi.Application.Models;
using AcbaReportsApi.Application.Settings;
using AcbaReportsApi.Infrastructure.ServiceDTOs.AcbaReports;
using Microsoft.Extensions.Options;
using ReportExecutionService;
using System.Threading.Tasks;

namespace AcbaReportsApi.Infrastructure.Services.Template
{
    public class AcbaReportsService : IAcbaReportsService
    {
        public AcbaReportsService(IOptions<AcbaReportingServiceUrlOptions> acbaReportingServiceUrlOptions,
             IRenderReportHelper renderReportHelper)
        {
            _acbaReportingServiceUrlOptions = acbaReportingServiceUrlOptions.Value;
            _renderReportHelper = renderReportHelper;
        }

        private readonly AcbaReportingServiceUrlOptions _acbaReportingServiceUrlOptions;
        private readonly IRenderReportHelper _renderReportHelper;

        public async Task<ServiceSSRSResponse> GetReportRequestAsync(SSRSRequest request)
        {
            string requestUri = ReportName.GetRequestUri(request.ReportName, _acbaReportingServiceUrlOptions);
            string baseUrl = _acbaReportingServiceUrlOptions.BaseUrl;
            byte[] response = await RenderReport(baseUrl, requestUri, request);
            ServiceSSRSResponse AcbaReportsApiDto = new ServiceSSRSResponse(response);
            return AcbaReportsApiDto;
        }

        private async Task<byte[]> RenderReport(string baseUrl, string reportPath, SSRSRequest sSRSRequest)
        {
            ReportExecutionServiceSoapClient rs = _renderReportHelper.CreateClient(baseUrl);
            TrustedUserHeader trustedHeader = new TrustedUserHeader();

            LoadReportResponse loadReponse = await _renderReportHelper.LoadReport(rs, trustedHeader, reportPath);

            await _renderReportHelper.AddParametersToTheReport(rs, loadReponse.ExecutionHeader, trustedHeader, sSRSRequest.Parameters);

            RenderResponse response = await _renderReportHelper.RenderReportByteArrayAsync(loadReponse.ExecutionHeader, trustedHeader, rs, sSRSRequest.ReportExportFormat.ToString(), null, null);


            return response.Result;
        }


    }
}

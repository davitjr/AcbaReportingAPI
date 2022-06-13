using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportExecutionService;

namespace AcbaReportsApi.Application.Helpers
{
    public interface IRenderReportHelper
    {
        ReportExecutionServiceSoapClient CreateClient(string baseUrl);

        Task<LoadReportResponse> LoadReport(ReportExecutionServiceSoapClient rs, TrustedUserHeader trustedHeader, string reportPath);

        Task<SetExecutionParametersResponse> AddParametersToTheReport(ReportExecutionServiceSoapClient rs, ExecutionHeader executionHeader, TrustedUserHeader trustedHeader, Dictionary<string, string> parameters);

        Task<RenderResponse> RenderReportByteArrayAsync(ExecutionHeader execHeader, TrustedUserHeader trustedHeader,
           ReportExecutionServiceSoapClient rs, string format, string width, string height);
    }
}

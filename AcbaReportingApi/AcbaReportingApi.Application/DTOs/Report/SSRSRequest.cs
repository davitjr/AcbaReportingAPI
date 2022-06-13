
using AcbaReportsApi.Application.Models;
using System.Collections.Generic;

namespace AcbaReportsApi.Application.DTOs.Report
{
    public class SSRSRequest
    {
        public Dictionary<string,string> Parameters { get; set; }

        public ReportsNames ReportName { get; set; }

        public ExportFormat ReportExportFormat { get; set; }
    }
}

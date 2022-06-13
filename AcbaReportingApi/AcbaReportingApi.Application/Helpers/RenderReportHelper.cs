using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportExecutionService;
using System.ServiceModel;
using AcbaReportsApi.Application.DTOs.Report;

namespace AcbaReportsApi.Application.Helpers
{
    public class RenderReportHelper: IRenderReportHelper
    {
        static string historyID = null;
        public ReportExecutionServiceSoapClient CreateClient(string baseUrl)
        {
            var rsBinding = new BasicHttpBinding();

            rsBinding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            rsBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Ntlm;

            rsBinding.MaxBufferPoolSize = 65536000;
            rsBinding.MaxBufferSize = 65536000;
            rsBinding.MaxReceivedMessageSize = 65536000;
            rsBinding.Security.Mode = BasicHttpSecurityMode.Transport;
            rsBinding.TransferMode = TransferMode.Buffered;

            rsBinding.ReceiveTimeout = new TimeSpan(0, 20, 0);
            rsBinding.SendTimeout = new TimeSpan(0, 20, 0);
            rsBinding.OpenTimeout = new TimeSpan(0, 20, 0);
            rsBinding.CloseTimeout = new TimeSpan(0, 20, 0);




            var rsEndpointAddress = new EndpointAddress(baseUrl);
            var rsClient = new ReportExecutionServiceSoapClient(rsBinding, rsEndpointAddress);

            rsClient.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;


            return rsClient;
        }
        public async Task<LoadReportResponse> LoadReport(ReportExecutionServiceSoapClient rs, TrustedUserHeader trustedHeader, string reportPath)
        {
            LoadReportResponse loadReponse = await rs.LoadReportAsync(trustedHeader, reportPath, historyID);

            return loadReponse;
        }

        public async Task<SetExecutionParametersResponse> AddParametersToTheReport(ReportExecutionServiceSoapClient rs, ExecutionHeader executionHeader, TrustedUserHeader trustedHeader, Dictionary<string, string> parameters)
        {
            List<ParameterValue> parametersList = new List<ParameterValue>();

            if (parameters != null)
            {
                foreach (KeyValuePair<string, string> param in parameters)
                {
                    ParameterValue oneParam = new ParameterValue
                    {
                        Name = param.Key,
                        Value = param.Value
                    };
                    parametersList.Add(oneParam);
                }
            }

            SetExecutionParametersResponse setParamsResponse = await rs.SetExecutionParametersAsync(executionHeader, trustedHeader, parametersList.ToArray(), "en-US");

            return setParamsResponse;
        }

        public async Task<RenderResponse> RenderReportByteArrayAsync(ExecutionHeader execHeader, TrustedUserHeader trustedHeader,
           ReportExecutionServiceSoapClient rs, string format, string width, string height)
        {
            string deviceInfo = String.Format("<DeviceInfo><PageHeight>{0}</PageHeight><PageWidth>{1}</PageWidth><PrintDpiX>300</PrintDpiX><PrintDpiY>300</PrintDpiY></DeviceInfo>", height, width);

            var renderRequest = new RenderRequest(execHeader, trustedHeader, format, deviceInfo);

            //get report bytes
            RenderResponse response = await rs.RenderAsync(renderRequest);
          
            return response;
        }
    }
}

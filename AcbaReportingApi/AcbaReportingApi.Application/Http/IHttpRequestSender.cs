using AcbaReportsApi.Application.DTOs.Report;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace AcbaReportsApi.Application.Http
{
    public interface IHttpRequestSender
    {
        Task<Stream> SendPostRequest(string requestUri, Dictionary<string, string> content);
    }
}
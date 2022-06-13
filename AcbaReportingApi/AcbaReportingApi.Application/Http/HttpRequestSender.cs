using AcbaReportsApi.Application.DTOs.Report;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AcbaReportsApi.Application.Http
{
    public class HttpRequestSender : IHttpRequestSender
    {
        public HttpRequestSender(IHttpClientFactory httpClientFactory, IEnumerable<IHttpResponsePreCheck> httpResponsePreChecks)
        {
            _httpClient = httpClientFactory.CreateClient(nameof(HttpRequestSender));
            _httpResponsePreChecks = httpResponsePreChecks;
            _httpClient.Timeout = TimeSpan.FromMinutes(5);
        }

        private readonly HttpClient _httpClient;
        private readonly IEnumerable<IHttpResponsePreCheck> _httpResponsePreChecks;

        public async Task<Stream> SendPostRequest(string requestUri, Dictionary<string,string> content)
        {            
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsync(requestUri, new StringContent(JsonSerializer.Serialize(content), Encoding.UTF8, MediaTypeNames.Application.Json));
            return await ResponseHandlerAsync(httpResponseMessage);
            //StringContent postContent = new StringContent(JsonConvert.SerializeObject(content));
            //var response = await _httpClient.PostAsync(requestUri, postContent);
            //var responseContent = await response.Content.ReadAsStringAsync();
            //return await ResponseHandlerAsync(response);
        }

        private async Task<Stream> ResponseHandlerAsync(HttpResponseMessage httpResponseMessage)
        {
            foreach (IHttpResponsePreCheck httpResponsePreCheck in _httpResponsePreChecks)
            {
                await httpResponsePreCheck.CheckHttpResponse(httpResponseMessage);
            }
            return await httpResponseMessage.Content.ReadAsStreamAsync();
        }
    }
}

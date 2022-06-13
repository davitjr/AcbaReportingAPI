using AutoWrapper.Wrappers;
using AcbaReportsApi.Application.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AcbaReportsApi.Application.Http
{
    public class HttpResponseChecker : IHttpResponsePreCheck
    {
        public HttpResponseChecker(IProblemDetailsHelper problemDetailsHelper)
        {
            _problemDetailsHelper = problemDetailsHelper;
        }

        private readonly IProblemDetailsHelper _problemDetailsHelper;
        public async Task CheckHttpResponse(HttpResponseMessage httpResponseMessage)
        {
            switch (httpResponseMessage.StatusCode)
            {
                case HttpStatusCode.OK:
                    break;
                case HttpStatusCode.BadRequest:
                    {
                        ValidationProblemDetails validationProblemDetails = await JsonSerializer.DeserializeAsync<ValidationProblemDetails>(await httpResponseMessage.Content.ReadAsStreamAsync());
                        throw new ApiProblemDetailsException(validationProblemDetails);
                    }
                default:
                    {
                        throw new ApiProblemDetailsException(_problemDetailsHelper.GetGlobalProblemDetails());
                    }
            }
        }
    }
}

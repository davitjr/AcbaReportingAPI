using System.Net.Http;
using System.Threading.Tasks;

namespace AcbaReportsApi.Application.Http
{
    public interface IHttpResponsePreCheck
    {
        Task CheckHttpResponse(HttpResponseMessage httpResponseMessage);
    }
}

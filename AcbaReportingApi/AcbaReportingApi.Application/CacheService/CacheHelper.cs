using AcbaReportsApi.Application.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcbaReportsApi.Application.CacheService
{
    public class CacheHelper
    {
        private readonly IMemoryCache _cache;
        private readonly IHttpContextAccessor _contextAccessor;
        private string SessionId;

        public AuthorizedCustomer GetAuthorizedCustomer()
        {
            SessionId = _contextAccessor.HttpContext.Request.Headers["SessionId"].ToString();

            _cache.TryGetValue(SessionId + "_authorizedCustomer", out AuthorizedCustomer authorizedCustomer);

            return authorizedCustomer;
        }
    }
}

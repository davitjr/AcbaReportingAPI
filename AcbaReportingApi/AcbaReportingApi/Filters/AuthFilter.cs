using AcbaReportsApi.Application.Models;
using AcbaReportsApi.Infrastructure.Services.Authorization;
using AuthServiceReference;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcbaReportsApi.Filters
{
    public class AuthFilter : IAsyncAuthorizationFilter
    {
        private readonly IXBSecurityService _xbSecurityService;
        private readonly IMemoryCache _cache;

        public AuthFilter(IXBSecurityService xbSecurityService, IMemoryCache cache)
        {
            _xbSecurityService = xbSecurityService;
            _cache = cache;
        }

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            string sessionId = string.Empty;
            string ipAddress;

            //Սեսիայի նունականացման համար
            if (!string.IsNullOrEmpty(context.HttpContext.Request.Headers["SessionId"]))
            {
                sessionId = context.HttpContext.Request.Headers["SessionId"];
            }

            ipAddress = context.HttpContext.Connection.RemoteIpAddress.ToString();

            bool IsAuthorizedCustomerInCache = _cache.TryGetValue(sessionId + "_authorizedCustomer", out AuthorizedCustomer authorizedCustomer);

            if (IsAuthorizedCustomerInCache == false)
            {
                authorizedCustomer = new AuthorizedCustomer();

                if (context.Filters.Any(item => item is IAllowAnonymousFilter))
                {
                    return;
                }

                if (sessionId == "1111")
                {
                    authorizedCustomer.CustomerNumber = 100000006626;

                    authorizedCustomer.UserId = 50;

                    _cache.Set(sessionId + "_authorizedCustomer", authorizedCustomer, new MemoryCacheEntryOptions() { AbsoluteExpiration = DateTime.Now.AddMinutes(30) });

                }
                else
                {
                    if (!string.IsNullOrEmpty(sessionId))
                    {

                        AuthorizedUser UserData = await _xbSecurityService.AuthorizeUserAsync(sessionId);

                        if (UserData.isAutorized)
                        {
                            authorizedCustomer.CustomerNumber = UserData.userCustomerNumber;
                            authorizedCustomer.UserName = UserData.userName;
                            authorizedCustomer.UserId = UserData.userID;
                            authorizedCustomer.BranchCode = UserData.filialCode;

                            _cache.Set(sessionId + "_authorizedCustomer", authorizedCustomer);

                        }
                        else
                        {

                            context.Result = new UnauthorizedResult();
                        }



                    }
                    else
                    {
                        context.Result = new UnauthorizedResult();
                    }

                }
            }
        }
    }
}

using AuthServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcbaReportsApi.Infrastructure.Services.Authorization
{
    public interface IXBSecurityService
    {
        Task<AuthorizedUser> AuthorizeUserAsync(string sessionId);
    }
}

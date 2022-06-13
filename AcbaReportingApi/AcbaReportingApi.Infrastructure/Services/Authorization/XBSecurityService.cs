using AcbaReportsApi.Application.Models;
using AcbaReportsApi.Application.Settings;
using AuthServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AcbaReportsApi.Infrastructure.Services.Authorization
{
    public class XBSecurityService : IXBSecurityService
    {
        private static async Task UseAsync(Func<AuthServiceReference.IInfSecChannel, Task> action)
        {
            BasicHttpsBinding binding = new()
            {
                MaxBufferPoolSize = 5242880,
                MaxBufferSize = 6553600,
                MaxReceivedMessageSize = 6553600
            };
            binding.ReaderQuotas.MaxArrayLength = 2500000;
            string endpointUrl = ExternalServicesConnections.AuthService;
            EndpointAddress endpoint = new(endpointUrl);
            IInfSecChannel client = ProxyManager<IInfSecChannel>.GetProxy(nameof(IInfSecChannel), binding, endpoint);

            bool success = false;
            try
            {
                await action(client);
                client.Close();
                success = true;
            }
            catch (TimeoutException)
            {
                client.Close();
            }
            catch (Exception)
            {
                client.Abort();
            }
            finally
            {
                if (!success)
                {
                    client.Abort();
                }
                client.Close();
                client.Dispose();
            }
        }

        public async Task<AuthorizedUser> AuthorizeUserAsync(string sessionId)
        {
            AuthorizedUser authorizedUser = new();
            await UseAsync(async client =>
            {
                authorizedUser = await client.AuthorizeUserBySessionAsync(sessionId);
            }
            );
            return authorizedUser;
        }
    }
}

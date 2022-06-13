using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace AcbaReportsApi.Application.Models
{
    public static class ProxyManager<IType>
    {
        public static ConcurrentDictionary<string, ChannelFactory<IType>> proxies = new();

        public static IType GetProxy(string key, Binding binding, EndpointAddress endpoint)
        {
            return proxies.GetOrAdd(key, m => new ChannelFactory<IType>(binding, endpoint)).CreateChannel();
        }

        public static bool RemoveProxy(string key)
        {
            return proxies.TryRemove(key, out _);
        }
    }
}

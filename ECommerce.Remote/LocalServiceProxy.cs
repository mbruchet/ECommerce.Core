using System;
using ECommerce.Core;

namespace ECommerce.Remote
{
    public class LocalServiceProxy
    {
        private RemoteServiceSettings _remoteServiceSettings;

        public LocalServiceProxy(RemoteServiceSettings remoteServiceSettings) 
            => _remoteServiceSettings = remoteServiceSettings;

        public ServiceProxy GetInstance(RemoteServiceSettings settings, Func<ServiceProxy> delFunc)
        {
            return delFunc.Invoke();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;

namespace Klz.API
{
 public    class ErrorHookAttribute : System.Attribute, System.ServiceModel.Description.IServiceBehavior
    {
        public Type ErrorHandlerMeta { set; get; }

        

        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        {
            
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            if (ErrorHandlerMeta == null)
                return;
            var handler= System.Activator.CreateInstance(ErrorHandlerMeta) as IErrorHandler;
            if (handler == null)
                return;
            foreach (ChannelDispatcherBase dispatcherBase in serviceHostBase.ChannelDispatchers)
            {
                var channelDispatcher = dispatcherBase as ChannelDispatcher;
                if (channelDispatcher != null )
                    channelDispatcher.ErrorHandlers.Add(handler);
            }
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            
        }
    }
}

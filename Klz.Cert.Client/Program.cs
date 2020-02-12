using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Klz.Cert.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var factory = new System.ServiceModel.ChannelFactory<IHomeHandler>("wch"))
            {
                var client = factory.CreateChannel();

                var rt = client.DoWork();
            }
        }
    }

    [System.ServiceModel.ServiceContract]
    public interface IHomeHandler
    {
        [OperationContract]
        string DoWork();
    }
}

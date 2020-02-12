using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klz.SAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var host= new System.ServiceModel.ServiceHost(typeof(UserInfo));
            host.Open();
            Console.WriteLine("http://localhost:8028/UserInfo");
            Console.ReadLine();
            host.Close();
        }
    }
}

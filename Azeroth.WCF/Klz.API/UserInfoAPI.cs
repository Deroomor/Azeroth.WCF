using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klz.API
{
    [ErrorHook(ErrorHandlerMeta =typeof(ErrorHandler))]
    public class UserInfoAPI:CrossDomainEnable,IUserInfoAPI
    {

        public static void Main(string[] args)
        {
            //Console.WriteLine("正在启动api服务");
            // System.ServiceModel.Web.WebServiceHost host = new System.ServiceModel.Web.WebServiceHost(typeof(UserInfoAPI));
            //host.Open();
            //Console.WriteLine("api服务正在运行");
            //Console.WriteLine("----------------");
            //Console.ReadKey();
            //host.Close();

            Console.WriteLine("正在启动api服务");
            var lsthost = System.Reflection.Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsSubclassOf(typeof(CrossDomainEnable))).Select(x => new System.ServiceModel.Web.WebServiceHost(x)).ToList();
            lsthost.ForEach(x=>x.Open());
            Console.WriteLine("api服务正在运行");
            Console.WriteLine("----------------");
            Console.ReadKey();
            lsthost.ForEach(x=>x.Close());
        }

        public UserInfo Add(UserInfo model)
        {
            model.Id = Guid.NewGuid();
            return model;
        }


        public List<UserInfo> GetList(UserInfo predicate)
        {
            predicate.Id = Guid.NewGuid();
            List<UserInfo> lst = new List<UserInfo>() { predicate, predicate, predicate };
            return lst;
        }
    }
}

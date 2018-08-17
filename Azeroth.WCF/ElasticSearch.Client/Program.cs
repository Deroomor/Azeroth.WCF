using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElasticSearch.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlbase = "http://111.230.87.237:9200/";
            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(urlbase);
                System.Net.Http.HttpRequestMessage request = new System.Net.Http.HttpRequestMessage(System.Net.Http.HttpMethod.Post, "_search/");
                //{
                //    "query": {
                //        "match_all": { }
                //    }
                //}
                string parameter = Newtonsoft.Json.JsonConvert.SerializeObject(new { query=new{ match_all=new{ } } });
                request.Content = new System.Net.Http.StringContent(parameter);
                request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var rt= client.SendAsync(request).Result.Content.ReadAsStringAsync().Result;
            }

            //新增指定document（类型名=索引名称）

            //修改document

            //删除docuemnt

            //查询document

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProjetoSalaoMVC
{
    public class HttpInstance
    {
        private static HttpClient httpCliensInstance;

        public HttpInstance()
        {

        }
        public static HttpClient GetHttpClientInstance()
        {
            if (httpCliensInstance == null)
            {
                httpCliensInstance = new HttpClient();
                httpCliensInstance.DefaultRequestHeaders.ConnectionClose = false;
            }
            return httpCliensInstance;
        }
    }
}

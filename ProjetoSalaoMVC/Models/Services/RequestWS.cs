using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ModernHttpClient;
using Newtonsoft.Json;

namespace ProjetoSalaoMVC.Models.Services
{
    public class RequestWS
    {
        public static string apiURI = "https://localhost:44303/";

        public static async Task<HttpResponseMessage> RequestGET(string sdsUrl)
        {
            try
            {
                var client = new HttpClient(new NativeMessageHandler(
                           throwOnCaptiveNetwork: false,
                           customSSLVerification: true))
                { BaseAddress = new Uri(apiURI, UriKind.Absolute) };

                var response = await client.GetAsync(sdsUrl); //Get

                response.EnsureSuccessStatusCode();

                return response;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}

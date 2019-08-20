using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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

        public static async Task<HttpResponseMessage> RequestPOST(string sdsUrl, string obj)
        {
            try
            {
                var client = new HttpClient(new NativeMessageHandler(
                           throwOnCaptiveNetwork: false,
                           customSSLVerification: true))
                { BaseAddress = new Uri(apiURI, UriKind.Absolute) };

                //string json = JsonConvert.SerializeObject(obj);
                var response = await client.PostAsync(sdsUrl, new StringContent(obj, Encoding.UTF8, "application/json"));

                response.EnsureSuccessStatusCode();

                return response;
            } catch (Exception e)
            {
                throw;
            }
        }

        public static async Task<HttpResponseMessage> RequestPUT(string sdsUrl, string json)
        {
            try
            {
                var client = new HttpClient(new NativeMessageHandler(
                           throwOnCaptiveNetwork: false,
                           customSSLVerification: true))
                { BaseAddress = new Uri(apiURI, UriKind.Absolute) };

                var response = await client.PutAsync(sdsUrl, new StringContent(json, Encoding.UTF8, "application/json"));

                response.EnsureSuccessStatusCode();

                return response;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static async Task<HttpResponseMessage> RequestDELETE(string sdsUrl)
        {
            try
            {
                var client = new HttpClient(new NativeMessageHandler(
                           throwOnCaptiveNetwork: false,
                           customSSLVerification: true))
                { BaseAddress = new Uri(apiURI, UriKind.Absolute) };

                var response = await client.DeleteAsync(sdsUrl);

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

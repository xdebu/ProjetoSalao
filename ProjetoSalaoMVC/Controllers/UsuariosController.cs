using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjetoSalaoAPI;
using ProjetoSalaoMVC.Models;

namespace ProjetoSalaoMVC.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            string ApiBaseUrl = "https://localhost:44303/"; // endereço da sua api
            string MetodoPath = "api/usuarios";

            var model = new Usuario();
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ApiBaseUrl + MetodoPath);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var retorno = JsonConvert.DeserializeObject<List<string>>(streamReader.ReadToEnd());

                    if (retorno != null)
                    {
                        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Usuario));
                        MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(retorno.ToString()));
                        Usuario obj = (Usuario)serializer.ReadObject(ms);
                        model = obj;
                    }
                }
                } catch (Exception e)
            {
                throw e;
            }

            return View(model);
        }

        public T ConverteJSonParaObject<T>(string jsonString)
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
                T obj = (T)serializer.ReadObject(ms);
                return obj;
            }
            catch
            {
                throw;
            }
        }
    }
}
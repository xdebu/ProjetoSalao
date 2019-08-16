using ProjetoSalaoAPI.Models.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSalaoMVC.Models
{
    public class Usuario
    {
        public int IdUsuar { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public TipoUsuario TipoUsuario { get; set; }

        public Usuario() { }

        public Usuario(int idUsuar, string login, string senha, TipoUsuario tipoUsuario)
        {
            IdUsuar = idUsuar;
            Login = login;
            Senha = senha;
            TipoUsuario = tipoUsuario;
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

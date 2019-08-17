using Newtonsoft.Json;
using ProjetoSalaoAPI.Models.Enums;
using ProjetoSalaoMVC.Models.Services;
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
        //public int userId { get; set; }
        //public int id { get; set; }
        //public string title { get; set; }
        //public bool completed { get; set; }
    }   
}

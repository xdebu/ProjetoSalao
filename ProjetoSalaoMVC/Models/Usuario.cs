using Newtonsoft.Json;
using ProjetoSalaoAPI.Models.Enums;
using ProjetoSalaoMVC.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSalaoMVC.Models
{
    public class Usuario
    {
        [Display(Name = "Código")]
        public int IdUsuar { get; set; }
        public string Login { get; set; }
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Display(Name = "Tipo do Usuário")]
        public TipoUsuario TipoUsuario { get; set; }
        //var lista = Enum.GetValues(typeof(TipoUsuario)).Cast<int>().ToList();
    }
}

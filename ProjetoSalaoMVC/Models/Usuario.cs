using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoSalaoMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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

    }
}

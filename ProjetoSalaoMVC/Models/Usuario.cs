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

        public List<SelectListItem> GetTipoUsuarios()
        {
            Usuario obj = new Usuario();
            // List<string> lista = Enum.GetNames(obj.TipoUsuario.GetType()).ToList();
            List<SelectListItem> lista = Enum.GetValues(typeof(TipoUsuario)).Cast<TipoUsuario>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }).ToList();

            return lista;
        }
    }
}

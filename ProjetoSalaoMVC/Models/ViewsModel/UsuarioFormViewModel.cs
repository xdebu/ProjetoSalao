using ProjetoSalaoMVC.Models.Enums;
using ProjetoSalaoMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProjetoSalaoMVC.Models.ViewsModel
{
    public class UsuarioFormViewModel
    {
        public Usuario Usuario { get; set; }
        //public TipoUsuario TipoUsuarios { get; set; }

        public SelectList TipoUsuarios = new SelectList(Enum.GetValues(typeof(TipoUsuario)).OfType<Enum>()
         .Select(x =>
             new SelectListItem
             {
                 Text = Enum.GetName(typeof(TipoUsuario), x),
                 Value = (Convert.ToInt32(x)).ToString()
             }), "Value", "Text");
    }
}

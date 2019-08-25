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
        public string IdTipoUsuario { get; set; }
        
    }
}

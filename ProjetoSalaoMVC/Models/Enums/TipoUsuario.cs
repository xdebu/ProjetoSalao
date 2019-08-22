using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ProjetoSalaoMVC.Models.Enums
{
    public enum TipoUsuario : int
    {
        [Description("Administrador")]
        Administrador = 0,
        [Description("Funcionario")]
        Funcionario = 1,
        [Description("Cliente")]
        Cliente = 2,
        [Description("Visitante")]
        Visitante = 3
    }

}

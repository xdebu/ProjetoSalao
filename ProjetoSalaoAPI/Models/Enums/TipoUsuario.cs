using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSalaoAPI.Models.Enums
{
    public enum TipoUsuario : int
    {
        Administrador = 0,
        Funcionario = 1,
        Cliente = 2,
        Visitante = 3
    }
}

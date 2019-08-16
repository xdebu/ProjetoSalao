using ProjetoSalaoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSalaoAPI.Services
{
    public class UsuarioService
    {
        private readonly ProjetoSalaoAPIContext _context;
        
        public UsuarioService(ProjetoSalaoAPIContext context)
        {
            _context = context;
        }

        public List<Usuario> FindAll()
        {
            return _context.Usuario.ToList();
        }
    }
}

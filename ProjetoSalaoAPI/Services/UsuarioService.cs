using Microsoft.AspNetCore.Mvc;
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

        public Usuario FindById(int id)
        {
            return _context.Usuario.FirstOrDefault(obj => obj.IdUsuar == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Usuario.Find(id);
            _context.Usuario.Remove(obj);
            _context.SaveChanges();
        }

        public void Insert(Usuario obj)
        {
            _context.Usuario.Add(obj);
            _context.SaveChanges();
        }

        public void Update(Usuario obj)
        {
            if (_context.Usuario.Any(x => x.IdUsuar == obj.IdUsuar))
            {
                
            }
            _context.Update(obj);
            _context.SaveChanges();
        }
    }
}

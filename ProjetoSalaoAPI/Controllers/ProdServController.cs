using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoSalaoAPI.Models;

namespace ProjetoSalaoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdServController : ControllerBase
    {
        private readonly ProjetoSalaoAPIContext _context;

        public ProdServController(ProjetoSalaoAPIContext context)
        {
            _context = context;
            if (_context.ProdServ.Count() == 0)
            {
                _context.ProdServ.Add(new ProdServ { Descricao = "Item1" });
                _context.SaveChanges();
            }
        }
    }
}
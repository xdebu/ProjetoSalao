using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProjetoSalaoAPI.Models;
using ProjetoSalaoAPI.Services;

namespace ProjetoSalaoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;

        public UsuariosController(UsuarioService UsuarioService)
        {
            _usuarioService = UsuarioService;
        }

        [HttpGet]
        public IEnumerable<Usuario> GetUsuarios()
        {
            return _usuarioService.FindAll();
        }

        [HttpPost]
        public void PostUsuarios(Usuario usuario)
        {
            //Usuario obj = JsonConvert.DeserializeObject<Usuario>(usuario.ToString());
            _usuarioService.Insert(usuario);
        }
    }
}
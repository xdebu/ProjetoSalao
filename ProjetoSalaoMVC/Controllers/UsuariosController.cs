using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjetoSalaoMVC.Models;
using Newtonsoft.Json;
using ProjetoSalaoMVC.Models.Services;
using System.Threading.Tasks;
using System;
using ProjetoSalaoAPI.Models.Enums;
using System.Linq;

namespace ProjetoSalaoMVC.Controllers
{
    public class UsuariosController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var result = await RequestWS.RequestGET("api/usuarios");

            var json = await result.Content.ReadAsStringAsync();
            List<Usuario> listaUsuario = JsonConvert.DeserializeObject<List<Usuario>>(json);

            return View(listaUsuario);
        }
        public async Task<IActionResult> Create()
        {
            //var lista = Enum.GetValues(typeof(TipoUsuario)).Cast<int>().ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Usuario usuario)
        {
            Usuario obj = new Usuario();
            obj.Login = usuario.Login;
            obj.Senha = usuario.Senha;
            obj.TipoUsuario = usuario.TipoUsuario;

            string json = JsonConvert.SerializeObject(obj);
            var result = await RequestWS.RequestPOST("api/usuarios", json);
            
            return RedirectToAction(nameof(Index));
        }
    }
}
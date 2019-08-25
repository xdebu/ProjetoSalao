using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjetoSalaoMVC.Models;
using Newtonsoft.Json;
using ProjetoSalaoMVC.Models.Services;
using System.Threading.Tasks;
using System;
using ProjetoSalaoMVC.Models.Enums;

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
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Usuario usuario)
        {

            TipoUsuario tp = Enum.Parse<TipoUsuario>("Cliente");

            Usuario obj = new Usuario();
            obj.Login = usuario.Login;
            obj.Senha = usuario.Senha;
            obj.TipoUsuario = tp;

            string json = JsonConvert.SerializeObject(obj);
            var result = await RequestWS.RequestPOST("api/usuarios", json);
            
            return RedirectToAction(nameof(Index));
        }

        //Apresenta a View
        public async Task<IActionResult> Delete(int? id)
        {
            var result = await RequestWS.RequestGET("api/usuarios/" + id);
            var json = await result.Content.ReadAsStringAsync();
            Usuario obj = JsonConvert.DeserializeObject<Usuario>(json);
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await RequestWS.RequestDELETE("api/usuarios/" + id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            var result = await RequestWS.RequestGET("api/usuarios/" + id);
            var json = await result.Content.ReadAsStringAsync();
            Usuario obj = JsonConvert.DeserializeObject<Usuario>(json);
            return View(obj);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            var result = await RequestWS.RequestGET("api/usuarios/" + id);
            var json = await result.Content.ReadAsStringAsync();
            Usuario obj = JsonConvert.DeserializeObject<Usuario>(json);
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Usuario usuario)
        {
            Usuario obj = new Usuario();
            obj.IdUsuar = id;
            obj.Login = usuario.Login;
            obj.Senha = usuario.Senha;
            
            string json = JsonConvert.SerializeObject(obj);

            var result = await RequestWS.RequestPUT("api/usuarios/" + id , json);
            return RedirectToAction(nameof(Index));
        }
    }
}
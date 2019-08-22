using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjetoSalaoMVC.Models;
using Newtonsoft.Json;
using ProjetoSalaoMVC.Models.Services;
using System.Threading.Tasks;
using System;
using ProjetoSalaoMVC.Models.Enums;
using System.Linq;
using ProjetoSalaoMVC.Models.ViewsModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoSalaoMVC.Models.ViewsModel;

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
            Usuario obj = new Usuario();
            //List<string> lista = Enum.GetNames(obj.TipoUsuario.GetType()).ToList();
            var lista = obj.GetTipoUsuarios();

            //var viewModel = new UsuarioFormViewModel { TipoUsuarios = lista };


            var enumData = new SelectList(Enum.GetValues(typeof(TipoUsuario)).OfType<Enum>()
         .Select(x =>
             new SelectListItem
             {
                 Text = Enum.GetName(typeof(TipoUsuario), x),
                 Value = (Convert.ToInt32(x)).ToString()
             }), "Value", "Text");

            ViewBag.EnumList = enumData;
            var viewModel = new UsuarioFormViewModel();
            return View(viewModel);
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
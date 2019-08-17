using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjetoSalaoMVC.Models;
using Newtonsoft.Json;
using ProjetoSalaoMVC.Models.Services;
using System.Threading.Tasks;

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
    }
}
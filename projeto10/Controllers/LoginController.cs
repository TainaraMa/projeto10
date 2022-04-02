using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto10.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Entrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(string usuario, string senha)
        {
            if(
                (usuario == "admin" && senha == "123")
                ||
              (usuario == "aluno" && senha == "aluno")
              )
            {
                return RedirectToAction("Logado");
            }
            else
            {
                return RedirectToAction("NaoLogado");
            }
        }

        public IActionResult Logado()
        {
            return View();
        }

        public IActionResult NaoLogado()
        {
            return View();
        }
    }
}

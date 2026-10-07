using CutePet.Models;
using Microsoft.AspNetCore.Mvc;

namespace CutePet.Controllers
{
    public class ContaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            string emailCorreto = "admin@email.com";
            string senhaCorreta = "123456";

            if (email == emailCorreto && senha == senhaCorreta)
            {
                Funcionario funcionario = new Funcionario("Administrador", email, "Gerente");

                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "E-mail ou senha incorretos");
            return View();
        }
    }
}

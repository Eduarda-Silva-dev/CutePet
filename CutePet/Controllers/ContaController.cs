using Microsoft.AspNetCore.Mvc;

namespace CutePet.Controllers
{
    public class ContaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

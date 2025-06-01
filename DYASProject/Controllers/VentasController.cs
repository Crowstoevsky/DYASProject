using Microsoft.AspNetCore.Mvc;

namespace DYASProject.Controllers
{
    public class VentasController : Controller
    {
        public IActionResult Ventas()
        {
            return View();
        }
    }
}

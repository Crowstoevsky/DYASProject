using DYASProject.Data;
using DYASProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DYASProject.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly AppDBContext _appDBcontext;

        public EmpleadoController(AppDBContext context)
        {
            _appDBcontext = context;
        }
        public IActionResult Ventas()
        {
            var vm = new VentaIndexVM
            {
                Ventas = _appDBcontext.Ventas.ToList(),
                Clientes = _appDBcontext.Clientes.ToList(),
                Empleados = _appDBcontext.Empleados.ToList(),
                MetodosPago = _appDBcontext.MetodosPago.ToList(),
                DetallesVentas = _appDBcontext.DetallesVentas.ToList(),
                ProductosMotos = _appDBcontext.ProductoMotos.ToList()
            };

            return View(vm);
        }
    }
}

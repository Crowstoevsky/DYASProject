using DYASProject.Data;
using Microsoft.AspNetCore.Mvc;
using DYASProject.ViewModels;
using DYASProject.Models;
using Microsoft.EntityFrameworkCore;


namespace DYASProject.Controllers
{
    public class AccesoController : Controller
    {
        private readonly AppDBContext _appDBContext;
        public AccesoController(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ViewData["Mensaje"] = "Todos los campos son requeridos.";
                return View();
            }

            // Busca al empleado con su rol
            var usuario = await _appDBContext.Empleados
                .Include(e => e.Rol)
                .FirstOrDefaultAsync(e => e.Email == email && e.Password == password);

            if (usuario == null)
            {
                ViewData["Mensaje"] = "Credenciales inválidas.";
                return View();
            }

            // Guardamos en sesión
            HttpContext.Session.SetInt32("IdUsuario", usuario.IdEmpleado);
            HttpContext.Session.SetString("Nombre", usuario.Nombre);
            HttpContext.Session.SetString("Rol", usuario.Rol.NombreRol);

            // Redirección por rol
            if (usuario.Rol.NombreRol == "Administrador")
                return RedirectToAction("Dashboard", "Admin");

            if (usuario.Rol.NombreRol == "Vendedor")
                return RedirectToAction("Index", "Ventas");

            // Por defecto
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        public IActionResult NoAutorizado()
        {
            return View(); // Crea una vista simple con mensaje "No autorizado"
        }

    }
}

using DYASProject.Data;
using DYASProject.Models;
using DYASProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DYASProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDBContext _appDBContext;
        public AdminController(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        [HttpGet]
        public IActionResult Dashboard()
        {
            var rol = HttpContext.Session.GetString("Rol");
            if (rol != "Administrador")
            {
                return RedirectToAction("Login", "Acceso");
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RegistrarEmpleado(EmpleadoVM model)
        {
            if (model.Password != model.PasswordConfirmed)
            {
                ViewData["Mensaje"] = "Las contraseñas no coenciden";
                return View();
            }
            
            Empleado user = new Empleado ()
            {
                Nombre = model.Nombre,
                Email = model.Email,
                Password = model.Password,
                Rol = new Rol() { IdRol = 2},
            };
            await _appDBContext.Empleados.AddAsync(user);
            await _appDBContext.SaveChangesAsync();
            if (user.Id != 0) return RedirectToAction("Login", "Acceso");
            ViewData["Mensaje"] = "No se pudo crear el usuario";
            return View();
        }
    }
}

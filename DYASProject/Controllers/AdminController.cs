using DYASProject.Data;
using DYASProject.Models;
using DYASProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DYASProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDBContext _appDBcontext;

        public AdminController(AppDBContext context)
        {
            _appDBcontext = context;
        }

        [HttpGet]
        public IActionResult Dashboard()
        {
            var rol = HttpContext.Session.GetString("Rol");
            if (rol != "Administrador")
                return RedirectToAction("Login", "Acceso");

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Empleados()
        {

            var viewModel = new EmpleadoIndexVM
            {
                EmpleadosList = await _appDBcontext.Empleados.Include(e => e.Rol).ToListAsync(),
                RolesList = await _appDBcontext.Roles.ToListAsync(),
                Empleado = new Empleado() // vacío para formulario
            };

            

            return View(viewModel);
        }




        [HttpPost]
        public async Task<IActionResult> AgregarEmpleado(EmpleadoIndexVM model)
        {
            Empleado nuevoEmpleado = new Empleado
            {
                Nombre = model.Empleado.Nombre,
                Email = model.Empleado.Email,
                Telefono = model.Empleado.Telefono,
                Password = model.Empleado.Password,
                RolId = model.IdRol // Asignación directa por Id
            };

            Console.WriteLine($"Nuevo Empleado: {nuevoEmpleado.Nombre}, RolId: {nuevoEmpleado.RolId}");
            await _appDBcontext.Empleados.AddAsync(nuevoEmpleado);
            await _appDBcontext.SaveChangesAsync();

            return RedirectToAction(nameof(Empleados));
        }



        [HttpPost]
        public async Task<IActionResult> EditEmpleado(EmpleadoIndexVM model)
        {


            var empleadoExistente = await _appDBcontext.Empleados.FindAsync(model.Empleado.IdEmpleado);
            if (empleadoExistente == null)
                return RedirectToAction(nameof(Empleados));

            empleadoExistente.Nombre = model.Empleado.Nombre;
            empleadoExistente.Email = model.Empleado.Email;
            empleadoExistente.Telefono = model.Empleado.Telefono;
            empleadoExistente.Password = model.Empleado.Password;
            empleadoExistente.RolId = model.IdRol;

            await _appDBcontext.SaveChangesAsync();

            return RedirectToAction(nameof(Empleados));
        }


        [HttpPost]
        public async Task<IActionResult> DeleteEmpleado(int idEmpleado)
        {
            var empleado = await _appDBcontext.Empleados.FindAsync(idEmpleado);
            if (empleado != null)
            {
                _appDBcontext.Empleados.Remove(empleado);
                await _appDBcontext.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Empleados));
        }






        [HttpPost]
        public async Task<IActionResult> RegistrarEmpleado(EmpleadoVM model)
        {
            if (model.Password != model.PasswordConfirmed)
            {
                ViewData["Mensaje"] = "Las contraseñas no coinciden";
                return View();
            }

            var nuevoEmpleado = new Empleado
            {
                Nombre = model.Nombre,
                Email = model.Email,
                Password = model.Password,
                Rol = new Rol { IdRol = 2 }, // Asignación directa por Id
            };

            await _appDBcontext.Empleados.AddAsync(nuevoEmpleado);
            await _appDBcontext.SaveChangesAsync();

            if (nuevoEmpleado.IdEmpleado != 0)
                return RedirectToAction("Login", "Acceso");

            ViewData["Mensaje"] = "No se pudo crear el usuario";
            return View();
        }



        [HttpGet]
        public IActionResult Productos()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Stock()
        {
            return View();
        }

        [HttpGet]
        public IActionResult HistorialVentas()
        {
            return View();
        }


    }
}

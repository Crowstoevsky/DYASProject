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
        public async Task<IActionResult> AddEmpleado(EmpleadoIndexVM model)
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
            Console.WriteLine(model.Empleado.IdEmpleado.ToString());
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

        [HttpGet]
        public async Task<IActionResult> Productos()
        {
            ProductoMotoIndexVM productoMIVM = new ProductoMotoIndexVM
            {
                Estados = await _appDBcontext.EstadosProductoMotos.ToListAsync(),
                Proveedores = await _appDBcontext.Proveedores.ToListAsync(),
                Motos = await _appDBcontext.ProductoMotos.ToListAsync(),
                Sucursales = await _appDBcontext.Sucursales.ToListAsync(),
                StockSucursales = await _appDBcontext.StockSucursales.Include(ss => ss.Sucursal).ToListAsync()
            };

            return View(productoMIVM);

        }
        [HttpPost]
        public async Task<IActionResult> AddMoto(ProductoMotoIndexVM model)
        {
            ProductoMoto nuevaMoto = new ProductoMoto
            {
                Marca = model.Moto.Marca,
                Modelo = model.Moto.Modelo,
                CC = model.Moto.CC,
                Anio = new DateOnly(2020, 1, 1), // Año 2020 como ejemplo TODO: ARREGLAR EL NULL    
                FechaCreacion = DateTime.Now,   // Fecha y hora actual TODO: ARREGLAR EL NULL
                Color = model.Moto.Color,
                Precio = model.Moto.Precio,
                EstadoPMId = model.IdEstadoPM,
                Proveedor = await _appDBcontext.Proveedores.FindAsync(model.IdProveedor)
            };

            await _appDBcontext.ProductoMotos.AddAsync(nuevaMoto);
            await _appDBcontext.SaveChangesAsync();

            return RedirectToAction(nameof(Productos));
        }

        [HttpPost]
        public async Task<IActionResult> EditMoto(ProductoMotoIndexVM model)
        {
            var motoExistente = await _appDBcontext.ProductoMotos.FindAsync(model.Moto.IdProducto);
            if (motoExistente == null)
                return RedirectToAction(nameof(Productos));

            motoExistente.Marca = model.Moto.Marca;
            motoExistente.Modelo = model.Moto.Modelo;
            motoExistente.CC = model.Moto.CC;
            
            motoExistente.Anio = model.Moto.Anio;
            motoExistente.Color = model.Moto.Color;
            motoExistente.Precio = model.Moto.Precio;
            motoExistente.EstadoPMId = model.IdEstadoPM;
            motoExistente.Proveedor = await _appDBcontext.Proveedores.FindAsync(model.IdProveedor);

            await _appDBcontext.SaveChangesAsync();

            return RedirectToAction(nameof(Productos));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMoto(int idProducto)
        {
            var moto = await _appDBcontext.ProductoMotos.FindAsync(idProducto);
            if (moto != null)
            {
                _appDBcontext.ProductoMotos.Remove(moto);
                await _appDBcontext.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Productos));
        }

        public async Task<IActionResult> HistorialVentas()
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

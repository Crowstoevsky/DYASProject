using DYASProject.Models;

namespace DYASProject.ViewModels
{
    public class EmpleadoIndexVM
    {
        public List<Empleado> EmpleadosList { get; set; }
        public List<Rol> RolesList { get; set; }
        // Para el formulario
        public Empleado Empleado { get; set; } = new();

        // Para el combo
        public int IdRol { get; set; }
    }
}

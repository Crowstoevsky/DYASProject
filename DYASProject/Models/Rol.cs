using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DYASProject.Models
{
    public class Rol
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRol {  get; set; }
        [Required,StringLength(50)]
        public string NombreRol { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
    }
}

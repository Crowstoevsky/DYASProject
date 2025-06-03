using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DYASProject.Models
{
    public class EstadoDevolucion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEstadoD { get; set; }
        [Required, StringLength(50)]
        public string NombreEstado { get; set; }
        public ICollection<OpcionDevolucion> OpcionesDevolucion { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DYASProject.Models
{
    public class EstadoProductoMoto
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEstadoPM { get; set; }
        [Required, StringLength(50)]
        public string NombreEstado { get; set; }
        public ICollection<ProductoMoto> ProductoMotos { get; set; }
    }
}

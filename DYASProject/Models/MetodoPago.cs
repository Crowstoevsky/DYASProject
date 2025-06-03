using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DYASProject.Models
{
    public class MetodoPago
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMetodo { get; set; }

        [Required]
        public string NombreMetodo { get; set; }

        public ICollection<Venta> Ventas { get; set; }
    }
}

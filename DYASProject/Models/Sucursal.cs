using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DYASProject.Models
{
    public class Sucursal
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSucursal { get; set; }
        [Required, StringLength(50)]
        public string Nombre { get; set; }
        [Required, StringLength(100)]
        public string Ubicacion { get; set; }
        public ICollection<StockSucursal> Stocks { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DYASProject.Models
{
    public class Estado
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEstado { get; set; }
        [Required,StringLength(50)]
        public string NombreEstado { get; set; }
        public ICollection<ProductoMoto> ProductoMotos { get; set; }

    }
}

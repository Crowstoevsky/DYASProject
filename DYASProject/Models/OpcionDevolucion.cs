using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DYASProject.Models
{
    public class OpcionDevolucion
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDevolucion { get; set; }
        public Venta Venta { get; set; }
        public int VentaId { get; set; }
        public DateTime FechaSolicitud { get; set; } = DateTime.Now;

        public string Motivo { get; set; }

        [Required,StringLength(10)]
        public string Estado { get; set; } // pendiente, aprobada, rechazada
    }
}

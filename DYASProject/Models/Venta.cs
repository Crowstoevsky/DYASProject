using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DYASProject.Models
{
    public class Venta
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdVenta { get; set; }
        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }

        [ForeignKey("EmpleadoId")]
        public Empleado Empleado { get; set; }

        [ForeignKey("MetodoPagoId")]
        public MetodoPago MetodoPago { get; set; }

        [Required]
        public decimal Total { get; set; }

        public ICollection<DetallesVenta> Detalles { get; set; }
        public OpcionDevolucion OpcionDevolucion { get; set; }

    }
}

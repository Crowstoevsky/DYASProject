using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace DYASProject.Models
{
    public class ProductoMoto
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProducto { get; set; }
        [Required, StringLength(50)]
        public string Marca { get; set; }
        [Required, StringLength(50)]
        public string Modelo { get; set; }
        [Required, StringLength(6)]
        public string CC { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime FechaCreacion { get; set; }

        public DateOnly Anio { get; set; }
        [Required]
        public string Color { get; set; }
        [Required, Column(TypeName = "decimal(6,2)")]
        public decimal Precio { get; set; }
        [ForeignKey("ProveedorId")]
        public Proveedor Proveedor { get; set; }
        [ForeignKey("EstadoId")]
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
        public ICollection<StockSucursal> StockSucursal { get; set; }
        public ICollection<DetallesVenta> DetallesVentas { get; set; }
    }
}
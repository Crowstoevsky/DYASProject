using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DYASProject.Models
{
    public class StockSucursal
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdStockSucursal { get; set; }
        public ProductoMoto ProductoMoto { get; set; }
        public int ProductoMotoId { get; set; }
        public Sucursal Sucursal { get; set; }
        public int SucursalId { get; set; }
        public int Cantidad { get; set; }
    }
}

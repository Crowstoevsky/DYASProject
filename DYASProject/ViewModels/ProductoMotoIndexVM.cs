using DYASProject.Models;

namespace DYASProject.ViewModels
{
    public class ProductoMotoIndexVM
    {
        public List<EstadoProductoMoto> Estados { get; set; }
        public List<ProductoMoto> Motos { get; set; }
        public List<Proveedor> Proveedores { get; set; }
        public List<Sucursal> Sucursales { get; set; }
        public List<StockSucursal> StockSucursales { get; set; }
        public ProductoMoto Moto { get; set; } = new ProductoMoto();
        public int IdEstadoPM { get; set; }
        public int IdProveedor { get; set; }    
        public int IdProducto { get; set; } 

    }
}

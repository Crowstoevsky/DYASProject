using DYASProject.Models;

namespace DYASProject.ViewModels
{
    public class VentaIndexVM
    {
        
        public List<Venta> Ventas { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Empleado> Empleados { get; set; }
        public List<MetodoPago> MetodosPago { get; set; }
        public List<DetallesVenta> DetallesVentas { get; set; }
        public List<ProductoMoto> ProductosMotos { get; set; }
        public Cliente Cliente { get; set; } = null;
        public int MetodoPagoId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
    }
}

namespace DYASProject.ViewModels
{
    public class ProductoMotoVM
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string CC { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateOnly Anio { get; set; }
        public string Color { get; set; }
        public decimal Precio { get; set; }
        public string ProveedorNombre { get; set; }
        public string Estado { get; set; }
        public List<StockSucursalVM> StockPorSucursal { get; set; }
    }
}

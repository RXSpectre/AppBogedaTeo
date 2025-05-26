namespace AppBogedaTeo.Entidades
{
    public class Productos
    {
        public int CodProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock{ get; set; }
        public int LimiteStock { get; set; }
        public int CodProductoCategoria { get; set; }
        public int CodProveedor { get; set; }
        public decimal PrecioCompra { get; set; }
    }
}

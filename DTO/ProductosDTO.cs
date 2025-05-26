using System.ComponentModel;

namespace AppBogedaTeo.DTO
{
    public  class ProductosDTO 
    {
        [Browsable(false)]
        public int CodProducto { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public int Stock { get; set; }

        [DisplayName("Mínimo de Stock")]
        public int LimiteStock { get; set; }

        [DisplayName("Precio Compra")]
        public decimal PrecioCompra { get; set; }

        [DisplayName("Precio Venta")]
        public decimal PrecioVenta { get; set; }

        [Browsable(false)]
        public int CodProductoCategoria { get; set; }

        [DisplayName("Categoria")]
        public string DscProductoCategoria { get; set; }

        [Browsable(false)]
        public int CodProveedor { get; set; }

        [DisplayName("Proveedor")]
        public string DscProveedor { get; set; }
       
    }
}

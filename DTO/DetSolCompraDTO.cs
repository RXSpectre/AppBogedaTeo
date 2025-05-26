using System.ComponentModel;

namespace AppBogedaTeo.DTO
{
    public class DetSolCompraDTO
    {
        [Browsable(false)]
        public int CodDetSolCompra { get; set; }
        [Browsable(false)]
        public int CodSolCompra { get; set; }
        [Browsable(false)]
        public int CodProducto { get; set; }
        [DisplayName("Producto")]
        public string DscProducto { get; set; }
        public int Cantidad { get; set; }
        [DisplayName("Precio Compra")]
        public decimal PrecioCompra { get; set; }
        [DisplayName("Valor Compra")]
        public decimal ValorCompra { get; set; }
    }
}

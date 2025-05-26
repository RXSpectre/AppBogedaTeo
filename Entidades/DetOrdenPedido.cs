using System.ComponentModel;

namespace AppBogedaTeo.Entidades
{
    public class DetOrdenPedido
    {
        public DetOrdenPedido()
        {
            this.Nro_Detalle = 0;
            this.CodProducto = 0;
            this.Descripcion = "";
            this.PrecioVenta = 0m;
            this.Cantidad = 0;
            this.ValorVenta = 0m;
            this.Nro_Orden = 0;
        }

        [Browsable(false)]
        public int Nro_Detalle { get; set; }

        [Browsable(false)]
        public int CodProducto { get; set; }

        [DisplayName("Producto")]
        public string Descripcion { get; set; }

        [DisplayName("Precio Venta")]
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }

        [DisplayName("Valor Venta")]
        public decimal ValorVenta { get; set; }

        [Browsable(false)]
        public int Nro_Orden { get; set; }
    }
}

using System.ComponentModel;


namespace AppBogedaTeo.DTO
{
    public class VentasDTO
    {
        public VentasDTO()
        {
            Cod_Venta = 0;
            Nro_Orden = 0;
            ImporteTotal = 0m;
            Tipo_Comp = 0;
            DscTipoComp = "";
        }

        [DisplayName("Código Venta")]
        public int Cod_Venta { get; set; }

        [Browsable(false)]
        public int Nro_Orden { get; set; }

        [Browsable(false)]
        public int Tipo_Comp { get; set; }

        [DisplayName("Tipo de Comprobante")]
        public string DscTipoComp { get; set; }

        [DisplayName("DNI")]
        public string Nro_Doc { get; set; }

        [DisplayName("Cliente")]
        public string NombresCompletos { get; set; }

        [Browsable(false)]
        public int CodMetodoPago { get; set; }

        [DisplayName("Método de Págo")]
        public string DscMetodoPago { get; set; }

        [Browsable(false)]
        public int Estado { get; set; }

        [DisplayName("Estado")]
        public string DscEstado { get; set; }


        [DisplayName("Fecha Creación")]
        public string FechaCreacion { get; set; }
        //[DisplayName("Fecha Limite de Pago")]
        //public string FechaLimitePago { get; set; }
        [DisplayName("Importe Total")]
        public decimal ImporteTotal { get; set; }
    }
}

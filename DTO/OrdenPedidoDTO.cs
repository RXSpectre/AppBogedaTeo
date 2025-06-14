
using System.ComponentModel;

namespace AppBogedaTeo.DTO
{
    public class OrdenPedidoDTO
    {
    
        [DisplayName("Nro. Orden")]
        public int Nro_Orden { get; set; }

        [DisplayName("DNI")]
        public string Nro_Doc { get; set; }

        [DisplayName("Cliente")]
        public string NombresCompletos { get; set; }


        //[DisplayName("Fecha Limite de Pago")]
        //public string FechaLimitePago { get; set; }

        [Browsable(false)]
        public int CodEstadoOrdenPedido { get; set; }

        [DisplayName("Estado")]
        public string DscEstado { get; set; }

        [DisplayName("Fecha Creación")]
        public string FechaCreacion { get; set; }

        [Browsable(false)]
        //[DisplayName("Fecha Modificación")]
        public string FechaModificacion { get; set; }

        public decimal ImporteTotal { get; set; }

        [Browsable(false)]
        public string EmpleadoCreador { get; set; }

        [Browsable(false)]
        public string EmpleadoModificador { get; set; }

       
    }
}

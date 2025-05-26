using System.ComponentModel;

namespace AppBogedaTeo.DTO
{
    public class ClienteOrdenPedidoDTO
    {
        [Browsable(false)]
        public int CodCliente { get; set; }

        [DisplayName("DNI")]
        public string Nro_Doc { get; set; }

        [Browsable(false)]
        public int CodTipoDocumento { get; set; }

        [Browsable(false)]
        //[DisplayName("Tipo Doc.")]
        public string DscTipoDoc { get; set; }

        [DisplayName("Cliente")]
        public string NombresCompletos { get; set; }

        [Browsable(false)]
        public int CodEstadoCliente { get; set; }

        [DisplayName("Estado")]
        public string DscEstCli { get; set; }

    
    }
}

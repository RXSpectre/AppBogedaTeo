using System.ComponentModel;

namespace AppBogedaTeo.DTO
{
    public class ClienteDTO
    {
        [Browsable(false)]
        public int CodCliente { get; set; }

        [DisplayName("DNI")]
        public string Nro_Doc { get; set; }

        [Browsable(false)]
        public int CodTipoDocumento { get; set; }

        //[DisplayName("Tipo Doc.")]
        [Browsable(false)]
        public string DscTipoDoc { get; set; }

        [Browsable(false)]
        //[DisplayName("Nombres y Apellidos")]
        public string NombresCompletos { get; set; }

        
        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        [Browsable(false)]
        public int CodEstadoCliente { get; set; }

        [DisplayName("Estado")]
        public string DscEstCli { get; set; }

        public string Correo { get; set; }

    }
}

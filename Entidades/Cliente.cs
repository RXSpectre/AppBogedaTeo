using System.ComponentModel;

namespace AppBogedaTeo.Entidades
{
    public class Cliente
    {
        public Cliente()
        {
            this.Nro_Doc = "";
            this.CodTipoDocumento = 0;
            this.DscTipoDoc = "";
            this.Nombres = "";
            this.Apellidos = "";
            this.NombresCompletos = "";
            this.CodEstadoCliente = 0;
            this.DscEstCli = "";
            this.Fmant = 1;
            this.FlagTieneHistPagos = false;
        }

        [Browsable(false)]
        public int CodCliente { get; set; }
        public string Nro_Doc { get; set; }

        [Browsable(false)]
        public int CodTipoDocumento { get; set; }

        [DisplayName("Tipo Doc.")]
        public string DscTipoDoc { get; set; }

        [DisplayName("Nombres y Apellidos")]
        public string NombresCompletos { get; set; }

        [Browsable(false)]
        public string Nombres { get; set; }

        [Browsable(false)]
        public string Apellidos { get; set; }

        public string Correo { get; set; }

        [Browsable(false)]
        public int CodEstadoCliente { get; set; }

        [DisplayName("Estado")]
        public string DscEstCli { get; set; }

        [Browsable(false)]
        public int Fmant { get; set; }

        [Browsable(false)]
        public bool FlagTieneHistPagos { get; set; }

    }
}

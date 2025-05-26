using System.ComponentModel;

namespace AppBogedaTeo.Entidades
{
    public class Proveedor
    {
        [Browsable(false)]
        public int CodProveedor { get; set; }

        [DisplayName("Ruc")]
        public string RucProveedor { get; set; }

        [DisplayName("Razón Social")]
        public string RazonSocial { get; set; }

        [DisplayName("Nro. telefono ")]
        public string NroTelContacto { get; set; }

        [DisplayName("Correo")]
        public string CorreoProveedor { get; set; }

        [Browsable(false)]
        public int CodEstadoProveedor { get; set; }

        [DisplayName("Estado")]
        public string DscEstadoProveedor { get; set; }
    }
}

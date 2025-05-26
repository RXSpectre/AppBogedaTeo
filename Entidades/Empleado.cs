using System.ComponentModel;


namespace AppBogedaTeo.Entidades
{
    public class Empleado
    {
        [Browsable(false)]
        public int CodEmpleado { get; set; }

        public string DNI { get; set; }

        [DisplayName("Nombre Completos")]
        public string NombreCompletos { get; set; }

        [Browsable(false)]
        public string Contra { get; set; }

        public string Correo { get; set; }

        [Browsable(false)]
        public int CodRol { get; set; }

        [DisplayName("Rol")]
        public string DscRol { get; set; }

        [Browsable(false)]
        public int FlagMant { get; set; }

        [Browsable(false)]
        public string UltFechaIngreso { get; set; }

    }
}

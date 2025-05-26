using System.ComponentModel;

namespace AppBogedaTeo.DTO
{
    public class ListarRolesDTO
    {
        [Browsable(false)]
        public string CodPrm { get; set; }

        [DisplayName("Código Rol")]
        public int Codigo { get; set; }

        [DisplayName("Descripción Rol")]
        public string Descripcion { get; set; }

    }
}

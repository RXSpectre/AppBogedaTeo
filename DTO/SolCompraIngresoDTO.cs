using System.ComponentModel;

namespace AppBogedaTeo.DTO
{
    public class SolCompraIngresoDTO
    {
        [DisplayName("Codigo")]
        public int CodSolCompra { get; set; }

        [DisplayName("RUC")]
        public string RucProveedor { get; set; }

        [Browsable(false)]
        public int CodProveedor { get; set; }

        [DisplayName("Proveedor")]
        public string DscProveedor { get; set; }

        [DisplayName("Estado")]
        public string DscEstadoSolCompra { get; set; }

        [DisplayName("Imp. Total Esperado")]
        public decimal ImporteTotalEsperado { get; set; }

        [DisplayName("Fecha Creación")]
        public string FechaCreacion { get; set; }
      
    }
}

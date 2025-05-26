
namespace AppBogedaTeo.DTO
{
    public class SolCompraMantDTO
    {
        public int CodSolCompra { get; set; }

        public int CodProveedor { get; set; }

        public int CodEstadoSolCompra { get; set; }
        public decimal ImporteTotalEsperado { get; set; }

        public string Observacion { get; set; }

        public decimal ImporteTotalPagado { get; set; }

        public int CodEmpleado { get; set; }
    }
}

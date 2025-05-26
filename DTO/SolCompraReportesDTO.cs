using System.Collections.Generic;

namespace AppBogedaTeo.DTO
{
    public class SolCompraReportesDTO
    {
        public SolCompraReportesDTO()
        {
            this.data = new List<SolCompraRepDTO>();
            this.ImporteTotalPagado = 0m;
            this.estadosXCantidad = new List<EstadoSolCompraXCantidadDTO>();
        }

        public List<SolCompraRepDTO> data { get; set; }

        //Resumen
        public decimal ImporteTotalPagado { get; set; }
        public List<EstadoSolCompraXCantidadDTO> estadosXCantidad { get; set; }

    }
}

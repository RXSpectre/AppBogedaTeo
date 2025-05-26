
using System.Collections.Generic;

namespace AppBogedaTeo.DTO
{
    public class VentasReportesDTO
    {
        public VentasReportesDTO()
        {
            this.data = new List<VentasDTO>();
            this.resumen = new List<ResumenVentasDTO>();
        }


        public List<VentasDTO> data { get; set; }
        public List<ResumenVentasDTO> resumen  { get; set; }
    }
}

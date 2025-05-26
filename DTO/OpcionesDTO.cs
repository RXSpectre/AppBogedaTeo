using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBogedaTeo.DTO
{
    public class OpcionesDTO
    {
        public int CodOpcion { get; set; }
        public string DscOpcion { get; set; }
        public OpcionesDTO()
        {
            this.CodOpcion = 0;
            this.DscOpcion = string.Empty;
        }

        public override string ToString()
        {
            return $"{CodOpcion} - {DscOpcion}";
        }

    }
}

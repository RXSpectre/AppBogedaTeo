using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBogedaTeo.DTO
{
    public class RespuestaDTO
    {
        public int CodRes { get; set; }
        public string MsgRespuesta { get; set; }

        public RespuestaDTO()
        {
            CodRes = 0;
            MsgRespuesta = "";
        }
    }
}

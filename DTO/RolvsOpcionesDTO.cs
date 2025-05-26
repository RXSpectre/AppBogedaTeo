using System.Collections.Generic;

namespace AppBogedaTeo.DTO
{
    public class RolvsOpcionesDTO
    {
        public List<OpcionesDTO> opcHabilitadas { get; set; }
        public List<OpcionesDTO> opcDeshabilitadas { get; set; }

        public RolvsOpcionesDTO()
        {
            opcHabilitadas = new List<OpcionesDTO>();
            opcDeshabilitadas = new List<OpcionesDTO>();
        }
    }
}

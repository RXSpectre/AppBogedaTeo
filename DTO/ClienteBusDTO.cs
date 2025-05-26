
namespace AppBogedaTeo.DTO
{
    public class ClienteBusDTO
    {
        public ClienteBusDTO()
        {
            Nro_Doc = "";
            FMant = ' ';
            Nombres = "";
            Apellidos = "";
            CodEstadoCliente = 0;
        }


        public string Nro_Doc { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public int CodEstadoCliente { get; set; }
        public char FMant { get; set; }
        public bool FlagTieneHistPagos { get; set; }

    }
}

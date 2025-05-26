
namespace AppBogedaTeo.DTO
{
    public class ProductosBusDTO
    {
        public ProductosBusDTO()
        {
            Descripcion = string.Empty;
            CodProductoCategoria = 0;
            CodProveedor = 0;
            FMod = 0;
        }

        public string Descripcion { get; set; }
        public int CodProductoCategoria { get; set; }
        public int CodProveedor { get; set; }

        public int FMod { get; set; }
    }
}

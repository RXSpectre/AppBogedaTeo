namespace AppBogedaTeo.DTO
{
    public class EstadoSolCompraXCantidadDTO
    {
        public EstadoSolCompraXCantidadDTO()
        {
            this.DscEstadoSolCompra = string.Empty;
            this.Cantidad = 0;
        }
        public string DscEstadoSolCompra { get; set; }
        public int Cantidad { get; set; }

    }
}

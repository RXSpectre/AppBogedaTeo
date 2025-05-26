namespace AppBogedaTeo.Entidades
{
    public class SolCompra
    {
        public int CodSolCompra { get; set; }
        public int CodProveedor { get; set; }
        public int CodEstadoSolCompra { get; set; }
        public string Observacion { get; set; }
        public decimal ImporteTotalEsperado { get; set; }
        public decimal ImporteTotalPagado { get; set; }
        public int CodEmpleadoCrea { get; set; }
        public int CodEmpleadoModi { get; set; }
    }
}

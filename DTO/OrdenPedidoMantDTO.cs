namespace AppBogedaTeo.DTO
{
    public class OrdenPedidoMantDTO
    {
        public int Nro_Orden { get; set; }
        public int CodCliente { get; set; }
        public decimal ImporteTotal { get; set; }
        public int CodEstadoOrdenPedido { get; set; }
        public int CodEmpleadoCrea { get; set; }
        public int CodEmpleadoModi { get; set; }
        public int Fmant { get; set; }

    }
}

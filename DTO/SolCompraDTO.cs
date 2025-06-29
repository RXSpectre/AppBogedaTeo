﻿using System.ComponentModel;

namespace AppBogedaTeo.DTO
{
    public class SolCompraDTO
    {
        [DisplayName("Codigo")]
        public int CodSolCompra { get; set; }

        [Browsable(false)]
        public int CodProveedor { get; set; }

        [DisplayName("RUC")]
        public string RucProveedor { get; set; }

        [DisplayName("Proveedor")]
        public string DscProveedor { get; set; }

        [Browsable(false)]
        public int CodEstadoSolCompra { get; set; }

        [DisplayName("Estado")]
        public string DscEstadoSolCompra { get; set; }

        [Browsable(false)]
        public string Observacion { get; set; }

        [DisplayName("Imp. Total Esperado")]
        public decimal ImporteTotalEsperado { get; set; }

        [DisplayName("Imp. Total Pagado")]
        public decimal ImporteTotalPagado { get; set; }
        public string FechaCreacion { get; set; }
        public string FechaModificacion { get; set; }

        [Browsable(false)]
        public string EmpleadoCreador { get; set; }

        [Browsable(false)]
        public string EmpleadoModificador { get; set; }
    }
}

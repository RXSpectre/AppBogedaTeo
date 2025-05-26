using System;
using System.ComponentModel;

namespace AppBogedaTeo.Entidades
{
    //Falta segementar este codigo en un DTO porque esta feo
    public class OrdenPedido
    {
        public OrdenPedido()
        {
            this.Nro_Orden = 0;
            this.CodCliente = 0;
            this.Nro_Doc = "";
        
            this.ImporteTotal = 0m;
            this.NombresCompletos = "";
            //Creado
            this.CodEstadoOrdenPedido = 1;
            this.FechaLimitePago = "";
            this.CodEmpleadoCrea = 0;
            this.CodEmpleadoModi = 0;
            this.Fmod = 0;
            this.FechaInicio = "";
            this.FechaFinal = "";
        }

        [Browsable(false)]
        public int CodCliente { get; set; }

        [DisplayName("Nro. Orden")]
        public int Nro_Orden { get; set; }

        [DisplayName("Nro. Documento")]
        public string Nro_Doc { get; set; }

        [DisplayName("Cliente")]
        public string NombresCompletos { get; set; }


        [DisplayName("Fecha Limite de Pago")]
        public string FechaLimitePago { get; set; }

        [Browsable(false)]
        public int CodEstadoOrdenPedido { get; set; }

        [DisplayName("Estado")]
        public string DscEstado { get; set; }
        public decimal ImporteTotal { get; set; }

        [Browsable(false)]
        public int CodEmpleadoCrea { get; set; }

        [Browsable(false)]
        public int CodEmpleadoModi { get; set; }

        [Browsable(false)]
        public int Fmant { get; set; }
        [Browsable(false)]
        public int Fmod { get; set; }


        [Browsable(false)]
        public string FechaInicio { get; set; }

        [Browsable(false)]
        public string FechaFinal { get; set; }

        [Browsable(false)]
        public string EmpleadoCreador { get; set; }

        [Browsable(false)]
        public string EmpleadoModificador { get; set; }


    }
}

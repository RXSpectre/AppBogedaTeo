using AppBogedaTeo.DTO;
using AppBogedaTeo.Entidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace AppBogedaTeo.Repositorio
{
    public class MantPagoCreditoRepositorio : BaseRepositorio
    {
        public MantPagoCreditoRepositorio(string cadenaConexion)
        {
            this.connection = cadenaConexion;
        }

        public List<OrdenPedido> BuscarHistorialPagos(int codCliente)
        {
            List<OrdenPedido> resultado = new List<OrdenPedido>();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@CodCliente", codCliente);

                    resultado = con.Query<OrdenPedido>("Usp_BuscarHistorialPagos", prm, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return resultado;
        }

        public RespuestaDTO MantPagosAlCredito(string Nro_Doc,int NroOrden,string FechaLimitePago,int Fmant=0)
        {
            RespuestaDTO resultado = new RespuestaDTO();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@Nro_Doc", Nro_Doc);
                    prm.Add("@Nro_Orden", NroOrden);
                    prm.Add("@FechaLimitePago", FechaLimitePago);
                    prm.Add("@Fmant", Fmant);

                    resultado = con.Query<RespuestaDTO>("Usp_MantPagosAlCredito", prm, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return resultado;
        }
    }
}

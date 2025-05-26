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
    public class OrdenPedidoRepositorio : BaseRepositorio
    {
        public OrdenPedidoRepositorio(string cadenaConexion)
        {
            this.connection = cadenaConexion;
        }

        public List<OrdenPedidoDTO> ObtenerOrdenPedido(OrdenPedidoBusDTO req)
        {
            var resultado = new List<OrdenPedidoDTO>();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@Nro_Orden", req.Nro_Orden);
                    prm.Add("@Nro_Doc", req.Nro_Doc);
                    prm.Add("@CodEstadoOrdenPedido", req.CodEstadoOrdenPedido);
                    prm.Add("@NombresCompletos", req.NombresCompletos);
                    prm.Add("@FechaInicio", req.FechaInicio);
                    prm.Add("@FechaFinal", req.FechaFinal);
                    prm.Add("@FMod", req.Fmod);

                    resultado = con.Query<OrdenPedidoDTO>("Usp_ObtenerOrdenPedido", prm, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch
            {
                throw;

            }
            return resultado;
        }


        public List<DetOrdenPedido> ObtenerDetOrdenPedido(int nroOrden)
        {
            var resultado = new List<DetOrdenPedido>();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@Nro_Orden", nroOrden);
                  
                    resultado = con.Query<DetOrdenPedido>("Usp_ObtenerDetOrdenPedido", prm, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch
            {
                throw ;

            }
            return resultado;
        }


        public RespuestaDTO MantOrdenPedido(OrdenPedidoMantDTO req)
        {
            RespuestaDTO resultado = new RespuestaDTO();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@Nro_Orden", req.Nro_Orden);
                    prm.Add("@CodCliente", req.CodCliente);
                    //prm.Add("@Nro_Doc", req.Nro_Doc);
                    prm.Add("@ImporteTotal", req.ImporteTotal);
                    prm.Add("@CodEstadoOrdenPedido", req.CodEstadoOrdenPedido);
                    prm.Add("@CodEmpleadoCrea", req.CodEmpleadoCrea);
                    prm.Add("@CodEmpleadoModi", req.CodEmpleadoModi);
                    prm.Add("@Fmant", req.Fmant);

                    resultado = con.Query<RespuestaDTO>("Usp_MantOrdenPedido", prm, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch
            {
                throw;

            }
            return resultado;
        }


        public RespuestaDTO InsDetaOrdenPedido(DetOrdenPedido req)
        {
            RespuestaDTO resultado = new RespuestaDTO();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@CodProducto", req.CodProducto);
                    prm.Add("@PrecioVenta", req.PrecioVenta);
                    prm.Add("@Cantidad", req.Cantidad);
                    prm.Add("@ValorVenta", req.ValorVenta);
                    prm.Add("@Nro_Orden", req.Nro_Orden);

                    resultado = con.Query<RespuestaDTO>("Usp_InsDetaOrdenPedido", prm, commandType: CommandType.StoredProcedure).FirstOrDefault();
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

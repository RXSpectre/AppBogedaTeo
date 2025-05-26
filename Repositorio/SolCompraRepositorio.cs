
using AppBogedaTeo.DTO;
using AppBogedaTeo.Entidades;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace AppBogedaTeo.Repositorio
{
    public class SolCompraRepositorio<T> : BaseRepositorio
    {
        public SolCompraRepositorio(string cadenaConexion)
        {
            this.connection = cadenaConexion;
        }


        public RespuestaDTO MantSolCompra(SolCompra req)
        {
            var resultado = new RespuestaDTO();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@CodSolCompra", req.CodSolCompra);
                    prm.Add("@CodProveedor", req.CodProveedor);
                    prm.Add("@CodEstadoSolCompra", req.CodEstadoSolCompra);
                    prm.Add("@ImporteTotalEsperado", req.ImporteTotalEsperado);
                    prm.Add("@Observacion", req.Observacion);
                    prm.Add("@ImporteTotalPagado", req.ImporteTotalPagado);
                    prm.Add("@CodEmpleadoCrea", req.CodEmpleadoCrea);
                    prm.Add("@CodEmpleadoModi", req.CodEmpleadoModi);

                    resultado = con.Query<RespuestaDTO>("Usp_MantSolCompra", prm, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch
            {
                throw;

            }
            return resultado;
        }


        public RespuestaDTO InsertDetSolCompra(DetSolCompraDTO req)
        {
            var resultado = new RespuestaDTO();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@CodSolCompra", req.CodSolCompra);
                    prm.Add("@CodProducto", req.CodProducto);
                    prm.Add("@Cantidad", req.Cantidad);
                    prm.Add("@PrecioCompra", req.PrecioCompra);
                    prm.Add("@ValorCompra", req.ValorCompra);

                    resultado = con.Query<RespuestaDTO>("Usp_InsDetaSolCompra", prm, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch
            {
                throw;

            }
            return resultado;
        }


        public RespuestaDTO ActualizarDetSolCompra(DetSolCompraDTO req)
        {
            var resultado = new RespuestaDTO();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@CodDetSolCompra", req.CodDetSolCompra);
                    prm.Add("@CodProducto", req.CodProducto);
                    prm.Add("@Cantidad", req.Cantidad);
                    prm.Add("@ValorCompra", req.ValorCompra);

                    resultado = con.Query<RespuestaDTO>("Usp_ActualizarDetSolCompra", prm, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch
            {
                throw;

            }
            return resultado;
        }


        public List<T> BuscarSolCompra(SolCompraBuscaDTO req,out decimal sumatoriaImportesPagados)
        {
            var resultado = new List<T>();
            sumatoriaImportesPagados = 0m;
            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@CodSolCompra", req.CodSolCompra);
                    prm.Add("@CodProveedor", req.CodProveedor);
                    prm.Add("@CodEstadoSolCompra", req.CodEstadoSolCompra);
                    prm.Add("@FechaInicio", req.fechaInicio);
                    prm.Add("@FechaFinal", req.fechaFin);

                    //resultado = con.Query<SolCompraDTO>("Usp_ObtenerSolCompra", prm, commandType: CommandType.StoredProcedure).ToList();

                    using (var multi = con.QueryMultiple("Usp_ObtenerSolCompra", prm, commandType: CommandType.StoredProcedure))
                    {
                        resultado = multi.Read<T>().ToList();
                        sumatoriaImportesPagados = multi.Read<decimal>().FirstOrDefault();
                    }
                }
            }
            catch 
            {
                throw;

            }
            return resultado;
        }


        public SolCompraReportesDTO ReporteSolCompra(SolCompraBuscaDTO req)
        {
            var resultado = new SolCompraReportesDTO();
          
            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@CodSolCompra", req.CodSolCompra);
                    prm.Add("@CodProveedor", req.CodProveedor);
                    prm.Add("@CodEstadoSolCompra", req.CodEstadoSolCompra);
                    prm.Add("@FechaInicio", req.fechaInicio);
                    prm.Add("@FechaFinal", req.fechaFin);

                    using (var multi = con.QueryMultiple("Usp_ReporteSolCompra", prm, commandType: CommandType.StoredProcedure))
                    {
                        resultado.data = multi.Read<SolCompraRepDTO>().ToList();
                        resultado.ImporteTotalPagado = multi.Read<decimal>().FirstOrDefault();
                        resultado.estadosXCantidad = multi.Read<EstadoSolCompraXCantidadDTO>().ToList();
                    }
                }
            }
            catch
            {
                throw;

            }
            return resultado;
        }



        public List<DetSolCompraDTO> BuscarDetalleSolCompra(int CodSolCompra)
        {
            var resultado = new List<DetSolCompraDTO>();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@CodSolCompra", CodSolCompra);
                  
                    resultado = con.Query<DetSolCompraDTO>("Usp_ObtenerDetSolCompra", prm, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch
            {
                throw;

            }
            return resultado;
        }







    }
}

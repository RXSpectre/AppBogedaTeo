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
    public class VentasRepositorio : BaseRepositorio
    {
        public VentasRepositorio(string cadenaConexion)
        {
            this.connection = cadenaConexion;
        }

        public RespuestaDTO GenVentas(VentasMantDTO req)
        {
            RespuestaDTO resultado = new RespuestaDTO();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@Nro_Orden", req.Nro_Orden);
                    prm.Add("@ImporteTotal", req.ImporteTotal);
                    prm.Add("@Tipo_Comp", req.Tipo_Comp);
                    prm.Add("@CodEmpleado", req.CodEmpleado);
                    resultado = con.Query<RespuestaDTO>("Usp_GenVentas", prm, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch 
            {
                throw ;

            }
            return resultado;
        }

        public List<VentasDTO> ObtenerVentas(VentasBusDTO req,out decimal sumatoriaImportes)
        {
            List<VentasDTO> resultado = new List<VentasDTO>();
            sumatoriaImportes = 0m;
            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();

                    prm.Add("@Nro_Doc", req.Nro_Doc);
                    prm.Add("@NombresCompletos", req.NombresCompletos);
                    prm.Add("@FechaInicio", req.FechaInicio);
                    prm.Add("@FechaFinal", req.FechaFinal);
                    prm.Add("@CodMetodoPago", req.CodMetodoPago);

                    using (var multi = con.QueryMultiple("Usp_ObtenerVentas",prm,commandType:CommandType.StoredProcedure))
                    {
                        resultado = multi.Read<VentasDTO>().ToList();
                        sumatoriaImportes = multi.Read<decimal>().FirstOrDefault();
                    }

                    //resultado = con.Query<VentasDTO>("Usp_ObtenerVentas", prm, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch 
            {
                throw ;

            }
            return resultado;
        }

        public VentasReportesDTO ReporteVentas(VentasBusDTO req)
        {
            VentasReportesDTO resultado = new VentasReportesDTO();
          
            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();

                    prm.Add("@Nro_Doc", req.Nro_Doc);
                    prm.Add("@NombresCompletos", req.NombresCompletos);
                    prm.Add("@FechaInicio", req.FechaInicio);
                    prm.Add("@FechaFinal", req.FechaFinal);
                    prm.Add("@CodMetodoPago", req.CodMetodoPago);

                    using (var multi = con.QueryMultiple("Usp_ReporteVentas", prm, commandType: CommandType.StoredProcedure))
                    {
                        resultado.data = multi.Read<VentasDTO>().ToList();
                        resultado.resumen = multi.Read<ResumenVentasDTO>().ToList();
                    }
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

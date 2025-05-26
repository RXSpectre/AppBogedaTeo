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
    public class ParametroRepositorio : BaseRepositorio
    {
        public ParametroRepositorio(string cadenaConexion)
        {
            this.connection = cadenaConexion;
        }

        public List<Parametro> ObtenerParametro(Parametro req)
        {
            List<Parametro> resultado = new List<Parametro>();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@CodPrm", req.CodPrm);
                    prm.Add("@Descripcion", req.Descripcion);
                    prm.Add("@Fmod", req.Fmod);

                    resultado = con.Query<Parametro>("Usp_ObtenerParametro", prm, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return resultado;
        }

        //public RespuestaDTO MantParam(Parametro req)
        //{
        //    RespuestaDTO resultado = new RespuestaDTO();

        //    try
        //    {
        //        using (IDbConnection con = new SqlConnection(connection))
        //        {
        //            DynamicParameters prm = new DynamicParameters();
        //            prm.Add("@CodPrm", req.CodPrm);
        //            prm.Add("@CodIden", req.CodIden);
                  
        //            resultado = con.Query<RespuestaDTO>("Usp_MantParam", prm, commandType: CommandType.StoredProcedure).FirstOrDefault();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;

        //    }
        //    return resultado;
        //}

    }
}

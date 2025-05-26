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
    public class EmpleadoRepositorio : BaseRepositorio
    {
        public EmpleadoRepositorio(string connection)
        {
            this.connection = connection;
        }

        public List<Empleado> ObtenerEmpleado(string DNI,string NomCompletos, byte FMod)
        {
            List<Empleado> empleados = new List<Empleado>();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@DNI", DNI);
                    prm.Add("@NomCompletos", NomCompletos);
                    prm.Add("@FMod", FMod);
                    empleados = con.Query<Empleado>("Usp_ObtenerEmple", prm, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return empleados;
        }

        public RespuestaDTO MantEmpleado(Empleado req)
        {
            RespuestaDTO usuario = new RespuestaDTO();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@CodEmpleado", req.CodEmpleado);
                    prm.Add("@DNI", req.DNI);
                    prm.Add("@NombreCompletos", req.NombreCompletos);
                    prm.Add("@Contra", req.Contra);
                    prm.Add("@Correo", req.Correo);
                    prm.Add("@CodRol", req.CodRol);
                    prm.Add("@FlagMant", req.FlagMant);

                    usuario = con.Query<RespuestaDTO>("Usp_MantEmple", prm, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return usuario;
        }

    }
}

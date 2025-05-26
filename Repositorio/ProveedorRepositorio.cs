using AppBogedaTeo.DTO;
using AppBogedaTeo.Entidades;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace AppBogedaTeo.Repositorio
{
    public class ProveedorRepositorio : BaseRepositorio
    {
        public ProveedorRepositorio(string cadenaConexion)
        {
            this.connection = cadenaConexion;
        }


        public RespuestaDTO MantProveedor(Proveedor req)
        {
            RespuestaDTO resultado = new RespuestaDTO();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@CodProveedor", req.CodProveedor);
                    prm.Add("@RucProveedor", req.RucProveedor);
                    prm.Add("@RazonSocial", req.RazonSocial);
                    prm.Add("@NroTelContacto", req.NroTelContacto);
                    prm.Add("@CorreoProveedor", req.CorreoProveedor);
                    prm.Add("@CodEstadoProveedor", req.CodEstadoProveedor);

                    resultado = con.Query<RespuestaDTO>("Usp_MantProveedor", prm, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch 
            {
                throw;

            }
            return resultado;
        }

        public List<Proveedor> BuscarProveedor(string rucProveedor, string RazonSocial,int codEstadoProveedor)
        {
            List<Proveedor> resultado = new List<Proveedor>();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@Ruc", rucProveedor);
                    prm.Add("@RazonSocial", RazonSocial);
                    prm.Add("@CodEstadoProveedor", codEstadoProveedor);

                    resultado = con.Query<Proveedor>("Usp_BuscarProveedor", prm, commandType: CommandType.StoredProcedure).ToList();
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

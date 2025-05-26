using AppBogedaTeo.DTO;
using AppBogedaTeo.Entidades;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace AppBogedaTeo.Repositorio
{
    public class ClienteRepositorio<T> : BaseRepositorio
    {
        public ClienteRepositorio(string connection)
        {
            this.connection = connection;
        }

        public List<T> BuscarCliente(ClienteBusDTO req)
        {
            var resultado = new List<T>();
            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                  
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@Nro_Doc", req.Nro_Doc);
                    prm.Add("@Nombres", req.Nombres);
                    prm.Add("@Apellidos", req.Apellidos);
                    prm.Add("CodEstadoCliente", req.CodEstadoCliente);
                    prm.Add("@FlagTieneHistPagos", req.FlagTieneHistPagos);
                    prm.Add("@FMant", req.FMant);
                    resultado = con.Query<T>("Usp_BuscarCliente", prm, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch
            {
                throw ;

            }
            return resultado;
        }

        public RespuestaDTO MantCliente(Cliente req)
        {
            RespuestaDTO resultado = new RespuestaDTO();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@CodCliente", req.CodCliente);
                    prm.Add("@Nro_Doc", req.Nro_Doc);
                    prm.Add("@CodTipoDocumento", req.CodTipoDocumento);
                    prm.Add("@Nombres", req.Nombres);
                    prm.Add("@Apellidos", req.Apellidos);
                    prm.Add("@CodEstadoCliente", req.CodEstadoCliente);
                    prm.Add("@Correo", req.Correo);
                    prm.Add("@Fmant", req.Fmant);

                    resultado = con.Query<RespuestaDTO>("Usp_MantCliente", prm, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch 
            {
                throw ;

            }
            return resultado;
        }



    }
}

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
    public class RolXOpcionRepositorio:BaseRepositorio
    {
        public RolXOpcionRepositorio(string cadenaConexion)
        {
            this.connection = cadenaConexion;
        }

        public RolvsOpcionesDTO RolvsOpciones(int codRol)
        {
            RolvsOpcionesDTO resultado = new RolvsOpcionesDTO();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@CodRol", codRol);

                    using (var multi = con.QueryMultiple("Usp_ListOpcHabiYDesah", prm, commandType: CommandType.StoredProcedure))
                    {

                        resultado.opcHabilitadas = multi.Read<OpcionesDTO>().ToList();
                        resultado.opcDeshabilitadas = multi.Read<OpcionesDTO>().ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }


            return resultado;
        }


        //Opciones del perfil por usuario
        public List<OpcionesDTO> ObtenerOpcPorRol(int codRol)
        {
            List<OpcionesDTO> resultado = new List<OpcionesDTO>();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@CodRol", codRol);

                    resultado = con.Query<OpcionesDTO>("Usp_ObtenerRolXOpcion", prm, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }

            return resultado;
        }


        public int EliminarRolConOpciones(int codRol)
        {
            int resultado = 0;
            try
            {
                using (IDbConnection con = new SqlConnection(this.connection))
                {
                    string sql = "DELETE FROM TBRolXOpcion WHERE CodRol=@CodRol";
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@CodRol", codRol);
                    resultado = con.Execute(sql, prm);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return resultado;
        }


        public RespuestaDTO MantRolXOpcion(RolXOpcion req)
        {
            RespuestaDTO resultado = new RespuestaDTO();
            try
            {
                using (IDbConnection con = new SqlConnection(this.connection))
                {

                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@CodRol", req.CodRol);
                    prm.Add("@CodOpcion", req.CodOpcion);

                    resultado = con.Query<RespuestaDTO>("Usp_MantRolXOpcion", prm, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return resultado;
        }

        public List<ListarRolesDTO> ListarRoles(Parametro req)
        {
            List<ListarRolesDTO> resultado = new List<ListarRolesDTO>();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@CodPrm", req.CodPrm);
                    prm.Add("@Descripcion", req.Descripcion);
                    prm.Add("@Fmod", req.Fmod);

                    resultado = con.Query<ListarRolesDTO>("Usp_ObtenerParametro", prm, commandType: CommandType.StoredProcedure).ToList();
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

using AppBogedaTeo.DTO;
using AppBogedaTeo.Entidades;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace AppBogedaTeo.Repositorio
{
    public class ProductoRepositorio<T> : BaseRepositorio
    {
        public ProductoRepositorio(string cadenaConexion)
        {
            this.connection = cadenaConexion;
        }

        public List<T> BuscarProducto(ProductosBusDTO req)
        {
            var resultado = new List<T>();
            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@Descripcion", req.Descripcion);
                
                    resultado =con.Query<T>("Usp_BuscarProducto", prm, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch
            {
                throw;
            }

            return resultado;
        }



        public RespuestaDTO MantProducto(Productos req)
        {
            RespuestaDTO resultado = new RespuestaDTO();

            try
            {
                using (IDbConnection con = new SqlConnection(connection))
                {
                    DynamicParameters prm = new DynamicParameters();
                    prm.Add("@CodProducto", req.CodProducto);
                    prm.Add("@Descripcion", req.Descripcion);
                    prm.Add("@PrecioVenta", req.PrecioVenta);
                    prm.Add("@Stock", req.Stock);
                    prm.Add("@CodProductoCategoria", req.CodProductoCategoria);
                    prm.Add("@LimiteStock", req.LimiteStock);
                    prm.Add("@CodProveedor", req.CodProveedor);
                    prm.Add("@PrecioCompra", req.PrecioCompra);

                    resultado = con.Query<RespuestaDTO>("Usp_MantProducto", prm, commandType: CommandType.StoredProcedure).FirstOrDefault();
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

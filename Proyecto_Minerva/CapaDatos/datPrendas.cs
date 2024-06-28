using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datPrendas
    {
        #region Singleton
        private static readonly datPrendas _instancia = new datPrendas();
        public static datPrendas Instancia
        {
            get
            {
                return datPrendas._instancia;
            }
        }
        #endregion Singleton
        public List<string> ObtenerCategorias()
        {
            List<string> categorias = new List<string>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spObtenerCategorias", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    categorias.Add(dr["Categoria"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return categorias;
        }

        public List<string> ObtenerColegios()
        {
            List<string> colegios = new List<string>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spObtenerColegios", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    colegios.Add(dr["Colegio"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return colegios;
        }

        public List<string> ObtenerTallas()
        {
            List<string> tallas = new List<string>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spObtenerTallas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tallas.Add(dr["Talla"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return tallas;
        }

        public List<entPrendas> ListarPrendas()
        {
            List<entPrendas> prendas = new List<entPrendas>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarPrendas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPrendas prenda = new entPrendas
                    {
                        PrendaID = dr["PrendaID"] != DBNull.Value ? Convert.ToInt32(dr["PrendaID"]) : 0,
                        Prenda = dr["Prenda"] != DBNull.Value ? dr["Prenda"].ToString() : string.Empty,
                        Descripcion = dr["Descripcion"] != DBNull.Value ? dr["Descripcion"].ToString() : string.Empty,
                        Categoria = dr["Categoria"] != DBNull.Value ? dr["Categoria"].ToString() : string.Empty,
                        Talla = dr["Talla"] != DBNull.Value ? dr["Talla"].ToString() : string.Empty,
                        Colegio = dr["Colegio"] != DBNull.Value ? dr["Colegio"].ToString() : string.Empty,
                        PrecioCompra = dr["PrecioCompra"] != DBNull.Value ? Convert.ToDecimal(dr["PrecioCompra"]) : 0,
                        PrecioVenta = dr["Precioventa"] != DBNull.Value ? Convert.ToDecimal(dr["Precioventa"]) : 0,
                        Stock = dr["Stock"] != DBNull.Value ? Convert.ToInt32(dr["Stock"]) : 0,
                        Estado = dr["Estado"] != DBNull.Value ? Convert.ToBoolean(dr["Estado"]) : false
                    };
                    prendas.Add(prenda);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return prendas;
        }
        public void InsertarPrenda(entPrendas prenda)
        {
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                SqlCommand cmd = new SqlCommand("spInsertarPrenda", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Prenda", prenda.Prenda);
                cmd.Parameters.AddWithValue("@Descripcion", prenda.Descripcion);
                cmd.Parameters.AddWithValue("@Categoria", prenda.Categoria); // Nueva propiedad
                cmd.Parameters.AddWithValue("@Talla", prenda.Talla); // Nueva propiedad
                cmd.Parameters.AddWithValue("@Colegio", prenda.Colegio); // Nueva propiedad
                cmd.Parameters.AddWithValue("@PrecioCompra", prenda.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", prenda.PrecioVenta);
                cmd.Parameters.AddWithValue("@Stock", prenda.Stock);
                cmd.Parameters.AddWithValue("@Estado", prenda.Estado);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarPrenda(entPrendas prenda)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarPrenda", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PrendaID", prenda.PrendaID);
                cmd.Parameters.AddWithValue("@Prenda", prenda.Prenda);
                cmd.Parameters.AddWithValue("@Descripcion", prenda.Descripcion);
                cmd.Parameters.AddWithValue("@Categoria", prenda.Categoria); // Nueva propiedad
                cmd.Parameters.AddWithValue("@Talla", prenda.Talla); // Nueva propiedad
                cmd.Parameters.AddWithValue("@Colegio", prenda.Colegio); // Nueva propiedad
                cmd.Parameters.AddWithValue("@PrecioCompra", prenda.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", prenda.PrecioVenta);
                cmd.Parameters.AddWithValue("@Stock", prenda.Stock);
                cmd.Parameters.AddWithValue("@Estado", prenda.Estado);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
        }

        public entPrendas BuscarPrendaPorID(int prendaID)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entPrendas prenda = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarPrendaPorID", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PrendaID", prendaID);

                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    prenda = new entPrendas
                    {
                        PrendaID = Convert.ToInt32(dr["PrendaID"]),
                        Prenda = dr["Prenda"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        Categoria = dr["Categoria"].ToString(), // Nueva propiedad
                        Talla = dr["Talla"].ToString(), // Nueva propiedad
                        Colegio = dr["Colegio"].ToString(), // Nueva propiedad
                        PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"]),
                        PrecioVenta = Convert.ToDecimal(dr["Precioventa"]),
                        Stock = Convert.ToInt32(dr["Stock"]),
                        Estado = Convert.ToBoolean(dr["Estado"])
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dr != null && !dr.IsClosed) dr.Close();
                if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return prenda;


        }
    }

}

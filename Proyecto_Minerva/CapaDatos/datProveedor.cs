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
    public class datProveedor
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProveedor _instancia = new datProveedor();
        //privado para evitar la instanciación directa
        public static datProveedor Instancia
        {
            get
            {
                return datProveedor._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //////////////////listado de Proveedores
        public List<entProveedor> ListarProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor prov = new entProveedor();
                    prov.ID = Convert.ToInt32(dr["ID"]);
                    prov.NomPro = dr["NomPro"].ToString();
                    prov.RUC = Convert.ToInt32(dr["RUC"]);
                    prov.Ciudad = dr["Ciudad"].ToString();
                    prov.Rubro = dr["Rubro"].ToString();
                    prov.RazonSocial = dr["RazonSocial"].ToString();
                    prov.Direccion = dr["Direccion"].ToString();
                    prov.Telefono = Convert.ToInt32(dr["Telefono"]);
                    prov.Email = dr["Email"].ToString();
                    prov.Ubigeo= Convert.ToInt32(dr["Ubigeo"]);
                    prov.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(prov);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        #endregion metodos

        public List<string> ObtenerCiudad()
        {
            List<string> ciudad = new List<string>();
            SqlCommand? cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ObtenerCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ciudad.Add(dr["Ciudad"].ToString());
                }
            }
            catch (Exception) { throw; }
            finally
            {
                if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return ciudad;
        }
        public List<string> ObtenerRubro()
        {
            List<string> rubro = new List<string>();
            SqlCommand? cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ObtenerRubro", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rubro.Add(dr["Rubro"].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return rubro;
        }
        /////////////////////////InsertaCliente
        public Boolean InsertaProveedor(entProveedor prov)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RazonSocial", prov.RazonSocial);
                cmd.Parameters.AddWithValue("@RUC", prov.RUC);
                cmd.Parameters.AddWithValue("@NomPro", prov.NomPro);
                cmd.Parameters.AddWithValue("@Ciudad", prov.Ciudad);
                cmd.Parameters.AddWithValue("@Direccion", prov.Direccion);
                cmd.Parameters.AddWithValue("@Email", prov.Email);
                cmd.Parameters.AddWithValue("@Telefono", prov.Telefono);
                cmd.Parameters.AddWithValue("@Estado", prov.Estado);
                cmd.Parameters.AddWithValue("@Rubro", prov.Rubro);
                cmd.Parameters.AddWithValue("@Ubigeo", prov.Ubigeo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return inserta;
        }

        public entProveedor BuscarProveedorPorID(int id)
        {
            SqlCommand cmd = null;
            entProveedor prov = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarProveedorPorID", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    prov = new entProveedor
                    {
                        ID = Convert.ToInt32(dr["ID"]),
                        NomPro = dr["NomPro"].ToString(),
                        RUC = Convert.ToInt32(dr["RUC"]),
                        Ciudad = dr["Ciudad"].ToString(),
                        Rubro = dr["Rubro"].ToString(),
                        RazonSocial = dr["RazonSocial"].ToString(),
                        Direccion = dr["Direccion"].ToString(),
                        Telefono = Convert.ToInt32(dr["Telefono"]),
                        Email = dr["Email"].ToString(),
                        Estado = Convert.ToBoolean(dr["Estado"]),
                    };
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return prov;
        }

        public Boolean ModificarProveedor(entProveedor prov)
        {
            SqlCommand cmd = null;
            Boolean modifica = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", prov.ID);
                cmd.Parameters.AddWithValue("@NomPro", prov.NomPro);
                cmd.Parameters.AddWithValue("@RazonSocial", prov.RazonSocial);
                cmd.Parameters.AddWithValue("@Direccion", prov.Direccion);
                cmd.Parameters.AddWithValue("@Email", prov.Email);
                cmd.Parameters.AddWithValue("@Telefono", prov.Telefono);
                cmd.Parameters.AddWithValue("@Rubro", prov.Rubro);
                cmd.Parameters.AddWithValue("@Estado", prov.Estado);
                cmd.Parameters.AddWithValue("@RUC", prov.RUC);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    modifica = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return modifica;
        }

        public entUbigeo BuscarUbigeo(string codigoUbigeo)
        {
            SqlCommand cmd = null;
            entUbigeo ubigeo = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarUbigeoPorCodigo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodigoUbigeo", codigoUbigeo);
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        ubigeo = new entUbigeo
                        {
                            Ubigeo = dr["Ubigeo"].ToString(),
                            Departamento = dr["Departamento"].ToString(),
                            Provincia = dr["Provincia"].ToString(),
                            Distrito = dr["Distrito"].ToString()
                        };
                    }
                }
            }
            catch (Exception e)
            {
                // Considera loggear la excepción aquí
                throw;
            }
            finally
            {
                if (cmd?.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return ubigeo;
        }
        public Boolean InhabilitarProveedor(int id)
        {
            SqlCommand cmd = null;
            Boolean inhabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInhabilitarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inhabilita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return inhabilita;
        }

    }
}
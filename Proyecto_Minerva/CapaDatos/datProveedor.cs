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
                using (SqlConnection cn = Conexion.Instancia.Conectar()) // Usar using para la conexión
                {
                    cmd = new SqlCommand("spListarProveedor", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader()) // Usar using para el SqlDataReader
                    {
                        while (dr.Read())
                        {
                            entProveedor prov = new entProveedor();
                            prov.ID = Convert.ToInt32(dr["ID"]);
                            prov.RUC = dr["RUC"].ToString();
                            prov.NombreComercial = dr["NombreComercial"].ToString();
                            prov.Rubro = dr["Rubro"].ToString(); // Cambiar Rubro a RubroID
                            prov.RazonSocial = dr["RazonSocial"].ToString();
                            prov.Distrito= dr["Distrito"].ToString();
                            prov.Direccion = dr["Direccion"].ToString();
                            prov.Telefono = Convert.ToInt32(dr["Telefono"]);
                            prov.Email = dr["Email"].ToString();
                            prov.Estado = Convert.ToBoolean(dr["Estado"]);
                           
                            lista.Add(prov);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar proveedores.", e); // Mejorar manejo de errores
            }
            return lista;
        }

        #endregion metodos
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

        public Boolean InsertaProveedor(entProveedor prov)
        {
            Boolean inserta = false;

            // Validar parámetros de entrada
            if (prov == null)
            {
                throw new ArgumentNullException(nameof(prov), "El proveedor no puede ser nulo.");
            }

            // Utilizar la declaración using para manejar la conexión y el comando
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spInsertarProveedor", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RazonSocial", prov.RazonSocial);
                    cmd.Parameters.AddWithValue("@RUC", prov.RUC);
                    cmd.Parameters.AddWithValue("@NombreComercial", prov.NombreComercial);
                    cmd.Parameters.AddWithValue("@Direccion", prov.Direccion);
                    cmd.Parameters.AddWithValue("@Email", prov.Email);
                    cmd.Parameters.AddWithValue("@Telefono", prov.Telefono);
                    cmd.Parameters.AddWithValue("@Estado", prov.Estado);
                    cmd.Parameters.AddWithValue("@Rubro", prov.Rubro);
                    cmd.Parameters.AddWithValue("@Ubigeo", prov.Ubigeo);
                    cmd.Parameters.AddWithValue("@Distrito", prov.Distrito);

                    try
                    {
                        cn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            inserta = true;
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Manejar la excepción de manera adecuada (por ejemplo, registrar el error)
                        throw new Exception("Error al insertar el proveedor.", ex);
                    }
                    // No es necesario el bloque finally si usamos using
                }
            }

            return inserta;
        }

        //public entProveedor BuscarProveedorPorNombre(string nombre)
        //{
        //    SqlCommand cmd = null;
        //    entProveedor prov = null;
        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.Conectar();
        //        cmd = new SqlCommand("spBuscarProveedorPorNombre", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cn.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            prov = new entProveedor
        //            {
        //                ID = Convert.ToInt32(dr["ID"]),
        //                RUC = dr["RUC"].ToString(),
        //                Ciudad = dr["Ciudad"].ToString(),
        //                Rubro = dr["Rubro"].ToString(),
        //                RazonSocial = dr["RazonSocial"].ToString(),
        //                Direccion = dr["Direccion"].ToString(),
        //                Telefono = Convert.ToInt32(dr["Telefono"]),
        //                Email = dr["Email"].ToString(),
        //                Estado = Convert.ToBoolean(dr["Estado"]),
        //            };
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //    finally
        //    {
        //        if (cmd?.Connection != null)
        //        {
        //            cmd.Connection.Close();
        //        }
        //    }
        //    return prov;
        //}
        public entProveedor BuscarProveedorPorRUC(string ruc)
        {
            SqlCommand cmd = null;
            entProveedor prov = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarProveedorPorID", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RUC", ruc);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    prov = new entProveedor
                    {
                        ID = Convert.ToInt32(dr["ID"]),
                        RUC = dr["RUC"].ToString(),
                        Distrito = dr["Ciudad"].ToString(),
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
                if (cmd?.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return prov;
        }

        //public Boolean ModificarProveedor(entProveedor prov)
        //{
        //    SqlCommand cmd = null;
        //    Boolean modifica = false;
        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.Conectar();
        //        cmd = new SqlCommand("spModificarProveedor", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@RUC", prov.RUC);
        //        cmd.Parameters.AddWithValue("@NomPro", prov.NomPro);
        //        cmd.Parameters.AddWithValue("@RazonSocial", prov.RazonSocial);
        //        cmd.Parameters.AddWithValue("@Direccion", prov.Direccion);
        //        cmd.Parameters.AddWithValue("@Email", prov.Email);
        //        cmd.Parameters.AddWithValue("@Telefono", prov.Telefono);
        //        cmd.Parameters.AddWithValue("@Rubro", prov.Rubro);
        //        cmd.Parameters.AddWithValue("@Estado", prov.Estado);
        //        cn.Open();
        //        int i = cmd.ExecuteNonQuery();
        //        if (i > 0)
        //        {
        //            modifica = true;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //    finally
        //    {
        //        if (cmd != null && cmd.Connection != null)
        //        {
        //            cmd.Connection.Close();
        //        }
        //    }
        //    return modifica;
        //}

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
        //public Boolean InhabilitarProveedor(string ruc)
        //{
        //    SqlCommand cmd = null;
        //    Boolean inhabilita = false;
        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.Conectar();
        //        cmd = new SqlCommand("spInhabilitarProveedor", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@RUC", ruc);
        //        cn.Open();
        //        int i = cmd.ExecuteNonQuery();
        //        if (i > 0)
        //        {
        //            inhabilita = true;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //    finally
        //    {
        //        if (cmd != null && cmd.Connection != null)
        //        {
        //            cmd.Connection.Close();
        //        }
        //    }
        //    return inhabilita;
        //}
    }
}
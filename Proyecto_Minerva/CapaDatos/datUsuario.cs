using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datUsuario
    {
        #region Singleton
        private static readonly datUsuario _instancia = new datUsuario();
        public static datUsuario Instancia
        {
            get
            {
                return datUsuario._instancia;
            }
        }
        #endregion Singleton

        #region metodos

        //LISTAR USUARIOS
        public List<entdescUsuario> ListarUsuario()
        {
            SqlCommand cmd = null;
            List<entdescUsuario> lista = new List<entdescUsuario>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarUsuarios", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entdescUsuario User = new entdescUsuario();
                    User.UsuarioID = Convert.ToInt32(dr["UsuarioID"]);
                    User.descripcion = Convert.ToString(dr["Descripcion"]);
                    User.Documento = Convert.ToInt32(dr["Documento"]);
                    User.NombreCompleto = Convert.ToString(dr["NombreCompleto"]);
                    User.Estado = Convert.ToBoolean(dr["Estado"]);
                    User.Clave = Convert.ToString(dr["Clave"]);
                    User.FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]);
                    User.Correo = Convert.ToString(dr["Correo"]);
                    User.Usuario = Convert.ToString(dr["Usuario"]);
                    lista.Add(User);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }
            return lista;
        }

        public bool ActualizarEstadoConexion(int? Documento, bool estaConectado, DateTime ultimaActividad)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("spActualizarEstadoConexion", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Documento", Documento.HasValue ? (object)Documento.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@EstaConectado", estaConectado);
                    cmd.Parameters.AddWithValue("@UltimaActividad", ultimaActividad);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                return false;
            }
        }


        public List<entUsuario> ListarValidacionUsuario()
        {
            SqlCommand cmd = null;
            List<entUsuario> lista = new List<entUsuario>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    SqlCommand cmd1 = new SqlCommand("spListarValidacionUsuario", cn);
                    cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                    cn.Open();

                    SqlDataReader dr = cmd1.ExecuteReader();
                    while (dr.Read())
                    {
                        entUsuario user = new entUsuario();

                        // Manejar DBNull para cada campo
                        user.Documento = dr["Documento"] != DBNull.Value
                                         ? Convert.ToInt32(dr["Documento"])
                                         : 0; // o manejar como desees

                        user.NombreCompleto = dr["NombreCompleto"] != DBNull.Value
                                              ? dr["NombreCompleto"].ToString()
                                              : string.Empty; // o manejar como desees

                        user.Clave = dr["Clave"] != DBNull.Value
                                     ? dr["Clave"].ToString()
                                     : string.Empty; // o manejar como desees

                        user.Estado = dr["Estado"] != DBNull.Value
                                       ? Convert.ToBoolean(dr["Estado"])
                                       : false; // o manejar como desees

                        user.EstaConectado = dr["EstaConectado"] != DBNull.Value
                                             ? Convert.ToBoolean(dr["EstaConectado"])
                                             : false; // o manejar como desees

                        user.UltimaActividad = dr["UltimaActividad"] != DBNull.Value
                                               ? Convert.ToDateTime(dr["UltimaActividad"])
                                               : DateTime.MinValue; // o manejar como desees

                        user.Usuario = dr["Usuario"] != DBNull.Value
                                              ? dr["Usuario"].ToString()
                                              : string.Empty; // o manejar como desees
                        user.idRol = dr["RolID"] != DBNull.Value
                                             ? Convert.ToInt32(dr["RolID"])
                                             : 0;
                        lista.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }

            return lista;
        }



        public Boolean InsertarUsuario(entUsuario User)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Documento", User.Documento);
                cmd.Parameters.AddWithValue("@RolID", User.idRol);
                cmd.Parameters.AddWithValue("@NombreCompleto", User.NombreCompleto);
                cmd.Parameters.AddWithValue("@Estado", User.Estado);
                cmd.Parameters.AddWithValue("@Clave", User.Clave);
                cmd.Parameters.AddWithValue("@FechaRegistro", User.FechaRegistro);
                cmd.Parameters.AddWithValue("@Correo", User.Correo);
                cmd.Parameters.AddWithValue("@Usuario", User.Usuario);

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
            finally { cmd.Connection.Close(); }


            return inserta;
        }

        public Boolean ModificarUsuario(entUsuario user)
        {
            SqlCommand cmd = null;
            bool modificado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioID", user.UsuarioID);
                cmd.Parameters.AddWithValue("@Documento", user.Documento);
                cmd.Parameters.AddWithValue("@RolID", user.idRol);
                cmd.Parameters.AddWithValue("@NombreCompleto", user.NombreCompleto);
                cmd.Parameters.AddWithValue("@Estado", user.Estado);
                cmd.Parameters.AddWithValue("@Clave", user.Clave);
                cmd.Parameters.AddWithValue("@FechaRegistro", user.FechaRegistro);
                cmd.Parameters.AddWithValue("@Correo", user.Correo);
                cmd.Parameters.AddWithValue("@Usuario", user.Usuario);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    modificado = true;
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
            return modificado;
        }

        public Boolean DeshabilitarUsuarios(entUsuario User)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInhabilitarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioID", User.UsuarioID);
                //cmd.Parameters.AddWithValue("@estado", Alm.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        public List<entUsuario> BuscarUsuarios(int? Documento, string NombreCompleto, int? RolID, bool? Estado)
        {
            SqlCommand cmd = null;
            List<entUsuario> lista = new List<entUsuario>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cn.Open();
                cmd = new SqlCommand("spBuscarUsuarios", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Documento", Documento.HasValue ? (object)Documento.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@NombreCompleto", !string.IsNullOrEmpty(NombreCompleto) ? (object)NombreCompleto : DBNull.Value);
                cmd.Parameters.AddWithValue("@RolID", RolID.HasValue ? (object)RolID.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@Estado", Estado.HasValue ? (object)Estado.Value : DBNull.Value);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entUsuario u = new entUsuario
                    {
                        UsuarioID = Convert.ToInt32(dr["UsuarioID"]),
                        Documento = Convert.ToInt32(dr["Documento"]),
                        NombreCompleto = dr["NombreCompleto"].ToString(),
                        idRol = Convert.ToInt32(dr["RolID"]),
                        Estado = Convert.ToBoolean(dr["Estado"]),
                        FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"])
                    };
                    lista.Add(u);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return lista;
        }



        #endregion metodos


    }
}

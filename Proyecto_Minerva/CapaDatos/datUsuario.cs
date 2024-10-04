﻿using CapaEntidad;
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


        public List<entUsuario> ListarValidacionUsuario()
        {
            SqlCommand cmd = null;
            List<entUsuario> lista = new List<entUsuario>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarValidacionUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entUsuario User = new entUsuario();
                    User.UsuarioID = Convert.ToInt32(dr["UsuarioID"]);
                    User.idRol = Convert.ToInt32(dr["RolID"]);
                    User.Documento = Convert.ToInt32(dr["Documento"]);
                    User.NombreCompleto = Convert.ToString(dr["NombreCompleto"]);
                    User.Estado = Convert.ToBoolean(dr["Estado"]);
                    User.Clave = Convert.ToString(dr["Clave"]);
                    User.Correo = Convert.ToString(dr["Correo"]);
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

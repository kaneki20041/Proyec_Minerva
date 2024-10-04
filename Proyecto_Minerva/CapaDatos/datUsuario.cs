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

        //INGRESO DE USUARIO

        /*public entUsuario IngresoUsuario(string user, string pass)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entUsuario usuario = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spIngresoUsuarios", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@User", user);
                cmd.Parameters.AddWithValue("@Password", pass);
                cn.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    usuario = new entUsuario()
                    {
                        UsuarioID = Convert.ToInt32(dr["UsuarioID"]),
                        NombreCompleto = dr["Documento"].ToString(),
                        objRol = new entRol()
                        {
                            Descripcion = dr["Descripcion"].ToString()
                        }
                        //nombTrab = dr["NombreCompleto"].ToString() // Se mantiene para obtener el nombre completo
                    };


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usuario;
        }*/


        //LISTAR USUARIOS
        public List<entUsuario> ListarUsuario()
        {
            SqlCommand cmd = null;
            List<entUsuario> lista = new List<entUsuario>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarUsuarios", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entUsuario User = new entUsuario();
                    User.UsuarioID = Convert.ToInt32(dr["UsuarioID"]);
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

        #endregion metodos


    }
}

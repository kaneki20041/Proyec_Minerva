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
    public class datRol
    {
        #region Singleton
        private static readonly datRol _instancia = new datRol();
        public static datRol Instancia
        {
            get
            {
                return datRol._instancia;
            }
        }
        #endregion Singleton

        #region metodos


        //LISTAR ROLES
        public List<entRol> ListarRol()
        {
            SqlCommand cmd = null;
            List<entRol> lista = new List<entRol>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarRol", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRol Rol = new entRol();
                    Rol.RolID = Convert.ToInt32(dr["RolID"]);
                    Rol.Descripcion = Convert.ToString(dr["Descripcion"]);
                    Rol.FechaRegistro = Convert.ToString(dr["FechaRegistro"]);
                    lista.Add(Rol);
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

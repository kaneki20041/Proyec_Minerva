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
    public class datPermisos
    {
        #region Singleton
        private static readonly datPermisos _instancia = new datPermisos();
        public static datPermisos Instancia
        {
            get
            {
                return datPermisos._instancia;
            }
        }
        #endregion Singleton

        #region metodos

        //LISTAR USUARIOS
        public List<entPermisos> ListarPermisos(int usuarioID)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                List<entPermisos> lista = new List<entPermisos>();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("spListarPermisosUsuario", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);

                        cn.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(new entPermisos
                                {
                                    idRol = Convert.ToInt32(dr["IdRol"]),
                                    NombreMenu = dr["NombreMenu"].ToString(),
                                    // Agrega aquí otros campos si los necesitas
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log del error si tienes un sistema de logging
                    throw new Exception($"Error en la base de datos: {ex.Message}", ex);
                }

                return lista;
            }
        }

        #endregion metodos
    }
}

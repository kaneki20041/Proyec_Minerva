using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datComprobante
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datComprobante _instancia = new datComprobante();
        //privado para evitar la instanciación directa
        public static datComprobante Instancia
        {
            get
            {
                return datComprobante._instancia;
            }
        }
        #endregion singleton

        public List<string> ObtenerTiposComprobante()
        {
            List<string> comprobantes = new List<string>();
            SqlCommand? cmd = null;
            try
            {
                // Conectar a la base de datos
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTiposComprobante", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Abrir la conexión
                cn.Open();

                // Ejecutar el comando y leer los resultados
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // Agregar el nombre del comprobante a la lista
                    comprobantes.Add(dr["descripcion"].ToString());
                }
            }
            catch (Exception)
            {
                throw; // Relanzar la excepción para que sea manejada externamente
            }
            finally
            {
                // Asegurarse de que la conexión se cierre adecuadamente
                if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return comprobantes; // Retornar la lista de comprobantes
        }

    }
}

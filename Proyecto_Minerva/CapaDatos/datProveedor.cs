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
        ////////////////////listado de Proveedores
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
                    prov.RazonSocial = dr["Razon Social"].ToString();
                    prov.Direccion = dr["Direccion"].ToString();
                    prov.Telefono =  Convert.ToInt32(dr["Telefono"]);
                    prov.Email = dr["Email"].ToString();
                    prov.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(prov);
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
    }
}

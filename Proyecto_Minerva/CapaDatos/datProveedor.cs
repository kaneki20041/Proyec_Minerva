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
                    prov.RazonSocial = dr["RazonSocial"].ToString();
                    prov.Direccion = dr["Direccion"].ToString();
                    prov.Telefono = Convert.ToInt32(dr["Telefono"]);
                    prov.Email = dr["Email"].ToString();
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
                        Estado = Convert.ToBoolean(dr["Estado"])
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


    }
}

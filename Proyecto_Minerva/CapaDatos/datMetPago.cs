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
    public class datMetPago
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datMetPago _instancia = new datMetPago();
        //privado para evitar la instanciación directa
        public static datMetPago Instancia
        {
            get
            {
                return datMetPago._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de Clientes
        public List<EntMetPago> ListarMetPago()
        {
            SqlCommand cmd = null;
            List<EntMetPago> lista = new List<EntMetPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaMetPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntMetPago Met = new EntMetPago();
                    Met.MetPagoid = Convert.ToInt32(dr["MetodopagoID"]);
                    Met.metodopago = dr["MetodoPago"].ToString();
                    Met.estMetpago = Convert.ToBoolean(dr["EstadoMetodopago"]);
                    lista.Add(Met);
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
        public Boolean InsertaMetpago(EntMetPago Met)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaMetpago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MetodoPago", Met.metodopago);
                cmd.Parameters.AddWithValue("@EstadoMetodopago", Met.estMetpago);
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
        //////////////////////////////////EditaCliente
        public Boolean EditarMetPago(EntMetPago Met)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("speditametpago", cn);
                cmd.Parameters.AddWithValue("MetodopagoID", Met.MetPagoid);
                cmd.Parameters.AddWithValue("@MetodoPago", Met.metodopago);
                cmd.Parameters.AddWithValue("@EstadoMetodopago", Met.estMetpago);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }
        public Boolean DeshabilitarMetpago(EntMetPago Met)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitametpago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MetodopagoID", Met.MetPagoid);
                cmd.Parameters.AddWithValue("@EstadoMetodopago", Met.estMetpago);
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
        public EntMetPago BuscarMetodoPagoPorID(int metPagoID)
        {
            SqlCommand cmd = null;
            EntMetPago metodoPago = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MetodopagoID", metPagoID);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    metodoPago = new EntMetPago
                    {
                        MetPagoid = metPagoID,
                        metodopago = dr["MetodoPago"].ToString()
                    };
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }
            return metodoPago;
        }

        public List<string> ObtenerMetodosPago()
        {
            List<string> metodosPago = new List<string>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spObtenerMetodosPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    metodosPago.Add(dr["MetodoPago"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return metodosPago;
        }
    }
    #endregion metodos
}


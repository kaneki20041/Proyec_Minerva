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
    public class datCompra
    {
        #region Singleton
        private static readonly datCompra _instancia = new datCompra();
        public static datCompra Instancia
        {
            get
            {
                return datCompra._instancia;
            }
        }
        #endregion Singleton
        #region metodos

        public List<entCompra> ListaCompra()
        {
            SqlCommand? cmd = null;
            List<entCompra> lista = new List<entCompra>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarOC", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entCompra Com = new entCompra();
                    entProveedor Pro = new entProveedor();
                    EntMetPago MetPago = new EntMetPago();

                    Com.idCompra = Convert.ToInt32(dr["OcompraID"]);
                    Com.fechCompra = Convert.ToDateTime(dr["FechaRegistroC"]);

                    Pro.ID = Convert.ToInt32(dr["ProveedorID"]);
                    Pro.RazonSocial = dr["RazonSocial"].ToString();
                    MetPago.MetPagoid = Convert.ToInt32(dr["MetodopagoID"]);
                    MetPago.metodopago = dr["Metodopago"].ToString();
                    Com.Metpagoid = MetPago;
                    Com.ID = Pro;

                    Com.Monto = Convert.ToDouble(dr["Monto"]);
                    lista.Add(Com);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd?.Connection.Close(); }
            return lista;
        }


        public int InsertaCompra(entCompra Com)
        {
            if (Com == null || Com.ID == null || Com.Metpagoid == null)
            {
                throw new ArgumentNullException("Los parámetros de la compra no pueden ser nulos.");
            }

            SqlCommand? cmd = null;
            int idCom = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProveedorID", Com.ID.ID);
                cmd.Parameters.AddWithValue("@MetodoPagoID", Com.Metpagoid.MetPagoid);
                cmd.Parameters.AddWithValue("@FechaRegistroC", Com.fechCompra);
                cmd.Parameters.AddWithValue("@Monto", Com.Monto);

                SqlParameter m = new SqlParameter("@retorno", DbType.Int32);
                m.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(m);
                cn.Open();
                cmd.ExecuteNonQuery();
                idCom = Convert.ToInt32(cmd.Parameters["@retorno"].Value);
                return idCom;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cmd?.Connection.Close();
            }
        }


        public bool InsertarDetCom(entDetCom dCom)
        {
            SqlCommand? cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDetCom", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@OcompraID", dCom.idCompra);
                cmd.Parameters.AddWithValue("@PrendaID", dCom.PrendaID.PrendaID);
                cmd.Parameters.AddWithValue("@Cantidad", dCom.cantPren);
                cmd.Parameters.AddWithValue("@PrecioCompra", dCom.precPren);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception) { throw; }
            finally
            {
                cmd?.Connection.Close();
            }
            return inserta;
        }
        #endregion metodos

    }
}

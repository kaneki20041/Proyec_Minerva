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
    public class datOVenta
    {
        // Singleton
        private static readonly datOVenta instancia = new datOVenta();
        public static datOVenta Instancia
        {
            get { return instancia; }
        }

        // Método para obtener todas las ventas
        public List<entOVenta> ListarVentas()
        {
            List<entOVenta> lista = new List<entOVenta>();
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("spListarVentas", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOVenta venta = new entOVenta
                    {
                        OventaID = Convert.ToInt32(dr["OventaID"]),
                        Nombre = dr["Nombre"].ToString(),
                        Prenda = dr["Prenda"].ToString(),
                        Talla = dr["Talla"].ToString(),
                        Precioventa = Convert.ToDecimal(dr["Precioventa"]),
                        Stock = dr["Stock"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["Stock"]),
                        Cantidad = dr["Cantidad"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["Cantidad"]),
                        MetodoPago = dr["MetodoPago"].ToString(),
                        Monto = dr["Monto"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dr["Monto"]),
                        FRegistroV = Convert.ToDateTime(dr["FRegistroV"]),
                        TipoComprobante = dr["TipoComprobante"].ToString()
                    };
                    lista.Add(venta);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
            return lista;
        }
        public void RegistrarVenta(entOVenta venta)
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("spRegistrarVenta", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Nombre", venta.Nombre);
            cmd.Parameters.AddWithValue("@Prenda", venta.Prenda);
            cmd.Parameters.AddWithValue("@Talla", venta.Talla);
            cmd.Parameters.AddWithValue("@Precioventa", venta.Precioventa);
            cmd.Parameters.AddWithValue("@Stock", venta.Stock);
            cmd.Parameters.AddWithValue("@Cantidad", venta.Cantidad);
            cmd.Parameters.AddWithValue("@MetodoPago", venta.MetodoPago);
            cmd.Parameters.AddWithValue("@Monto", venta.Monto);
            cmd.Parameters.AddWithValue("@FRegistroV", venta.FRegistroV); // Uso del nombre correcto
            cmd.Parameters.AddWithValue("@TipoComprobante", venta.TipoComprobante);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
     
    }
}

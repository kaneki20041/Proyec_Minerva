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
        #region Singleton

        private static readonly datOVenta instancia = new datOVenta();
        public static datOVenta Instancia
        {
            get { return instancia; }
        }

        #endregion Singleton

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
                    entOVenta venta = new entOVenta();
                    try
                    {
                        venta.OventaID = Convert.ToInt32(dr["OventaID"]);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al leer OventaID: " + ex.Message);
                    }
                    venta.Nombre = dr["Nombre"].ToString();
                    venta.MetodoPago = dr["MetodoPago"].ToString();
                    venta.Prenda = dr["Prenda"].ToString();
                    venta.Talla = dr["Talla"].ToString();
                    venta.Precioventa = Convert.ToDecimal(dr["Precioventa"]);
                    venta.Cantidad = dr["Cantidad"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["Cantidad"]);
                    venta.Monto = dr["Monto"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dr["Monto"]);
                    venta.TipoComprobante = dr["TipoComprobante"].ToString();
                    venta.FRegistroV = Convert.ToDateTime(dr["FRegistroV"]);
                    venta.Colegio = dr["Colegio"].ToString();
                    venta.Categoria = dr["Categoria"].ToString();

                    lista.Add(venta);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al listar las ventas: " + ex.Message);
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
            cmd.Parameters.AddWithValue("@TipoComprobante", venta.TipoComprobante);
            cmd.Parameters.AddWithValue("@Nombre", venta.Nombre);
            cmd.Parameters.AddWithValue("@Monto", venta.Monto);
            cmd.Parameters.AddWithValue("@Prenda", venta.Prenda);
            cmd.Parameters.AddWithValue("@Precioventa", venta.Precioventa);
            cmd.Parameters.AddWithValue("@MetodoPago", venta.MetodoPago);
            cmd.Parameters.AddWithValue("@Cantidad", venta.Cantidad);
            cmd.Parameters.AddWithValue("@FRegistroV", venta.FRegistroV);
            cmd.Parameters.AddWithValue("@Talla", venta.Talla);
            cmd.Parameters.AddWithValue("@Colegio", venta.Colegio);
            cmd.Parameters.AddWithValue("@Categoria", venta.Categoria);

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

        public List<entOVenta> ListarDetalleVenta(int oventaID)
        {
            List<entOVenta> lista = new List<entOVenta>();
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("spListarDetalleVenta", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@OventaID", oventaID);
            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOVenta venta = new entOVenta
                    {
                        TipoComprobante = dr["TipoComprobante"].ToString(),
                        Monto = Convert.ToDecimal(dr["Monto"]),
                        Prenda = dr["Prenda"].ToString(),
                        Precioventa = Convert.ToDecimal(dr["Precioventa"]),
                        MetodoPago = dr["MetodoPago"].ToString(),
                        Cantidad = Convert.ToInt32(dr["Cantidad"]),
                        Talla = dr["Talla"].ToString(),
                        Colegio = dr["Colegio"].ToString(),
                        Categoria = dr["Categoria"].ToString()
                    };
                    lista.Add(venta);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al listar el detalle de ventas: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return lista;
        }
        public void RegistrarDetalleVenta(entOVenta detalleVenta)
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("spRegistrarDetalleVenta", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@OventaID", detalleVenta.OventaID);
            cmd.Parameters.AddWithValue("@TipoComprobante", detalleVenta.TipoComprobante);
            cmd.Parameters.AddWithValue("@Nombre", detalleVenta.Nombre);
            cmd.Parameters.AddWithValue("@Monto", detalleVenta.Monto);
            cmd.Parameters.AddWithValue("@Prenda", detalleVenta.Prenda);
            cmd.Parameters.AddWithValue("@Precioventa", detalleVenta.Precioventa);
            cmd.Parameters.AddWithValue("@MetodoPago", detalleVenta.MetodoPago);
            cmd.Parameters.AddWithValue("@Cantidad", detalleVenta.Cantidad);
            cmd.Parameters.AddWithValue("@FRegistroV", detalleVenta.FRegistroV);
            cmd.Parameters.AddWithValue("@Talla", detalleVenta.Talla);
            cmd.Parameters.AddWithValue("@Colegio", detalleVenta.Colegio);
            cmd.Parameters.AddWithValue("@Categoria", detalleVenta.Categoria);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al registrar el detalle de la venta: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void EliminarVenta(int oventaID)
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("spEliminarVenta", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@OventaID", oventaID);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al eliminar la venta: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public int ObtenerNuevoDetalleVentaID()
        {
            int nuevoID = 0;
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("spObtenerNuevoDetalleVentaID", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            try
            {
                cn.Open();
                nuevoID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al obtener el nuevo ID de detalle de venta: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

            return nuevoID;
        }


    }
}

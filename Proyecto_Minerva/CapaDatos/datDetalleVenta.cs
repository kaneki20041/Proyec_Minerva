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
    public class datDetalleVenta
    {
            #region Singleton

            private static readonly datDetalleVenta instancia = new datDetalleVenta();
            public static datDetalleVenta Instancia
            {
                get { return instancia; }
            }

            #endregion Singleton

            public List<entDetalleVenta> ListarDetalleVenta(int oventaID)
            {
                List<entDetalleVenta> lista = new List<entDetalleVenta>();
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
                        entDetalleVenta detalle = new entDetalleVenta
                        {
                            DetalleVentaID = Convert.ToInt32(dr["DetalleVentaID"]),
                            OventaID = Convert.ToInt32(dr["OventaID"]),
                            Nombre = dr["Nombre"].ToString(),
                            Prenda = dr["Prenda"].ToString(),
                            Talla = dr["Talla"].ToString(),
                            Precioventa = Convert.ToDecimal(dr["Precioventa"]),
                            Cantidad = dr["Cantidad"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["Cantidad"]),
                            MetodoPago = dr["MetodoPago"].ToString(),
                            Monto = dr["Monto"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dr["Monto"]),
                            FRegistroV = Convert.ToDateTime(dr["FRegistroV"]),
                            Colegio = dr["Colegio"].ToString(),
                            Categoria = dr["Categoria"].ToString(),
                            TipoComprobante = dr["TipoComprobante"].ToString()
                        };
                        lista.Add(detalle);
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
    }
}

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
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spListarVentas", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        cn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                entOVenta venta = new entOVenta
                                {
                                    OventaID = Convert.ToInt32(dr["O.ventaID"]),
                                    NombreCliente = dr["NombreCliente"].ToString(),
                                    Vendedor = dr["Vendedor"].ToString(),
                                    MontoPago = dr["MontoPago"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dr["MontoPago"]),
                                    MontoCambio = dr["MontoCambio"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dr["MontoCambio"]), // Agregado
                                    Precioventa = Convert.ToDecimal(dr["PrecioVenta"]),
                                    FRegistroV = Convert.ToDateTime(dr["Fecha"]) // Ajusta este nombre si es diferente
                                };

                                lista.Add(venta);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Ocurrió un error al listar las ventas: " + ex.Message);
                    }
                }
            }
            return lista;
        }


        public int RegistrarVenta(entOVenta venta)
        {
            SqlCommand cmd = null;
            int idVenta = 0;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Validar que los objetos necesarios no sean nulos
                if (venta.ClienteID?.ID == null)
                    throw new ArgumentException("El ID del cliente es requerido");
                if (venta.UsuarioID?.UsuarioID == null)
                    throw new ArgumentException("El ID del usuario es requerido");

                // Agregar los parámetros del procedimiento almacenado
                cmd.Parameters.AddWithValue("@ClienteID", venta.ClienteID.ID);
                cmd.Parameters.AddWithValue("@UsuarioID", venta.UsuarioID.UsuarioID);
                cmd.Parameters.AddWithValue("@FechaRegistroV", venta.FRegistroV);
                cmd.Parameters.AddWithValue("@Monto", venta.MontoTotal);
                cmd.Parameters.AddWithValue("@MontoPago", (object)venta.MontoPago ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@MontoCambio", (object)venta.MontoCambio ?? DBNull.Value);

                // Parámetro de salida
                SqlParameter retornoParam = new SqlParameter
                {
                    ParameterName = "@retorno",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(retornoParam);

                // Abrir conexión y ejecutar el comando
                cn.Open();
                cmd.ExecuteNonQuery();

                // Obtener el ID de la venta insertada
                if (retornoParam.Value != DBNull.Value)
                {
                    idVenta = Convert.ToInt32(retornoParam.Value);
                    if (idVenta <= 0)
                        throw new Exception("No se pudo obtener un ID de venta válido");
                }
                else
                {
                    throw new Exception("No se pudo obtener el ID de la venta");
                }

                return idVenta;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos al registrar la venta: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar la venta: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (cmd?.Connection?.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                cmd?.Dispose();
            }
        }


        public int InsertarDetalleVenta(entDetalleVenta detalleVenta)
        {
            SqlCommand cmd = null;
            int idDetalleVenta = 0; // Variable para almacenar el ID del detalle de venta
            try
            {
                // Conectar a la base de datos
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDetVen", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros del procedimiento almacenado
                cmd.Parameters.AddWithValue("@Descripcion", detalleVenta.Descripcion.Descripcion);
                cmd.Parameters.AddWithValue("@OventaID", detalleVenta.OventaID); // ID de la venta
                cmd.Parameters.AddWithValue("@Cantidad", detalleVenta.Cantidad); // Cantidad vendida
                cmd.Parameters.AddWithValue("@PrecioVenta", detalleVenta.PrecioVenta); // Precio de venta

                // Parámetro de retorno
                SqlParameter retornoParam = new SqlParameter("@retorno", DbType.Int32);
                retornoParam.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(retornoParam);

                // Abrir conexión y ejecutar el comando
                cn.Open();
                cmd.ExecuteNonQuery();

                // Obtener el valor retornado por el procedimiento
                idDetalleVenta = Convert.ToInt32(cmd.Parameters["@retorno"].Value);
                return idDetalleVenta;
            }
            catch (Exception e)
            {
                throw e; // Lanza la excepción hacia arriba para su manejo
            }
            finally
            {
                // Cierra la conexión en el bloque finally
                if (cmd.Connection != null) cmd.Connection.Close();
            }
        }
    }
}

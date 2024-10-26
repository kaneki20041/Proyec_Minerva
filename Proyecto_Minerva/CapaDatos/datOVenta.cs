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
        public List<entOVenta> ListarItemsPorVenta(int ventaID)
        {
            List<entOVenta> lista = new List<entOVenta>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spListarVentas", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VentaID", ventaID); // Añadimos el parámetro

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
                                    MontoPago = dr["MontoPago"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dr["MontoPago"]),
                                    FRegistroV = Convert.ToDateTime(dr["Fecha"]), // Asegúrate de que este nombre sea correcto
                                    PrendaID = dr["PrendaID"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["PrendaID"]),
                                    Descripcion = dr["DescripcionTalla"].ToString(), // Cambiado para usar el campo concatenado
                                    Cantidad = Convert.ToInt32(dr["Cantidad"]),
                                    PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                                    MontoTotal = Convert.ToDecimal(dr["MontoTotal"])
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

        public decimal ObtenerMontoTotalPorVenta(int ventaID)
        {
            decimal montoTotal = 0;
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerMontoTotal", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VentaID", ventaID);

                    try
                    {
                        cn.Open();
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            montoTotal = Convert.ToDecimal(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Ocurrió un error al obtener el monto total: " + ex.Message);
                    }
                }
            }
            return montoTotal;
        }

        public string ContarVentas()
        {
            string totalVentas = string.Empty; // Inicializa la variable
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spCountVenta", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        cn.Open();
                        // Ejecuta el lector para obtener el resultado
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            // Almacena todos los IDs de ventas en una lista
                            List<int> idsVentas = new List<int>();
                            while (dr.Read())
                            {
                                idsVentas.Add(Convert.ToInt32(dr["TotalVentas"])); // Lee el ID de venta
                            }

                            // Convierte la lista de IDs en una cadena separada por comas
                            totalVentas = string.Join(", ", idsVentas);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Ocurrió un error al contar las ventas: " + ex.Message);
                    }
                }
            }
            return totalVentas; // Retorna los IDs de ventas
        }


        public List<string> ListarUsuariosConectados()
        {
            List<string> lista = new List<string>(); // Cambia el tipo de la lista si necesitas un objeto más complejo
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spListarUsuariosConectados", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        cn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                // Supongamos que solo deseas el NombreCompleto
                                string nombreCompleto = dr["NombreCompleto"].ToString();
                                lista.Add(nombreCompleto);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Ocurrió un error al listar los usuarios conectados: " + ex.Message);
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

                // Agregar los parámetros del procedimiento almacenado
                cmd.Parameters.AddWithValue("@Documento", venta.Documento);
                cmd.Parameters.AddWithValue("@NombreCompleto", venta.NombreCompleto);
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

        public int InsertarDetalleVenta(entCarrito detalleVenta)
        {
            SqlCommand cmd = null;
            int idDetalleVenta = 0;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDetVen", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros
                cmd.Parameters.AddWithValue("@Descripcion", detalleVenta.Descripcion.Descripcion);
                cmd.Parameters.AddWithValue("@Talla", detalleVenta.Talla.Talla);
                cmd.Parameters.AddWithValue("@OventaID", detalleVenta.OventaID);
                cmd.Parameters.AddWithValue("@Cantidad", detalleVenta.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioVenta", detalleVenta.PrecioVenta);

                // Agregar parámetro de retorno (si es necesario)
                SqlParameter retornoParam = new SqlParameter("@retorno", SqlDbType.Int);
                retornoParam.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(retornoParam);

                cn.Open();
                cmd.ExecuteNonQuery();

                // Obtener el valor de retorno
                idDetalleVenta = (int)retornoParam.Value;

                return idDetalleVenta;
            }
            catch (SqlException sqlEx)
            {
                // Manejo de excepciones específicas de SQL
                throw new Exception("Error al insertar el detalle de la venta: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                // Manejo de otras excepciones
                throw new Exception("Error inesperado: " + ex.Message);
            }
            finally
            {
                cmd?.Connection?.Close();
            }
        }

    }
}

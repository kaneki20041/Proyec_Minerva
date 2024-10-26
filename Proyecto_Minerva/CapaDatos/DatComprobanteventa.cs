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
    public class DatComprobanteventa
    {
        #region Singleton
        private static readonly DatComprobanteventa _instancia = new DatComprobanteventa();
        public static DatComprobanteventa Instancia
        {
            get
            {
                return DatComprobanteventa._instancia;
            }
        }
        #endregion Singleton

        //aqui ira el metodo de la comprobante
        #region metodos
        public int RegistrarComprobantePago(entComprobanteventa comprobante)
        {
            SqlCommand cmd = null;
            int idComprobante = 0;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaComprobantePagoVenta", cn); // Asegúrate de que este sea el nombre correcto del SP
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros del procedimiento almacenado
                cmd.Parameters.AddWithValue("@IdVenta", comprobante.id_venta);
                cmd.Parameters.AddWithValue("@DescripcionTipoComprobante", comprobante.descripcion); // Descripción
                cmd.Parameters.AddWithValue("@NumeroComprobante", comprobante.numero_comprobante);
                cmd.Parameters.AddWithValue("@FechaEmision", comprobante.fecha_emision);
                cmd.Parameters.AddWithValue("@Subtotal", comprobante.subtotal);
                cmd.Parameters.AddWithValue("@IGV", comprobante.igv);
                cmd.Parameters.AddWithValue("@Total", comprobante.total);

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

                // Obtener el ID del comprobante insertado
                if (retornoParam.Value != DBNull.Value)
                {
                    idComprobante = Convert.ToInt32(retornoParam.Value);
                    if (idComprobante <= 0)
                        throw new Exception("No se pudo obtener un ID de comprobante válido");
                }
                else
                {
                    throw new Exception("No se pudo obtener el ID del comprobante");
                }

                return idComprobante;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos al registrar el comprobante de pago: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el comprobante de pago: " + ex.Message);
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


        public string GenerarNumeroComprobante(string tipoComprobante)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spGenerarNumeroComprobante", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros
                    cmd.Parameters.AddWithValue("@TipoComprobante", tipoComprobante);

                    // Parámetro de salida
                    SqlParameter nuevoNumeroParam = new SqlParameter
                    {
                        ParameterName = "@NuevoNumero",
                        SqlDbType = SqlDbType.NVarChar,
                        Size = 50,
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(nuevoNumeroParam);

                    // Abrir conexión y ejecutar el comando
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    // Retornar el número generado
                    return nuevoNumeroParam.Value.ToString();
                }
            }
        }
        #endregion Métodos
    }
}


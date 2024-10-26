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
        public List<entCompra> ListarCompras()
        {
            SqlCommand cmd = null;
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
                    //----Ped.idCliente = new entCliente();
                    //entProveedor Pro = new entProveedor();
                    //EntMetPago Met = new EntMetPago();


                    Com.idCompra = Convert.ToInt32(dr["OcompraID"]);
                    Com.fechCompra = Convert.ToDateTime(dr["FechaRegistroC"]);


                    Com.IDProveedor = Convert.ToInt32(dr["ProveedorID"]);
                    //Com.RazonSocial = dr["RazonSocial"].ToString();

                    Com.Metodopagoid = Convert.ToInt32(dr["MetodopagoID"]);
                    //Met.metodopago = dr["MetodoPago"].ToString();

                    Com.RazonSocia = dr["RazonSocial"].ToString();

                    Com.UsuID=Convert.ToInt32(dr["UsuarioID"]);
                    //Com.ID = Pro;
                    //Com.Metpagoid = Met;


                    Com.Monto = Convert.ToDecimal(dr["Monto"]);
                    lista.Add(Com);

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
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

        public int InsertarCompra(entCompra Com)
        {
            SqlCommand cmd = null;
            int idCom = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros del procedimiento almacenado
                cmd.Parameters.AddWithValue("@RUC", Com.ID.RUC); // El RUC del proveedor
                cmd.Parameters.AddWithValue("@RazonSocial", Com.RazonSocial.RazonSocial); // La razón social del proveedor
                cmd.Parameters.AddWithValue("@MetodoPagoID", Com.Metpagoid.MetPagoid); // El método de pago
                cmd.Parameters.AddWithValue("@NombreCompleto", Com.NombreCompleto.NombreCompleto); // El ID del usuario
                cmd.Parameters.AddWithValue("@FechaRegistroC", Com.fechCompra); // La fecha de registro de la compra
                cmd.Parameters.AddWithValue("@Monto", Com.Monto); // El monto de la compra

                // Parámetro de retorno
                SqlParameter m = new SqlParameter("@retorno", DbType.Int32);
                m.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(m);

                // Abrir conexión y ejecutar
                cn.Open();
                cmd.ExecuteNonQuery();

                // Obtener el valor retornado por el procedimiento almacenado
                idCom = Convert.ToInt32(cmd.Parameters["@retorno"].Value);
                return idCom;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd.Connection != null) cmd.Connection.Close();
            }
        }


        public Boolean InsertarDetCompra(entDetCompra dCom)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDetCom", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Descripcion", dCom.Prenda.Descripcion);
                cmd.Parameters.AddWithValue("@OcompraID", dCom.idCompra);
                cmd.Parameters.AddWithValue("@Cantidad", dCom.cantPrenda);
                cmd.Parameters.AddWithValue("@PrecioCompra", dCom.precPrenda);

                cn.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (SqlException sqlEx)
            {
                throw new Exception($"Error en la base de datos: {sqlEx.Message}", sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar detalle de compra: {ex.Message}", ex);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
        #endregion metodos
        }
    }
}

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
                cmd.Parameters.AddWithValue("@ProveedorID", Com.ID.ID);
                cmd.Parameters.AddWithValue("@RazonSocial", Com.RazonSocial.RazonSocial);
                cmd.Parameters.AddWithValue("@MetodoPagoID", Com.Metpagoid.MetPagoid);
                cmd.Parameters.AddWithValue("@UsuarioID", Com.UsuarioID.UsuarioID); // Asignar el ID del usuario
                cmd.Parameters.AddWithValue("@FechaRegistroC", Com.fechCompra);
                cmd.Parameters.AddWithValue("@Monto", Com.Monto);

                // Parámetro de retorno
                SqlParameter m = new SqlParameter("@retorno", DbType.Int32);
                m.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(m);

                cn.Open();
                cmd.ExecuteNonQuery();

                // Obtener el valor retornado por el procedimiento
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
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDetCom", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PrendaID", dCom.PrendaID.PrendaID);
                cmd.Parameters.AddWithValue("@Prenda", dCom.Prenda.Prenda);
                cmd.Parameters.AddWithValue("@OcompraID", dCom.idCompra);
                cmd.Parameters.AddWithValue("@Cantidad", dCom.cantPrenda);
                cmd.Parameters.AddWithValue("@PrecioCompra", dCom.precPrenda);
                //cmd.Parameters.AddWithValue("@igv", dPed. );

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { inserta = true; }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        #endregion metodos
    }
}

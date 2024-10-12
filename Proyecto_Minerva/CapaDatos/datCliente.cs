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
    public class datCliente
    {
        #region Singleton
        private static readonly datCliente _instancia = new datCliente();
        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente cli = new entCliente();
                    cli.ID = Convert.ToInt32(dr["ID"]);
                    cli.TipoDoc = dr["TipoDoc"].ToString();
                    cli.Documento = Convert.ToInt32(dr["Documento"]);
                    cli.Tipocliente = dr["TipoCliente"].ToString();
                    cli.Nombre = dr["Nombre"].ToString();
                    cli.Apellidos = dr["Apellidos"].ToString();
                    cli.FRegistro = Convert.ToDateTime(dr["F.Registro"]);
                    cli.Estado = Convert.ToBoolean(dr["Estado"]);
                    cli.Direccion = dr["Direccion"].ToString();
                    cli.Celular = dr["Celular"].ToString();
                    cli.Email = dr["Email"].ToString();
                    lista.Add(cli);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return lista;
        }

        public void InsertaCliente(entCliente cliente)
        {
            SqlCommand cmd = null;
            try
            {
                // Establecer la conexión a la base de datos
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Asignar los parámetros requeridos por el procedimiento almacenado
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                cmd.Parameters.AddWithValue("@Tipocliente", cliente.Tipocliente); // Se envía el nombre de TipoCliente
                cmd.Parameters.AddWithValue("@TipoDoc", cliente.TipoDoc); // Se envía el nombre de TipoDoc
                cmd.Parameters.AddWithValue("@Documento", cliente.Documento);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
                cmd.Parameters.AddWithValue("@FRegistro", cliente.FRegistro);
                cmd.Parameters.AddWithValue("@Estado", cliente.Estado);

                // Abrir la conexión
                cn.Open();

                // Ejecutar el comando para insertar los datos
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                throw new Exception("Error al insertar el cliente: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
        }


        public entCliente BuscarClientePorID(string documento)
        {
            SqlCommand cmd = null;
            entCliente cli = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarClientePorID", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Documento", documento); // Cambia el parámetro a documento
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cli = new entCliente
                    {
                        ID = Convert.ToInt32(dr["ID"]),
                        Nombre = dr["Nombre"].ToString(),
                        Apellidos = dr["Apellidos"].ToString(),
                        TipoDoc = dr["TipoDoc"].ToString(), // Obtener el TipoDoc
                        Documento = Convert.ToInt32(dr["Documento"]), // Cambiado a string para manejar documentos que no sean solo números
                        Direccion = dr["Direccion"].ToString(),
                        Email = dr["Email"].ToString(),
                        Celular = dr["Celular"].ToString(),
                        Estado = Convert.ToBoolean(dr["Estado"])
                    };
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return cli;
        }


        public string BuscarDocCliente(int documento)
        {
            SqlCommand cmd = null;
            string nombreCompleto = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("BuscarDocCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Documento", documento);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    nombreCompleto = dr["NombreCompleto"].ToString();
                }
            }
            catch (Exception e)
            {
                // Puedes manejar el error de manera más específica o registrar el error
                throw e;
            }
            finally
            {
                if (cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return nombreCompleto;
        }
        //public void ModificarCliente(entCliente cliente)
        //{
        //    SqlCommand cmd = null;
        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.Conectar();
        //        cmd = new SqlCommand("spModificarCliente", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.AddWithValue("@ID", cliente.ID);
        //        cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
        //        cmd.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
        //        cmd.Parameters.AddWithValue("@Tipocliente", cliente.Tipocliente);
        //        cmd.Parameters.AddWithValue("@TipoDoc", cliente.TipoDoc);
        //        cmd.Parameters.AddWithValue("@Documento", cliente.Documento);
        //        cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
        //        cmd.Parameters.AddWithValue("@Email", cliente.Email);
        //        cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
        //        cmd.Parameters.AddWithValue("@Estado", cliente.Estado);

        //        cn.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
        //        {
        //            cmd.Connection.Close();
        //        }
        //    }
        //}
        public List<string> ObtenerTiposClientes()
        {
            List<string> tiposClientes = new List<string>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spObtenerTiposClientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tiposClientes.Add(dr["TipoCliente"].ToString());
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
            return tiposClientes;
        }

        public List<string> ObtenerTiposDocumentos()
        {
            List<string> tiposDocumentos = new List<string>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spObtenerTiposDocumentos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tiposDocumentos.Add(dr["TipoDoc"].ToString());
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
            return tiposDocumentos;
        }

    }
    #endregion Metodos
}

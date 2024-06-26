﻿using CapaEntidad;
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
                    cli.Nombre = dr["Nombre"].ToString();
                    cli.Apellidos = dr["Apellidos"].ToString();
                    cli.Tipocliente = dr["Tipocliente"].ToString();
                    cli.TipoDoc = dr["TipoDoc"].ToString();
                    cli.Documento = Convert.ToInt32(dr["Documento"]);
                    cli.Direccion = dr["Direccion"].ToString();
                    cli.Email = dr["Email"].ToString();
                    cli.Celular = dr["Celular"].ToString();
                    cli.FRegistro = Convert.ToDateTime(dr["F.Registro"]);
                    cli.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(cli);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }
            return lista;
        }
        #endregion Metodos

        public void InsertaCliente(entCliente cliente)
        {
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                SqlCommand cmd = new SqlCommand("spInsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                cmd.Parameters.AddWithValue("@Tipocliente", cliente.Tipocliente);
                cmd.Parameters.AddWithValue("@TipoDoc", cliente.TipoDoc);
                cmd.Parameters.AddWithValue("@Documento", cliente.Documento);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
                cmd.Parameters.AddWithValue("@FRegistro", cliente.FRegistro);
                cmd.Parameters.AddWithValue("@Estado", cliente.Estado);

                cn.Open();
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public entCliente BuscarClientePorID(int id)
        {
            SqlCommand cmd = null;
            entCliente cli = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarClientePorID", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cli = new entCliente
                    {
                        ID = Convert.ToInt32(dr["ID"]),
                        Nombre = dr["Nombre"].ToString(),
                        Apellidos = dr["Apellidos"].ToString(),
                        Tipocliente = dr["Tipocliente"].ToString(),
                        TipoDoc = dr["TipoDoc"].ToString(),
                        Documento = Convert.ToInt32(dr["Documento"]),
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

        public void ModificarCliente(entCliente cliente)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", cliente.ID);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                cmd.Parameters.AddWithValue("@Tipocliente", cliente.Tipocliente);
                cmd.Parameters.AddWithValue("@TipoDoc", cliente.TipoDoc);
                cmd.Parameters.AddWithValue("@Documento", cliente.Documento);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
                cmd.Parameters.AddWithValue("@Estado", cliente.Estado);

                cn.Open();
                cmd.ExecuteNonQuery();
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
        }
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
}

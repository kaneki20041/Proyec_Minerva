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
    public class datCategoria
    {
        #region Singleton
        private static readonly datCategoria _instancia = new datCategoria();
        public static datCategoria Instancia
        {
            get
            {
                return datCategoria._instancia;
            }
        }
        #endregion Singleton

        #region metodos
        public List<entCategoria> ListaCategoria()
        {
            SqlCommand cmd = null;
            List<entCategoria> lista = new List<entCategoria>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("splistarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCategoria gato = new entCategoria();
                    gato.idactegoria = Convert.ToInt32(dr["CategoriaID"]);
                    gato.descripcion = dr["Categoria"].ToString();
                    gato.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(gato);
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

        public void InsertaCat(entCategoria cat)
            {
                try
                {
                    SqlConnection cn = Conexion.Instancia.Conectar();
                    SqlCommand cmd = new SqlCommand("spAgregarCategoria", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@descripcion", cat.descripcion);
                    cmd.Parameters.AddWithValue("@estado", cat.estado);

                    cn.Open();
                    cmd.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    throw ex;

                }
            }
        }

        #endregion metodos
}
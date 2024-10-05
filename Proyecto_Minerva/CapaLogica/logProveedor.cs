using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProveedor
    {
        #region sigleton
        private static readonly logProveedor _instancia = new logProveedor();
        public static logProveedor Instancia
        {
            get
            {
                return logProveedor._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entProveedor> ListarProveedor()
        {
            //return datCliente.Instancia.ListarCliente();
            return datProveedor.Instancia.ListarProveedor();
        }

        ///inserta <summary>
        /// inserta
        /// </summary>
        /// <param name="prov"></param>
        /// 

        public List<string> ObtenerCiudad()
        {
            return datProveedor.Instancia.ObtenerCiudad();
        }

        public List<string> ObtenerRubro()
        {
            return datProveedor.Instancia.ObtenerRubro();
        }

        public void InsertaProveedor(entProveedor prov)
        {
            datProveedor.Instancia.InsertaProveedor(prov);
        }

        public entProveedor BuscarProveedorPorID(int id)
        {
            return datProveedor.Instancia.BuscarProveedorPorID(id);
        }
        public entUbigeo BuscarUbigeo(string codigoUbigeo)
        {
            return datProveedor.Instancia.BuscarUbigeo(codigoUbigeo);
        }

        public void ModificarProveedor(entProveedor prov)
        {
            datProveedor.Instancia.ModificarProveedor(prov);
        }
        public void InhabilitarProveedor(int id)
        {
            datProveedor.Instancia.InhabilitarProveedor(id);
        }

        #endregion metodos
    }
}

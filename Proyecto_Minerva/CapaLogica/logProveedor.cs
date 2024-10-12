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
            return datProveedor.Instancia.ListarProveedor();
        }

        ///inserta <summary>
        /// inserta
        /// </summary>
        /// <param name="prov"></param>
        /// 


        public List<string> ObtenerRubro()
        {
            return datProveedor.Instancia.ObtenerRubro();
        }

        public void InsertaProveedor(entProveedor prov)
        {
            datProveedor.Instancia.InsertaProveedor(prov);
        }

        public entProveedor BuscarProveedorPorRUC(string ruc)
        {
            return datProveedor.Instancia.BuscarProveedorPorRUC(ruc);
        }
        //public entProveedor BuscarProveedorPorNombre(string nombre)
        //{
        //    return datProveedor.Instancia.BuscarProveedorPorNombre(nombre);
        //}
        public entUbigeo BuscarUbigeo(string codigoUbigeo)
        {
            return datProveedor.Instancia.BuscarUbigeo(codigoUbigeo);
        }

        //public void ModificarProveedor(entProveedor prov)
        //{
        //    datProveedor.Instancia.ModificarProveedor(prov);
        //}
        //public void InhabilitarProveedor(string ruc)
        //{
        //    datProveedor.Instancia.InhabilitarProveedor(ruc);
        //}

        #endregion metodos
    }
}

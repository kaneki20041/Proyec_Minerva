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

        ///inserta
        public void InsertaProveedor(entProveedor prov)
        {
            datProveedor.Instancia.InsertaProveedor(prov);
        }

        public entProveedor BuscarProveedorPorID(int id)
        {
            return datProveedor.Instancia.BuscarProveedorPorID(id);
        }

        public void ModificarProveedor(entProveedor prov)
        {
            datProveedor.Instancia.ModificarProveedor(prov);
        }

        #endregion metodos
    }
}

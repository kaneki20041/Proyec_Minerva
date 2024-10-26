using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCompra
    {
        #region Singleton
        private static readonly logCompra _instancia = new logCompra();
        public static logCompra Instancia
        {
            get
            {
                return logCompra._instancia;
            }
        }
        #endregion Singleton
        #region metodos
        public List<entCompra> ListarCompra()
        {
            try
            {
                return datCompra.Instancia.ListarCompras();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<string> ListarUsuariosConectados()
        {
            return datOVenta.Instancia.ListarUsuariosConectados();
        }
        public int InsertarCompra(entCompra Com)
        {
            int a;
            try
            {
                a = datCompra.Instancia.InsertarCompra(Com);
            }
            catch (Exception e)
            { throw e; }

            return a;
        }
        public void InsertarDetCompra(entDetCompra dCom)
        {
            try
            {
                datCompra.Instancia.InsertarDetCompra(dCom);
            }
            catch (Exception e)
            { throw e; }
        }
        #endregion metodos
    }
}

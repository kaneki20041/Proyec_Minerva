using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCompras
    {
        #region Singleton
        private static readonly logCompras _instancia = new logCompras();
        public static logCompras Instancia
        {
            get
            {
                return logCompras._instancia;
            }
        }
        #endregion Singleton
        #region metodos
        public List<entCompra> ListarCompra()
        {
            try
            {
                return datCompra.Instancia.ListaCompra();
            }
            catch (Exception) { throw; }
        }
        public int InsertarCompra(entCompra Com)
        {
            int a;
            try
            {
                a = datCompra.Instancia.InsertaCompra(Com);
            }
            catch (Exception) { throw; }

            return a;
        }
        public void InsertarDetCompra(entDetCom dCom)
        {
            try
            {
                datCompra.Instancia.InsertarDetCom(dCom);
            }
            catch (Exception) { throw; }
        }


        #endregion metodos
    }
}

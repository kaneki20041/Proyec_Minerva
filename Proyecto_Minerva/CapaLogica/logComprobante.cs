using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logComprobante
    {
        #region sigleton
        private static readonly logComprobante _instancia = new logComprobante();
        public static logComprobante Instancia
        {
            get
            {
                return logComprobante._instancia;
            }
        }
        #endregion singleton

        public List<string> ObtenerComprobante()
        {
            return datComprobante.Instancia.ObtenerTiposComprobante();
        }
    }
}

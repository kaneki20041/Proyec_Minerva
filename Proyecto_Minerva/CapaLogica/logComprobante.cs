using CapaDatos;
using CapaEntidad;
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

        public int RegistrarComprobantePago(entComprobanteventa comprobante)
        {
            return DatComprobanteventa.Instancia.RegistrarComprobantePago(comprobante); // Llama al método de la capa de datos
        }

        public string GenerarNumeroComprobante(string tipoComprobante)
        {
            // Llama al método de la capa de datos para generar el número de comprobante
            return DatComprobanteventa.Instancia.GenerarNumeroComprobante(tipoComprobante);
        }


    }
}

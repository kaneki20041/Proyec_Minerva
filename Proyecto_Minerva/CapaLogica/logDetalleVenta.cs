using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logDetalleVenta
    {
        // Singleton
        private static readonly logDetalleVenta instancia = new logDetalleVenta();
        public static logDetalleVenta Instancia
        {
            get { return instancia; }
        }

        public List<entDetalleVenta> ListarDetalleVenta(int oventaID)
        {
            return datDetalleVenta.Instancia.ListarDetalleVenta(oventaID);
        }
    }
}

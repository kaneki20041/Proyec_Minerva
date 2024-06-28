using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logOVenta
    {
        // Singleton
        private static readonly logOVenta instancia = new logOVenta();
        public static logOVenta Instancia
        {
            get { return instancia; }
        }

        // Método para obtener todas las ventas
        public List<entOVenta> ListarVentas()
        {
            return datOVenta.Instancia.ListarVentas();
        }
        public void RegistrarVenta(entOVenta venta)
        {
            datOVenta.Instancia.RegistrarVenta(venta);
        }

    }
}

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

        public int RegistrarVenta(entOVenta venta)
        {
            if (venta == null)
            {
                throw new ArgumentNullException(nameof(venta), "La venta no puede ser nula.");
            }

            // Llamar al método de la capa de datos para registrar la venta
            int idVenta = datOVenta.Instancia.RegistrarVenta(venta);
            return idVenta;
        }

        public int InsertarDetalleVenta(entDetalleVenta detalleVenta)
        {
            // Validar el detalle de venta aquí si es necesario
            if (detalleVenta == null)
            {
                throw new ArgumentNullException(nameof(detalleVenta), "El detalle de venta no puede ser nulo.");
            }

            // Llamar al método de la capa de datos para insertar el detalle de venta
            int idDetalleVenta = datOVenta.Instancia.InsertarDetalleVenta(detalleVenta);
            return idDetalleVenta;
        }
    }
}

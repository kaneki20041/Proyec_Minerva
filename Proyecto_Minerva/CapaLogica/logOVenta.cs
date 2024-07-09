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

        public void RegistrarDetalleVenta(entOVenta detalleVenta)
        {
            datOVenta.Instancia.RegistrarDetalleVenta(detalleVenta);
        }

        public void ActualizarStock(string prenda, int cantidadVendida)
        {
            datPrendas.Instancia.ActualizarStock(prenda, cantidadVendida);
        }

        public void EliminarVenta(int oventaID)
        {
            datOVenta.Instancia.EliminarVenta(oventaID);
        }

        public int GenerarDetalleVentaID()
        {
            // Implementa la lógica para generar un ID único
            return datOVenta.Instancia.ObtenerNuevoDetalleVentaID();
        }

    }
}

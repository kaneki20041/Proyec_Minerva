using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOVenta
    {
        public int OventaID { get; set; }

        public string NombreCliente { get; set; } // Nombre del cliente
        public string Vendedor { get; set; } // Nombre completo del usuario
        public string MetodoPago { get; set; }
        public decimal? MontoPago { get; set; } // Monto pagado
        public decimal? MontoCambio { get; set; } // Monto de cambio
        public decimal Precioventa { get; set; } // Precio de venta
        public DateTime FRegistroV { get; set; } // Fecha de registro
    }
}

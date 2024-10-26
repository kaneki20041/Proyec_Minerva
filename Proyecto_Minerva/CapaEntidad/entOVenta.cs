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
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreCliente { get; set; }
        public decimal? MontoPago { get; set; }
        public decimal? MontoCambio { get; set; }
        public DateTime FRegistroV { get; set; }
        public int? PrendaID { get; set; } // Agregado
        public string Descripcion { get; set; } // Agregado
        public int Cantidad { get; set; } // Agregado
        public decimal PrecioVenta { get; set; } // Agregado
        public decimal MontoTotal { get; set; }
    }
}
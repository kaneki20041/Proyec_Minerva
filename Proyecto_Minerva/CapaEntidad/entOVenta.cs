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
        public entCliente ClienteID { get; set; }
        public entUsuario UsuarioID { get; set; }
        public string NombreCliente { get; set; }
        public string Vendedor { get; set; }
        public string MetodoPago { get; set; }
        public decimal? MontoPago { get; set; }
        public decimal? MontoCambio { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal Precioventa { get; set; }
        public DateTime FRegistroV { get; set; }
    }
}

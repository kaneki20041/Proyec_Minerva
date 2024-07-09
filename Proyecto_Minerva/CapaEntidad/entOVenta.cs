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
        public string Nombre { get; set; }
        public string Prenda { get; set; }
        public string Talla { get; set; }
        public decimal Precioventa { get; set; }
        public int? Cantidad { get; set; }
        public string MetodoPago { get; set; }
        public decimal? Monto { get; set; }
        public DateTime FRegistroV { get; set; }
        public string Colegio { get; set; }
        public string Categoria { get; set; }
        public string TipoComprobante { get; set; }
    }
}

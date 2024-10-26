using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entComprobanteventa
    {
        public int id_comprobante_venta { get; set; }
        public int id_venta { get; set; }
        public int id_tipo_comprobante { get; set; }
        
        public String descripcion { get; set; }
        public String numero_comprobante { get; set; }
        
        public DateTime fecha_emision { get; set; }
        public decimal subtotal { get; set; }
        public decimal igv { get; set; }
        public decimal total { get; set; }
    }
}

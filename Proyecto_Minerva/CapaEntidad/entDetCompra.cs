using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetCompra
    {
        public int idDetCompra { get; set; }
        public int idCompra { get; set; }
        public int cantPrenda { get; set; }
        public Decimal precPrenda { get; set; }
        public entPrendas PrendaID {  get; set; }
        public entPrendas Prenda { get; set; }

    }
}

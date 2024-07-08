using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetCom
    {
        public int DetallecompraID { get; set; }
        public int idCompra { get; set; }
        public int cantPren { get; set; }
        public Decimal precPren { get; set; }
        public entPrendas? PrendaID { get; set; }
}
}

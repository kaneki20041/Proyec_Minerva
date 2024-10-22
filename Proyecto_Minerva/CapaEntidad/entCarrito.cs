using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
        public class entCarrito
        {
            public int OventaID { get; set; }
            public int? Cantidad { get; set; }
            
            public entPrendas Descripcion { get; set; }

            public entPrendas Talla { get; set; }
            public decimal PrecioVenta { get; set; }
    }
    

}

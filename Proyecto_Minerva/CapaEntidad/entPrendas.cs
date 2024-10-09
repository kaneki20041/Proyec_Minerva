using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPrendas
    {
        public int PrendaID { get; set; }
        //public string Prenda { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; } // Nueva propiedad
        public string Talla { get; set; } // Nueva propiedad
        public string Colegio { get; set; } // Nueva propiedad
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public bool Estado { get; set; }
    }

}

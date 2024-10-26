using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPermisos
    {   
        public int idPermiso {  get; set; }
        public int idRol { get; set; }
        public string NombreMenu { get; set; }
        public string FechaCreacion {  get; set; }
    }
}

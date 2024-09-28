using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPermisos
    {
        public int PermisosID {  get; set; }
        public entRol objRol { get; set; }
        public string NombreMenu { get; set; }

        public string FechaRegistro {  get; set; }
    }
}

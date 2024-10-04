using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entUsuario
    {
        public int UsuarioID {  get; set; }
        public int Documento {  get; set; }
        public entRol objRol { get; set; }
        public string NombreCompleto { get; set; }
        public bool Estado { get; set; }
        public string Clave { get; set; }
        public string FechaRegistro { get; set; }
        public string Correo { get; set; }

    }
}

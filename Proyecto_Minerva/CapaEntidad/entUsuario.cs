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
        public int idRol { get; set; }
        public string NombreCompleto { get; set; }
        public bool Estado { get; set; }
        public string Clave { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Correo { get; set; }

        public bool EstaConectado { get; set; }
        public DateTime UltimaActividad { get; set; }

        public string Usuario {  get; set; }
    }

    public class entdescUsuario
    {
        public int UsuarioID { get; set; }
        public int Documento { get; set; }
        public string descripcion { get; set; }
        public string NombreCompleto { get; set; }
        public bool Estado { get; set; }
        public string Clave { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Correo { get; set; }
        public string Usuario { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
        public class entCliente
        {
            public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        //public int TipoDocID { get; set; }
        public string Tipocliente { get; set; }
            public string TipoDoc { get; set; }
            public int Documento { get; set; }
            public string Direccion { get; set; }
            public string Email { get; set; }
            public string Celular { get; set; }
            public DateTime FRegistro { get; set; }
            public bool Estado { get; set; }

        }
}


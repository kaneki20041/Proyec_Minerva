﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProveedor
    {
        public int ID { get; set; }
        public string NomPro { get; set; }
        public int RUC { get; set; }
        public string Ciudad { get; set; }
        public string Rubro { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }     
        public string Email { get; set; }
        public Boolean Estado { get; set; }
    }
}

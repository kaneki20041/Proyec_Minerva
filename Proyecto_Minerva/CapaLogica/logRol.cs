using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logRol
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logRol _instancia = new logRol();
        //privado para evitar la instanciación directa
        public static logRol Instancia
        {
            get
            {
                return logRol._instancia;
            }
        }

        #endregion singleton

        #region metodos

        public List<entRol> ListarRol()
        {
            return datRol.Instancia.ListarRol();

        }

        #endregion metodos
    }
}

using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logUsuario
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logUsuario _instancia = new logUsuario();
        //privado para evitar la instanciación directa
        public static logUsuario Instancia
        {
            get
            {
                return logUsuario._instancia;
            }
        }

        #endregion singleton


        #region metodos


        public List<entUsuario> ListarUsuario()
        {
            //return datCliente.Instancia.ListarCliente();
            return datUsuario.Instancia.ListarUsuario();
        }


        /*public entUsuario login(string username, string password)
        {
            return datUsuario.Instancia.IngresoUsuario(username, password);
        }


        public List<entUsuario> ListarUsuario()
        {
            try
            {
                return datUsuario.Instancia.ListarUsuario();
            }
            catch (Exception e)
            {
                throw e;
            }

        }*/

        #endregion metodos
    }
}
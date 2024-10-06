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
        public bool ActualizarEstadoConexion(int documento, bool estaConectado)
        {
            return new datUsuario().ActualizarEstadoConexion(documento, estaConectado, DateTime.Now);
        }


        public List<entUsuario> ListarValidarUsuario()
        {
            //return datCliente.Instancia.ListarCliente();
            return datUsuario.Instancia.ListarValidacionUsuario();
        }
        public List<entdescUsuario> ListarUsuario()
        {
            //return datCliente.Instancia.ListarCliente();
            return datUsuario.Instancia.ListarUsuario();

        }

        public void InsertarUsuarios(entUsuario Use)
        {
            datUsuario.Instancia.InsertarUsuario(Use);
        }

        public void ModificarUsuario(entUsuario user)
        {
            datUsuario.Instancia.ModificarUsuario(user);
        }

        public void DeshabilitarUsuarios(entUsuario user)
        {
            datUsuario.Instancia.DeshabilitarUsuarios(user);
        }

        public List<entUsuario> BuscarUsuarios(entUsuario usuario)
        {
            int? Documento = usuario.Documento;
            string NombreCompleto = usuario.NombreCompleto;
            int? RolID = usuario.idRol;
            bool? Estado = usuario.Estado;

            return datUsuario.Instancia.BuscarUsuarios(Documento, NombreCompleto, RolID, Estado);
        }

        #endregion metodos
    }
}
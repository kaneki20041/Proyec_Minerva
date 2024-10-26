using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logPermisos
    {
        #region Singleton
        private static logPermisos _instancia = null;
        private datPermisos _datPermisos;

        public logPermisos()
        {
            _datPermisos = datPermisos.Instancia;
        }

        public static logPermisos Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new logPermisos();
                }
                return _instancia;
            }
        }
        #endregion Singleton

        #region metodos


        public List<entPermisos> ListarPermisos(int usuarioID)
        {
            if (usuarioID <= 0)
            {
                throw new ArgumentException("ID de usuario no válido");
            }

            try
            {
                return _datPermisos.ListarPermisos(usuarioID);
            }
            catch (Exception ex)
            {
                // Aquí puedes agregar logging si lo deseas
                throw new Exception($"Error al listar permisos: {ex.Message}", ex);
            }
        }
        #endregion metodos
    }
}

using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCat
    {
        #region Singleton
        private static readonly logCat _instancia = new logCat();
        public static logCat Instancia
        {
            get
            {
                return logCat._instancia;
            }
        }
        #endregion Singleton
        #region Metodos

        /// Listado
        public List<entCategoria> ListaCategoria()
        {
            return datCategoria.Instancia.ListaCategoria();
        }
        public void InsertaCat(entCategoria gato)
        {
            datCategoria.Instancia.InsertaCat(gato);
        }

        #endregion Metodos
    }
}

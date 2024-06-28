using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMetPago
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logMetPago _instancia = new logMetPago();
        //privado para evitar la instanciación directa
        public static logMetPago Instancia
        {
            get
            {
                return logMetPago._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ///listado

        public List<EntMetPago> ListarMetPago()
        {
            return datMetPago.Instancia.ListarMetPago();
        }
        public void InsertaMetpago(EntMetPago Met)
        {
            datMetPago.Instancia.InsertaMetpago(Met);
        }
        //edita
        public void EditaMetPago(EntMetPago Met)
        {
            datMetPago.Instancia.EditarMetPago(Met);
        }
        public void DeshabilitaMetPago(EntMetPago Met)
        {
            datMetPago.Instancia.DeshabilitarMetpago(Met);
        }
        #endregion metodos
    }
    }

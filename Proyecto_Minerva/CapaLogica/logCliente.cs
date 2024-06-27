﻿using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logCliente
    {
        #region Singleton
        private static readonly logCliente _instancia = new logCliente();
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        #endregion Singleton

        #region Metodos

        /// Listado
        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }
        #endregion Metodos

        public void InsertaCliente(entCliente cli)
        {
            datCliente.Instancia.InsertaCliente(cli);
        }
        public void ModificarCliente(entCliente cliente)
        {
            datCliente.Instancia.ModificarCliente(cliente);
        }

        public entCliente BuscarClientePorID(int id)
        {
            return datCliente.Instancia.BuscarClientePorID(id);
        }

    }
}
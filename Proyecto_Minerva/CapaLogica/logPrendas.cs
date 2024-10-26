using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logPrendas
    {
        #region Singleton
        private static readonly logPrendas _instancia = new logPrendas();
        public static logPrendas Instancia
        {
            get
            {
                return logPrendas._instancia;
            }
        }
        #endregion Singleton
        public List<string> ObtenerCategorias()
        {
            return datPrendas.Instancia.ObtenerCategorias();
        }

        public List<string> ObtenerColegios()
        {
            return datPrendas.Instancia.ObtenerColegios();
        }

        public List<string> ObtenerTallas()
        {
            return datPrendas.Instancia.ObtenerTallas();
        }

        public List<entPrendas> ListarPrendas()
        {
            return datPrendas.Instancia.ListarPrendas();
        }
        public void InsertarPrenda(entPrendas prenda)
        {
            datPrendas.Instancia.InsertarPrenda(prenda);
        }

        public void ModificarPrenda(entPrendas prenda)
        {
            datPrendas.Instancia.ModificarPrenda(prenda);
        }

        //public entPrendas BuscarPrendaPorID(int prendaID)
        //{
        //    return datPrendas.Instancia.BuscarPrendaPorID(prendaID);
        //}

        public entPrendas BuscarPrendaPorDescripcion(string descripcion)
        {
            return datPrendas.Instancia.BuscarPrendaPorDescripcion(descripcion);
        }

        public void ActualizarStock(string prenda, int cantidadVendida)
        {
            datPrendas.Instancia.ActualizarStock(prenda, cantidadVendida);
        }

        public void ModificarPrecioUnidad(int prendaID, decimal nuevoPrecio)
        {
            try
            {
                datPrendas datos = new datPrendas();
                datos.ModificarPrecioUnidad(prendaID, nuevoPrecio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

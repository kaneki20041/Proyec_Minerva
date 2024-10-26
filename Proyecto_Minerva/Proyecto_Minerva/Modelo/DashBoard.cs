using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Modelo
{
    public class DashBoard : CapaDatos.Conexion
    {
        public struct FechaIngresos
        {
            public string Fecha { get; set; }
            public decimal CantidadTotal { get; set; }
        }

        private DateTime FechaInicio;
        private DateTime FechaFinal;
        private int numeroDias;

        public int NumeroClientes { get; private set; }
        public int NumeroProveedores { get; private set; }
        public int NumeroPrenda { get; private set; }

        public List<KeyValuePair<string, int>> ListaProductosDestacados { get; private set; }
        public List<KeyValuePair<string, int>> ListaStock { get; private set; }
        public List<KeyValuePair<string, int>> ListaIngresos { get; private set; }
        public int NumeroCompras { get; set; }
        public decimal TotalGanancia { get; set; }
        public decimal TotalBeneficio { get; set; }

        public DashBoard()
        {

        }

        private void ObtenerTotal()
        {
            using (var connection = Conexion.Instancia.Conectar())
            {
                connection.Open();               
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    //Numero total de Clientes
                    command.CommandText = "select COUNT(ID) from Cliente";
                    NumeroClientes = (int)command.ExecuteScalar();

                    //Numero Total de Proveedores
                    command.CommandText = "select COUNT(ID) from Proveedor";
                    NumeroProveedores = (int)command.ExecuteScalar();

                    //Numero Total de Prendas
                    command.CommandText = "select COUNT(PrendaID) from Prenda";
                    NumeroPrenda = (int)command.ExecuteScalar();

                    //Numero total de Compras
                    command.CommandText = "select* from [Ocompra] where FechaRegistroC between"+
                              "'2020 - 01 - 01 00:00:00.000' and '2026 - 01 - 01 00:00:00.000'";
                    command.Parameters.Add("@fromdate", System.Data.SqlDbType.DateTime).Value = FechaInicio;
                    NumeroCompras = (int)command.ExecuteScalar();
                }
            }
        } 
    }
}

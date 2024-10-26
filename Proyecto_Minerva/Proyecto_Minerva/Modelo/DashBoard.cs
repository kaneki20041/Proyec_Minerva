using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Modelo
{
    public class DashBoard : CapaDatos.Conexion
    {
        public struct RevenueByDate
        {
            public string Fecha { get; set; }
            public decimal CantidadTotal { get; set; }
        }

        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumeroClientes { get; private set; }
        public int NumeroProveedores { get; private set; }
        public int NumeroPrenda { get; private set; }

        public List<KeyValuePair<string, int>> TopPrendasList { get; private set; }
        public List<KeyValuePair<string, int>> UnderstockList { get; private set; }
        public List<RevenueByDate> GrossRevenueList {  get; private set; }
        public int numOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }

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
                    command.CommandText = @"SELECT COUNT(O.venta) FROM[O.venta]"+
                               "WHERE Fecha BETWEEN @fromDate AND @toDate";
                    command.Parameters.Add("@fromdate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    numOrders = (int)command.ExecuteScalar();
                }
            }
        }

        private void ObtenerRendimientoVentas()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;

            using (var connection = Conexion.Instancia.Conectar())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select Fecha, sum(MontoTotal)" +
                                          "from [O.venta]" +
                                          "where Fecha BETWEEN @fromDate AND @toDategroup" +
                                          "by Fecha";
                    command.Parameters.Add("@fromdate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime,decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(
                            new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1])
                            );
                        TotalRevenue += (decimal)reader[0];
                    }
                    TotalProfit = TotalRevenue * 0.2m;//20%
                    reader.Close();

                    //Agrupar por dias
                    if(numberDays <= 30)
                    {
                        foreach(var item in resultTable)
                        {
                            GrossRevenueList.Add(new RevenueByDate()
                            {
                                Fecha = item.Key.ToString("dd MMM"),
                                CantidadTotal = item.Value
                            });
                        }
                    }

                    //Agrupar por semana
                    else if(numberDays <= 92)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                          into order
                                            select new RevenueByDate
                                            {
                                                Fecha = "Week" + order.Key.ToString(),
                                                CantidadTotal = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }


                    //Agrupar por meses
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MM yyyy")
                                          into order
                                            select new RevenueByDate
                                            {
                                                Fecha = isYear? order.Key.Substring(0, order.Key.IndexOf(" ")): order.Key,
                                                CantidadTotal = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Agrupar por años

                    else 
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("yyyy")
                                          into order
                                            select new RevenueByDate
                                            {
                                                Fecha = order.Key,
                                                CantidadTotal = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                }
            }
        }

        private void RendimientodeProductos()
        {
            TopPrendasList = new List<KeyValuePair<string, int>>();
            UnderstockList = new List<KeyValuePair<string, int>>();

            using (var connection = Conexion.Instancia.Conectar())
            {
                SqlDataReader reader;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select top 5 p.Descripcion, sum(Detalleventa.Cantidad) as Q"+
                                "from Detalleventa"+
                                "inner join Prenda p on p.PrendaID = Detalleventa.PrendaID"+
                                "inner join [O.venta] o on o.[O.ventaID] = Detalleventa.[O.ventaID]"+
                                "where Fecha between @fromDate and @toDate"+
                                "group by p.Descripcion"+
                                "order by q desc";
                    command.Parameters.Add("@fromdate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        TopPrendasList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    //Obtener productos bajos de stock
                    command.CommandText = @"select Descripcion, Stock" +
                                          "from Prenda" +
                                          "where stock <= 30";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UnderstockList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));                    
                    }
                    reader.Close();
                }
            }
        }


        //Metodos Publicos

        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                ObtenerTotal();
                ObtenerRendimientoVentas();
                RendimientodeProductos();
                Console.WriteLine("Recargue los datos: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Datos no actualizados, misma consulta: {0} - {1}", startDate.ToString(),endDate.ToString());
                return false;
            }
  
        }
    }
}
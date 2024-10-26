using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class Conexion
    {
        //patron de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source= DESKTOP-B1DGGC8\\SQLEXPRESS; Initial Catalog = test3;" +//"User ID=sa; Password=123";
                                "Integrated Security=true";

            return cn;
        }
    }
}
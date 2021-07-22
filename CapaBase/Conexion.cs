using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace CapaBase
{
   public class Conexion
    {
        public string Cadena = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PAU.mdf;Integrated Security=True";//"Data Source=DESKTOP-HK8GGIP\\SQLEXPRESS; Initial Catalog=PAU;Integrated Security=true";
        public SqlConnection conectar = new SqlConnection();
        public Conexion() 
        {
            conectar.ConnectionString = Cadena;
        }
        public void abrir()
        {
            try
            {
                conectar.Open();
                MessageBox.Show("Conexion establecida");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexion", ex.Message);
            }
        }

        public void cerrar()
        {
            conectar.Close();
        }
    }
}

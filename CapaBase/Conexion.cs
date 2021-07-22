using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaBase
{
    public class Conexion
    {
        public string Cadena = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PAU.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlConnection Conectar =  new();

        public Conexion() 
        {
            Conectar.ConnectionString = Cadena;
        }

        public void Abrir()
        {
            try
            {
                Conectar.Open();
                Console.WriteLine("Conexion exitosa a la base de datos PAU");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexion", ex.Message);
            }
        }

        public void Cerrar()
        {
            try
            {
                Conectar.Close();

            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}

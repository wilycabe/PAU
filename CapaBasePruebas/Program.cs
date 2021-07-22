using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBase;

namespace CapaBasePruebas
{
    internal class Program
    {
        private static void FormatearaConsola()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Consola de pruebas de la capa de Base de datos");
        }

        private static void Main(string[] args)
        {
            FormatearaConsola();
            var conexion = new Conexion();
            conexion.Abrir();
            Console.ReadKey(); // para que no se cierre la consola al terminar
        }
    }
}

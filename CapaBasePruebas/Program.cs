using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.ReadKey(); // para que no se cierre la consola al terminar
        }
    }
}

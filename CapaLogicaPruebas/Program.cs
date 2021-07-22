using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaPruebas
{
    internal class Program
    {
        private static void FormatearaConsola()
        {
            Console.WriteLine("Cosola de pruebas la Capa logica");
        }

        private static void Main(string[] args)
        {
            FormatearaConsola();

            Console.ReadKey(); // para que no se cierre la consola al terminar
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBase;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Conexion conexion = new Conexion();
            conexion.abrir();
        }
    }
}

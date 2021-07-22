using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica.Personas;
using CapaLogica.Objetos;
using Operaciones = CapaLogica.Objetos.Operaciones;

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
            var operaciones = new Operaciones();
            operaciones.ConectarBaseDatos();
            Console.WriteLine(CapaLogica.Objetos.Operaciones.ValidadUsuarioContrasena("Usuario1", "contraseña1") ? "Si existe" : "No existe");
            Console.ReadKey(); // para que no se cierre la consola al terminar
        }
    }
}

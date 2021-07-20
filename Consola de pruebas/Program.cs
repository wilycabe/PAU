using System;
using CapaLogica.Objetos;
using CapaLogica.Personas;

namespace Consola_de_pruebas
{
    internal class Program
    {

        private static void Main()
        {
            Cliente cliente = new Cliente();
            
            Usuario usuario = new Usuario();
            Destinatario destinatario = new Destinatario();
            Chofer chofer = new Chofer();

            if (Vehiculo.ValidarPlaca("sda2933"))
            {
                Console.WriteLine("Si");
            }
        }

    }
}

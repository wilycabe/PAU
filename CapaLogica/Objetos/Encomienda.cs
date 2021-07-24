using System;
using System.Globalization;

namespace CapaLogica.Objetos
{
    public class Encomienda
    {

        public string Codigo { get; set; }
        public double Peso { get; set; }
        public string Descripcion { get; set; }
        public string FechaEnvio { get; set; }
        public string CodigoPostal { get; set; }
        public string CiudadEnvio { get; set; }
        public string CiudadLlegada { get; set; }
        public double ValorEncomienda { get; set; }
        public string CedulaCliente { get; set; }
        public string CedulaDestinatario { get; set; }
        public string DireccionEnvio { get; set; }
        public string DireccionLlegada { get; set; }
        public string CedulaChofer { get; set; }

        public string Dimensiones { get; set; }

        public Encomienda()
        {
            Codigo = string.Empty;
            Peso = 0;
            Descripcion = string.Empty;
            FechaEnvio = string.Empty;
            CodigoPostal = string.Empty;
            CiudadEnvio = string.Empty;
            DireccionEnvio = string.Empty;
            CiudadLlegada = string.Empty;
            DireccionLlegada = string.Empty;
            ValorEncomienda = 0;
            CedulaCliente = string.Empty;
            CedulaDestinatario = string.Empty;
            CedulaChofer = string.Empty;
            Dimensiones = string.Empty;
        }

        public Encomienda(string codigo, double peso, string descripcion, string fechaEnvio, string codigoPostal, string ciudadEnvio, string direccionEnvio, string ciudadLlegada, string direccionLlegada, double valorEncomienda, string cedulaCliente, string cedulaDestinatario, string cedulaChofer, string dimensiones)
        {
            Codigo = codigo;
            Peso = peso;
            Descripcion = descripcion;
            FechaEnvio = fechaEnvio;
            CodigoPostal = codigoPostal;
            CiudadEnvio = ciudadEnvio;
            DireccionEnvio = direccionEnvio;
            CiudadLlegada = ciudadLlegada;
            DireccionLlegada = direccionLlegada;
            ValorEncomienda = valorEncomienda;
            CedulaCliente = cedulaCliente;
            CedulaDestinatario = cedulaDestinatario;
            CedulaChofer = cedulaChofer;
            Dimensiones = dimensiones;
        }

        public static bool VerificarDimensiones(string cadena)
        {
            var dimenesion = cadena.ToUpper().Split('X');
            if (dimenesion.Length is < 2 or > 3)
            {
                return false;
            }
            try
            {
                return int.TryParse(dimenesion[0], out _) && int.TryParse(dimenesion[1], out _) && int.TryParse(dimenesion[2], out _);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool VerificarPeso(double peso)
        {
            return true;
        }

        public static bool VerificarFechaEnvio(string fecha)
        {
            var date = DateTime.Parse(fecha);
            return date.DayOfYear > DateTime.Now.DayOfYear;
        }
    }
}

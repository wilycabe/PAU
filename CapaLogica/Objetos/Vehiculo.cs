using System;
using System.Security.Authentication;
using System.Text.RegularExpressions;

namespace CapaLogica.Objetos
{
    public class Vehiculo
    {

        public string CedulaChofer { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public string Modelo { get; set; }
        public int Agno { get; set; }

        public Vehiculo()
        {
            CedulaChofer = string.Empty;
            Placa = string.Empty;
            Marca = string.Empty;
            Color = string.Empty;
        }

        public Vehiculo(string cedulaChofer, string placa, string marca, string color)
        {
            CedulaChofer = cedulaChofer;
            Placa = placa;
            Marca = marca;
            Color = color;
        }

        public static bool ValidarPlaca(string placa)
        {
            if (placa.Length is not (6 or 7)) throw new ArgumentOutOfRangeException(nameof(placa));
            var letras = placa.Substring(0, 3).ToUpper();
            var numeros = placa.Remove(0, 3);
            if (!Regex.IsMatch(letras, "^[A-Z]+$")) throw new ArgumentException(nameof(placa));
            if (!Regex.IsMatch(numeros, "^[0-9]+$")) throw new ArgumentException(nameof(placa));
            if (letras[1] == 'E' || letras[1] == 'X' || letras[1] == 'M') throw new AuthenticationException(nameof(placa));
            return true;
        }

    }
}

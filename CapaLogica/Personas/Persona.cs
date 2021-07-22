using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CapaLogica.Personas
{
    /// <summary>
    /// repesenta un objeto persona
    /// </summary>
    public class Persona
    {

        /// <summary>
        /// Asigna o retorna la cedula de la persona
        /// </summary>
        protected string Cedula { get;  set; }

        /// <summary>
        /// Asigna o retorna el nombre de la persona
        /// </summary>
        protected string Nombre { get; set; }

        /// <summary>
        /// Asigna o retorna el apellido de la persona
        /// </summary>
        protected string Apellido { get; set; }

        /// <summary>
        /// Asigna o retorna el número celular de la persona
        /// </summary>
        protected string Celular { get; set; }

        /// <summary>
        /// Asigna o retorna la dirección de la persona
        /// </summary>
        protected string Direccion { get; set; }

        /// <summary>
        /// Asigna o retorna el correo de la persona
        /// </summary>
        protected string Correo { get; set; }

        protected string FechaNacimineto { get; set; }

        // Solo una clase heredera puede inicializar el constructor se inicializa con cadenas vacias
        protected Persona()
        {
            Cedula = string.Empty;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Celular = string.Empty;
            Direccion = string.Empty;
            Correo = string.Empty;
        }

        // Solo una clase heredera puede inicializar el constructor con datos, esto es una sobrecarga
        protected Persona(string cedula, string nombre, string apellido, string celular, string direccion, string correo, string fechaNacimineto)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Celular = celular;
            Direccion = direccion;
            Correo = correo;
            FechaNacimineto = fechaNacimineto;
        }

        /// <summary>
        /// Verifica si un nombre o apellido cumple con los requisitos
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns><see cref="bool"/></returns>
        protected static bool VerificarNombreOApellido(string cadena)
        {
            // intenta convertir una cadena a numero, si la cadena se puede convertir a número entonces no un nombre o apellido válido
            // Un nombre o apellido no puede contener dígitos.
            return !int.TryParse(cadena, out _);
        }

        /// <summary>
        /// Verifica si un número celular cumple con los requisitos
        /// </summary>
        /// <param name="celular"></param>
        /// <returns><see cref="bool"/></returns>
        protected static  bool VerificarCelular(string celular)
        {
            // Si la cadena no se puede comvertir a numero entonces no es un numero
            if (!int.TryParse(celular, out _)) return false;
            // Si los dos primeros digitos son iguales a "09" es un numero valido caso contrario no
            return celular.Substring(0, 2) == "09";
        }

        /// <summary>
        /// Verifica si un número de cédula cumple con los requisitos
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns><see cref="bool"/></returns>
        protected static bool VerificarCedula(string cedula)
        {
            // hace uso del meotodo Verificar identidad de la clase Cedula
            return Personas.Cedula.VerificaIdentificacion(cedula);
        }

        /// <summary>
        /// Verifica si un correo cumple con los requisitos, usando los metodos de la clase clase <see cref="Regex"/>
        /// </summary>
        /// <param name="correo"></param>
        /// <returns><see cref="bool"/></returns>
        protected static bool VerificarCorreo(string correo)
        {

            // este metodo es cortecía de microsoft :v
            // https://docs.microsoft.com/es-es/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format

            // si la cadena esta vacia o es un espcio en blanco retorna falso
            if (string.IsNullOrWhiteSpace(correo))
                return false;
            try
            {
                // Normalize the domain
                // aqui se sepata el dominio del usuario: <usuario>@<dominio>
                correo = Regex.Replace(correo, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                // Analiza las partes del dominio comprobando que contenga solo caracteres acordes unicode (un dominio no puede tener caracteres utf-8)
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    // crea instancia de un convertidor unicode
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    // converte el nombre del dominio en unicode
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    // retorna el nuevo correo con caraceristicas unicode 
                    // si no cumple provaca una excepcion
                    return match.Groups[1].Value + domainName;
                }
            }
            // Captura de las dos posibles expreciones, se retorna falso porque no cumplen con las caracterisicas de un correo valido
            catch  (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }
            // se intenta ver si el correo contiene los simbolos @, _, . ("@" sin repeticiones) si es asi se retorna verdadero sino se lanza una excepcion y se retorna falso
            try
            {
                return Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        /// <summary>
        /// Verifica si la fecha de naciemiento es una fecha valida
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns><see cref="bool"/></returns> 
        protected static bool VerificarFechaNacimieto(string fecha)
        {
            try
            {
                // DateTime.Parse(fecha) intenta convertir, si no lo logra lanza una excepcion sy lo logra compara el resultado con la fecha actual
                // si es menor a la fecha actual es una fecha valida
                return DateTime.Parse(fecha) <= DateTime.Today;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Verifica si una persona es mayor de edad
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns><see cref="bool"/></returns> 
        protected static bool VerificarMayoriaEdad(string fecha)
        {
            if (!VerificarFechaNacimieto(fecha)) return false;
            var fechaActual = DateTime.Today; // Toma la fecha del dia de actual
            var fechaNacimiento = DateTime.Parse(fecha); // Convierte la cadena fecha en Datetime
            var tiempoTranscurrido = (fechaActual - fechaNacimiento); // Se resta le fecha actual con la fecha de nacimiento
            return tiempoTranscurrido.TotalDays > 6574; // Si el total de dias es mayor que 6574 dias (17.99 años) se retorna verdadero caso contrario falso
        }
    }
}

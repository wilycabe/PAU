using System;
using System.Windows.Forms;

namespace CapaLogica.Personas
{
    public class Destinatario : Persona
    {

        /// <summary>
        /// Asigna o retorna el nombre del destinatario
        /// </summary>
        public new string Cedula
        {
            // Retorna el valor de la cedula almacenada en la herencia de la clase persona
            get => base.Cedula;
            // Asigna el valor de la cedula en la herencia de la clase persona
            set => base.Cedula = value;
        }

        /// <summary>
        /// Asigna o retorna el nombre del destinatario
        /// </summary>
        public new string Nombre
        {
            // Retorna el nombre almacenado en la herencia de la clase persona
            get => base.Nombre;
            // Asigna el valor del nombre en la herencia de la clase persona
            set => base.Nombre = value;
        }

        /// <summary>
        /// Asigna o retorna el apellido del destinatario
        /// </summary>
        public new string Apellido
        {
            // Retorna el apellido almacenado en la herencia de la clase persona
            get => base.Apellido;
            // Asigna el valor del apellido en la herencia de la clase persona
            set => base.Apellido = value;
        }

        /// <summary>
        /// Asigna o retorna el número de celular del destinatario
        /// </summary>
        public new string Celular
        {
            // Retorna el número de celular almacenado en la herencia de la clase persona
            get => base.Celular;
            // Asigna el valor del número de celular en la herencia de la clase persona
            set => base.Celular = value;
        }

        /// <summary>
        /// Asigna o retorna la dirección de celular del destinatario
        /// </summary>
        public new string Direccion
        {
            // Retorna la dirección almacenada en la herencia de la clase persona
            get => base.Direccion;
            // Asigna el valor de la dirección en la herencia de la clase persona
            set => base.Direccion = value;
        }

        /// <summary>
        /// Asigna o retorna el correo del destinatario
        /// </summary>
        public new string Correo
        {
            // Retorna el correo almacenado en la herencia de la clase persona
            get => base.Correo;
            // Asigna el valor del correo en la herencia de la clase persona
            set => base.Correo = value;
        }

        /// <summary>
        /// Constructor de la clase destinatario sin parametros de inicio
        /// </summary>
        public Destinatario()
        {

        }

        /// <summary>
        /// Constructor de la clase destinatario con parametros de inicio
        /// </summary>
        public Destinatario(string cedula, string nombre, string apellido, string celular, string direccion, string correo, string fechaNacimineto) : base(cedula, nombre, apellido, celular, direccion, correo, fechaNacimineto)
        {

        }

        /// <summary>
        /// Verifica si un nombre o apellido cumple con los requisitos
        /// </summary>
        /// <param name="nombreoapellido"></param>
        /// <returns><see cref="bool"/></returns>
        public new static bool VerificarNombreOApellido(string nombreoapellido)
        {
            return Persona.VerificarNombreOApellido(nombreoapellido);
        }

        /// <summary>
        /// Verifica si un número de cédula cumple con los requisitos, usando los metodos de la clase clase <see cref="Cedula"/>
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns><see cref="bool"/></returns>
        public new static bool VerificarCedula(string cedula)
        {
            return Persona.VerificarCedula(cedula);
        }

        /// <summary>
        /// Verifica si un número de celular cumple con los requisitos
        /// </summary>
        /// <param name="celular"></param>
        /// <returns><see cref="bool"/></returns>
        public new static bool VerificarCelular(string celular)
        {
            return Persona.VerificarCelular(celular);
        }

        /// <summary>
        /// Verifica si un correo cumple con los requisitos
        /// </summary>
        /// <param name="correo"></param>
        /// <returns><see cref="bool"/></returns>
        public new static bool VerificarCorreo(string correo)
        {
            return Persona.VerificarCorreo(correo);
        }

        /// <summary>
        /// Verifica si la fecha de naciemiento es correcta
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns><see cref="bool"/></returns>
        public new static bool VerificarFechaNacimieto(string fecha)
        {
            return Persona.VerificarFechaNacimieto(fecha);
        }

        /// <summary>
        /// Verifica si un destinatario existe en la base de datos
        /// </summary>
        /// <param name="destinatario"></param>
        /// <returns><see cref="bool"/></returns>
        public static bool Existedestinatario(Destinatario destinatario)
        {
            // verifica la valides de la cedula
            if (!VerificarCedula(destinatario.Cedula)) throw new ArgumentException(nameof(destinatario.Cedula));

            // Lineas para saber si existe

            return false;
        }

        /// <summary>
        /// Añade un destinatario a la base de datos
        /// </summary>
        /// <param name="destinatario"></param>
        public static void Anadirdestinatario(Destinatario destinatario)
        {
            try
            {
                if (!Existedestinatario(destinatario))
                {
                    // Lineas para añadir
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el destinatario con numero de cedula " + '"' + destinatario.Cedula + '"' + ".", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Ingrese un número de cedula válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Elimina un destinatario de la base de datos
        /// </summary>
        /// <param name="destinatario"></param>
        public static void Eliminardestinatario(Destinatario destinatario)
        {
            try
            {
                if (!Existedestinatario(destinatario))
                {
                    // Lineas para eliminar
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el destinatario con numero de cedula " + '"' + destinatario.Cedula + '"' + ".", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Ingrese un número de cedula válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Modifica un destinatario en la base de datos
        /// </summary>
        /// <param name="destinatario"></param>
        public static void Modificardestinatario(Destinatario destinatario)
        {
            try
            {
                if (!Existedestinatario(destinatario))
                {
                    // Lineas para eliminar
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el destinatario con numero de cedula " + '"' + destinatario.Cedula + '"' + ".", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Ingrese un número de cedula válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

using System;
using System.Windows.Forms;

namespace CapaLogica.Personas
{
    public class Cliente : Persona
    {

        /// <summary>
        /// Asigna o retorna el nombre del cliente
        /// </summary>
        public new string Cedula
        {
            // Retorna el valor de la cedula almacenada en la herencia de la clase persona
            get => base.Cedula;
            // Asigna el valor de la cedula en la herencia de la clase persona
            set => base.Cedula = value;
        }

        /// <summary>
        /// Asigna o retorna el nombre del cliente
        /// </summary>
        public new string Nombre
        {
            // Retorna el nombre almacenado en la herencia de la clase persona
            get => base.Nombre;
            // Asigna el valor del nombre en la herencia de la clase persona
            set => base.Nombre = value;
        }

        /// <summary>
        /// Asigna o retorna el apellido del cliente
        /// </summary>
        public new string Apellido
        {
            // Retorna el apellido almacenado en la herencia de la clase persona
            get => base.Apellido;
            // Asigna el valor del apellido en la herencia de la clase persona
            set => base.Apellido = value;
        }

        /// <summary>
        /// Asigna o retorna el número de celular del cliente
        /// </summary>
        public new string Celular
        {
            // Retorna el número de celular almacenado en la herencia de la clase persona
            get => base.Celular;
            // Asigna el valor del número de celular en la herencia de la clase persona
            set => base.Celular = value;
        }

        /// <summary>
        /// Asigna o retorna la dirección de celular del cliente
        /// </summary>
        public new string Direccion
        {
            // Retorna la dirección almacenada en la herencia de la clase persona
            get => base.Direccion;
            // Asigna el valor de la dirección en la herencia de la clase persona
            set => base.Direccion = value;
        }

        /// <summary>
        /// Asigna o retorna el correo del cliente
        /// </summary>
        public new string Correo
        {
            // Retorna el correo almacenado en la herencia de la clase persona
            get => base.Correo;
            // Asigna el valor del correo en la herencia de la clase persona
            set => base.Correo = value;
        }

        /// <summary>
        /// Constructor de la clase cliente sin parametros de inicio
        /// </summary>
        public Cliente()
        {
           
        }

        /// <summary>
        /// Constructor de la clase cliente con parametros de inicio
        /// </summary>
        public Cliente(string cedula, string nombre, string apellido, string celular, string direccion, string correo, string fechaNacimineto) : base(cedula, nombre, apellido, celular, direccion, correo, fechaNacimineto)
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
        /// Verifica si un cliente existe en la base de datos
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns><see cref="bool"/></returns>
        public static bool ExisteCliente(Cliente cliente)
        {
            // verifica la valides de la cedula
            if (!VerificarCedula(cliente.Cedula)) throw new ArgumentException(nameof(cliente.Cedula));

            // Lineas para saber si existe

            return false;
        }

        /// <summary>
        /// Añade un cliente a la base de datos
        /// </summary>
        /// <param name="cliente"></param>
        public static void Anadircliente(Cliente cliente)
        {
            try
            {
                if (!ExisteCliente(cliente))
                {
                    // Lineas para añadir
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el cliente con numero de cedula " + '"' + cliente.Cedula + '"' + ".", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Ingrese un número de cedula válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Elimina un cliente de la base de datos
        /// </summary>
        /// <param name="cliente"></param>
        public static void Eliminarcliente(Cliente cliente)
        {
            try
            {
                if (!ExisteCliente(cliente))
                {
                    // Lineas para eliminar
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el cliente con numero de cedula " + '"' + cliente.Cedula + '"' + ".", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Ingrese un número de cedula válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Modifica un cliente en la base de datos
        /// </summary>
        /// <param name="cliente"></param>
        public static void Modificarcliente(Cliente cliente)
        {
            try
            {
                if (!ExisteCliente(cliente))
                {
                    // Lineas para eliminar
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el cliente con numero de cedula " + '"' + cliente.Cedula + '"' + ".", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Ingrese un número de cedula válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

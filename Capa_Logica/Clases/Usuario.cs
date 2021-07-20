﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CapaLogica.Clases
{
    internal class Usuario : Persona
    {

        /// <summary>
        /// Asigna o retorna el nombre del usuario
        /// </summary>
        public new string Cedula
        {
            // Retorna el valor de la cedula almacenada en la herencia de la clase persona
            get => base.Cedula;
            // Asigna el valor de la cedula en la herencia de la clase persona
            set => base.Cedula = value;
        }

        /// <summary>
        /// Asigna o retorna el nombre del usuario
        /// </summary>
        public new string Nombre
        {
            // Retorna el nombre almacenado en la herencia de la clase persona
            get => base.Nombre;
            // Asigna el valor del nombre en la herencia de la clase persona
            set => base.Nombre = value;
        }

        /// <summary>
        /// Asigna o retorna el apellido del usuario
        /// </summary>
        public new string Apellido
        {
            // Retorna el apellido almacenado en la herencia de la clase persona
            get => base.Apellido;
            // Asigna el valor del apellido en la herencia de la clase persona
            set => base.Apellido = value;
        }

        /// <summary>
        /// Asigna o retorna el número de celular del usuario
        /// </summary>
        public new string Celular
        {
            // Retorna el número de celular almacenado en la herencia de la clase persona
            get => base.Celular;
            // Asigna el valor del número de celular en la herencia de la clase persona
            set => base.Celular = value;
        }

        /// <summary>
        /// Asigna o retorna la dirección de celular del usuario
        /// </summary>
        public new string Direccion
        {
            // Retorna la dirección almacenada en la herencia de la clase persona
            get => base.Direccion;
            // Asigna el valor de la dirección en la herencia de la clase persona
            set => base.Direccion = value;
        }

        /// <summary>
        /// Asigna o retorna el correo del usuario
        /// </summary>
        public new string Correo
        {
            // Retorna el correo almacenado en la herencia de la clase persona
            get => base.Correo;
            // Asigna el valor del correo en la herencia de la clase persona
            set => base.Correo = value;
        }

        /// <summary>
        /// Asigna o retorna el nombre de usuario (nick de usuario, no confundir con nombre de usuario)
        /// </summary>
        public string UsuarioNombre { get; set; }

        /// <summary>
        /// Asigna o retorna la contraseña del usuario
        /// </summary>
        public string Contrasena { get; set; }

        /// <summary>
        /// Constructor de la clase usuario sin parametros de inicio
        /// </summary>
        public Usuario()
        {
            UsuarioNombre = string.Empty;
            Contrasena = string.Empty;
        }

        /// <summary>
        /// Constructor de la clase usuario con parametros de inicio
        /// </summary>
        public Usuario(string cedula, string nombre, string apellido, string celular, string direccion, string correo,
            string usuarioNombre, string contrasena, string fechaNacimineto) : base(cedula, nombre, apellido, celular, direccion, correo, fechaNacimineto)
        {
            UsuarioNombre = usuarioNombre;
            Contrasena = contrasena;
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
        /// Verifica si un usuario existe en la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns><see cref="bool"/></returns>
        public static bool ExisteUsuario(string usuario)
        {
            // si el usuario es igual a null o cadena vacia o si la cdena se lanza una excepcion
            // nota: la excepcion se debe capturar desde donde llama a este metodo "ExisteUsuario"
            if (string.IsNullOrEmpty(usuario)) throw new ArgumentNullException(nameof(usuario)); // excepcion para argumento null o vacio
            if (!Regex.IsMatch(usuario, "^[a-zA-Z0-9]+$")) throw new ArgumentException(nameof(usuario)); // execpcion para caracteres no validos
            // Aun por desarrollar
            return false;
        }

        /// <summary>
        /// Verifica si el usuario y la contraseña son correctos
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contrasena"></param>
        /// <returns><see cref="bool"/></returns>
        public static bool VerificarUsuarioYContrasena(string usuario, string contrasena)
        {
            // si el usuario o la contraseña es igual a null o cadena vacia se lanza una excepcion
            // nota: la excepcion se debe capturar desde donde llama a este  metodo "VerificarUsuarioYContrasena"
            if (string.IsNullOrEmpty(usuario)) throw new ArgumentNullException(nameof(usuario));
            if (string.IsNullOrEmpty(contrasena)) throw new ArgumentNullException(nameof(contrasena));
            // Aun por desarrollar
            return false;
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
        /// Verifica si la contraseña tiene un formato valido 
        /// </summary>
        /// <param name="contrasena"></param>
        /// <returns><see cref="bool"/></returns>
        public static bool VerificarSeguridadContrasena(string contrasena)
        {
            // si la contraseña es igual a null o cadena vacia se lanza una excepcion
            // nota: la excepcion se debe capturar desde donde llama a este metodo "VerificarSeguridadContrasena"
            if (string.IsNullOrEmpty(contrasena)) throw new ArgumentNullException(nameof(contrasena));
            // por realizar o no se xd
            return false;
        }

        /// <summary>
        /// Añade un nuevo usuario dentro de la base de datos
        /// </summary>
        /// <param name="nick"></param>
        /// <returns><see cref="bool"/></returns>
        public static void AnadirUsuario(string nick)
        {
            // intenta buscar si existe un usuario con el mismo nick si no es asi lo crea
            try
            {
                if (!ExisteUsuario(nick))
                {
                    // lienas para crear
                }
                else
                {
                    MessageBox.Show("El usuario " + '"' + nick + '"' + " ya existe en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Ingrese un nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("El nombre de usuario solo admite números y letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Elimina un usuairio dentro de la base de datos
        /// </summary>
        /// <param name="nick"></param>
        /// <returns><see cref="bool"/></returns>
        public static void EliminarUsuario(string nick)
        {
            // intenta buscar el usuario y luego eliminarlo
            try
            {
                if (ExisteUsuario(nick))
                {
                    // lienas para eliminar
                }
            }
            catch
            {
                MessageBox.Show("El usuario " + '"' + nick +  '"' + " no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Modificar un usuario dentro de la base de datos
        /// </summary>
        /// <param name="nick"></param>
        /// <returns><see cref="bool"/></returns>
        public static void ModificarUsuario(string nick)
        {
            // intenta buscar el usuario y luego modificar
            try
            {
                if (ExisteUsuario(nick))
                {
                    // lienas para modificar
                }
            }
            catch
            {
                MessageBox.Show("El usuario " + '"' + nick + '"' + " no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

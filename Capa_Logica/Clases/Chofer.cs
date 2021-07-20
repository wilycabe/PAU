namespace CapaLogica.Clases
{
    internal class Chofer : Persona
    {

        /// <summary>
        /// Asigna o retorna el nombre del chofer
        /// </summary>
        public new string Cedula
        {
            // Retorna el valor de la cedula almacenada en la herencia de la clase persona
            get => base.Cedula;
            // Asigna el valor de la cedula en la herencia de la clase persona
            set => base.Cedula = value;
        }

        /// <summary>
        /// Asigna o retorna el nombre del chofer
        /// </summary>
        public new string Nombre
        {
            // Retorna el nombre almacenado en la herencia de la clase persona
            get => base.Nombre;
            // Asigna el valor del nombre en la herencia de la clase persona
            set => base.Nombre = value;
        }

        /// <summary>
        /// Asigna o retorna el apellido del chofer
        /// </summary>
        public new string Apellido
        {
            // Retorna el apellido almacenado en la herencia de la clase persona
            get => base.Apellido;
            // Asigna el valor del apellido en la herencia de la clase persona
            set => base.Apellido = value;
        }

        /// <summary>
        /// Asigna o retorna el número de celular del chofer
        /// </summary>
        public new string Celular
        {
            // Retorna el número de celular almacenado en la herencia de la clase persona
            get => base.Celular;
            // Asigna el valor del número de celular en la herencia de la clase persona
            set => base.Celular = value;
        }

        /// <summary>
        /// Asigna o retorna la dirección de celular del chofer
        /// </summary>
        public new string Direccion
        {
            // Retorna la dirección almacenada en la herencia de la clase persona
            get => base.Direccion;
            // Asigna el valor de la dirección en la herencia de la clase persona
            set => base.Direccion = value;
        }

        /// <summary>
        /// Asigna o retorna el correo del chofer
        /// </summary>
        public new string Correo
        {
            // Retorna el correo almacenado en la herencia de la clase persona
            get => base.Correo;
            // Asigna el valor del correo en la herencia de la clase persona
            set => base.Correo = value;
        }

        /// <summary>
        /// Constructor de la clase chofer sin parametros de inicio
        /// </summary>
        public Chofer()
        {

        }

        /// <summary>
        /// Constructor de la clase chofer con parametros de inicio
        /// </summary>
        public Chofer(string cedula, string nombre, string apellido, string celular, string direccion, string correo, string fechaNacimineto) : base(cedula, nombre, apellido, celular, direccion, correo, fechaNacimineto)
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
        /// Verifica si un chofer existe en la base de datos
        /// </summary>
        /// <param name="chofer"></param>
        /// <returns><see cref="bool"/></returns>
        public static bool ExisteChofer(string chofer)
        {
            // Aun por desarrollar
            return false;
        }

        /// <summary>
        /// Verifica si la fecha de naciemiento de un chofer es correcta
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns><see cref="bool"/></returns>
        public new static bool VerificarMayoriaEdad(string fecha)
        {
            return Persona.VerificarMayoriaEdad(fecha);
        }


    }
}

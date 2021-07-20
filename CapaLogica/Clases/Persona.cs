using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Clases
{
    /// <summary>
    /// repesenta un objeto persona
    /// </summary>
    class Persona
    {
        /// <summary>
        /// Asigna o retorna la cedula de la persona
        /// </summary>
        public string Cedula { get; set; }

        /// <summary>
        /// Asigna o retorna el nombre de la persona
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Asigna o retorna el apellido de la persona
        /// </summary>
        public string Apellido { get; set; }

        /// <summary>
        /// Asigna o retorna el número celular de la persona
        /// </summary>
        public string Celular { get; set; }

        /// <summary>
        /// Asigna o retorna la dirección de la persona
        /// </summary>
        public string Direccion { get; set; }

        /// <summary>
        /// Asigna o retorna el correo de la persona
        /// </summary>
        public string Correo { get; set; }

    }
}

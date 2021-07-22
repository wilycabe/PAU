using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaBase;
using CapaLogica.Personas;

namespace CapaLogica.Objetos
{
    public class Operaciones
    {
        private readonly Conexion _conexion = new();

        public void ConectarBaseDatos()
        {
            _conexion.Abrir();
        }

        public static bool ValidadUsuarioContrasena(string usuario, string contrasena)
        {
            return CapaBase.Operaciones.ValidadUsuarioContrasena(usuario, contrasena);
        }

        public static void AnadirUsuario(Usuario usuario)
        {
            CapaBase.Operaciones.AnadirUsuarioBaseDatos(
                usuario.Cedula,
                usuario.Nombre,
                usuario.Apellido,
                usuario.Celular,
                usuario.Correo,
                usuario.Direccion, 
                usuario.UsuarioNombre,
                usuario.Contrasena);
        }

    }
}

using System.Data;
using CapaBase;
using CapaLogica.Personas;

namespace CapaLogica.Objetos
{
    public class OperacionesLl
    {

        public static PAUDataSet DataSet = new();

        public static bool ValidarUsuarioContrasena(string idUsuario, string contrasena)
        {
            return Operaciones.ValidarUsuarioContrasena(idUsuario, contrasena);
        }

        public static bool ExisteUsuario(string idUsuario)
        {
            return Operaciones.BuscarUsuario(idUsuario) != null;
        }

        public static void AnadirUsuario(Usuario usuario)
        {
            Operaciones.AnadirUsuario(
                usuario.Cedula,
                usuario.Nombre,
                usuario.Apellido, 
                usuario.Celular, 
                usuario.Correo, 
                usuario.Direccion,
                usuario.UsuarioNombre,
                usuario.Contrasena);
        }

        public static void ModificarUsuario(Usuario usuario)
        {
            Operaciones.ModificarUsuario(
                usuario.Cedula,
                usuario.Nombre,
                usuario.Apellido,
                usuario.Celular,
                usuario.Correo,
                usuario.Direccion,
                usuario.UsuarioNombre,
                usuario.Contrasena);
        }

        public static void EliminarUsuario(string idUsuario, string contrasena)
        {
            Operaciones.EliminarUsuario(idUsuario, contrasena);
        }

        public static DataTable BuscarUsuario(string idUsuario)
        {
            return Operaciones.BuscarUsuario(idUsuario);
        }

        public static bool ExisteChofer(string cedula)
        {
            return Operaciones.BuscarChofer(cedula).Rows.Count > 0;
        }

        public static void AnadirChofer(Chofer chofer)
        {
            Operaciones.AnadirChofer(
                chofer.Cedula,
                chofer.Nombre,
                chofer.Apellido,
                chofer.Celular,
                chofer.Correo,
                chofer.Direccion,
                chofer.FechaNacimineto
                );
        }

        public static void ModificarChofer(Chofer chofer)
        {
            Operaciones.ModificarChofer(
                chofer.Cedula,
                chofer.Nombre,
                chofer.Apellido,
                chofer.Celular,
                chofer.Correo,
                chofer.Direccion,
                chofer.FechaNacimineto
            );
        }

        public static void EliminarChofer(string cedula)
        {
            Operaciones.EliminarChofer(cedula);
        }

        public static DataTable BuscarChofer(string cedula)
        {
            return Operaciones.BuscarChofer(cedula);
        }

        public static bool ExisteDestinatario(string cedula)
        {
            return Operaciones.BuscarDestinatario(cedula).Rows.Count > 0;
        }

        public static void AnadirDestinatario(Destinatario destinatario)
        {
            Operaciones.AnadirDestinatario(
                destinatario.Cedula,
                destinatario.Nombre,
                destinatario.Apellido,
                destinatario.Celular,
                destinatario.Correo,
                destinatario.Direccion
            );
        }

        public static void ModificarDestinatario(Destinatario destinatario)
        {
            Operaciones.ModificarDestinatario(
                destinatario.Cedula,
                destinatario.Nombre,
                destinatario.Apellido,
                destinatario.Celular,
                destinatario.Correo,
                destinatario.Direccion
            );
        }

        public static void EliminarDestinatario(string cedula)
        {
            Operaciones.EliminarDestinatario(cedula);
        }

        public static DataTable BuscarDestinatario(string cedula)
        {
            return Operaciones.BuscarDestinatario(cedula);
        }

        public static bool ExisteCliente(string cedula)
        {
            return Operaciones.BuscarCliente(cedula).Rows.Count > 0;
        }

        public static void AnadirCliente(Cliente cliente)
        {
            Operaciones.AnadirCliente(
                cliente.Cedula,
                cliente.Nombre,
                cliente.Apellido,
                cliente.Celular,
                cliente.Correo,
                cliente.Direccion,
                cliente.FechaNacimiento
            );
        }

        public static void ModificarCliente(Cliente cliente)
        {
            Operaciones.ModificarCliente(
                cliente.Cedula,
                cliente.Nombre,
                cliente.Apellido,
                cliente.Celular,
                cliente.Correo,
                cliente.Direccion,
                cliente.FechaNacimiento
            );
        }

        public static void EliminarClienter(string cedula)
        {
            Operaciones.EliminarCliente(cedula);
        }

        public static DataTable BuscarCliente(string cedula)
        {
            return Operaciones.BuscarCliente(cedula);
        }

        public static bool ExisteVehiculo(string placa)
        {
            return Operaciones.BuscarVehiculo(placa).Rows.Count > 0;
        }

        public static void AnadirVehiculo(Vehiculo vehiculo)
        {
            Operaciones.AnadirVehiculo(
                vehiculo.Placa,
                vehiculo.Modelo,
                vehiculo.Marca,
                vehiculo.Color,
                vehiculo.CedulaChofer,
                vehiculo.Agno
            );
        }

        public static void ModificarVehiculo(Vehiculo vehiculo)
        {
            Operaciones.ModificarVehiculo(
                vehiculo.Placa,
                vehiculo.Modelo,
                vehiculo.Marca,
                vehiculo.Color,
                vehiculo.CedulaChofer,
                vehiculo.Agno
            );
        }

        public static void EliminarVehiculo(string placa)
        {
            Operaciones.EliminarVehiculo(placa);
        }

        public static void EliminarVehiculoPorChofer(string cedula)
        {
            Operaciones.EliminarVehiculoPorChofer(cedula);
        }

        public static DataTable BuscarVehiculo(string placa)
        {
            return Operaciones.BuscarCliente(placa);
        }

        public static bool ExisteEncomienda(string codigo)
        {
            return Operaciones.BuscarEncomienda(codigo).Rows.Count > 0;
        }

        public static void AnadirEncomienda(Encomienda encomienda)
        {
            Operaciones.AnadirEncomienda(
                encomienda.CiudadEnvio,
                encomienda.DireccionEnvio,
                encomienda.CiudadLlegada,
                encomienda.DireccionLlegada,
                encomienda.FechaEnvio,
                encomienda.ValorEncomienda,
                encomienda.CodigoPostal,
                encomienda.Peso,
                encomienda.Descripcion,
                encomienda.CedulaDestinatario,
                encomienda.CedulaCliente,
                encomienda.CedulaChofer
            );
        }

        public static void ModificarEncomienda(Encomienda encomienda)
        {
            Operaciones.ModificarEncomienda(
                encomienda.Codigo,
                encomienda.CiudadEnvio,
                encomienda.DireccionEnvio,
                encomienda.CiudadLlegada,
                encomienda.DireccionLlegada,
                encomienda.FechaEnvio,
                encomienda.ValorEncomienda,
                encomienda.CodigoPostal,
                encomienda.Peso,
                encomienda.Descripcion,
                encomienda.CedulaDestinatario,
                encomienda.CedulaCliente,
                encomienda.CedulaChofer
            );
        }

        public static void EliminarEncomienda(string codigo)
        {
            Operaciones.EliminarVehiculo(codigo);
        }

        public static DataTable BuscarEncomienda(string codigo)
        {
            return Operaciones.BuscarCliente(codigo);
        }

        public static bool ExisteReservacion(string codigo)
        {
            return Operaciones.BuscarReservacion(codigo).Rows.Count > 0;
        }

        public static void AnadirReservacion(Reservacion reservacion)
        {
            Operaciones.AnadirReservacion(
                reservacion.CiudadPartida,
                reservacion.DireccionPartida,
                reservacion.CiudadDestino,
                reservacion.DireccionDestino,
                reservacion.FechaReservacion,
                reservacion.ValorReservacion,
                reservacion.CedulaChofer,
                reservacion.CedulaCliente
            );
        }

        public static void ModificarReservacion(Reservacion reservacion)
        {
            Operaciones.ModificarReservacion(
                reservacion.Codigo,
                reservacion.CiudadPartida,
                reservacion.DireccionPartida,
                reservacion.CiudadDestino,
                reservacion.DireccionDestino,
                reservacion.FechaReservacion,
                reservacion.ValorReservacion,
                reservacion.CedulaChofer,
                reservacion.CedulaCliente
            );
        }

        public static void EliminarReservacion(string codigo)
        {
            Operaciones.EliminarReservacion(codigo);
        }

        public static DataTable BuscarReservacion(string codigo)
        {
            return Operaciones.BuscarReservacion(codigo);
        }

        public static DataTable BuscarVehiculoPorChofer(string cedula)
        {
            return Operaciones.BuscarVehiculoPorChofer(cedula);
        }

        public static DataTable Choferes()
        {
            return Operaciones.Choferes();
        }

        public static DataTable Encomiendas()
        {
            return Operaciones.Encomiendas();
        }
    }
}

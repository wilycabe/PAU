using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace CapaBase
{
    public class Operaciones
    {

        private static readonly Conexion Conexion = new();
        private static DataTable _tabla;

        #region Usuario


        public static bool ValidarUsuarioContrasena(string idUsuario, string contrasena)
        {
            try
            {
                _tabla = new DataTable();
                var cmdText = $"SELECT * FROM usuario WHERE id_usuario='{idUsuario}' AND contrasena_usuario ='{contrasena}'";
                Conexion.Abrir();
                SqlCommand command = new(cmdText, Conexion.Conectar);
                SqlDataAdapter adapter = new() { SelectCommand = command };
                adapter.Fill(_tabla);
                _tabla.AcceptChanges();
                Conexion.Cerrar();
                return _tabla.Rows.Count > 0;
            }
            catch (Exception)
            {
                Conexion.Cerrar();
                _tabla = null;
                return false;
            }
        }

        public static DataTable BuscarUsuario(string idUsuario)
        {
            try
            {
                _tabla = new DataTable();
                var cmdText = $"SELECT * FROM usuario WHERE id_usuario='{idUsuario}'";
                Conexion.Abrir();
                SqlCommand command = new(cmdText, Conexion.Conectar);
                SqlDataAdapter adapter = new() { SelectCommand = command };
                adapter.Fill(_tabla);
                _tabla.AcceptChanges();
                Conexion.Cerrar();
                return _tabla;
            }
            catch (Exception)
            {
                Conexion.Cerrar();
                _tabla = null;
                return _tabla;
            }
        }

        public static void AnadirUsuario(string cedula, string nombre, string apellido, string celular, string correo,
            string direccion, string idUsuario, string contrasena)
        {
            try
            {
                Conexion.Abrir();
                var cmdText =
                    $"INSERT INTO usuario(cedula_usuario, nombres_usuario, apellidos_usuario, celular_usuario, correo_usuario, direccion_usuario, id_usuario, contrasena_usuario) VALUES ('{cedula}', '{nombre}', '{apellido}', '{celular}', '{correo}', '{direccion}', '{idUsuario}', '{contrasena}')";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }

        }

        public static void ModificarUsuario(string cedula, string nombre, string apellido, string celular, string correo,
            string direccion, string idUsuario, string contrasena)
        {
            try
            {
                Conexion.Abrir();
                var cmdText =
                    $"UPDATE usuario SET cedula_usuario='{cedula}', " +
                    $"nombres_usuario='{nombre}', " +
                    $"apellidos_usuario='{apellido}', " +
                    $"celular_usuario='{celular}', " +
                    $"correo_usuario='{correo}', " +
                    $"direccion_usuario='{direccion}', " +
                    $"contrasena_usuario='{contrasena}' " +
                    $"WHERE id_usuario = '{idUsuario}'";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        public static void EliminarUsuario(string idUsuario, string contrasena)
        {
            try
            {
                Conexion.Abrir();
                var cmdText =
                    $"DELETE FROM usuario WHERE " +
                    $"contrasena_usuario='{contrasena}' " +
                    $"AND id_usuario = '{idUsuario}'";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        #endregion

        #region Chofer

        public static DataTable BuscarChofer(string cedula)
        {
            try
            {
                _tabla = new DataTable();
                var cmdText = $"SELECT * FROM chofer WHERE cedula_chofer='{cedula}'";
                Conexion.Abrir();
                SqlCommand command = new(cmdText, Conexion.Conectar);
                SqlDataAdapter adapter = new() { SelectCommand = command };
                adapter.Fill(_tabla);
                _tabla.AcceptChanges();
                Conexion.Cerrar();
                return _tabla;
            }
            catch (Exception)
            {
                Conexion.Cerrar();
                _tabla = null;
                return _tabla;
            }
        }

        public static void AnadirChofer(string cedula, string nombre, string apellido, string celular, string correo, string direccion, string fechaNacChofer)
        {
            try
            {
                Conexion.Abrir();
                var cmdText =
                    $"INSERT INTO chofer VALUES (" +
                    $"'{cedula}', " +
                    $"'{nombre}', " +
                    $"'{apellido}', " +
                    $"'{celular}', " +
                    $"'{correo}', " +
                    $"'{direccion}', " +
                    $"'{DateTime.Parse(fechaNacChofer, CultureInfo.CurrentCulture)}')";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }

        }

        public static void ModificarChofer(string cedula, string nombre, string apellido, string celular, string correo, string direccion, string fechaNacChofer)
        {
            try
            {
                Conexion.Abrir();
                var cmdText =
                    $"UPDATE chofer SET nombres_chofer='{nombre}', " +
                    $"apellidos_chofer='{apellido}', " +
                    $"celular_chofer='{celular}', " +
                    $"correo_chofer='{correo}', " +
                    $"direccion_chofer='{direccion}', " +
                    $"fecha_nac_chofer='{fechaNacChofer}' " +
                    $"WHERE cedula_chofer = '{cedula}'";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        public static void EliminarChofer(string cedula)
        {
            try
            {
                Conexion.Abrir();
                var cmdText = $"DELETE FROM chofer WHERE cedula_chofer='{cedula}'";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        #endregion

        #region Cliente

        public static DataTable BuscarCliente(string cedula)
        {
            try
            {
                _tabla = new DataTable();
                var cmdText = $"SELECT * FROM cliente WHERE cedula_cliente='{cedula}'";
                Conexion.Abrir();
                SqlCommand command = new(cmdText, Conexion.Conectar);
                SqlDataAdapter adapter = new() { SelectCommand = command };
                adapter.Fill(_tabla);
                _tabla.AcceptChanges();
                Conexion.Cerrar();
                return _tabla;
            }
            catch (Exception)
            {
                Conexion.Cerrar();
                _tabla = null;
                return _tabla;
            }
        }

        public static void AnadirCliente(string cedula, string nombre, string apellido, string celular, string correo, string direccion, string fechaNacCiente)
        {
            try
            {
                Conexion.Abrir();
                var cmdText =
                    $"INSERT INTO cliente VALUES (" +
                    $"'{cedula}', " +
                    $"'{nombre}', " +
                    $"'{apellido}', " +
                    $"'{celular}', " +
                    $"'{correo}', " +
                    $"'{direccion}', " +
                    $"'{DateTime.Parse(fechaNacCiente, CultureInfo.CurrentCulture)}')";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        public static void ModificarCliente(string cedula, string nombre, string apellido, string celular, string correo, string direccion, string fechaNacCliente)
        {
            try
            {
                Conexion.Abrir();
                var cmdText =
                    $"UPDATE cliente SET nombres_cliente='{nombre}', " +
                    $"apellidos_cliente='{apellido}', " +
                    $"celular_cliente='{celular}', " +
                    $"correo_cliente='{correo}', " +
                    $"direccion_cliente='{direccion}', " +
                    $"fecha_nac_cliente='{fechaNacCliente}' " +
                    $"WHERE cedula_cliente = '{cedula}'";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        public static void EliminarCliente(string cedula)
        {
            try
            {
                Conexion.Abrir();
                var cmdText = $"DELETE FROM cliente WHERE cedula_cliente='{cedula}'";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        #endregion

        #region Destinatario

        public static DataTable BuscarDestinatario(string cedula)
        {
            try
            {
                _tabla = new DataTable();
                var cmdText = $"SELECT * FROM destinatario WHERE cedula_destinatario='{cedula}'";
                Conexion.Abrir();
                SqlCommand command = new(cmdText, Conexion.Conectar);
                SqlDataAdapter adapter = new() { SelectCommand = command };
                adapter.Fill(_tabla);
                _tabla.AcceptChanges();
                Conexion.Cerrar();
                return _tabla;
            }
            catch (Exception)
            {
                Conexion.Cerrar();
                _tabla = null;
                return _tabla;
            }
        }

        public static void AnadirDestinatario(string cedula, string nombre, string apellido, string celular, string correo, string direccion)
        {
            try
            {
                Conexion.Abrir();
                var cmdText =
                    $"INSERT INTO destinatario VALUES (" +
                    $"'{cedula}', " +
                    $"'{nombre}', " +
                    $"'{apellido}', " +
                    $"'{celular}', " +
                    $"'{correo}', " +
                    $"'{direccion}') ";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        public static void ModificarDestinatario(string cedula, string nombre, string apellido, string celular, string correo, string direccion)
        {
            try
            {
                Conexion.Abrir();
                var cmdText =
                    $"UPDATE destinatario SET nombres_destinatario='{nombre}', " +
                    $"apellidos_destinatario='{apellido}', " +
                    $"celular_destinatario='{celular}', " +
                    $"correo_destinatario='{correo}', " +
                    $"direccion_destinatario='{direccion}' " +
                    $"WHERE cedula_destinatario = '{cedula}'";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        public static void EliminarDestinatario(string cedula)
        {
            try
            {
                Conexion.Abrir();
                var cmdText = $"DELETE FROM destinatario WHERE cedula_destinatario='{cedula}'";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        #endregion

        #region Vehiculo

        public static DataTable BuscarVehiculo(string placa)
        {
            try
            {
                _tabla = new DataTable();
                var cmdText = $"SELECT * FROM vehiculo WHERE placa='{placa}'";
                Conexion.Abrir();
                SqlCommand command = new(cmdText, Conexion.Conectar);
                SqlDataAdapter adapter = new() { SelectCommand = command };
                adapter.Fill(_tabla);
                _tabla.AcceptChanges();
                Conexion.Cerrar();
                return _tabla;
            }
            catch (Exception)
            {
                Conexion.Cerrar();
                _tabla = null;
                return _tabla;
            }
        }

        public static void AnadirVehiculo(string placa, string modelo, string marca, string color, string cedulaChofer, int agno)
        {
            try
            {
                Conexion.Abrir();
                var cmdText =
                    $"INSERT INTO vehiculo VALUES (" +
                    $"'{placa}', " +
                    $"'{modelo}', " +
                    $"'{marca}', " +
                    $"'{color}', " +
                    $"'{cedulaChofer}', " +
                    $"'{agno}') ";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        public static void ModificarVehiculo(string placa, string modelo, string marca, string color, string cedulaChofer, int agno)
        {
            try
            {
                Conexion.Abrir();
                var cmdText =
                    $"UPDATE vehiculo SET modelo='{modelo}', " +
                    $"marca='{marca}', " +
                    $"color='{color}', " +
                    $"cedula_chofer='{cedulaChofer}' " +
                    $"agno='{agno}' " +
                    $"WHERE placa = '{placa}'";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        public static void EliminarVehiculo(string placa)
        {
            try
            {
                Conexion.Abrir();
                var cmdText = $"DELETE FROM vehiculo WHERE placa='{placa}'";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        #endregion

        #region Encomienda

        public static DataTable BuscarEncomienda(string codigo)
        {
            try
            {
                _tabla = new DataTable();
                var cmdText = $"SELECT * FROM encomienda WHERE codigo_enc='{codigo}'";
                Conexion.Abrir();
                SqlCommand command = new(cmdText, Conexion.Conectar);
                SqlDataAdapter adapter = new() { SelectCommand = command };
                adapter.Fill(_tabla);
                _tabla.AcceptChanges();
                Conexion.Cerrar();
                return _tabla;
            }
            catch (Exception)
            {
                Conexion.Cerrar();
                _tabla = null;
                return _tabla;
            }
        }

        public static void AnadirEncomienda(string ciudadEnvEnc, string direccionEnvEnc, string ciudadLlegEnc, string direccionLlegEnc, string fechaEnc, double valorEnc, string codigoPostalEnc, double peso, string descripcion, string cedulaDestinatario, string cedulaCliente, string cedulaChofer)
        {
            try
            {
                Conexion.Abrir();
                var cmdText =
                    $"INSERT INTO encomienda(ciudad_env_enc,direccion_env_enc,ciudad_lleg_enc,direccion_lleg_enc,fecha_enc,valor_enc,codigo_postal_enc,peso,descripcion,cedula_destinatario,cedula_cliente,cedula_chofer) " +
                    $"VALUES (" +
                    $"'{ciudadEnvEnc}', " +
                    $"'{direccionEnvEnc}', " +
                    $"'{ciudadLlegEnc}', " +
                    $"'{direccionLlegEnc}', " +
                    $"'{fechaEnc}', " +
                    $"'{valorEnc}', " +
                    $"'{codigoPostalEnc}', " +
                    $"'{peso}', " +
                    $"'{descripcion}', " +
                    $"'{cedulaDestinatario}', " +
                    $"'{cedulaCliente}', " +
                    $"'{cedulaChofer}')";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        public static void ModificarEncomienda(string codigoEnc, string ciudadEnvEnc, string direccionEnvEnc, string ciudadLlegEnc, string direccionLlegEnc, string fechaEnc, double valorEnc, string codigoPostalEnc, double peso, string descripcion, string cedulaDestinatario, string cedulaCliente, string cedulaChofer)
        {
            try
            {
                Conexion.Abrir();
                var cmdText =
                    $"UPDATE encomienda SET ciudad_env_enc='{ciudadEnvEnc}', " +
                    $"direccion_env_enc='{direccionEnvEnc}', " +
                    $"ciudad_lleg_enc='{ciudadLlegEnc}', " +
                    $"direccionLlegEnc='{direccionLlegEnc}', " +
                    $"fecha_enc='{fechaEnc}' " +
                    $"valor_enc='{valorEnc}' " +
                    $"codigo_postal_enc='{codigoPostalEnc}' " +
                    $"peso='{peso}' " +
                    $"descripcion='{descripcion}' " +
                    $"cedula_destinatario='{cedulaDestinatario}' " +
                    $"cedula_cliente='{cedulaCliente}' " +
                    $"cedula_chofer='{cedulaChofer}' " +
                    $"WHERE codigo_enc = '{codigoEnc}'";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        public static void EliminarEncomienda(string codigo)
        {
            try
            {
                Conexion.Abrir();
                var cmdText = $"DELETE FROM encomienda WHERE codigo_enc='{codigo}'";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        #endregion

        #region Reservacion

        public static DataTable BuscarReservacion(string codigo)
        {
            try
            {
                _tabla = new DataTable();
                var cmdText = $"SELECT * FROM reservacion WHERE codigo_reser='{codigo}'";
                Conexion.Abrir();
                SqlCommand command = new(cmdText, Conexion.Conectar);
                SqlDataAdapter adapter = new() { SelectCommand = command };
                adapter.Fill(_tabla);
                _tabla.AcceptChanges();
                Conexion.Cerrar();
                return _tabla;
            }
            catch (Exception)
            {
                Conexion.Cerrar();
                _tabla = null;
                return _tabla;
            }
        }

        public static void AnadirReservacion(string ciudadParReser, string dirrecionParReser, string ciudadLlegReser, string direccionLlegReser, string fechaReser, double valorReser, string cedulaChofer, string cedulaCliente)
        {
            try
            {
                Conexion.Abrir();
                var cmdText =
                    $"INSERT INTO reservacion(ciudad_par_reser,direccion_par_reser,ciudad_lleg_reser,direccion_lleg_reser,fecha_reser,valor_res,cedula_chofer,cedula_cliente) " +
                    $"VALUES ('{ciudadParReser}', " +
                    $"'{dirrecionParReser}', " +
                    $"'{ciudadLlegReser}', " +
                    $"'{direccionLlegReser}', " +
                    $"'{fechaReser}', " +
                    $"'{valorReser}', " +
                    $"'{cedulaChofer}', " +
                    $"'{cedulaCliente}') ";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        public static void ModificarReservacion(string codigo, string ciudadParReser, string dirrecionParReser, string ciudadLlegReser, string direccionLlegReser, string fechaReser, double valorReser, string cedulaChofer, string cedulaCliente)
        {
            try
            {
                Conexion.Abrir();
                var cmdText =
                    $"UPDATE reservacion SET ciudad_par_reser='{ciudadParReser}', " +
                    $"direccion_par_reser='{dirrecionParReser}', " +
                    $"ciudad_lleg_reser='{ciudadLlegReser}', " +
                    $"direccion_lleg_reser='{direccionLlegReser}' " +
                    $"fecha_reser='{fechaReser}' " +
                    $"valor_res='{valorReser}' " +
                    $"cedula_chofer='{cedulaChofer}' " +
                    $"cedula_cliente='{cedulaCliente}' " +
                    $"WHERE codigo_reser = '{codigo}'";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        public static void EliminarReservacion(string codigo)
        {
            try
            {
                Conexion.Abrir();
                var cmdText = $"DELETE FROM reservacion WHERE codigo_reser='{codigo}'";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        #endregion

        public static void EliminarVehiculoPorChofer(string cedula)
        {
            try
            {
                Conexion.Abrir();
                var cmdText = $"DELETE FROM vehiculo WHERE cedula_chofer='{cedula}'";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                command.ExecuteNonQuery();
                Conexion.Cerrar();
            }
            catch (Exception)
            {
                Conexion.Cerrar();
            }
        }

        public static DataTable BuscarVehiculoPorChofer(string cedula)
        {
            try
            {
                Conexion.Abrir();
                _tabla = new DataTable();
                var cmdText = $"SELECT * FROM vehiculo WHERE cedula_chofer='{cedula}'";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                SqlDataAdapter adapter = new() { SelectCommand = command };
                adapter.Fill(_tabla);
                _tabla.AcceptChanges();
                Conexion.Cerrar();
                return _tabla;
            }
            catch (Exception)
            {
                Conexion.Cerrar();
                _tabla = null;
                return _tabla;
            }
        }

        public static DataTable Choferes()
        {
            try
            {
                Conexion.Abrir();
                _tabla = new DataTable();
                var cmdText = $"SELECT * FROM chofer";
                SqlCommand command = new(cmdText, Conexion.Conectar);
                SqlDataAdapter adapter = new() { SelectCommand = command };
                adapter.Fill(_tabla);
                _tabla.Columns[0].ColumnName = "Cédula";
                _tabla.Columns[1].ColumnName = "Nombre";
                _tabla.Columns[2].ColumnName = "Apellido";
                _tabla.Columns[3].ColumnName = "Celular";
                _tabla.Columns[4].ColumnName = "Correo";
                _tabla.Columns[5].ColumnName = "Dirección";
                _tabla.Columns[6].ColumnName = "Fecha de Nacimiento";
                _tabla.AcceptChanges();
                Conexion.Cerrar();
                return _tabla;
            }
            catch (Exception)
            {
                Conexion.Cerrar();
                _tabla = null;
                return _tabla;
            }
        }
    }
}

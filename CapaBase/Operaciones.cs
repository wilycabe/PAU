using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace CapaBase
{
    public class Operaciones
    {
        static readonly Conexion objConec = new Conexion();
        DataTable tabla = new DataTable();

        public DataTable MostrarEnc()
        {
            try
            {
                objConec.Abrir();
                SqlCommand comando = new SqlCommand("Select * From encomienda", objConec.Conectar);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                return tabla;
            }
            catch
            {
                objConec.Cerrar();
                tabla = null;
                return tabla;
            }
        }
        public void InsertarEnc(int _cod_enc, string _ciudad_destino_enc, string _direccion_destino_enc, string _ciudad_fin_enc, DateTime _fecha_enc, float _valor_enc, int _codigo_postal_enc, float _peso_enc, string _descrip_enc, int _dni_destinatario_enc, int _dni_cliente_enc)
        {
            objConec.Abrir();
            String cadenaSQL = "INSERT into encomienda(codigo_enc,ciudad_env_enc,direccion_env_enc,ciudad_lleg_enc,fecha_enc,valor_enc,codigo_postal_enc,peso,descripción,cecula_destinatario,cedula_cliente) VALUES(" + _cod_enc + ",'" + _ciudad_destino_enc + "','" + _direccion_destino_enc + "','" + _ciudad_fin_enc + "','" + _fecha_enc + "','" + _valor_enc + "','" + _codigo_postal_enc + "','" + _peso_enc + "','" + _descrip_enc + "','" + _dni_destinatario_enc + "','" + _dni_cliente_enc + "')";
            SqlCommand comando = new SqlCommand(cadenaSQL, objConec.Conectar);
            comando.ExecuteNonQuery();
            objConec.Cerrar();

        }
        public void EliminarEnc(int _cod_enc)
        {
            objConec.Abrir();
            string cadenaSQL = "DELETE from encomienda where codigo_enc=" + _cod_enc + "";
            SqlCommand comando = new SqlCommand(cadenaSQL, objConec.Conectar);
            comando.ExecuteNonQuery();
            objConec.Cerrar();
        }
        public void EditarEnc(int _cod_enc, string _ciudad_destino_enc, string _direccion_destino_enc, string _ciudad_fin_enc, DateTime _fecha_enc, float _valor_enc, int _codigo_postal_enc, float _peso_enc, string _descrip_enc, int _dni_destinatario_enc, int _dni_cliente_enc)
        {
            objConec.Abrir();
            string cadenaSQL = "UPDATE encomienda set codigo_enc'" + _cod_enc + "'ciudad_env_enc='" + _ciudad_destino_enc + "'direccion_env_enc='" + _direccion_destino_enc + "'ciudad_lleg_enc='" + _ciudad_fin_enc + "'fecha_enc'" + _fecha_enc + "'valor_enc='" + _valor_enc + "'codigo_postal_enc='" + _codigo_postal_enc + "'peso='" + _peso_enc + "'descripcion='" + _descrip_enc + "'cedula_destinatario='" + _dni_destinatario_enc + "'cedula_cliente='" + _dni_cliente_enc + "";
            SqlCommand comando = new SqlCommand(cadenaSQL, objConec.Conectar);
            comando.ExecuteNonQuery();
            objConec.Cerrar();
        }
        public void BuscarEnc(int _cod_enc)
        {
            objConec.Abrir();
            string cadenaSQL = "SELECT * from encomienda where codigo_enc =" + _cod_enc + "";
            SqlCommand comando = new SqlCommand(cadenaSQL, objConec.Conectar);
            comando.ExecuteNonQuery();
            objConec.Cerrar();
        }
        public DataTable MostrarReser()
        {
            try
            {
                objConec.Abrir();
                SqlCommand comando = new SqlCommand("Select * From reservacion", objConec.Conectar);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                return tabla;
            }
            catch
            {
                objConec.Cerrar();
                tabla = null;
                return tabla;
            }
        }
        public void InsertarReser(int _cod_reser, string _ciudad_destino, string _direccion_destino, string _ciudad_fin, DateTime _fecha_reser, float _valor_reser, int _dni_chofer, int _dni_cliente)
        {
            objConec.Abrir();
            String cadenaSQL = "INSERT into reservación(codigo_reser,ciudad_par_reser,direccion_par_reser,ciudad_lleg_reser,direccion_lleg_reser,fecha_reser,vlaor_res,cedula_chofer,cedula_cliente) VALUES(" + _cod_reser + ",'" + _ciudad_destino + "','" + _direccion_destino + "','" + _ciudad_fin + "','" + _fecha_reser + "','" + _dni_chofer + "','" + _dni_cliente + "')";
            SqlCommand comando = new SqlCommand(cadenaSQL, objConec.Conectar);
            comando.ExecuteNonQuery();
            objConec.Cerrar();

        }
        public void EliminarReser(int _cod_reser)
        {
            objConec.Abrir();
            string cadenaSQL = "DELETE from Estudiantes where dniEstudiante=" + _cod_reser + "";
            SqlCommand comando = new SqlCommand(cadenaSQL, objConec.Conectar);
            comando.ExecuteNonQuery();
            objConec.Cerrar();
        }
        public void EditarReser(int _cod_reser, string _ciudad_destino, string _direccion_destino, string _ciudad_fin, string _direccion_fin, DateTime _fecha_reser, float _valor_reser, int _dni_chofer, int _dni_cliente)
        {
            objConec.Abrir();
            string cadenaSQL = "UPDATE reservacion set codigo_reser'" + _cod_reser + "'ciudad_par_reser='" + _ciudad_destino + "'direccion_par_reser='" + _direccion_destino + "'ciudad_lleg_reser='" + _ciudad_fin + "'direccion_lleg_reser='" + _direccion_fin + "'fecha_reser='" + _fecha_reser + "'valor_res='" + _valor_reser + "'cedula_chofer='" + _dni_chofer + "'cedula_cliente='" + _dni_cliente + "";
            SqlCommand comando = new SqlCommand(cadenaSQL, objConec.Conectar);
            comando.ExecuteNonQuery();
            objConec.Cerrar();
        }

        public void BuscarReser(int _cod_reser)
        {
            objConec.Abrir();
            string cadenaSQL = "SELECT * from reservacion where codigo_reser =" + _cod_reser + "";
            SqlCommand comando = new SqlCommand(cadenaSQL, objConec.Conectar);
            comando.ExecuteNonQuery();
            objConec.Cerrar();
        }

        #region esto necesitamos la capa logica
        
        // regresa la una tabla con los datos del usuario con un nick en espeficifico
        public static DataTable ExisteUsuario(string nick)
        {
            try
            {
                var sentencia = "SELECT * FROM usuario WHERE id_usuario = '" + nick + "'";
                var tabla = new DataTable();
                var conexion = new SqlCommand(sentencia, objConec.Conectar);
                var adaptador = new SqlDataAdapter(conexion);
                adaptador.Fill(tabla);
                tabla.AcceptChanges();
                return tabla;
            }
            catch
            {
                // si ocurre un error se lanza esta excepcion, se debe campturar desde donde se llama la funcion "ExisteUsuario"
                throw new AccessViolationException();
            }
        }

        public static bool ValidadUsuarioContrasena(string usuario, string contrasena)
        {
            try
            {
                var sentencia = "" +
                                "SELECT * FROM usuario " +
                                "WHERE id_usuario = '" + usuario + "' " +
                                "AND contrasena_usuario = '" + contrasena + "'";
                var tabla = new DataTable();
                var conexion = new SqlCommand(sentencia, objConec.Conectar);
                var adaptador = new SqlDataAdapter(conexion);
                adaptador.Fill(tabla);
                tabla.AcceptChanges();
                return tabla.Rows.Count > 0;
            }
            catch
            {
                return false;
            }
        }

        public static void AnadirUsuarioBaseDatos(string cedula, string nombre, string apellido, string celular, string correo, string direccion, string nick, string contrasena )
        {
            try
            {
                var sentencia = "" +
                                "INSERT INTO usuarios " +
                                "VALUES('" + cedula + "', " +
                                "'" + nombre + "', " +
                                "'" + apellido + "', " +
                                "'" + celular + "', " +
                                "'" + correo + "', " +
                                "'" + direccion + "', " +
                                "'" + nick + "', " +
                                "'" + contrasena + "')";
                var conexion = new SqlCommand(sentencia, objConec.Conectar);
                conexion.ExecuteNonQuery();
            }
            catch
            {
                //
            }
        }

        #endregion

    }
}

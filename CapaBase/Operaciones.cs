﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaBase
{
    public class Operaciones
    {
        Conexion objConec = new Conexion();
        DataTable tabla = new DataTable();

        public DataTable MostrarEnc()
        {
            try
            {
                objConec.abrir();
                SqlCommand comando = new SqlCommand("Select * From encomienda", objConec.conectar);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                return tabla;
            }
            catch
            {
                objConec.cerrar();
                tabla = null;
                return tabla;
            }
        }
        public void InsertarEnc(int _cod_enc, string _ciudad_destino_enc, string _direccion_destino_enc, string _ciudad_fin_enc, DateTime _fecha_enc, float _valor_enc, int _codigo_postal_enc, float _peso_enc, string _descrip_enc, int _dni_destinatario_enc, int _dni_cliente_enc)
        {
            objConec.abrir();
            String cadenaSQL = "INSERT into encomienda(codigo_enc,ciudad_env_enc,direccion_env_enc,ciudad_lleg_enc,fecha_enc,valor_enc,codigo_postal_enc,peso,descripción,cecula_destinatario,cedula_cliente) VALUES(" + _cod_enc + ",'" + _ciudad_destino_enc + "','" + _direccion_destino_enc + "','" + _ciudad_fin_enc + "','" + _fecha_enc + "','" + _valor_enc + "','" + _codigo_postal_enc + "','" + _peso_enc + "','" + _descrip_enc + "','" + _dni_destinatario_enc + "','" + _dni_cliente_enc + "')";
            SqlCommand comando = new SqlCommand(cadenaSQL, objConec.conectar);
            comando.ExecuteNonQuery();
            objConec.cerrar();

        }
        public void EliminarEnc(int _cod_enc)
        {
            objConec.abrir();
            string cadenaSQL = "DELETE from encomienda where codigo_enc=" + _cod_enc + "";
            SqlCommand comando = new SqlCommand(cadenaSQL, objConec.conectar);
            comando.ExecuteNonQuery();
            objConec.cerrar();
        }
        public void EditarEnc(int _cod_enc, string _ciudad_destino_enc, string _direccion_destino_enc, string _ciudad_fin_enc, DateTime _fecha_enc, float _valor_enc, int _codigo_postal_enc, float _peso_enc, string _descrip_enc, int _dni_destinatario_enc, int _dni_cliente_enc)
        {
            objConec.abrir();
            string cadenaSQL = "UPDATE encomienda set codigo_enc'" + _cod_enc + "'ciudad_env_enc='" + _ciudad_destino_enc + "'direccion_env_enc='" + _direccion_destino_enc + "'ciudad_lleg_enc='" + _ciudad_fin_enc + "'fecha_enc'" + _fecha_enc + "'valor_enc='" + _valor_enc + "'codigo_postal_enc='" + _codigo_postal_enc + "'peso='" + _peso_enc + "'descripcion='" + _descrip_enc + "'cedula_destinatario='" + _dni_destinatario_enc + "'cedula_cliente='" + _dni_cliente_enc + "";
            SqlCommand comando = new SqlCommand(cadenaSQL, objConec.conectar);
            comando.ExecuteNonQuery();
            objConec.cerrar();
        }
        public void BuscarEnc(int _cod_enc)
        {
            objConec.abrir();
            string cadenaSQL = "SELECT * from encomienda where codigo_enc =" + _cod_enc + "";
            SqlCommand comando = new SqlCommand(cadenaSQL, objConec.conectar);
            comando.ExecuteNonQuery();
            objConec.cerrar();
        }
        public DataTable MostrarReser()
        {
            try
            {
                objConec.abrir();
                SqlCommand comando = new SqlCommand("Select * From reservacion", objConec.conectar);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                return tabla;
            }
            catch
            {
                objConec.cerrar();
                tabla = null;
                return tabla;
            }
        }
        public void InsertarReser(int _cod_reser, string _ciudad_destino, string _direccion_destino, string _ciudad_fin, DateTime _fecha_reser, float _valor_reser, int _dni_chofer, int _dni_cliente)
        {
            objConec.abrir();
            String cadenaSQL = "INSERT into reservación(codigo_reser,ciudad_par_reser,direccion_par_reser,ciudad_lleg_reser,direccion_lleg_reser,fecha_reser,vlaor_res,cedula_chofer,cedula_cliente) VALUES(" + _cod_reser + ",'" + _ciudad_destino + "','" + _direccion_destino + "','" + _ciudad_fin + "','" + _fecha_reser + "','" + _dni_chofer + "','" + _dni_cliente + "')";
            SqlCommand comando = new SqlCommand(cadenaSQL, objConec.conectar);
            comando.ExecuteNonQuery();
            objConec.cerrar();

        }
        public void EliminarReser(int _cod_reser)
        {
            objConec.abrir();
            string cadenaSQL = "DELETE from Estudiantes where dniEstudiante=" + _cod_reser + "";
            SqlCommand comando = new SqlCommand(cadenaSQL, objConec.conectar);
            comando.ExecuteNonQuery();
            objConec.cerrar();
        }
        public void EditarReser(int _cod_reser, string _ciudad_destino, string _direccion_destino, string _ciudad_fin, string _direccion_fin, DateTime _fecha_reser, float _valor_reser, int _dni_chofer, int _dni_cliente)
        {
            objConec.abrir();
            string cadenaSQL = "UPDATE reservacion set codigo_reser'" + _cod_reser + "'ciudad_par_reser='" + _ciudad_destino + "'direccion_par_reser='" + _direccion_destino + "'ciudad_lleg_reser='" + _ciudad_fin + "'direccion_lleg_reser='" + _direccion_fin + "'fecha_reser='" + _fecha_reser + "'valor_res='" + _valor_reser + "'cedula_chofer='" + _dni_chofer + "'cedula_cliente='" + _dni_cliente + "";
            SqlCommand comando = new SqlCommand(cadenaSQL, objConec.conectar);
            comando.ExecuteNonQuery();
            objConec.cerrar();
        }

        public void BuscarReser(int _cod_reser)
        {
            objConec.abrir();
            string cadenaSQL = "SELECT * from reservacion where codigo_reser =" + _cod_reser + "";
            SqlCommand comando = new SqlCommand(cadenaSQL, objConec.conectar);
            comando.ExecuteNonQuery();
            objConec.cerrar();
        }
    }
}
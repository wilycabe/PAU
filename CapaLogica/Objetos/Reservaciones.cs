namespace CapaLogica.Objetos
{
    public class Reservacion
    {

        public string Codigo { get; set; }
        public string CiudadPartida { get; set; }
        public string DireccionPartida { get; set; }
        public string CiudadDestino { get; set; }
        public string DireccionDestino { get; set; }
        public string FechaReservacion { get; set; }
        public double ValorReservacion { get; set; }
        public string CedulaChofer { get; set; }
        public string CedulaCliente { get; set; }

        public Reservacion()
        {
            Codigo = string.Empty;
            CiudadPartida = string.Empty;
            DireccionPartida = string.Empty;
            CiudadDestino = string.Empty;
            DireccionDestino = string.Empty;
            FechaReservacion = string.Empty;
            ValorReservacion = 0;
            CedulaChofer = string.Empty;
            CedulaCliente = string.Empty;
        }

        public Reservacion(string codigo, string ciudadPartida, string direccionPartida, string ciudadDestino, string direccionDestino, string fechaReservacion, double valorReservacion, string cedulaChofer, string cedulaCliente)
        {
            Codigo = codigo;
            CiudadPartida = ciudadPartida;
            DireccionPartida = direccionPartida;
            CiudadDestino = ciudadDestino;
            DireccionDestino = direccionDestino;
            FechaReservacion = fechaReservacion;
            ValorReservacion = valorReservacion;
            CedulaCliente = cedulaCliente;
            CedulaChofer = cedulaChofer;
        }

        
    }
}

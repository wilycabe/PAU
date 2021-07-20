namespace CapaLogica.Objetos
{
    public class Reservacione
    {

        public string Codigo { get; set; }
        public string CiudadPartida { get; set; }
        public string DireccionPartida { get; set; }
        public string CiudadDestino { get; set; }
        public string DireccionDestino { get; set; }
        public string FechaReservacion { get; set; }
        public string ValorReservacion { get; set; }

        public Reservacione()
        {
            Codigo = string.Empty;
            CiudadPartida = string.Empty;
            DireccionPartida = string.Empty;
            CiudadDestino = string.Empty;
            DireccionDestino = string.Empty;
            FechaReservacion = string.Empty;
            ValorReservacion = string.Empty;
        }

        public Reservacione(string codigo, string ciudadPartida, string direccionPartida, string ciudadDestino, string direccionDestino, string fechaReservacion, string valorReservacion)
        {
            Codigo = codigo;
            CiudadPartida = ciudadPartida;
            DireccionPartida = direccionPartida;
            CiudadDestino = ciudadDestino;
            DireccionDestino = direccionDestino;
            FechaReservacion = fechaReservacion;
            ValorReservacion = valorReservacion;
        }

    }
}

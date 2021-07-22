namespace CapaLogica.Objetos
{
    public class Encomienda
    {

        public string Codigo { get; set; }
        public string Peso { get; set; }
        public string Descripcion { get; set; }
        public string FechaEnvio { get; set; }
        public string CodigoPostal { get; set; }
        public string CiudadEnvio { get; set; }
        public string CiudadLlegada { get; set; }
        public string ValorEncomienda { get; set; }
        public string CedulaCliente { get; set; }
        public string CedulaDestinatario { get; set; }

        public Encomienda()
        {
            Codigo = string.Empty;
            Peso = string.Empty;
            Descripcion = string.Empty;
            FechaEnvio = string.Empty;
            CodigoPostal = string.Empty;
            CiudadEnvio = string.Empty;
            CiudadLlegada = string.Empty;
            ValorEncomienda = string.Empty;
            CedulaCliente = string.Empty;
            CedulaDestinatario = string.Empty;
        }

        public Encomienda(string codigo, string peso, string descripcion, string fechaEnvio, string codigoPostal, string ciudadEnvio, string ciudadLlegada, double valorEncomienda, string cedulaCliente, string cedulaDestinatario)
        {
            Codigo = codigo;
            Peso = peso;
            Descripcion = descripcion;
            FechaEnvio = fechaEnvio;
            CodigoPostal = codigoPostal;
            CiudadEnvio = ciudadEnvio;
            CiudadLlegada = ciudadLlegada;
            ValorEncomienda = valorEncomienda.ToString("C2");
            CedulaCliente = cedulaCliente;
            CedulaDestinatario = cedulaDestinatario;
        }

    }
}

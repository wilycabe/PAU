using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBase
{
    class ReporteEnc
    {
        
        public string CodeEnc { get; set; }
        public string CiudaEnvio { get; set; }
        public string DireccionEnvio { get; set; }
        public string CiudadLlegadaEnvio { get; set; }
        public string DireccionLlegadaEnvio { get; set; }
        public string FecharEncomienda { get; set; }
        public string ValorrEncomienda { get; set; }
        public string Codigopostal { get; set; }
        public float PesoEncomienda { get; set; }
        public string DescripEncomienda { get; set; }
        public string CedulaDestinatario { get; set; }
        public string CedulaClient { get; set; }

        public ReporteEnc() { }
    }
}

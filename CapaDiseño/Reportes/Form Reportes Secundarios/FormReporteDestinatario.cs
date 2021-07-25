using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseño.Reportes.Form_Reportes_Secundarios
{
    public partial class FormReporteDestinatario : Form
    {
        public FormReporteDestinatario()
        {
            InitializeComponent();
        }

        private void FormReporteDestinatario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetPrincipal.Reporte_destinatario' Puede moverla o quitarla según sea necesario.
            this.Reporte_destinatarioTableAdapter.Fill(this.dataSetPrincipal.Reporte_destinatario);
            this.reportViewer1.RefreshReport();
        }
    }
}

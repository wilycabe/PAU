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
    public partial class FormReporteReservaciones : Form
    {
        public FormReporteReservaciones()
        {
            InitializeComponent();
        }

        private void FormReporteReservaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetPrincipal.Reporte_reservacion' Puede moverla o quitarla según sea necesario.
            this.Reporte_reservacionTableAdapter.Fill(this.dataSetPrincipal.Reporte_reservacion);
            this.reportViewer1.RefreshReport();
        }
    }
}

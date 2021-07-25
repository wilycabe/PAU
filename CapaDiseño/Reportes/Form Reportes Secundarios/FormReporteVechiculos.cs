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
    public partial class FormReporteVechiculos : Form
    {
        public FormReporteVechiculos()
        {
            InitializeComponent();
        }

        private void FormReporteVechiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetPrincipal.Reporte_vehiculo' Puede moverla o quitarla según sea necesario.
            this.Reporte_vehiculoTableAdapter.Fill(this.dataSetPrincipal.Reporte_vehiculo);
            this.reportViewer1.RefreshReport();
        }
    }
}

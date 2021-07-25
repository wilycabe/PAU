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
    public partial class FormReporteEncomienda_Real : Form
    {
        private DateTime fecha= DateTime.Now;
        public FormReporteEncomienda_Real()
        {
            InitializeComponent();
        }
        
        private void FormReporteEncomienda_Real_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetPrincipal.Reporte_encomienda_realizada' Puede moverla o quitarla según sea necesario.
            this.Reporte_encomienda_realizadaTableAdapter.Fill(this.dataSetPrincipal.Reporte_encomienda_realizada, fecha);
            this.reportViewer1.RefreshReport();
        }
    }
}

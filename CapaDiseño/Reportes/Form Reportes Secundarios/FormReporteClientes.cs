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
    public partial class FormReporteClientes : Form
    {
        public FormReporteClientes()
        {
            InitializeComponent();
        }

        private void FormReporteClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.Reporte_cliente' Puede moverla o quitarla según sea necesario.
            this.Reporte_clienteTableAdapter.Fill(this.DataSetPrincipal.Reporte_cliente);
            this.reportViewer1.RefreshReport();
        }
    }
}

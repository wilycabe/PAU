using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaLogica.Objetos;

namespace CapaDiseño.Encomiendas
{
    public partial class BuscarDatosEncomienda : Form
    {
        private readonly DataTable _table = OperacionesLl.Encomiendas();
        public BuscarDatosEncomienda()
        {
            InitializeComponent();
        }

        private void BuscarDatosEncomienda_Load(object sender, EventArgs e)
        {
            dgvBuscar.DataSource = _table;
            dgvBuscar.Columns[0].Visible = false;
            dgvBuscar.Columns[8].Visible = false;
            dgvBuscar.Columns[10].Visible = false;
            dgvBuscar.Columns[13].Visible = false;
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == @"Ingrese el código de una encomienda")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.DimGray;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Ingrese el código de una encomienda";
                txtBuscar.ForeColor = Color.DarkGray;
                dgvBuscar.DataSource = _table;
                dgvBuscar.Columns[0].Visible = false;
                dgvBuscar.Columns[8].Visible = false;
                dgvBuscar.Columns[10].Visible = false;
                dgvBuscar.Columns[13].Visible = false;
            }
        }
    }
}

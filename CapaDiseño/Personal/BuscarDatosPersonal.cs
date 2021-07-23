using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica.Objetos;

namespace CapaDiseño
{
    public partial class BuscarDatosPersonal : Form
    {
        public BuscarDatosPersonal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var cedula = txtBuscarPersonal.Text;
            var table = OperacionesLl.BuscarChofer(cedula);
            if (table.Rows.Count > 0)
            {
                dgvBuscarPersonal.DataSource = null;
                table.Columns[0].ColumnName = "Cédula";
                table.Columns[1].ColumnName = "Nombre";
                table.Columns[2].ColumnName = "Apellido";
                table.Columns[3].ColumnName = "Celular";
                table.Columns[4].ColumnName = "Correo";
                table.Columns[5].ColumnName = "Dirección";
                table.Columns[6].ColumnName = "Fecha nacimiento";
                dgvBuscarPersonal.DataSource = table;
            }
            else
            {
                MessageBox.Show(@"No se han encontrado coincidencias", @"Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvBuscarPersonal.CurrentRow != null)
            {
                if (MessageBox.Show(@"Seguro que de desea eliminar este elemento?", @"Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                var cedula = dgvBuscarPersonal.CurrentRow.Cells[0].Value.ToString();
                OperacionesLl.EliminarVehiculoPorChofer(cedula);
                OperacionesLl.EliminarChofer(cedula);
                MessageBox.Show(@"Se han eliminado los registros", @"Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"Selecione primero una fila", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}

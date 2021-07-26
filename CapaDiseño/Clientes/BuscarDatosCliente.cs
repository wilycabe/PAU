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
using CapaLogica.Personas;

namespace CapaDiseño
{
    public partial class BuscarDatosCliente : Form
    {
       // private readonly DataTable _table = OperacionesLl.Clientes();
        public BuscarDatosCliente()
        {
            InitializeComponent();
        }

        private void BuscarDatosCliente_Load(object sender, EventArgs e)
        {
           // dgvBuscarCliente.DataSource = _table;
            
        }

        private void textBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

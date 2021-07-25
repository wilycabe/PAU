using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseño.Reportes.Form_Reportes_Secundarios;

namespace CapaDiseño
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FormReporteChofer formReporteChofer = new FormReporteChofer();
            formReporteChofer.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            FormReporteClientes formReporteClientes = new FormReporteClientes();
            formReporteClientes.ShowDialog();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            FormReporteDestinatario formReporteDestinatario = new FormReporteDestinatario();
            formReporteDestinatario.ShowDialog();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            FormReporteEncomienda_Pen formReporteEncomienda_Pen = new FormReporteEncomienda_Pen();
            formReporteEncomienda_Pen.ShowDialog();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            FormReporteEncomienda_Real formReporteEncomienda_Real = new FormReporteEncomienda_Real();
            formReporteEncomienda_Real.ShowDialog();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            FormReporteReservaciones formReporteReservaciones = new FormReporteReservaciones();
            formReporteReservaciones.ShowDialog();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            FormReporteUsuario formReporteUsuario = new FormReporteUsuario();
            formReporteUsuario.ShowDialog();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            FormReporteVechiculos formReporteVechiculos = new FormReporteVechiculos();
            formReporteVechiculos.ShowDialog();
        }
    }
}

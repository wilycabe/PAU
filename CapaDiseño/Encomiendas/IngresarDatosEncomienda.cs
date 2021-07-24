using System;
using System.CodeDom;
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
    public partial class IngresarDatosEncomienda : Form
    {
        public IngresarDatosEncomienda()
        {
            InitializeComponent();
        }

        public bool ValidarCampos()
        {
            if (!Encomienda.VerificarDimensiones(txtDimenConte.Text)) return false;
            if (!Encomienda.VerificarFechaEnvio(dateTimePicker.Text)) return false;
            if (OperacionesLl.ExisteDestinatario(txtCedulaDestintario.Text)) return true;
            if (!Destinatario.VerificarCedula(txtCedulaDestintario.Text)) return false;
            if (!Destinatario.VerificarCelular(txtTelefono.Text)) return false;
            if (!Destinatario.VerificarCorreo(textCorreo.Text)) return false;
            if (!Destinatario.VerificarNombreOApellido(txtNombre.Text)) return false;
            if (!Destinatario.VerificarNombreOApellido(textApellido.Text)) return false;
            if (!Destinatario.VerificarCorreo(textCorreo.Text)) return false;
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            var destinatario = new Destinatario()
            {
                Nombre = txtNombre.Text,
                Cedula = txtCedulaDestintario.Text,
                Apellido = textApellido.Text,
                Direccion = txtDireccionDestinatario.Text,
                Celular = txtTelefono.Text,
                Correo = textCorreo.Text,
            };
            var encomienda = new Encomienda()
            {
                CiudadEnvio = txtCiudadEnvio.Text,
                DireccionEnvio = txtDireccionEnvio.Text,
                CiudadLlegada = txtCiudadLLegada.Text,
                DireccionLlegada = txtDireccionLLegada.Text,
                FechaEnvio = dateTimePicker.Text,
                ValorEncomienda = double.Parse(txtPreciollegada.Text),
                Descripcion = "   ",
                CedulaDestinatario = txtCedulaDestintario.Text,
                CedulaCliente = txtCedulaCliente.Text,
                CedulaChofer = "1805206479",
                Peso = double.Parse(txtPeso.Text),
            };
            if (OperacionesLl.ExisteCliente(encomienda.CedulaCliente))
            {
                if (!OperacionesLl.ExisteDestinatario(destinatario.Cedula))
                {
                    OperacionesLl.AnadirDestinatario(destinatario);
                    MessageBox.Show(@"Se ha registrado un nuevo destinatario", @"Información", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                OperacionesLl.AnadirEncomienda(encomienda);
                MessageBox.Show(@"Se ha registrado la encomienda", @"Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"El cliente no existe", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IngresarDatosEncomienda_Load(object sender, EventArgs e)
        {

        }
    }
}

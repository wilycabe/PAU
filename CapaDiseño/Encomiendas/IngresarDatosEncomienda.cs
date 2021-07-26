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

        private void txtCedulaDestintario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtCedulaDestintario.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtCedulaDestintario.Focus();

                    }
                    else
                    {
                        txtNombre.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtCedulaDestintario.Focus();
                }
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtNombre.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtNombre.Focus();

                    }
                    else
                    {
                        textApellido.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtNombre.Focus();
                }
            }
        }

        private void textApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (textApellido.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        textApellido.Focus();

                    }
                    else
                    {
                        txtDireccionDestinatario.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    textApellido.Focus();
                }
            }
        }

        private void txtDireccionDestinatario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtDireccionDestinatario.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtDireccionDestinatario.Focus();

                    }
                    else
                    {
                        txtTelefono.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtDireccionDestinatario.Focus();
                }
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtTelefono.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtTelefono.Focus();

                    }
                    else
                    {
                        textCorreo.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtTelefono.Focus();
                }
            }
        }

        private void textCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (textCorreo.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        textCorreo.Focus();

                    }
                    else
                    {
                        txtPeso.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    textCorreo.Focus();
                }
            }

        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtPeso.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtPeso.Focus();

                    }
                    else
                    {
                        txtDimenConte.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtPeso.Focus();
                }
            }
        }

        private void txtDimenConte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtDimenConte.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtDimenConte.Focus();

                    }
                    else
                    {
                        dateTimePicker.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtDimenConte.Focus();
                }
            }

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker.Value <= System.DateTime.Now)
                {
                    MessageBox.Show("La fecha no puede ser igual o anterior al día actual", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    dateTimePicker.Focus();

                }
                else
                {
                    txtCiudadEnvio.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Seleccione una fecha válida", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                dateTimePicker.Focus();
            }
        }

        private void txtCiudadEnvio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtCiudadEnvio.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtCiudadEnvio.Focus();

                    }
                    else
                    {
                        txtDireccionEnvio.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtCiudadEnvio.Focus();
                }
            }
        }

        private void txtDireccionEnvio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtDireccionEnvio.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtDireccionEnvio.Focus();

                    }
                    else
                    {
                        txtCiudadLLegada.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtDireccionEnvio.Focus();
                }
            }

        }

        private void txtCiudadLLegada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtCiudadLLegada.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtCiudadLLegada.Focus();

                    }
                    else
                    {
                        txtDireccionLLegada.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtCiudadLLegada.Focus();
                }
            }
        }

        private void txtDireccionLLegada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtDireccionLLegada.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtDireccionLLegada.Focus();

                    }
                    else
                    {
                        txtPreciollegada.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtDireccionLLegada.Focus();
                }
            }
        }

        private void txtPreciollegada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtPreciollegada.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtPreciollegada.Focus();

                    }
                    else
                    {
                        txtCedulaCliente.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtPreciollegada.Focus();
                }
            }
        }

        private void txtCedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtCedulaCliente.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtCedulaCliente.Focus();

                    }
                    else
                    {
                        btnGuardar.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtCedulaCliente.Focus();
                }
            }
        }

    }


}

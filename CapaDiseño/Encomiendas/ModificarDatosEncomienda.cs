using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseño
{
    public partial class ModificarDatosEncomienda : Form
    {
        public ModificarDatosEncomienda()
        {
            InitializeComponent();
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtNombreApellido.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtNombreApellido.Focus();

                    }
                    else
                    {
                        txtDireccionDestino.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtNombreApellido.Focus();
                }
            }
        }

        private void txtDireccionDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtDireccionDestino.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtDireccionDestino.Focus();

                    }
                    else
                    {
                        txtTelefono.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtDireccionDestino.Focus();
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
                        txtPeso.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtTelefono.Focus();
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
                        txtTipo.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtPeso.Focus();
                }
            }
        }

        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtTipo.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtTipo.Focus();

                    }
                    else
                    {
                        txtCedulaRemitente.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtCodigoPostal.Focus();
                }
            }
        }

        private void txtCedulaRemitente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtCedulaRemitente.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtCedulaRemitente.Focus();

                    }
                    else
                    {
                        txtCedulaCliente.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtCedulaRemitente.Focus();
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
                        txtDimenConte.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtCedulaCliente.Focus();
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
                        txtFechaEnvio.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtDimenConte.Focus();
                }
            }
        }

        private void txtFechaEnvio_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtFechaEnvio.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtFechaEnvio.Focus();

                    }
                    else
                    {
                        txtCiudadEnvio.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtFechaEnvio.Focus();
                }
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
                        txtCiudadLLegada.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtCiudadEnvio.Focus();
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
                        txtPreciollegada.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtCiudadLLegada.Focus();
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
                        button3.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    button3.Focus();
                }
            }
        }
    }
}

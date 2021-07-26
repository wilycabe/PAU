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
    public partial class ModificarDatosCliente : Form
    {
        public ModificarDatosCliente()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

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
                        txtApellido.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtNombre.Focus();
                }

            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtApellido.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtApellido.Focus();

                    }
                    else
                    {
                        txtCedula.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtApellido.Focus();
                }
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtCedula.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtCedula.Focus();

                    }
                    else
                    {
                        txtDireccion.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtCedula.Focus();
                }
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtDireccion.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtDireccion.Focus();

                    }
                    else
                    {
                        txtCelular.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtDireccion.Focus();
                }
            }
        }

        private void ModificarDatosCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtCelular.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtCelular.Focus();

                    }
                    else
                    {
                        txtFechaNaci.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtCelular.Focus();
                }
            }
        }

        private void txtFechaNaci_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaNaci_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtFechaNaci.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtFechaNaci.Focus();

                    }
                    else
                    {
                        btnGuardar.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtDireccion.Focus();
                }
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

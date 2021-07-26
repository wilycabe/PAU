using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica.Personas;
using CapaLogica.Objetos;


namespace CapaDiseño
{
    public partial class IngresarDatosCliente : Form
    {
        public IngresarDatosCliente()
        {
            InitializeComponent();
        }


        private bool validarCampos()
        {
            if (!Cliente.VerificarNombreOApellido(txtNombre.Text)) return false;
            if (!Cliente.VerificarNombreOApellido(txtApellido.Text)) return false;
            if (!Cliente.VerificarCedula(txtCedula.Text)) return false;
            if (!Cliente.VerificarCelular(txtCedula.Text)) return false;
            if (!Cliente.VerificarFechaNacimieto(txtFechaNaci.Text)) return false;
            return true;
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
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
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

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
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

        private void txtFechaNaci_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
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
                        bntIngresar.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtDireccion.Focus();
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

        private void bntIngresar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                var cliente = new Cliente()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Cedula = txtCedula.Text,
                    Direccion = txtDireccion.Text,
                    Celular = txtCelular.Text,
                    FechaNacimiento = txtFechaNaci.Text,
                };

                if (!OperacionesLl.ExisteCliente(cliente.Cedula))
                {
                    OperacionesLl.AnadirCliente(cliente);
                    MessageBox.Show(@"Registro guardado", @"Información", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(@"Este registro ya existe", @"Información", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(@"Faltan campos por completar.", @"Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}

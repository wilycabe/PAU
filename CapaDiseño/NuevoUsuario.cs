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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.LightGray;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.LightGray;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.LightGray;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
                txtApellido.ForeColor = Color.LightGray;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.LightGray;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
                txtCorreo.ForeColor = Color.LightGray;
            }
        }

        private void txtNombreUsuario_Enter(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "Nombre de usuario")
            {
                txtNombreUsuario.Text = "";
                txtNombreUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtNombreUsuario_Leave(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "")
            {
                txtNombreUsuario.Text = "Nombre de usuario";
                txtNombreUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.LightGray;
                
            }
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            if (txtCedula.Text == "Cedula")
            {
                txtCedula.Text = "";
                txtCedula.ForeColor = Color.LightGray;
                
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "Cedula";
                txtCedula.ForeColor = Color.LightGray;

            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            var nombre = txtNombre.Text;
            var apellido = txtApellido.Text;
            var correo = txtCorreo.Text;
            var nombreUsuario = txtNombreUsuario.Text;
            var contrasena = txtContraseña.Text;
            var cedula = txtCedula.Text;
            if (OperacionesLl.ExisteUsuario(nombreUsuario))
            {
                try
                {
                    var usuario = new Usuario()
                    {
                        Apellido = apellido,
                        Cedula = cedula,
                        Nombre = nombre,
                        Correo = correo,
                        Contrasena = contrasena
                    };
                    OperacionesLl.AnadirUsuario(usuario);
                    var parentForm = ParentForm;
                    parentForm?.Hide();
                    var oWel = new Welcome();
                    oWel.ShowDialog();
                    var oPrinci = new PantallaPrincipal();
                    oPrinci.ShowDialog();
                }
                catch
                {
                    MessageBox.Show(@"El usuairio ya existe", @"Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show(@"El usuairio ya existe", @"Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {

                    if (txtNombre.Text== "")
                    {
                        MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtNombre.Focus();
                    }
                    else
                    {
                        txtApellido.Focus();
                    }
                    


                }
                catch
                {
                    MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
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
                        MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtApellido.Focus();
                    }
                    else
                    {
                        txtCorreo.Focus();
                    }
                    
                }
                catch
                {
                    MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtApellido.Focus();
                }
            }
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtNombreUsuario.Text == "")
                    {
                        MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtNombreUsuario.Focus();
                    }
                    else
                    {
                        txtContraseña.Focus();
                    }



                }
                catch
                {
                    MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtNombreUsuario.Focus();
                }
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtCorreo.Text == "")
                    {
                        MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtCorreo.Focus();
                    }
                    else
                    {
                        txtNombreUsuario.Focus();
                    }

                    

                }
                catch
                {
                    MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtCorreo.Focus();
                }
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtContraseña.Text == "")
                    {
                        MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtContraseña.Focus();
                    }
                    else
                    {
                        txtCedula.Focus();
                    }



                }
                catch
                {
                    MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtCorreo.Focus();
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
                        MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtCedula.Focus();
                    }
                    else
                    {
                        btnAcceder.Focus();
                    }



                }
                catch
                {
                    MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtCorreo.Focus();
                }
            }
        }
    }
}

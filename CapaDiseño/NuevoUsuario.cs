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
            else
            {
                MessageBox.Show(@"El usuairio ya existe", @"Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}

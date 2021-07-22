using CapaLogica.Personas;
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
    public partial class CuadroLogin : Form
    {
        public CuadroLogin()
        {
            InitializeComponent();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Contraseña";
                txtUser.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    Usuario.VerificarNick(txtUser.Text);

                }
                catch(ArgumentException)
                {
                    MessageBox.Show("El nombre de usuario solo admite números y letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string Usuario;
            string Pass;
            Usuario = txtUser.Text;
            Pass = txtPass.Text;
            Operaciones oObj = new Operaciones();
            oObj.ConectarBaseDatos();
            if (Operaciones.ValidadUsuarioContrasena(Usuario, Pass) == true)
            {
                PantallaPrincipal oPantalla = new PantallaPrincipal();
                oPantalla.Show();
            }
        }
    }
}

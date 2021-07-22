using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace CapaDiseño
{
    public partial class InicioSesion : Form
    {
        NuevoUsuario objNuevoUser = new NuevoUsuario();
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

      

      

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            CuadroLogin objNuevoUser = new CuadroLogin();
            objNuevoUser.TopLevel = false;
            objNuevoUser.Dock = DockStyle.Fill;
            panel3.Controls.Add(objNuevoUser);
            panel3.Tag = objNuevoUser;
            objNuevoUser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Form Login in panel3.Controls)
            {
                panel3.Controls.Remove(Login);
            }
            objNuevoUser.TopLevel = false;
            objNuevoUser.Dock = DockStyle.Fill;
            panel3.Controls.Add(objNuevoUser);
            panel3.Tag = objNuevoUser;
            objNuevoUser.Show();
        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            PantallaPrincipal objPrin = new PantallaPrincipal();
            objPrin.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Form Login in panel3.Controls)
            {
                panel3.Controls.Remove(Login);
            }
            CuadroLogin objNuevoUser = new CuadroLogin();
            objNuevoUser.TopLevel = false;
            objNuevoUser.Dock = DockStyle.Fill;
            panel3.Controls.Add(objNuevoUser);
            panel3.Tag = objNuevoUser;
            objNuevoUser.Show();
        }
    }
}

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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
            Visibilidad();
        }
        private void Visibilidad()
        {
            panelPersonal.Visible = false;
            panelCliente.Visible = false;
            panelEncomienda.Visible = false;
            panelViaje.Visible = false;
        }
        private void OcultarSubmenu()
        {
            if (panelPersonal.Visible == true)
                panelPersonal.Visible = false;
            if (panelCliente.Visible == true)
                panelCliente.Visible = false;
            if (panelEncomienda.Visible == true)
                panelEncomienda.Visible = false;
            if (panelViaje.Visible == true)
                panelViaje.Visible = false;
        }
        private void MostrarSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void openChildForm(Form childForm) // Metodo para abrir panel hijo en panel padre
        {

            foreach (Form ActiveForm in panelPadre.Controls) ActiveForm.Close();
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;

            this.panelPadre.Controls.Add(childForm);
            this.panelPadre.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

      


        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            MostrarSubmenu(panelPersonal);

            if (panelPadre.Controls.Count > 0)
            {
                panelPadre.Controls.RemoveAt(0);
            }

        }

        private void iconButton13_Click_1(object sender, EventArgs e)
        {
            MostrarSubmenu(panelCliente);

            if (panelPadre.Controls.Count > 0)
            {
                panelPadre.Controls.RemoveAt(0);
            }

        }

        private void iconButton18_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelEncomienda);

            if (panelPadre.Controls.Count > 0)
            {
                panelPadre.Controls.RemoveAt(0);
            }

        }

        private void iconButton19_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelViaje);

            if (panelPadre.Controls.Count > 0)
            {
                panelPadre.Controls.RemoveAt(0);
            }

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
            //
            //
            //
            if (panelPadre.Controls.Count > 0)
            {
                panelPadre.Controls.RemoveAt(0);
            }
            openChildForm(new IngresarDatosPersonal());
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
            openChildForm(new BuscarDatosPersonal());

        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
            openChildForm(new ModificarDatosPersonal());


        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            //OcultarSubmenu();
            //openChildForm(new EliminarDatosPersonal());

        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
            openChildForm(new IngresarDatosCliente());

        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
            openChildForm(new BuscarDatosCliente());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
            openChildForm(new ModificarDatosCliente());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            //OcultarSubmenu();
            //openChildForm(new EliminarDatosCliente());
        }

        private void iconButton17_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
            openChildForm(new IngresarDatosEncomienda());
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
            openChildForm(new BuscarDatosEncomienda());
        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
            openChildForm(new ModificarDatosEncomienda());
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            //OcultarSubmenu();
            //openChildForm(new EliminarDatosEncomienda());
        }

        private void iconButton24_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
            openChildForm(new AgendarViaje());
        }

        private void iconButton23_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
            openChildForm(new ContabilizarViaje());
        }

        private void iconButton22_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
            openChildForm(new AgendaDeViaje());
        }

        private void iconButton20_Click(object sender, EventArgs e)
        {
            //
            //
            //
            OcultarSubmenu();
            if (panelPadre.Controls.Count > 0)
            {
                panelPadre.Controls.RemoveAt(0);
            }
            openChildForm(new FormReportes());

        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            OcultarSubmenu();
            if (panelPadre.Controls.Count > 0)
            {
            panelPadre.Controls.RemoveAt(0);
            }
            openChildForm(new FormInicio());

            
        }
    }
}

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
            visibilidad();
            
        }

        private void visibilidad()
        {
            panelSubMenuPersonal.Visible = false;
            panelSubMenuCliente.Visible = false;
            panelSubMenuEnco.Visible = false;
            panelSubMenuViajes.Visible = false;
        }

        private void ocultarSubMenu()
        {
            if (panelSubMenuPersonal.Visible == true)
                panelSubMenuPersonal.Visible = false;
            if (panelSubMenuCliente.Visible == true)
                panelSubMenuCliente.Visible = true;
            if (panelSubMenuEnco.Visible == true)
                panelSubMenuEnco.Visible = false;
            if (panelSubMenuViajes.Visible == true)
                panelSubMenuViajes.Visible = false;

        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        
     
        private void MostrarSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
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
            this.WindowState = FormWindowState.Minimized;
        }

        private void openChildForm(Form childForm) // Metodo para abrir panel hijo en panel padre
        {

            foreach (Form ActiveForm in panelPrincipal.Controls) ActiveForm.Close();
            childForm.TopLevel = false;
            //childForm.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(childForm);
            this.panelPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        

        private void btnEncomiendas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuEnco);
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }

        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuPersonal);
            //MostrarSubmenu(panelSubMenuPersonal);
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }

        }

        private void btnIngresarPersonal_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }
            openChildForm(new IngresarDatosPersonal());

        }

        private void btnBuscarPersonal_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }
            openChildForm(new BuscarDatosPersonal());
        }

        private void btnModificarPersonal_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }
            openChildForm(new ModificarDatosPersonal());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuCliente);
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }

        }

        private void btnIngresarClientes_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }
            openChildForm(new IngresarDatosCliente());
        }

        

        private void btnModificarClientes_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }
            openChildForm(new ModificarDatosCliente());
        }

        private void btnIngresarEnco_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }
            openChildForm(new IngresarDatosEncomienda());
        }

        private void btnBuscarEnco_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }
            openChildForm(new BuscarDatosEncomienda());
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuViajes);
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }

        }

        private void btnAgendarViaje_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }
            openChildForm(new AgendarViaje());
        }

        private void btnContabilizarViaje_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }
            openChildForm(new ContabilizarViaje());
        }

        private void btnAgendaDeViaje_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }
            openChildForm(new AgendaDeViaje());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }
            openChildForm(new FormReportes());

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }
            openChildForm(new FormInicio());

        }

       

        private void btnModificarEnco_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }
            openChildForm(new ModificarDatosEncomienda());
            
        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
           if (panelPrincipal.Controls.Count > 0)
           {
                panelPrincipal.Controls.RemoveAt(0);
           }
            openChildForm(new BuscarDatosCliente());
            
        }

        private void btnModificarClientes_Click_1(object sender, EventArgs e)
        {
            ocultarSubMenu();
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }
            openChildForm(new ModificarDatosCliente());
        }
    }
}

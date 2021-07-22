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

namespace CapaDiseño
{
    public partial class BuscarDatosCliente : Form
    {
        public BuscarDatosCliente()
        {
            InitializeComponent();
        }
       


        private void textBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                   // Cliente.ExisteCliente(oCliente);
                    //code
                    //code


                }
                catch (ArgumentException)
                {
                //MessageBox.Show("No se ha encontrado el cliente con numero de cedula " + '"' + cliente.Cedula + '"' + ".", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                //Cliente.bu(oCliente); aca va el buscar
                //code
            }
            catch (ArgumentException)
            {
                //MessageBox.Show("No se ha encontrado el cliente con numero de cedula " + '"' + cliente.Cedula + '"' + ".", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente oCliente = new Cliente();

                if (Cliente.ExisteCliente(oCliente) == true)
                {
                    //elimina
                }
                else
                {
                    //aca no :vvv
                }
            }
            catch (ArgumentException)
            {
                //MessageBox.Show("No se ha encontrado el cliente con numero de cedula " + '"' + cliente.Cedula + '"' + ".", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente oCliente = new Cliente();
                oCliente.Cedula = textBuscar.Text;
                if(Cliente.ExisteCliente(oCliente) == false)
                {
                    //guarda
                    MessageBox.Show("Se ha registrado el cliente" + '"' + ".", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se ha encontrado el cliente" + '"' + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //aca no :vvv
                }


            }
            catch (ArgumentException)
            {
                MessageBox.Show("No se ha guardado el cliente" + '"' + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

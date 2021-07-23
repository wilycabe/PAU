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
    public partial class ModificarDatosPersonal : Form
    {
        public ModificarDatosPersonal()
        {
            InitializeComponent();
        }

        private bool ValidadCampos()
        {
            if (!Chofer.VerificarNombreOApellido(txtNombre.Text)) return false;
            if (!Chofer.VerificarNombreOApellido(txtApellido.Text)) return false;
            if (!Chofer.VerificarCedula(txtCedula.Text)) return false;
            if (!Chofer.VerificarCelular(txtCelular.Text)) return false;
            if (!Vehiculo.ValidarPlaca(txtPlaca.Text)) return false;
            if (!Chofer.VerificarCorreo(txtCorreo.Text)) return false;
            return true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var cedula = textBuscar.Text;
            
            var vehiculo = OperacionesLl.BuscarVehiculoPorChofer(cedula);
            var chofer = OperacionesLl.BuscarChofer(cedula);
            if (chofer.Rows.Count > 0 && vehiculo.Rows.Count > 0)
            {
                var fila = chofer.Rows[0];
                txtCedula.Text = fila[0].ToString();
                txtNombre.Text = fila[1].ToString();
                txtApellido.Text = fila[2].ToString();
                txtCelular.Text = fila[3].ToString();
                txtCorreo.Text = fila[4].ToString();
                txtDireccion.Text = fila[5].ToString();
                var fila2 = vehiculo.Rows[0];
                txtPlaca.Text = fila2[0].ToString();
                txtModeloVehi.Text = fila2[1].ToString();
                txtMarcaVehiculo.Text = fila2[2].ToString();
                txtColor.Text = fila2[3].ToString();
            }
            else
            {
                MessageBox.Show(@"No se han encontrado coincidencias", @"Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidadCampos())
            {
                var chofer = new Chofer()
                {
                    Cedula = txtCedula.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Celular = txtCelular.Text,
                    Correo = txtCorreo.Text,
                    Direccion = txtDireccion.Text,
                    FechaNacimineto = "1999-04-13"
                };
                var vehiculo = new Vehiculo()
                {
                    Placa = txtPlaca.Text,
                    Agno = 0,
                    CedulaChofer = txtCedula.Text,
                    Color = txtColor.Text,
                    Marca = txtMarcaVehiculo.Text,
                    Modelo = txtModeloVehi.Text,
                };
                OperacionesLl.ModificarChofer(chofer);
                OperacionesLl.ModificarVehiculo(vehiculo);
                MessageBox.Show(@"Registro guardado", @"Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"Faltan campos por completar.", @"Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}

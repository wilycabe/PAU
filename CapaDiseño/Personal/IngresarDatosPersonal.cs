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
    public partial class IngresarDatosPersonal : Form
    {
        public IngresarDatosPersonal()
        {
            InitializeComponent();
        }

        //private void txtNombre_Enter(object sender, EventArgs e)
        //{
        //    if (txtCedula.Text == "Nombre")
        //    {
        //        txtCedula.Text = "";
        //        txtCedula.ForeColor = Color.LightGray;
        //    }
        //}

        //private void txtNombre_Leave(object sender, EventArgs e)
        //{
        //    if (txtCedula.Text == "")
        //    {
        //        txtCedula.Text = "Nombre";
        //        txtCedula.ForeColor = Color.LightGray;
        //    }
        //}

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

        private void IngresarDatosPersonal_Load(object sender, EventArgs e)
        {

        }

        private void bntIngresar_Click(object sender, EventArgs e)
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

                if (!OperacionesLl.ExisteChofer(chofer.Cedula) && !OperacionesLl.ExisteVehiculo(vehiculo.Placa))
                {
                    OperacionesLl.AnadirChofer(chofer);
                    OperacionesLl.AnadirVehiculo(vehiculo);
                    MessageBox.Show(@"Registro guardado", @"Información", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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

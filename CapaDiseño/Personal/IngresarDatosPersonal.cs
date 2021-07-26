using System;
using System.Windows.Forms;
using CapaLogica.Objetos;
using CapaLogica.Personas;

namespace CapaDiseño.Personal
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
            if (!Chofer.VerificarMayoriaEdad(dateTimePicker.Text)) return false;
            return true;
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
                    FechaNacimineto = dateTimePicker.Text,
                };
                var vehiculo = new Vehiculo()
                {
                    Placa = txtPlaca.Text,
                    Agno = int.Parse(txtAgno.Text),
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {

                    if (txtNombre.Text == "")
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

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

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
                        txtCedula.Focus();
                    }



                }
                catch
                {
                    MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtApellido.Focus();
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
                        txtDireccion.Focus();
                    }



                }
                catch
                {
                    MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtCedula.Focus();
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
                        MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtDireccion.Focus();
                    }
                    else
                    {
                        txtCelular.Focus();
                    }



                }
                catch
                {
                    MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
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

                    if (txtCelular.Text == "" )
                    {
                        MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtCelular.Focus();
                    }
                    else
                    {
                        txtCorreo.Focus();
                    }



                }
                catch
                {
                    MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtCelular.Focus();
                }
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
           if( e.KeyChar == Convert.ToChar(Keys.Enter))
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
                        txtMarcaVehiculo.Focus();
                    }



                }
                catch
                {
                    MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtCorreo.Focus();
                }
            }
        }

        private void txtMarcaVehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {

                    if (txtMarcaVehiculo.Text == "")
                    {
                        MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtMarcaVehiculo.Focus();
                    }
                    else
                    {
                        txtModeloVehi.Focus();
                    }



                }
                catch
                {
                    MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtMarcaVehiculo.Focus();
                }
            }
        }

        private void txtModeloVehi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {

                    if (txtModeloVehi.Text == "")
                    {
                        MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtModeloVehi.Focus();
                    }
                    else
                    {
                        txtColor.Focus();
                    }



                }
                catch
                {
                    MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtModeloVehi.Focus();
                }
            }
        }

        private void txtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {

                    if (txtColor.Text == "")
                    {
                        MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtColor.Focus();
                    }
                    else
                    {
                        txtPlaca.Focus();
                    }



                }
                catch
                {
                    MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtColor.Focus();
                }
            }

        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {

                    if (txtPlaca.Text == "")
                    {
                        MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtPlaca.Focus();
                    }
                    else
                    {
                        txtAgno.Focus();
                    }



                }
                catch
                {
                    MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtPlaca.Focus();
                }
            }
        }

        private void txtAgno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                try
                {

                    if (txtAgno.Text == "")
                    {
                        MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtAgno.Focus();
                    }
                    else
                    {
                        dateTimePicker.Focus();
                    }



                }
                catch
                {
                    MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtAgno.Focus();
                }
            }
        }

        private void bunifuSeparator5_Load(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator9_Load(object sender, EventArgs e)
        {

        }
    }
}

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
            var cedula = txtBuscar.Text;
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
                dateTimePicker.Text = fila[6].ToString();
                fila = vehiculo.Rows[0];
                txtPlaca.Text = fila[0].ToString();
                txtModeloVehi.Text = fila[1].ToString();
                txtMarcaVehiculo.Text = fila[2].ToString();
                txtColor.Text = fila[3].ToString();
                txtAgno.Text = fila[5].ToString();
                MessageBox.Show(@"Se han encontrado coincidencias y se ha cargado la información al formulario", @"Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtCedula.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtCelular.Text = string.Empty;
                txtCorreo.Text = string.Empty;
                txtDireccion.Text = string.Empty;
                dateTimePicker.Text = string.Empty;
                txtPlaca.Text = string.Empty;
                txtModeloVehi.Text = string.Empty;
                txtMarcaVehiculo.Text = string.Empty;
                txtColor.Text = string.Empty;
                txtAgno.Text = string.Empty;
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

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == @"Ingrese la cedula de un chofer")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.DimGray;

            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == @"")
            {
                txtBuscar.Text = "Ingrese la cedula de un chofer";
                txtBuscar.ForeColor = Color.DarkGray;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if(txtNombre.Text == "")
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        txtNombre.Focus();
                    }
                    else
                    {
                        txtApellido.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Los campos no pueden estar vacíos", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {

                    if (txtCelular.Text == "")
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
                        dateTimePicker.Focus();
                    }



                }
                catch
                {
                    MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtCorreo.Focus();
                }
            }
        }

        private void dateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if(dateTimePicker.Value > System.DateTime.Now)
                    {
                        MessageBox.Show("La fecha de nacimiento no puede ser mayor a la actual", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        dateTimePicker.Focus();
                    }
                    else
                    {
                        txtMarcaVehiculo.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("La fecha de nacimiento no puede ser mayor a la actual", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    dateTimePicker.Focus();

                }
            }
        }

        private void txtMarcaVehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
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
                        button2.Focus();
                    }



                }
                catch
                {
                    MessageBox.Show("El campo no puede estar vacío", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    txtAgno.Focus();
                }
            }
        }
    }
}

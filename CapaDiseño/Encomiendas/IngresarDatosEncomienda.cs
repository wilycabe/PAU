using System;
using System.CodeDom;
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
    public partial class IngresarDatosEncomienda : Form
    {
        public IngresarDatosEncomienda()
        {
            InitializeComponent();
        }

        public bool ValidarCampos()
        {
            if (OperacionesLl.ExisteDestinatario(txtCedulaDestintario.Text)) throw new AccessViolationException();
            if (!Destinatario.VerificarCedula(txtCedulaDestintario.Text)) return false;
            if (!Destinatario.VerificarCelular(txtTelefono.Text)) return false;
            if (!Destinatario.VerificarCorreo(textCorreo.Text)) return false;
            if (!Destinatario.VerificarNombreOApellido(txtNombre.Text)) return false;
            if (!Destinatario.VerificarNombreOApellido(textApellido.Text)) return false;
            if (!Encomienda) return false;
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void IngresarDatosEncomienda_Load(object sender, EventArgs e)
        {

        }
    }
}

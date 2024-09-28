using CapaEntidad;
using CapaLogica;
using FontAwesome.Sharp;
using Proyecto_Minerva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            btnMostrar.Visible = true;
            btnOcultar.Visible = false;
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtDocumento.Text = "";
            txtPassword.Text = "";
            this.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmacion", MessageBoxButtons.YesNo);
            // Verificar la respuesta del usuario
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Gracias por su visita");

                Application.Exit();
            }
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            btnOcultar.Visible = false;
            btnMostrar.Visible = true;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            btnMostrar.Visible = false;
            btnOcultar.Visible = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<entUsuario> login = new logUsuario().ListarUsuario();

            int Documento;
            if (int.TryParse(txtDocumento.Text, out Documento))
            {
                entUsuario usuario = login.Where(u => u.Documento == Documento && u.Clave == txtPassword.Text).FirstOrDefault();
                if (usuario != null)
                {
                    Principal form = new Principal(usuario);
                    form.Show();
                    this.Hide();
                    form.FormClosing += frm_closing;

                    string mensajeBienvenida = $"Bienvenido, {usuario.NombreCompleto}!";
                    MessageBox.Show(mensajeBienvenida);
                }
                else
                {
                    MessageBox.Show("Uusuario o Contraseña incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese su número de DNI.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Llamar al método o realizar la acción deseada al presionar Enter
                btnIngresar.PerformClick();
                // Evitar que se procese la tecla Enter más de una vez
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Llamar al método o realizar la acción deseada al presionar Enter
                btnIngresar.PerformClick();
                // Evitar que se procese la tecla Enter más de una vez
                e.Handled = true;
            }
        }
    }
}

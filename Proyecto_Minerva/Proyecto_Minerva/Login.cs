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
            txtPassword.UseSystemPasswordChar = true;
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtDocumento.Text = "";
            txtPassword.Text = "";
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Gracias por su visita");
                Application.Exit();
            }
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true; // Vuelve a censurar
            btnOcultar.Visible = false;
            btnMostrar.Visible = true;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false; // Muestra el texto
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
                    MessageBox.Show("Usuario o Contraseña incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                btnIngresar.PerformClick();
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar.PerformClick();
                e.Handled = true;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtDocumento_Enter(object sender, EventArgs e)
        {
            if (txtDocumento.Text == "Documento de Identidad")
            {
                txtDocumento.Text = "";
                txtDocumento.ForeColor = Color.Black;
            }
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            if (txtDocumento.Text == "")
            {
                txtDocumento.Text = "Documento de Identidad";
                txtDocumento.ForeColor = Color.Gray;
            }
        }
    }
}

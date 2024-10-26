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
        private System.Windows.Forms.Timer activityTimer;
        public Login()
        {
            InitializeComponent();
            btnMostrar.Visible = true;
            btnOcultar.Visible = false;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            Principal form = sender as Principal;
            if (form != null && form.UsuarioActual != null)
            {
                new logUsuario().ActualizarEstadoConexion(form.UsuarioActual.Documento, false);
            }
            txtUsuario.Text = "";
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
            string usuarioIngresado = txtUsuario.Text.Trim();
            if (!string.IsNullOrEmpty(usuarioIngresado))
            {
                // Obtener la lista de usuarios
                List<entUsuario> usuarios = logUsuario.Instancia.ListarValidarUsuario();

                // Buscar el usuario por documento
                entUsuario? entUsuario = usuarios.FirstOrDefault(u => u.Usuario == usuarioIngresado);
                entUsuario usuario = entUsuario;

                if (usuario != null)
                {
                    if (usuario.Clave == txtPassword.Text)
                    {
                        if (usuario.Estado)
                        {
                            // Verificar si el usuario ya está conectado
                            if (usuario.EstaConectado)
                            {
                                // Verificar si la última actividad fue hace más de 30 minutos
                                if (usuario.UltimaActividad != DateTime.MinValue &&
                                    (DateTime.Now - usuario.UltimaActividad).TotalMinutes > 30)
                                {
                                    // Forzar cierre de la sesión anterior por inactividad
                                    logUsuario.Instancia.ActualizarEstadoConexion(usuario.Documento, false);
                                }
                                else
                                {
                                    MessageBox.Show("Este usuario ya tiene una sesión activa en otro equipo.",
                                                    "Sesión activa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }

                            // Marcar al usuario como conectado
                            logUsuario.Instancia.ActualizarEstadoConexion(usuario.Documento, true);

                            Principal form = new Principal(usuario);
                            form.Show();
                            this.Hide();
                            form.FormClosing += frm_closing;
                            MessageBox.Show($"Bienvenido, {usuario.NombreCompleto}!");
                        }
                        else
                        {
                            MessageBox.Show("El usuario está deshabilitado", "Mensaje",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta", "Mensaje",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Documento incorrecto", "Mensaje",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un documento válido", "Error de validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("In", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
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
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }
    }
}

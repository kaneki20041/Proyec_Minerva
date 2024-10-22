using CapaEntidad;
using CapaLogica;
using CapaPresentacion;

namespace Proyecto_Minerva
{
    public partial class Principal : Form
    {
        private entUsuario _usuarioActual;
        public entUsuario UsuarioActual
        {
            get { return _usuarioActual; }
            private set { _usuarioActual = value; }
        }
        public Principal(entUsuario usuario)
        {
            InitializeComponent();
            this.UsuarioActual = usuario;

            // Aquí puedes agregar código para personalizar el formulario según el usuario
            // Por ejemplo:
            this.Text = $"Sistema Minera - Usuario: {usuario.NombreCompleto}";

            // Si tienes un label para mostrar el usuario actual:
            // lblUsuarioActual.Text = usuario.NombreCompleto;

            // Configurar permisos según el rol del usuario
            ConfigurarPermisosSegunRol();
        }

        private void ConfigurarPermisosSegunRol()
        {
            // Aquí puedes agregar lógica para mostrar u ocultar elementos
            // según el rol del usuario actual
            switch (UsuarioActual.idRol)
            {
                case 1: // Administrador
                        // Mostrar todas las opciones
                    break;
                case 2: // Otro rol
                        // Mostrar opciones limitadas
                    break;
                    // etc.
            }
        }

        // Agregar método para el cierre del formulario
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Asegurarse de desconectar al usuario al cerrar
            if (UsuarioActual != null)
            {
                try
                {
                    new logUsuario().ActualizarEstadoConexion(UsuarioActual.Documento, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cerrar sesión: " + ex.Message,
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
        }

        // También puedes agregar un método para actualizar la última actividad
        private void ActualizarUltimaActividad()
        {
            if (UsuarioActual != null)
            {
                try
                {
                    new logUsuario().ActualizarEstadoConexion(UsuarioActual.Documento, true);
                }
                catch (Exception ex)
                {
                    // Manejar el error si es necesario
                    Console.WriteLine($"Error al actualizar última actividad: {ex.Message}");
                }
            }
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            lblUser.Text = UsuarioActual.NombreCompleto;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AbrirForm(object form)
        {
            if (this.panelconteiner.Controls.Count > 0)
                this.panelconteiner.Controls.RemoveAt(0);
            Form? fr = form as Form;
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            this.panelconteiner.Controls.Add(fr);
            this.panelconteiner.Tag = fr;
            fr.Show();
        }
        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            AbrirForm(new Registrocliente());
        }

        private void btn_IngMaterial_Click(object sender, EventArgs e)
        {
            AbrirForm(new DetalleCompra());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox5.Visible = false;
            pictureBox4.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            AbrirForm(new Categoriaa());
        }

        private void btnSalidaMaterial_Click(object sender, EventArgs e)
        {
            AbrirForm(new Carrito());
        }

        private void btnMetodoPago_Click(object sender, EventArgs e)
        {
            AbrirForm(new Desc_Formpago());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirForm(new Proveedor());
        }

        private void btnPrendas_Click(object sender, EventArgs e)
        {
            AbrirForm(new Prendas1());
        }

        private void btnComprarPrendas_Click(object sender, EventArgs e)
        {
            AbrirForm(new CompraPrenda());
        }

        private void btnVenderPrendas_Click(object sender, EventArgs e)
        {
            AbrirForm(new Ventauniforme());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistroUsuarios());
        }
    }
}
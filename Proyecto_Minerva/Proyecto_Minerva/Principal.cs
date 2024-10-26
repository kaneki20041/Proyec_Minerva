using CapaEntidad;
using CapaLogica;
using CapaPresentacion;
using FontAwesome.Sharp;
using System.Windows.Controls;
using System.Windows.Forms;


namespace Proyecto_Minerva
{
    public partial class Principal : Form
    {
        private entUsuario _usuarioActual;
        public entUsuario UsuarioActual
        {
            get { return _usuarioActual; }
            set 
            {
                _usuarioActual = value;
            }
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
            if (UsuarioActual == null)
            {
                MessageBox.Show("Error: No hay usuario activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Primero, ocultar todos los botones
                OcultarTodosBotones();

                // Luego, mostrar los botones según el rol
                switch (UsuarioActual.idRol)
                {
                    case 1: // Administrador
                        MostrarBotonesAdministrador();
                        break;
                    case 2: // Empleado
                        MostrarBotonesEmpleado();
                        break;
                    default:
                        MessageBox.Show("Rol no reconocido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al configurar permisos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarEstadoBotones()
        {
            IconButton[] todosBotones = {
            btnUsuarios,
            btnVenderPrendas,
            btnComprarPrendas,
            btnCliente,
            btnPrendas,
            btnProveedores,
            btnMetodoPago,
            btnCarrito,
            btn_IngMaterial,
            btnCategoria,
            btnInventario
        };  foreach (var boton in todosBotones)
            {
                if (boton != null)
                {
                    Console.WriteLine($"Botón {boton.Name}: {(boton.Visible ? "Visible" : "Oculto")}");
                }
            }
        }

        private void MostrarBotonesEmpleado()
        {
            IconButton[] botonesEmpleado = {
                btnVenderPrendas,     // Ventas
                btnComprarPrendas,    // Compras
                btnCliente,          // Gestión de clientes
                btnPrendas,           // Gestión de prendas
                btn_IngMaterial     // Control de salida de materiales
        }; System.Windows.Forms.Panel[] panelesEmpleado = {
                panelVender,
                panelComprar,
                panelCliente,
                panelPrenda,
                panelPagoVent
        };foreach (var boton in botonesEmpleado)
            {
                if (boton != null)
                {
                    boton.Visible = true;
                }
                else
                {
                    Console.WriteLine($"Advertencia: Botón no encontrado en la interfaz");
                }
            }

            OcultarTodosPaneles();

            foreach (var panel in panelesEmpleado)
            {
                if (panel != null)
                {
                    panel.Visible = true;
                }
            }
        }

        private void MostrarBotonesAdministrador()
        {
            IconButton[] botonesAdmin = {
                btnUsuarios,          // Gestión de usuarios
                btnVenderPrendas,     // Ventas
                btnComprarPrendas,    // Compras
                btnCliente,          // Gestión de clientes
                btnPrendas,           // Gestión de prendas
                btnProveedores,       // Gestión de proveedores
                btnMetodoPago,        // Configuración de métodos de pago
                btnCarrito,    // Control de salida de materiales
                btn_IngMaterial,       // Control de ingreso de materiales
                btnCategoria,         // Gestión de categorías
                btnInventario         // Control de inventario
        }; System.Windows.Forms.Panel[] panelesAdmin = {
                panelUsuario,
                panelVender,
                panelComprar,
                panelCliente,
                panelPrenda,
                panelProvee,
                panelMet,
                panelPagoVent,
                panelPagoComp,
                panelCategoria,
                panelInventario 
        };foreach (var boton in botonesAdmin)
            {
                if (boton != null)
                {
                    boton.Visible = true;
                }
                else
                {
                    Console.WriteLine($"Advertencia: Botón no encontrado en la interfaz");
                }
            }

            OcultarTodosPaneles();

            foreach (var panel in panelesAdmin)
            {
                if (panel != null)
                {
                    panel.Visible = true;
                }
            }
        }

        private void OcultarTodosBotones()
        {
            // Lista de todos los botones que necesitan ser controlados
            IconButton[] todosBotones = {
                btnUsuarios,
                btnVenderPrendas,
                btnComprarPrendas,
                btnCliente,
                btnPrendas,
                btnProveedores,
                btnMetodoPago,
                btnCarrito,
                btn_IngMaterial,
                btnCategoria,
                btnInventario

        };
           foreach (var boton in todosBotones)
            {
                if (boton != null)
                {
                    boton.Visible = false;
                }
            }
        }

        private void OcultarTodosPaneles()
        {
            System.Windows.Forms.Panel[] todosPaneles = {
                panelUsuario,
                panelVender,
                panelComprar,
                panelCliente,
                panelPrenda,
                panelProvee,
                panelMet,
                panelPagoVent,
                panelPagoComp,
                panelCategoria,
                panelInventario
            };

            foreach (var panel in todosPaneles)
            {
                if (panel != null)
                {
                    panel.Visible = false;
                }
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

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirForm(new Inventario());
        }
    }
}
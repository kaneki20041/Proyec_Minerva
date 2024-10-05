using CapaEntidad;
using CapaPresentacion;

namespace Proyecto_Minerva
{
    public partial class Principal : Form
    {
        private static entUsuario usuarioActual;
        public Principal(entUsuario objusuario)
        {
            usuarioActual = objusuario;
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            lblUser.Text = usuarioActual.NombreCompleto;
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
            AbrirForm(new Detalleventa());
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
    }
}
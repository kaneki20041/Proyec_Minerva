namespace Proyecto_Minerva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btn_venderu_Click(object sender, EventArgs e)
        {
            AbrirForm(new Ventauniforme());
        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            AbrirForm(new Registrocliente());
        }

        private void btn_IngMaterial_Click(object sender, EventArgs e)
        {
            AbrirForm(new IngMaterial());
        }

        private void btnSalidaMaterial_Click(object sender, EventArgs e)
        {
            AbrirForm(new SalidMaterial());
        }

        private void btn_Matyprod_Click(object sender, EventArgs e)
        {
            AbrirForm(new Produc_mat());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm(new Proveedor());
        }

        private void btn_Cambiou_Click(object sender, EventArgs e)
        {

        }

        private void btnMotorizado_Click(object sender, EventArgs e)
        {
            AbrirForm(new Desc_Formpago());
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

        private void btn_Cambiou_Click_1(object sender, EventArgs e)
        {

        }
    }
}
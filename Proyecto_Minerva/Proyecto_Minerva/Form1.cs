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
    }
}
using CapaEntidad;
using CapaLogica;

namespace Proyecto_Minerva
{
    public partial class Desc_Formpago : Form
    {
        public Desc_Formpago()
        {
            InitializeComponent();
            listarMetPago();
        }
        private void Desc_Formpago_Load(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            txtMetpago.Enabled = false;
            cbkEstMetPago.Enabled = false;

        }
        public void listarMetPago()
        {
            dgvMetPago.DataSource = logMetPago.Instancia.ListarMetPago();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtMetpago.Enabled = true;
            txtid.Enabled = false;
            cbkEstMetPago.Checked = true;
            cbkEstMetPago.Enabled = false;
            btnAgreMpag.Visible = true;
            btnModFpag.Visible = false;
            LimpiarVariables();

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgreMpag_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                EntMetPago m = new EntMetPago();
                m.metodopago = txtMetpago.Text.Trim();
                m.estMetpago = cbkEstMetPago.Checked;
                logMetPago.Instancia.InsertaMetpago(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarMetPago();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void LimpiarVariables()
        {
            txtMetpago.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            txtid.Enabled = true;
            txtMetpago.Enabled = true;
            cbkEstMetPago.Enabled = false;
            btnModFpag.Visible = true;
            btnAgreMpag.Visible = false;
        }
        private void btnModFpag_Click(object sender, EventArgs e)
        {
            try
            {
                EntMetPago m = new EntMetPago();
                m.MetPagoid = int.Parse(txtid.Text.Trim());
                m.metodopago = txtMetpago.Text.Trim();
                m.estMetpago = cbkEstMetPago.Checked;
                logMetPago.Instancia.EditaMetPago(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarMetPago();
            LimpiarVariables();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                EntMetPago m = new EntMetPago();
                m.MetPagoid = int.Parse(txtid.Text.Trim());
                m.estMetpago = cbkEstMetPago.Checked;
                logMetPago.Instancia.DeshabilitaMetPago(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarMetPago();

        }

        private void btnCancelFpag_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            txtid.Enabled = true;
            txtMetpago.Enabled = false;
            cbkEstMetPago.Enabled = true;
        }
    }
}

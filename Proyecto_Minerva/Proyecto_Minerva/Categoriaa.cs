using CapaEntidad;
using CapaLogica;
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
    public partial class Categoriaa : Form
    {
        public Categoriaa()
        {
            InitializeComponent();
            listarCat();
            Deshabilitado();
        }

        public void listarCat()
        {
            dgvCategoria.DataSource = logCat.Instancia.ListaCategoria();
        }

        public void Deshabilitado()
        {
            dgvCategoria.Enabled = false;
            gbDatos.Enabled = false;
        }

        public void Habilitado()
        {
            dgvCategoria.Enabled = true;
            gbDatos.Enabled = true;
        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entCategoria gato = new entCategoria();
                gato.descripcion = txtCategoria.Text.Trim();
                checkBox1.Checked = true;
                gato.estado = checkBox1.Checked;
                logCat.Instancia.InsertaCat(gato);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarCat();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Deshabilitado();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {

        }
    }
}

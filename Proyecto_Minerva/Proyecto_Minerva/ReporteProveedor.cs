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
    public partial class ReporteProveedor : Form
    {
        public string idProveedor { get; private set; }
        public string razonSocial { get; private set; }
        public string ruc { get; private set; }
        public string idrubro { get; private set; }
        public string rubro { get; private set; }
        public string ubigeo { get; private set; }
        public string nombreComercial { get; private set; }

        public ReporteProveedor()
        {
            InitializeComponent();
            listarReporteProveedor();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void listarReporteProveedor()
        {
            try
            {
                List<entProveedor> lista = logProveedor.Instancia.ListarProveedor();
                // Asignar la lista a un DataGridView, ListBox, etc.
                dgvProveedor.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProveedor.Rows[e.RowIndex];

            nombreComercial = filaActual.Cells[2].Value.ToString();
            ruc = filaActual.Cells[1].Value.ToString();
            razonSocial = filaActual.Cells[5].Value.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

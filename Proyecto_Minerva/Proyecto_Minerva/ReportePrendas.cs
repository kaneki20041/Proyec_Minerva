using CapaDatos;
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
using System.Windows.Documents;
using System.Windows.Forms;

namespace CapaPresentacion
{ 
    public partial class ReportePrendas : Form
    {
        public string idprenda { get; private set; }
        public string descripcion { get; private set; }
        public string categoria { get; private set; }
        public string talla { get; private set; }
        public string colegio { get; private set; }
        public string precioCompra { get; private set; }
        public string precioVenta { get;private set; }
        public string stock { get; private set; }
        public ReportePrendas()
        {
            InitializeComponent();
            listarReportePrendas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void listarReportePrendas()
        {
            try
            {
                List<entPrendas> lista = logPrendas.Instancia.ListarPrendas();
                // Asignar la lista a un DataGridView, ListBox, etc.
                dgvPrendas.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvPrendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPrendas.Rows[e.RowIndex];

            descripcion = filaActual.Cells[1].Value.ToString();
            categoria = filaActual.Cells[2].Value.ToString();
            talla = filaActual.Cells[3].Value.ToString();
            colegio = filaActual.Cells[4].Value.ToString();
            precioCompra = filaActual.Cells[5].Value.ToString();
            precioVenta = filaActual.Cells[6].Value.ToString();
            stock = filaActual.Cells[7].Value.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

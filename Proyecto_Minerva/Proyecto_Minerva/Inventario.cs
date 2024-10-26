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
    public partial class Inventario : Form
    {
        // Mantener una lista original de prendas
        private List<entPrendas> listaOriginalPrendas;

        public string idprenda { get; private set; }
        public string descripcion { get; private set; }
        public string categoria { get; private set; }
        public string talla { get; private set; }
        public string colegio { get; private set; }
        public string precioCompra { get; private set; }
        public string precioVenta { get; private set; }
        public string stock { get; private set; }

        public Inventario()
        {
            InitializeComponent();
            dgvInventario.CellDoubleClick += dgvInventario_CellDoubleClick;
        }
        private void Inventario_Load(object sender, EventArgs e)
        {
            ListarPrendas();

            cbBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;


            // Agregar opciones al comboBoxCriterio
            cbBusqueda.Items.Add("Descripcion");
            cbBusqueda.Items.Add("Talla");
            cbBusqueda.Items.Add("Colegio");
            cbBusqueda.Items.Add("PrecioVenta");

            txtNuevoPrecio.Enabled = false;

            gbBuscar.Enabled = false;
            gbPrenda.Enabled = false;
        }


        private void ListarPrendas()
        {
            try
            {
                // Cargar la lista original de prendas
                listaOriginalPrendas = logPrendas.Instancia.ListarPrendas();

                // Asignar la lista al DataGridView sin filtrar
                dgvInventario.DataSource = listaOriginalPrendas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Método para aplicar el filtro a las prendas basado en el comboBox y el textBox
        private void AplicarFiltroPrendas()
        {
            // Asegúrate de que haya un valor seleccionado en el ComboBox
            if (cbBusqueda.SelectedItem == null) return;

            // Obtener el filtro seleccionado y el texto de búsqueda
            string filtro = cbBusqueda.SelectedItem.ToString();
            string busqueda = txtBuscar.Text.ToLower();

            // Filtrar la lista original de prendas, no la lista actual del DataGridView
            var prendasFiltradas = listaOriginalPrendas.Where(p =>
            {
                switch (filtro)
                {
                    case "Descripcion":
                        return p.Descripcion.ToLower().Contains(busqueda);
                    case "Talla":
                        // Modificamos esta parte para manejar tallas numéricas y de letras
                        if (int.TryParse(busqueda, out int tallaNumero))
                        {
                            // Si la búsqueda es un número, comparamos con igualdad
                            return p.Talla.Trim() == busqueda;
                        }
                        else
                        {
                            // Si la búsqueda es texto, buscamos coincidencia parcial
                            return p.Talla.Trim().ToLower().Contains(busqueda);
                        }
                    case "Colegio":
                        return p.Colegio.ToLower().Contains(busqueda);
                    case "PrecioVenta":
                        return p.PrecioVenta.ToString().Contains(busqueda);
                    default:
                        return false;
                }
            }).ToList();

            // Actualizar el DataGridView con los resultados filtrados
            dgvInventario.DataSource = prendasFiltradas;
        }

        private void cbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltroPrendas(); // Llamar al método de filtrado
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltroPrendas(); // Llamar al método de filtrado
        }

        private void dgvInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInventario.Rows[e.RowIndex];

                // Asumiendo que tus TextBox se llaman txtID, txtDescripcion y txtPrecio
                txtID.Text = row.Cells["PrendaID"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = row.Cells["PrecioVenta"].Value.ToString();

                // No actualizamos el "Nuevo Precio" ya que parece ser un campo para entrada del usuario
            }
            txtID.Enabled = false;
            txtDescripcion.Enabled = false;
            txtPrecio.Enabled = false;
            txtNuevoPrecio.Enabled = true;
        }

        private void btnEliminarFiltro_Click(object sender, EventArgs e)
        {
            cbBusqueda.Text = "";
            txtBuscar.Text = "";
        }

        private void btnActualizarForm_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtNuevoPrecio.Text = "";
            txtID.Enabled = true;
            txtDescripcion.Enabled = true;
            txtPrecio.Enabled = true;
            txtNuevoPrecio.Enabled = false;
            gbPrenda.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gbBuscar.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int prendaID = Convert.ToInt32(txtID.Text);
                decimal nuevoPrecio = Convert.ToDecimal(txtNuevoPrecio.Text);

                logPrendas logica = new logPrendas();
                logica.ModificarPrecioUnidad(prendaID, nuevoPrecio);

                MessageBox.Show("Precio modificado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarPrendas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el precio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

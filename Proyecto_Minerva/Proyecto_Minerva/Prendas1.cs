
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
    public partial class Prendas1 : Form
    {
        public Prendas1()
        {
            InitializeComponent();
            listarPrendas();
            InicializarComboBoxes();
            groupBox1.Enabled = false;
        }
        public void listarPrendas()
        {
            dataGridView1.DataSource = logPrendas.Instancia.ListarPrendas();
        }
        private void InicializarComboBoxes()
        {
            // Llenado de ComboBox comboBox2 (Categorias)
            comboBox2.Items.Clear();
            List<string> categorias = logPrendas.Instancia.ObtenerCategorias();
            foreach (string categoria in categorias)
            {
                comboBox2.Items.Add(categoria);
            }

            // Llenado de ComboBox comboBox1 (Colegios)
            comboBox1.Items.Clear();
            List<string> colegios = logPrendas.Instancia.ObtenerColegios();
            foreach (string colegio in colegios)
            {
                comboBox1.Items.Add(colegio);
            }

            // Llenado de ComboBox comboBox3 (Tallas)
            comboBox3.Items.Clear();
            List<string> tallas = logPrendas.Instancia.ObtenerTallas();
            foreach (string talla in tallas)
            {
                comboBox3.Items.Add(talla);
            }
        }

        private void btnAgregarPre_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que los ComboBox tienen un ítem seleccionado
                if (comboBox2.SelectedItem == null || comboBox1.SelectedItem == null || comboBox3.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecciona una opción en los campos Categoría, Colegio y Talla.");
                    return;
                }

                // Captura los datos de los ComboBox y TextBox
                string categoria = comboBox2.SelectedItem.ToString();
                string colegio = comboBox1.SelectedItem.ToString();
                string talla = comboBox3.SelectedItem.ToString();
                decimal precioCompra;
                decimal precioVenta;
                int stock;

                // Verifica que los valores numéricos son válidos
                if (!decimal.TryParse(txtPrecioCompra.Text, out precioCompra) || !decimal.TryParse(txtPrevioVenta.Text, out precioVenta))
                {
                    MessageBox.Show("Por favor, ingresa valores válidos en los campos Precio Compra y Precio Venta.");
                    return;
                }

                if (!int.TryParse(txtStock.Text, out stock))
                {
                    MessageBox.Show("Por favor, ingresa un valor válido en el campo Stock.");
                    return;
                }

                // Crea una nueva prenda con los datos capturados
                entPrendas prenda = new entPrendas
                {
                    Descripcion = txtDescripcion.Text.Trim(),
                    Categoria = categoria,
                    Colegio = colegio,
                    Talla = talla,
                    PrecioCompra = precioCompra,
                    PrecioVenta = precioVenta,
                    Stock = stock,
                    Estado = cbxEstado.Checked
                };

                // Llama al método para insertar la prenda
                logPrendas.Instancia.InsertarPrenda(prenda);
                MessageBox.Show("Prenda agregada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            listarPrendas();
        }


        private void LimpiarCampos()
        {
            txtDescripcion.Clear();
            txtPrecioCompra.Clear();
            txtPrevioVenta.Clear();
            txtStock.Clear();
            comboBox2.SelectedIndex = -1; // Resetea el ComboBox
            comboBox1.SelectedIndex = -1; // Resetea el ComboBox
            comboBox3.SelectedIndex = -1; // Resetea el ComboBox
            cbxEstado.Checked = false;
        }

        private void btnEditPro_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que hay una fila seleccionada en el DataGridView
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona una prenda de la lista.");
                    return;
                }

                // Captura los datos de los ComboBox y TextBox
                string descripcion = txtDescripcion.Text;
                string categoria = comboBox2.SelectedItem.ToString();
                string talla = comboBox3.SelectedItem.ToString();
                string colegio = comboBox1.SelectedItem.ToString();
                decimal precioCompra;
                decimal precioVenta;
                int stock;

                // Verifica que los precios y el stock son números válidos
                if (!decimal.TryParse(txtPrecioCompra.Text, out precioCompra) || !decimal.TryParse(txtPrevioVenta.Text, out precioVenta))
                {
                    MessageBox.Show("Por favor, ingresa números válidos en los campos de precio.");
                    return;
                }

                if (!int.TryParse(txtStock.Text, out stock))
                {
                    MessageBox.Show("Por favor, ingresa un número válido en el campo de stock.");
                    return;
                }

                bool estado = cbxEstado.Checked;

                // Crea un objeto entPrendas
                entPrendas prendaActualizada = new entPrendas
                {
                    PrendaID = int.Parse(dataGridView1.SelectedRows[0].Cells["PrendaID"].Value.ToString()),
                    Descripcion = descripcion,
                    Categoria = categoria,
                    Talla = talla,
                    Colegio = colegio,
                    PrecioCompra = precioCompra,
                    PrecioVenta = precioVenta,
                    Stock = stock,
                    Estado = estado
                };

                // Llama a la capa lógica para modificar la prenda
                logPrendas.Instancia.ModificarPrenda(prendaActualizada);

                // Muestra un mensaje de éxito
                MessageBox.Show("Prenda modificada con éxito");

                // Limpia los campos del formulario
                LimpiarCamposPrenda();

                // Refresca la lista de prendas
                listarPrendas();
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que ocurra
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
        private void LimpiarCamposPrenda()
        {
            txtDescripcion.Clear();
            txtPrecioCompra.Clear();
            txtPrevioVenta.Clear();
            txtStock.Clear();
            cbxEstado.Checked = false;
        }

        private void dgvPrendas_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                txtDescripcion.Text = selectedRow.Cells["Descripcion"].Value.ToString();
                txtPrecioCompra.Text = selectedRow.Cells["PrecioCompra"].Value.ToString();
                txtPrevioVenta.Text = selectedRow.Cells["PrecioVenta"].Value.ToString();
                txtStock.Text = selectedRow.Cells["Stock"].Value.ToString();
                cbxEstado.Checked = (bool)selectedRow.Cells["Estado"].Value;
            }
        }

        private void BtnRemovPro_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = txtDescripcion.Text.Trim(); // Obtener la descripción desde el TextBox

                // Verifica que la descripción no esté vacía
                if (string.IsNullOrEmpty(descripcion))
                {
                    MessageBox.Show("Por favor, ingresa una descripción válida.");
                    return;
                }

                // Llama a la capa lógica para buscar la prenda por descripción
                entPrendas prendaEncontrada = logPrendas.Instancia.BuscarPrendaPorDescripcion(descripcion);

                if (prendaEncontrada != null)
                {
                    // Muestra los datos de la prenda encontrada en los campos correspondientes
                    txtPrecioCompra.Text = prendaEncontrada.PrecioCompra.ToString();
                    txtPrevioVenta.Text = prendaEncontrada.PrecioVenta.ToString();
                    txtStock.Text = prendaEncontrada.Stock.ToString();
                    cbxEstado.Checked = prendaEncontrada.Estado;

                    comboBox2.SelectedItem = prendaEncontrada.Categoria;
                    comboBox1.SelectedItem = prendaEncontrada.Colegio;
                    comboBox3.SelectedItem = prendaEncontrada.Talla;
                }
                else
                {
                    MessageBox.Show("Prenda no encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Prendas1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;

        }
    }
}

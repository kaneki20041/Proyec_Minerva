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

namespace Proyecto_Minerva
{
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
            listarProveedor();
            InicializarComboBoxes();
            grupBoxDatos.Enabled = false;
            grupBoxDatos2.Enabled = false;
            //txtidCliente.Enabled = false;

        }
        public void listarProveedor()
        {
            dvgProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
        }

        private void InicializarComboBoxes()
        {
            // Llenado de ComboBox para Ciudad
            comboBox2.Items.AddRange(new string[] { "Lima", "Arequipa", "Cusco", "Trujillo" }); // Añade tus ciudades aquí

            // Llenado de ComboBox para Rubro
            comboBox1.Items.AddRange(new string[] { "Tecnología", "Alimentos", "Textil", "Servicios" }); // Añade tus rubros aquí
        }


        private void button1_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            grupBoxDatos2.Enabled = true;
            btnAgregar.Visible = true;
            //LimpiarVariables();
            btnModificar.Visible = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que los ComboBox tienen un ítem seleccionado
                if (comboBox2.SelectedItem == null || comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecciona una opción en los campos Ciudad y Rubro.");
                    return;
                }

                // Captura los datos de los ComboBox y TextBox
                string ciudad = comboBox2.SelectedItem.ToString();
                string rubro = comboBox1.SelectedItem.ToString();
                int ruc, telefono;

                // Verifica que el RUC y el teléfono son números válidos
                if (!int.TryParse(textBox3.Text, out ruc))
                {
                    MessageBox.Show("Por favor, ingresa un número válido en el campo RUC.");
                    return;
                }

                if (!int.TryParse(textBox5.Text, out telefono))
                {
                    MessageBox.Show("Por favor, ingresa un número válido en el campo Teléfono.");
                    return;
                }

                string razonSocial = textBox7.Text.Trim();
                string nomPro = textBox1.Text.Trim();
                string direccion = textBox6.Text.Trim();
                string email = textBox4.Text.Trim();
                bool estado = checkBox1.Checked;

                // Crea un objeto entProveedor
                entProveedor nuevoProveedor = new entProveedor
                {
                    RazonSocial = razonSocial,
                    RUC = ruc,
                    NomPro = nomPro,
                    Ciudad = ciudad,
                    Direccion = direccion,
                    Email = email,
                    Telefono = telefono,
                    Estado = estado,
                    Rubro = rubro
                };

                // Llama a la capa lógica para insertar el proveedor
                logProveedor.Instancia.InsertaProveedor(nuevoProveedor);

                // Muestra un mensaje de éxito
                MessageBox.Show("Proveedor insertado con éxito");

                // Limpia los campos del formulario
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que ocurra
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }

            // Desactiva el grupo de datos y refresca la lista de proveedores
            grupBoxDatos.Enabled = false;
            listarProveedor();
        }

        private void LimpiarCampos()
        {
            textBox7.Clear();
            txtBuscarID.Clear();
            textBox3.Clear();
            textBox1.Clear();
            comboBox2.SelectedIndex = -1; // Resetea el ComboBox
            textBox6.Clear();
            textBox4.Clear();
            textBox5.Clear();
            checkBox1.Checked = false;
            comboBox1.SelectedIndex = -1; // Resetea el ComboBox
        }

        private void btnBuscProov_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtBuscarID.Text, out id))
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo ID.");
                return;
            }

            try
            {
                entProveedor prov = logProveedor.Instancia.BuscarProveedorPorID(id);
                if (prov != null)
                {
                    // Llena los campos del formulario con los datos del proveedor encontrado
                    textBox7.Text = prov.RazonSocial;
                    textBox3.Text = prov.RUC.ToString();
                    textBox1.Text = prov.NomPro;
                    comboBox2.SelectedItem = prov.Ciudad;
                    textBox6.Text = prov.Direccion;
                    textBox4.Text = prov.Email;
                    textBox5.Text = prov.Telefono.ToString();
                    checkBox1.Checked = prov.Estado;
                    comboBox1.SelectedItem = prov.Rubro;

                    grupBoxDatos.Enabled = true;
                    grupBoxDatos2.Enabled = true;
                    btnAgregar.Visible = false;
                    btnModificar.Visible = true;
                }
                else
                {
                    MessageBox.Show("Proveedor no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que hay una fila seleccionada en el DataGridView
                if (dvgProveedor.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona un proveedor de la lista.");
                    return;
                }

                // Verifica que los ComboBox tienen un ítem seleccionado
                if (comboBox2.SelectedItem == null || comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecciona una opción en los campos Ciudad y Rubro.");
                    return;
                }

                // Captura los datos de los ComboBox y TextBox
                string ciudad = comboBox2.SelectedItem.ToString();
                string rubro = comboBox1.SelectedItem.ToString();
                int ruc, telefono;

                // Verifica que el RUC y el teléfono son números válidos
                if (!int.TryParse(textBox3.Text, out ruc))
                {
                    MessageBox.Show("Por favor, ingresa un número válido en el campo RUC.");
                    return;
                }

                if (!int.TryParse(textBox5.Text, out telefono))
                {
                    MessageBox.Show("Por favor, ingresa un número válido en el campo Teléfono.");
                    return;
                }

                string razonSocial = textBox7.Text.Trim();
                string nomPro = textBox1.Text.Trim();
                string direccion = textBox6.Text.Trim();
                string email = textBox4.Text.Trim();
                bool estado = checkBox1.Checked;

                // Crea un objeto entProveedor
                entProveedor proveedorActualizado = new entProveedor
                {
                    ID = int.Parse(dvgProveedor.SelectedRows[0].Cells["ID"].Value.ToString()),
                    RazonSocial = razonSocial,
                    RUC = ruc,
                    NomPro = nomPro,
                    Ciudad = ciudad,
                    Direccion = direccion,
                    Email = email,
                    Telefono = telefono,
                    Estado = estado,
                    Rubro = rubro
                };

                // Llama a la capa lógica para modificar el proveedor
                logProveedor.Instancia.ModificarProveedor(proveedorActualizado);

                // Muestra un mensaje de éxito
                MessageBox.Show("Proveedor modificado con éxito");

                // Limpia los campos del formulario
                LimpiarCampos();

                // Refresca la lista de proveedores
                listarProveedor();
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que ocurra
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }

            // Desactiva el grupo de datos
            grupBoxDatos.Enabled = false;
            grupBoxDatos2.Enabled = false;
        }
    }
}

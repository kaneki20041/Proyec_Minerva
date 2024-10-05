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
            groupBoxUbigeo.Enabled = false;
            //txtidCliente.Enabled = false;
            btnAgregar.Enabled = false;
            btnInhabilitar.Enabled = false;
            btnModificar.Enabled = false;

        }
        private void InicializarComboBoxes()
        {
            // Llenado de ComboBox comboBox2 (Categorias)
            comboBox1.Items.Clear();
            List<string> Rubro = logProveedor.Instancia.ObtenerRubro();
            foreach (string rubro in Rubro)
            {
                comboBox1.Items.Add(rubro);
            }
        }
        public void listarProveedor()
        {
            dvgProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que los ComboBox tienen un ítem seleccionado
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecciona una opción en los campos Rubro.");
                    return;
                }

                string rubro = comboBox1.SelectedItem.ToString();
                int ruc, telefono, ubigeo;

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

                if (!int.TryParse(txtCodigoUbigeo.Text, out ubigeo))
                {
                    MessageBox.Show("Por favor, ingresa un número válido en el campo Ubigeo.");
                    return;
                }

                string razonSocial = textBox7.Text.Trim();
                string nomPro = textBox1.Text.Trim();
                string direccion = textBox6.Text.Trim();
                string email = textBox4.Text.Trim();
                bool estado = checkBox1.Checked;
                string distrito = txtDistrito.Text.Trim();


                // Crea un objeto entProveedor
                entProveedor nuevoProveedor = new entProveedor
                {
                    RazonSocial = razonSocial,
                    RUC = ruc,
                    NomPro = nomPro,
                    Ciudad = distrito,
                    Direccion = direccion,
                    Email = email,
                    Telefono = telefono,
                    Estado = estado,
                    Rubro = rubro,
                    Ubigeo = ubigeo
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
                    textBox6.Text = prov.Direccion;
                    textBox4.Text = prov.Email;
                    textBox5.Text = prov.Telefono.ToString();
                    checkBox1.Checked = prov.Estado;
                    comboBox1.SelectedItem = prov.Rubro;

                    grupBoxDatos.Enabled = true;
                    grupBoxDatos2.Enabled = true;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = true;
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
                // Verifica que se ha buscado un proveedor
                if (string.IsNullOrEmpty(txtBuscarID.Text))
                {
                    MessageBox.Show("Por favor, busca un proveedor antes de modificarlo.");
                    return;
                }
                // Verifica que los ComboBox tienen un ítem seleccionado
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecciona una opción para Rubro.");
                    return;
                }
                // Captura los datos del ComboBox y TextBox
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
                string distrito = txtDistrito.Text.Trim();

                // Crea un objeto entProveedor
                entProveedor proveedorActualizado = new entProveedor
                {
                    ID = int.Parse(txtBuscarID.Text),
                    RazonSocial = razonSocial,
                    RUC = ruc,
                    NomPro = nomPro,
                    Direccion = direccion,
                    Email = email,
                    Telefono = telefono,
                    Rubro = rubro,
                    Estado = checkBox1.Checked
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

        private void btnBuscUbigeo_Click(object sender, EventArgs e)
        {
            string codigoUbigeo = txtCodigoUbigeo.Text.Trim();

            if (!string.IsNullOrEmpty(codigoUbigeo))
            {
                // Instancia de la lógica de negocio
                logProveedor logProv = new logProveedor();

                try
                {
                    // Llamada al método BuscarUbigeo
                    entUbigeo ubigeo = logProv.BuscarUbigeo(codigoUbigeo);

                    if (ubigeo != null)
                    {
                        // Mostrar los datos en los controles correspondientes
                        txtDepartamento.Text = ubigeo.Departamento;
                        txtProvincia.Text = ubigeo.Provincia;
                        txtDistrito.Text = ubigeo.Distrito;
                    }
                    else
                    {
                        MessageBox.Show("Ubigeo no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un código de Ubigeo válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            // Verifica si el campo txtBuscarID no está vacío
            if (string.IsNullOrWhiteSpace(txtBuscarID.Text))
            {
                MessageBox.Show("Por favor, ingresa un ID válido para inhabilitar.");
                return;
            }

            // Intenta convertir el valor del txtBuscarID a un número entero
            if (!int.TryParse(txtBuscarID.Text, out int proveedorID))
            {
                MessageBox.Show("El ID ingresado no es válido. Debe ser un número.");
                return;
            }

            // Confirmación de inhabilitación
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas inhabilitar este proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Llama al método de la capa lógica para inhabilitar el proveedor
                    logProveedor.Instancia.InhabilitarProveedor(proveedorID);

                    // Muestra un mensaje de éxito
                    MessageBox.Show("Proveedor inhabilitado con éxito.");

                    // Limpia el campo de búsqueda
                    txtBuscarID.Clear();

                    // Actualiza la lista de proveedores
                    listarProveedor();
                }
                catch (Exception ex)
                {
                    // Muestra un mensaje de error en caso de excepciones
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
            grupBoxDatos2.Enabled = false;
            groupBoxUbigeo.Enabled = false;
            btnAgregar.Enabled = false;
            btnInhabilitar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            grupBoxDatos2.Enabled = true;
            groupBoxUbigeo.Enabled = true;
            btnAgregar.Visible = true;
            btnAgregar.Enabled = true;
            btnInhabilitar.Enabled = true;
            btnModificar.Enabled = true;
        }
    }
}

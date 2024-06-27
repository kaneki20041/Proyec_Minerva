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
    public partial class Registrocliente : Form
    {
        public Registrocliente()
        {
            InitializeComponent();
            listarCliente();
            InicializarComboBoxes();
        }

        public void listarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void InicializarComboBoxes()
        {
            // Llenado de ComboBox cbxTipoCliente
            cbxTipoCliente.Items.AddRange(new string[] { "Frecuente", "Casual", "Nuevo" }); // Añade tus valores aquí

            // Llenado de ComboBox cbxDocumento
            cbxDocumento.Items.AddRange(new string[] { "DNI", "Pasaporte", "Carnet de Extrajeria" }); // Añade tus valores aquí
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Registrocliente_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {

        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que los ComboBox tienen un ítem seleccionado
                if (cbxTipoCliente.SelectedItem == null || cbxDocumento.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecciona una opción en los campos Tipo Cliente y Tipo Documento.");
                    return;
                }

                // Captura los datos de los ComboBox y TextBox
                string tipocliente = cbxTipoCliente.SelectedItem.ToString();
                string tipoDoc = cbxDocumento.SelectedItem.ToString();
                int documento;

                // Verifica que el documento es un número válido
                if (!int.TryParse(txtDocumento.Text, out documento))
                {
                    MessageBox.Show("Por favor, ingresa un número válido en el campo Documento.");
                    return;
                }

                string direccion = txtDireccion.Text;
                string email = txtEmail.Text;
                string celular = txtCel.Text;
                DateTime fRegistro = DateTime.Now;
                bool estado = chkEstado.Checked;

                // Crea un objeto entCliente
                entCliente nuevoCliente = new entCliente
                {
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellido.Text,
                    Tipocliente = tipocliente,
                    TipoDoc = tipoDoc,
                    Documento = documento,
                    Direccion = direccion,
                    Email = email,
                    Celular = celular,
                    FRegistro = fRegistro,
                    Estado = estado
                };

                // Llama a la capa lógica para insertar el cliente
                logCliente.Instancia.InsertaCliente(nuevoCliente);

                // Muestra un mensaje de éxito
                MessageBox.Show("Cliente insertado con éxito");

                // Limpia los campos del formulario
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que ocurra
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            cbxTipoCliente.SelectedIndex = -1; // Resetea el ComboBox
            cbxDocumento.SelectedIndex = -1; // Resetea el ComboBox
            txtDocumento.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtCel.Clear();
            chkEstado.Checked = false;
        }

        private void btnModifCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que hay una fila seleccionada en el DataGridView
                if (dgvCliente.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona un cliente de la lista.");
                    return;
                }

                // Verifica que los ComboBox tienen un ítem seleccionado
                if (cbxTipoCliente.SelectedItem == null || cbxDocumento.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecciona una opción en los campos Tipo Cliente y Tipo Documento.");
                    return;
                }

                // Captura los datos de los ComboBox y TextBox
                string tipocliente = cbxTipoCliente.SelectedItem.ToString();
                string tipoDoc = cbxDocumento.SelectedItem.ToString();
                int documento;

                // Verifica que el documento es un número válido
                if (!int.TryParse(txtDocumento.Text, out documento))
                {
                    MessageBox.Show("Por favor, ingresa un número válido en el campo Documento.");
                    return;
                }

                string direccion = txtDireccion.Text;
                string email = txtEmail.Text;
                string celular = txtCel.Text;
                bool estado = chkEstado.Checked;

                // Crea un objeto entCliente
                entCliente clienteActualizado = new entCliente
                {
                    ID = int.Parse(dgvCliente.SelectedRows[0].Cells["ID"].Value.ToString()), // Asegúrate de tener una columna ID en el DataGridView
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellido.Text,
                    Tipocliente = tipocliente,
                    TipoDoc = tipoDoc,
                    Documento = documento,
                    Direccion = direccion,
                    Email = email,
                    Celular = celular,
                    Estado = estado
                };

                // Llama a la capa lógica para modificar el cliente
                logCliente.Instancia.ModificarCliente(clienteActualizado);

                // Muestra un mensaje de éxito
                MessageBox.Show("Cliente modificado con éxito");

                // Limpia los campos del formulario
                LimpiarCampos();

                // Refresca la lista de clientes
                listarCliente();
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que ocurra
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
        private void dgvCliente_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                var selectedRow = dgvCliente.SelectedRows[0];
                txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = selectedRow.Cells["Apellidos"].Value.ToString();
                cbxTipoCliente.SelectedItem = selectedRow.Cells["Tipocliente"].Value.ToString();
                cbxDocumento.SelectedItem = selectedRow.Cells["TipoDoc"].Value.ToString();
                txtDocumento.Text = selectedRow.Cells["Documento"].Value.ToString();
                txtDireccion.Text = selectedRow.Cells["Direccion"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtCel.Text = selectedRow.Cells["Celular"].Value.ToString();
                chkEstado.Checked = (bool)selectedRow.Cells["Estado"].Value;
            }
        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtBuscarIDCli.Text, out id))
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo ID.");
                return;
            }

            try
            {
                entCliente cli = logCliente.Instancia.BuscarClientePorID(id);
                if (cli != null)
                {
                    // Llena los campos del formulario con los datos del cliente encontrado
                    txtNombre.Text = cli.Nombre;
                    txtApellido.Text = cli.Apellidos;
                    cbxTipoCliente.SelectedItem = cli.Tipocliente;
                    cbxDocumento.Text = cli.TipoDoc;
                    txtDocumento.Text = cli.Documento.ToString();
                    txtDireccion.Text = cli.Direccion;
                    txtEmail.Text = cli.Email;
                    txtCel.Text = cli.Celular;
                    chkEstado.Checked = cli.Estado;

                    groupBox2.Enabled = true;
                    btn_AgregarCliente.Visible = false;
                    btnModifCliente.Visible = true;
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}

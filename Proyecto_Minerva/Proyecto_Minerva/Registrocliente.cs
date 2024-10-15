using CapaEntidad;
using CapaLogica;
using CapaPresentacion;
using CapaPresentacion.Utilidades;
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
        ApisPeru ApísPeru = new ApisPeru();

        public Registrocliente()
        {
            InitializeComponent();
            listarCliente();
            InicializarComboBoxes();
        }
        private void Registrocliente_Load_1(object sender, EventArgs e)
        {
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            gboInformacion.Enabled = true;
            gbContacto.Enabled = true;
            gboDatosBusqueda.Enabled = true;
            btnAgregar.Enabled = true;
            btnCancelar.Enabled = true;
            btnModificar.Enabled = true;
            btnInhabilitar.Enabled = true;
            chkEstado.Enabled = true;

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gboInformacion.Enabled = false;
            gbContacto.Enabled = false;
            gboDatosBusqueda.Enabled = false;
            btnAgregar.Enabled = false;
            btnCancelar.Enabled = false;
            btnModificar.Enabled = false;
            btnInhabilitar.Enabled = false;
            chkEstado.Enabled = false;
            LimpiarCampos();
        }

        public void listarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void InicializarComboBoxes()
        {
            // Llenado de ComboBox cbxTipoCliente
            cbxTipoCliente.Items.Clear();
            List<string> tiposClientes = logCliente.Instancia.ObtenerTiposClientes();
            foreach (string tipo in tiposClientes)
            {
                cbxTipoCliente.Items.Add(tipo);
            }

            // Llenado de ComboBox cbxDocumento
            cbxDocumento.Items.Clear();
            List<string> tiposDocumentos = logCliente.Instancia.ObtenerTiposDocumentos();
            foreach (string tipo in tiposDocumentos)
            {
                cbxDocumento.Items.Add(tipo);
            }
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

                // Valida campos obligatorios
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(direccion))
                {
                    MessageBox.Show("Por favor, completa todos los campos obligatorios.");
                    return;
                }

                DateTime fRegistro = DateTime.Now;
                bool estado = chkEstado.Checked;

                // Crea un objeto entCliente con los datos capturados
                entCliente nuevoCliente = new entCliente
                {
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellido.Text,
                    Tipocliente = tipocliente, // Asume que la capa lógica obtendrá el ID a partir de esta descripción
                    TipoDoc = tipoDoc, // Asume que la capa lógica obtendrá el ID a partir de esta descripción
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
                MessageBox.Show("Cliente insertado con éxito.");
                listarCliente(); // Refresca la lista de clientes si corresponde

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
                    //Nombre = txtNombre.Text,
                    //Apellidos = txtApellido.Text,
                    Tipocliente = tipocliente,
                    TipoDoc = tipoDoc,
                    Documento = documento,
                    Direccion = direccion,
                    Email = email,
                    Celular = celular,
                    Estado = estado
                };

                // Llama a la capa lógica para modificar el cliente
                //logCliente.Instancia.ModificarCliente(clienteActualizado);

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
            if (!int.TryParse(txtBuscarDocumento.Text, out id))
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo ID.");
                return;
            }

            try
            {
                //entCliente cli = logCliente.Instancia.BuscarClientePorID(id);
                //if (cli != null)
                //{
                //    // Llena los campos del formulario con los datos del cliente encontrado
                //    txtNombre.Text = cli.Nombre;
                //    txtApellido.Text = cli.Apellidos;
                //    cbxTipoCliente.SelectedItem = cli.Tipocliente;
                //    cbxDocumento.Text = cli.TipoDoc;
                //    txtDocumento.Text = cli.Documento.ToString();
                //    txtDireccion.Text = cli.Direccion;
                //    txtEmail.Text = cli.Email;
                //    txtCel.Text = cli.Celular;
                //    chkEstado.Checked = cli.Estado;

                //    gboInformacion.Enabled = true;
                //    btnAgregar.Visible = false;
                //    btnModificar.Visible = true;
                //}
                //else
                //{
                //    MessageBox.Show("Cliente no encontrado.");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void consultar()
        {
            try
            {
                //---------DNI-----------
                if (txtDocumento.Text.Length == 8)
                {
                    var apisPeru = new ApisPeru();
                    dynamic respuesta = apisPeru.Get("https://dniruc.apisperu.com/api/v1/dni/" + txtDocumento.Text + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImRhdmlsYWpob2phbkBnbWFpbC5jb20ifQ.OexW2Uf_nGrZjUiqutNGmMODVk4zHCDV7CA9SHR8HVM");
                    txtNombre.Text = respuesta.nombres.ToString();
                    txtApellido.Text = respuesta.apellidoPaterno.ToString() + " " + respuesta.apellidoMaterno.ToString();

                }
                else if (txtDocumento.Text.Length == 11)
                {
                    var apisPeru = new ApisPeru();
                    dynamic respuesta = apisPeru.Get("https://dniruc.apisperu.com/api/v1/ruc/" + txtDocumento.Text + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImRhdmlsYWpob2phbkBnbWFpbC5jb20ifQ.OexW2Uf_nGrZjUiqutNGmMODVk4zHCDV7CA9SHR8HVM");
                    txtNombre.Text = respuesta.razonSocial.ToString() + " " + respuesta.apellidoMaterno.ToString(); ;
                    txtCel.Text = respuesta.telefonos.ToString();
                    txtDireccion.Text = respuesta.direccion.ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error... " + ex.Message);
            }
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            consultar();
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra o una tecla de control como "Backspace"
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // Si la tecla no es una letra, cancelar el evento para no permitir la entrada
                e.Handled = true;
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número (permitir sólo números del 0-9)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si la tecla no es un número, cancelar el evento para no permitir la entrada
                e.Handled = true;
            }

            // Verificar si ya se ha alcanzado la longitud máxima de 9 caracteres
            if (txtDocumento.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                // Cancelar el evento si se intenta agregar más de 9 caracteres
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra o una tecla de control como "Backspace"
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // Si la tecla no es una letra, cancelar el evento para no permitir la entrada
                e.Handled = true;
            }
        }

        private void txtCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número (permitir sólo números del 0-9)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si la tecla no es un número, cancelar el evento para no permitir la entrada
                e.Handled = true;
            }

            // Verificar si ya se ha alcanzado la longitud máxima de 9 caracteres
            if (txtDocumento.Text.Length >= 9 && !char.IsControl(e.KeyChar))
            {
                // Cancelar el evento si se intenta agregar más de 9 caracteres
                e.Handled = true;
            }
        }
    }
}

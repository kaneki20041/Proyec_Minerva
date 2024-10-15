using CapaEntidad;
using CapaLogica;
using CapaPresentacion;
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
            comboBoxRubro.Items.Clear();
            List<string> Rubro = logProveedor.Instancia.ObtenerRubro();
            foreach (string rubro in Rubro)
            {
                comboBoxRubro.Items.Add(rubro);
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
                if (comboBoxRubro.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecciona una opción en los campos Rubro.");
                    return;
                }

                string rubro = comboBoxRubro.SelectedItem.ToString();
                string ruc = txtRUC.Text.Trim();
                int telefono, ubigeo;

                // Verifica que el RUC no está vacío
                if (string.IsNullOrWhiteSpace(ruc))
                {
                    MessageBox.Show("Por favor, ingresa un número válido en el campo RUC.");
                    return;
                }

                if (!int.TryParse(txtTelefono.Text, out telefono))
                {
                    MessageBox.Show("Por favor, ingresa un número válido en el campo Teléfono.");
                    return;
                }

                if (!int.TryParse(txtCodigoUbigeo.Text, out ubigeo))
                {
                    MessageBox.Show("Por favor, ingresa un número válido en el campo Ubigeo.");
                    return;
                }

                string razonSocial = txtRazonSocial.Text.Trim();
                string distrito = txtDistrito.Text.Trim();
                string nomPro = txtNombre.Text.Trim();
                string direccion = txtDireccion.Text.Trim();
                string email = txtEmail.Text.Trim();
                bool estado = cbEstado.Checked;

                // Crea un objeto entProveedor
                entProveedor nuevoProveedor = new entProveedor
                {
                    RazonSocial = razonSocial,
                    RUC = ruc,
                    Distrito = distrito,
                    NombreComercial = nomPro,
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
            txtRazonSocial.Clear();
            txtRUC.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            cbEstado.Checked = false;
            comboBoxRubro.SelectedIndex = -1;
            txtCodigoUbigeo.Clear();
            txtDepartamento.Clear();
            txtDistrito.Clear();
            txtProvincia.Clear();
        }

        private void btnBuscProov_Click(object sender, EventArgs e)
        {
            //string nombre = txtNombre.Text.Trim();

            //if (string.IsNullOrWhiteSpace(nombre))
            //{
            //    MessageBox.Show("Por favor, ingresa un nombre válido.");
            //    return;
            //}

            //try
            //{
            //    entProveedor prov = logProveedor.Instancia.BuscarProveedorPorNombre(nombre);
            //    if (prov != null)
            //    {
            //        txtRazonSocial.Text = prov.RazonSocial;
            //        txtRUC.Text = prov.RUC;
            //        txtDireccion.Text = prov.Direccion;
            //        txtEmail.Text = prov.Email;
            //        txtTelefono.Text = prov.Telefono.ToString();
            //        cbEstado.Checked = prov.Estado;
            //        comboBoxRubro.SelectedItem = prov.Rubro;

            //        grupBoxDatos.Enabled = true;
            //        grupBoxDatos2.Enabled = true;
            //        btnAgregar.Enabled = false;
            //        btnModificar.Enabled = true;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Proveedor no encontrado.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Ocurrió un error: {ex.Message}");
            //}
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que se ha buscado un proveedor
                if (string.IsNullOrEmpty(txtRUC.Text))
                {
                    MessageBox.Show("Por favor, busca un proveedor antes de modificarlo.");
                    return;
                }

                // Verifica que los ComboBox tienen un ítem seleccionado
                if (comboBoxRubro.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecciona una opción para Rubro.");
                    return;
                }

                // Captura los datos del ComboBox y TextBox
                string rubro = comboBoxRubro.SelectedItem.ToString();
                string ruc = txtRUC.Text.Trim();
                int telefono;

                // Verifica que el RUC no está vacío
                if (string.IsNullOrWhiteSpace(ruc))
                {
                    MessageBox.Show("Por favor, ingresa un número válido en el campo RUC.");
                    return;
                }

                if (!int.TryParse(txtTelefono.Text, out telefono))
                {
                    MessageBox.Show("Por favor, ingresa un número válido en el campo Teléfono.");
                    return;
                }

                string razonSocial = txtRazonSocial.Text.Trim();
                string nomPro = txtNombre.Text.Trim();
                string direccion = txtDireccion.Text.Trim();
                string email = txtEmail.Text.Trim();
                string distrito = txtDistrito.Text.Trim();
                bool estado = cbEstado.Checked;

                entProveedor proveedorActualizado = new entProveedor
                {
                    RazonSocial = razonSocial,
                    RUC = ruc,
                    Direccion = direccion,
                    Email = email,
                    Telefono = telefono,
                    Rubro = rubro,
                    Estado = estado
                };

                //logProveedor.Instancia.ModificarProveedor(proveedorActualizado);
                MessageBox.Show("Proveedor modificado con éxito");
                LimpiarCampos();
                listarProveedor();
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que ocurra
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }

            grupBoxDatos.Enabled = false;
            grupBoxDatos2.Enabled = false;
            groupBoxUbigeo.Enabled = false;
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
            if (string.IsNullOrWhiteSpace(txtRUC.Text))
            {
                MessageBox.Show("Por favor, ingresa un RUC válido para inhabilitar.");
                return;
            }

            // Intenta convertir el valor del txtBuscarID a un número entero
            if (txtRUC.Text.Length != 11 || !txtRUC.Text.All(char.IsDigit))
            {
                MessageBox.Show("El RUC ingresado no es válido. Debe tener 11 dígitos numéricos.");
                return;
            }

            // Confirmación de inhabilitación
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas inhabilitar este proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    //logProveedor.Instancia.InhabilitarProveedor(txtRUC.Text);
                    MessageBox.Show("Proveedor inhabilitado con éxito.");
                    txtRUC.Clear();
                    listarProveedor();
                }
                catch (Exception ex)
                {
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
            cbEstado.Checked = true;
            grupBoxDatos.Enabled = true;
            grupBoxDatos2.Enabled = true;
            groupBoxUbigeo.Enabled = true;
            btnAgregar.Visible = true;
            btnAgregar.Enabled = true;
            btnInhabilitar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void btnBuscarPorRUC_Click(object sender, EventArgs e)
        {
            consultar();
        }
        private void consultar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtRUC.Text))
                {
                    MessageBox.Show("Ingrese un numero RUC.");
                }
                else if (txtRUC.Text.Length == 11)
                {
                    var apisPeru = new ApisPeru();
                    dynamic respuesta = apisPeru.Get("https://dniruc.apisperu.com/api/v1/ruc/" + txtRUC.Text + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImRhdmlsYWpob2phbkBnbWFpbC5jb20ifQ.OexW2Uf_nGrZjUiqutNGmMODVk4zHCDV7CA9SHR8HVM");
                    txtNombre.Text = respuesta.nombreComercial.ToString();
                    txtRazonSocial.Text = respuesta.razonSocial.ToString();
                    txtDireccion.Text = respuesta.direccion.ToString();
                    txtCodigoUbigeo.Text = respuesta.ubigeo.ToString();
                    txtDepartamento.Text = respuesta.departamento.ToString();
                    txtProvincia.Text = respuesta.provincia.ToString();
                    txtDistrito.Text = respuesta.distrito.ToString();
                }
                else
                {
                    MessageBox.Show("Ingrese su RUC correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error... " + ex.Message);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número (permitir sólo números del 0-9)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si la tecla no es un número, cancelar el evento para no permitir la entrada
                e.Handled = true;
            }

            // Verificar si ya se ha alcanzado la longitud máxima de 9 caracteres
            if (txtTelefono.Text.Length >= 9 && !char.IsControl(e.KeyChar))
            {
                // Cancelar el evento si se intenta agregar más de 9 caracteres
                e.Handled = true;
            }
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {            // Verificar si la tecla presionada es un número (permitir sólo números del 0-9)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si la tecla no es un número, cancelar el evento para no permitir la entrada
                e.Handled = true;
            }

            // Verificar si ya se ha alcanzado la longitud máxima de 9 caracteres
            if (txtTelefono.Text.Length >= 20 && !char.IsControl(e.KeyChar))
            {
                // Cancelar el evento si se intenta agregar más de 9 caracteres
                e.Handled = true;
            }

        }
    }
}

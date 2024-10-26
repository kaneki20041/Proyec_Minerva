using CapaDatos;
using CapaEntidad;
using CapaLogica;
using CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace Proyecto_Minerva
{
    public partial class Ventauniforme : Form
    {
        public Ventauniforme()
        {
            InitializeComponent();
            IniciaComboBox();
            textBox13.TextChanged += TextBox13_TextChanged;

        }
        public string NumVenta
        {
            get { return txtNumVenta.Text; }
        }


        private void TextBox13_TextChanged(object sender, EventArgs e)
        {
            decimal pago;
            decimal subtotal;

            // Intenta convertir el texto ingresado a decimal
            if (decimal.TryParse(textBox13.Text, out pago) && decimal.TryParse(textBox14.Text, out subtotal))
            {
                // Calcula el cambio
                decimal cambio = pago - subtotal;

                // Muestra el cambio en textBox6
                textBox6.Text = cambio >= 0 ? cambio.ToString("F2") : "Monto insuficiente";
            }
            else
            {
                // Limpiar el campo de cambio si hay un error
                textBox6.Text = string.Empty;
            }
        }
        private void IniciaComboBox()
        {
            List<string> metodosPago = logMetPago.Instancia.ObtenerMetodosPago();


        }
        private void CargarNombreCompleto()
        {
            logOVenta logicVenta = new logOVenta();

            // Aquí puedes ajustar según tu lógica para obtener el usuario
            var usuariosConectados = logicVenta.ListarUsuariosConectados();

            // Supongamos que solo necesitas el primer usuario conectado
            if (usuariosConectados.Count > 0)
            {
                txtVendedor.Text = usuariosConectados[0]; // Cargar el NombreCompleto en el TextBox
            }
            else
            {
                txtVendedor.Text = "No hay usuarios conectados"; // Mensaje alternativo
            }
        }
        private void CargarTotalVentas()
        {
            logOVenta logicaVenta = new logOVenta();
            string totalVentas = logicaVenta.ContarVentas();

            txtNumVenta.Text = totalVentas; // Asumiendo que tienes un TextBox para mostrar el total
        }

        private void Ventauniforme_Load(object sender, EventArgs e)
        {
            CargarNombreCompleto();
            CargarTotalVentas();
        }

        public int confilas = 0;
        public decimal Total = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            entCompra dCom = new entCompra();
            entPrendas Pren = new entPrendas();

            if ((this.txtStock.Text.Trim() != "") && (txtCantidad.Text.Trim() != ""))
            {
                if ((Convert.ToInt32(txtCantidad.Text) > 0) && (Convert.ToInt32(txtCantidad.Text) <= Convert.ToInt32(txtStock.Text)))
                {
                    if (confilas == 0)
                    {

                        tablaVentas.Rows.Add(txtDescripcion.Text, txtColegio.Text, txtCategoria.Text, txtTalla.Text, txtCantidad.Text, txtPrecio.Text);
                        decimal subTotal = Convert.ToDecimal(tablaVentas.Rows[confilas].Cells[4].Value) * Convert.ToDecimal(tablaVentas.Rows[confilas].Cells[5].Value);
                        tablaVentas.Rows[confilas].Cells[6].Value = subTotal;
                        confilas++;
                    }
                    else
                    {
                        tablaVentas.Rows.Add(txtDescripcion.Text, txtColegio.Text, txtCategoria.Text, txtTalla.Text, txtCantidad.Text, txtPrecio.Text);
                        decimal subTotal = Convert.ToDecimal(tablaVentas.Rows[confilas].Cells[4].Value) * Convert.ToDecimal(tablaVentas.Rows[confilas].Cells[5].Value);
                        tablaVentas.Rows[confilas].Cells[6].Value = subTotal;
                        confilas++;
                    }
                }
                Total = 0;
                foreach (DataGridViewRow Fila in tablaVentas.Rows)
                {

                    Total += Convert.ToInt32(Fila.Cells[6].Value);
                }
                textBox14.Text = Total.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (confilas > 0)
            {
                Total -= Convert.ToDecimal(tablaVentas.Rows[tablaVentas.CurrentRow.Index].Cells[6].Value);
                //txtTotal.Text = "S/." + Total.ToString();
                txtTalla.Text = Total.ToString();
                tablaVentas.Rows.RemoveAt(tablaVentas.CurrentRow.Index);
                confilas--;
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

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            int documento;
            if (int.TryParse(txtDocumento.Text, out documento))
            {
                logCliente logicaCliente = new logCliente();
                string nombreCompleto = logicaCliente.BuscarNombreCompletoPorDocumento(documento);

                if (!string.IsNullOrEmpty(nombreCompleto))
                {
                    txtNombre.Text = $"{nombreCompleto}";
                }
                else
                {
                    DialogResult result = MessageBox.Show("Cliente no encontrado. ¿Desea registrar un nuevo cliente?",
    "Cliente no encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Obtener referencia al formulario principal
                        Form Principal = this.ParentForm;

                        // Obtener referencia al panel contenedor
                        Panel panelContainer = (Panel)Principal.Controls["panelconteiner"];

                        // Limpiar el panel contenedor
                        panelContainer.Controls.Clear();

                        // Crear nueva instancia del formulario de registro
                        Registrocliente formRegistro = new Registrocliente();
                        formRegistro.TopLevel = false;
                        formRegistro.FormBorderStyle = FormBorderStyle.None;
                        formRegistro.Dock = DockStyle.Fill;

                        // Agregar el formulario al panel
                        panelContainer.Controls.Add(formRegistro);
                        formRegistro.Show();
                    }

                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            using (ReportePrendas formRepPrenda = new ReportePrendas())
            {
                if (formRepPrenda.ShowDialog() == DialogResult.OK)
                {
                    txtDescripcion.Text = formRepPrenda.descripcion;
                    txtTalla.Text = formRepPrenda.talla;
                    txtColegio.Text = formRepPrenda.colegio;
                    txtCategoria.Text = formRepPrenda.categoria;
                    txtPrecio.Text = formRepPrenda.precioVenta;
                    txtStock.Text = formRepPrenda.stock;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos requeridos
                if (!ValidarCamposRequeridos())
                    return;

                // Preguntar al usuario si ha terminado de registrar la venta
                DialogResult result = MessageBox.Show("¿Has terminado de registrar la venta?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    MessageBox.Show("Puedes continuar eligiendo artículos para vender.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // No registrar la venta
                }

                // Crear objeto de venta
                entOVenta venta = new entOVenta
                {
                    FRegistroV = dateTimePicker2.Value,
                    MontoTotal = Convert.ToDecimal(textBox14.Text),
                    MontoPago = !string.IsNullOrEmpty(textBox13.Text) ? Convert.ToDecimal(textBox13.Text) : (decimal?)null,
                    MontoCambio = !string.IsNullOrEmpty(textBox6.Text) ? Convert.ToDecimal(textBox6.Text) : (decimal?)null,
                    Documento = txtDocumento.Text,
                    NombreCompleto = txtVendedor.Text,
                    NombreCliente = txtNombre.Text
                };

                int idVenta = 0; // Declarar idVenta aquí

                // Registrar la venta usando TransactionScope
                using (TransactionScope scope = new TransactionScope())
                {
                    idVenta = logOVenta.Instancia.RegistrarVenta(venta);

                    if (idVenta <= 0)
                    {
                        MessageBox.Show("Error al registrar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (GrabarDetalleVenta(idVenta))
                    {
                        scope.Complete(); // Completa la transacción solo si todas las operaciones se realizan correctamente
                        MessageBox.Show("Venta registrada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al grabar los detalles de la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Redirigir al formulario Carrito
                Form Principal = this.ParentForm;
                Panel panelContainer = (Panel)Principal.Controls["panelconteiner"];

                panelContainer.Controls.Clear();

                Carrito formCarrito = new Carrito(idVenta); // Usar idVenta aquí
                formCarrito.TopLevel = false;
                formCarrito.FormBorderStyle = FormBorderStyle.None;
                formCarrito.Dock = DockStyle.Fill;

                panelContainer.Controls.Add(formCarrito);
                formCarrito.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private bool GrabarDetalleVenta(int idVenta)
        {
            bool todoCorrecto = true;
            List<string> errores = new List<string>();

            try
            {
                foreach (DataGridViewRow fila in tablaVentas.Rows)
                {
                    if (fila.IsNewRow || fila.Cells[0].Value == null)
                        continue;

                    try
                    {
                        entCarrito detalleVenta = new entCarrito
                        {
                            OventaID = idVenta // ID de la venta a la que pertenece el detalle
                        };

                        // Validar y obtener la descripción
                        string descripcion = fila.Cells[0].Value?.ToString().Trim();
                        if (string.IsNullOrWhiteSpace(descripcion))
                        {
                            errores.Add($"Fila {fila.Index + 1}: La descripción está vacía");
                            todoCorrecto = false;
                            continue;
                        }

                        // Validar y obtener la talla
                        string talla = fila.Cells[3].Value?.ToString().Trim();
                        if (string.IsNullOrWhiteSpace(talla))
                        {
                            errores.Add($"Fila {fila.Index + 1}: La talla está vacía");
                            todoCorrecto = false;
                            continue;
                        }

                        // Validar y obtener la cantidad
                        if (!int.TryParse(fila.Cells[4].Value?.ToString(), out int cantidad))
                        {
                            errores.Add($"Fila {fila.Index + 1}: Cantidad inválida");
                            todoCorrecto = false;
                            continue;
                        }

                        // Validar y obtener el precio
                        if (!decimal.TryParse(fila.Cells[5].Value?.ToString(), out decimal precio))
                        {
                            errores.Add($"Fila {fila.Index + 1}: Precio inválido");
                            todoCorrecto = false;
                            continue;
                        }

                        if (cantidad <= 0 || precio <= 0)
                        {
                            errores.Add($"Fila {fila.Index + 1}: Cantidad y precio deben ser mayores a 0");
                            todoCorrecto = false;
                            continue;
                        }

                        // Asignar propiedades al detalleVenta
                        detalleVenta.Descripcion = new entPrendas { Descripcion = descripcion }; // Ajusta según tu modelo
                        detalleVenta.Talla = new entPrendas { Talla = talla }; // Ajusta según tu modelo
                        detalleVenta.Cantidad = cantidad;
                        detalleVenta.PrecioVenta = precio;

                        // Intentar insertar el detalle
                        try
                        {
                            logOVenta.Instancia.InsertarDetalleVenta(detalleVenta);
                        }
                        catch (Exception ex)
                        {
                            errores.Add($"Fila {fila.Index + 1}: Error al grabar el detalle - {ex.Message}");
                            todoCorrecto = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        errores.Add($"Fila {fila.Index + 1}: {ex.Message}");
                        todoCorrecto = false;
                    }
                }

                // Mostrar errores si hay
                if (errores.Count > 0)
                {
                    string mensajeError = "Se encontraron los siguientes errores:\n\n" +
                                          string.Join("\n", errores);
                    MessageBox.Show(mensajeError, "Errores en detalles", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return todoCorrecto;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general al grabar detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool ValidarCamposRequeridos()
        {
            if (string.IsNullOrEmpty(textBox14.Text) ||
                string.IsNullOrEmpty(txtDocumento.Text) ||
                string.IsNullOrEmpty(txtVendedor.Text))
            {
                MessageBox.Show("Todos los campos requeridos deben estar llenos",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (tablaVentas.Rows.Count <= 1)
            {
                MessageBox.Show("Debe agregar al menos un detalle de venta",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número (permitir sólo números del 0-9)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si la tecla no es un número, cancelar el evento para no permitir la entrada
                e.Handled = true;
            }

            // Verificar si ya se ha alcanzado la longitud máxima de 9 caracteres
            if (txtCantidad.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                // Cancelar el evento si se intenta agregar más de 9 caracteres
                e.Handled = true;
            }
        }

    }
}

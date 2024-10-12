
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

        private void ListarVentas()
        {
            try
            {
                List<entOVenta> lista = logOVenta.Instancia.ListarVentas();
                tablaVentas.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al listar las ventas: {ex.Message}");
            }
        }

        public int confilas = 0;
        public decimal Total = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            entCompra dCom = new entCompra();
            entPrendas Pren = new entPrendas();

            if ((this.textBox5.Text.Trim() != "") && (txtCantidad.Text.Trim() != ""))
            {
                if ((Convert.ToInt32(txtCantidad.Text) > 0) && (Convert.ToInt32(txtCantidad.Text) <= Convert.ToInt32(textBox5.Text)))
                {
                    if (confilas == 0)
                    {

                        tablaVentas.Rows.Add(textBox10.Text, textBox11.Text, textBox12.Text, textBox2.Text, txtCantidad.Text, textBox3.Text);
                        decimal subTotal = Convert.ToDecimal(tablaVentas.Rows[confilas].Cells[4].Value) * Convert.ToDecimal(tablaVentas.Rows[confilas].Cells[5].Value);
                        tablaVentas.Rows[confilas].Cells[6].Value = subTotal;
                        confilas++;
                    }
                    else
                    {
                        tablaVentas.Rows.Add(textBox10.Text, textBox11.Text, textBox12.Text, textBox2.Text, txtCantidad.Text, textBox3.Text);
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
                textBox2.Text = Total.ToString();
                tablaVentas.Rows.RemoveAt(tablaVentas.CurrentRow.Index);
                confilas--;
            }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            int documento;
            if (int.TryParse(textBox7.Text, out documento))
            {
                logCliente logicaCliente = new logCliente();
                string nombreCompleto = logicaCliente.BuscarNombreCompletoPorDocumento(documento);

                if (!string.IsNullOrEmpty(nombreCompleto))
                {
                    textBox1.Text = $"{nombreCompleto}";
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
                    textBox10.Text = formRepPrenda.descripcion;
                    textBox2.Text = formRepPrenda.talla;
                    textBox11.Text = formRepPrenda.colegio;
                    textBox12.Text = formRepPrenda.categoria;
                    textBox3.Text = formRepPrenda.precioVenta;
                    textBox5.Text = formRepPrenda.stock;
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

        // Crear objeto de venta
        entOVenta venta = new entOVenta
        {
            FRegistroV = dateTimePicker2.Value,
            MontoTotal = Convert.ToDecimal(textBox14.Text),
            MontoPago = !string.IsNullOrEmpty(textBox13.Text) ? Convert.ToDecimal(textBox13.Text) : null,
            MontoCambio = !string.IsNullOrEmpty(textBox6.Text) ? Convert.ToDecimal(textBox6.Text) : null,
            Documento =textBox7.Text,
            NombreCompleto =textBox4.Text,
            NombreCliente = textBox1.Text
        };

        // Registrar la venta usando TransactionScope
        using (TransactionScope scope = new TransactionScope())
        {
            int idVenta = logOVenta.Instancia.RegistrarVenta(venta);

            if (idVenta <= 0)
            {
                MessageBox.Show("Error al registrar la venta", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (GrabarDetalleVenta(idVenta))
            {
                scope.Complete();
                MessageBox.Show("Venta registrada correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Preguntar al usuario si desea continuar al pago
                DialogResult result = MessageBox.Show("¿Deseas continuar al pago?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                else
                {
                    // Aquí puedes agregar lógica adicional si el usuario elige no continuar
                    MessageBox.Show("Operación cancelada. No se procederá al pago.", "Cancelado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error al procesar la venta: {ex.Message}",
            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}



        private bool GrabarDetalleVenta(int idVenta)
        {
            bool todoCorrecto = true;
            List<string> errores = new List<string>();

            try
            {
                foreach (DataGridViewRow fila in tablaVentas.Rows) // Cambiar a tablaVentas
                {
                    if (fila.IsNewRow || fila.Cells[0].Value == null)
                        continue;

                    try
                    {
                        // Crear nuevo objeto para cada detalle de venta
                        entDetalleVenta detalleVenta = new entDetalleVenta();
                        detalleVenta.OventaID = idVenta; // ID de la venta a la que pertenece el detalle

                        // Validar y obtener la descripción
                        if (string.IsNullOrWhiteSpace(fila.Cells[0].Value?.ToString()))
                        {
                            errores.Add($"Fila {fila.Index + 1}: La descripción está vacía");
                            todoCorrecto = false;
                            continue;
                        }

                        entPrendas prenda = new entPrendas();
                        prenda.Descripcion = fila.Cells[0].Value.ToString().Trim();
                        detalleVenta.Descripcion = prenda; // Asignar la descripción a detalleVenta

                        // Validar y obtener la cantidad y precio
                        if (!int.TryParse(fila.Cells[4].Value?.ToString(), out int cantidad))
                        {
                            errores.Add($"Fila {fila.Index + 1}: Cantidad inválida");
                            todoCorrecto = false;
                            continue;
                        }

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

                        detalleVenta.Cantidad = cantidad; // Asignar cantidad
                        detalleVenta.PrecioVenta = precio; // Asignar precio

                        // Intentar insertar el detalle
                        try
                        {
                            logOVenta.Instancia.InsertarDetalleVenta(detalleVenta); // Llamar al método de la capa lógica
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
                string.IsNullOrEmpty(textBox7.Text) ||
                string.IsNullOrEmpty(textBox4.Text))
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ventauniforme_Load_1(object sender, EventArgs e)
        {

        }
    }
}

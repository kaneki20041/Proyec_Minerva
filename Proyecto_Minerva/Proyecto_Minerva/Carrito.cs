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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Proyecto_Minerva
{
    public partial class Carrito : Form
    {
        private int _idVenta;
        private FacturacionApi api;
        private entComprobanteventa comprobante;

        public Carrito(int idVenta)
        {
            _idVenta = idVenta;
            InitializeComponent();
            ListarVentas();
            InicializarComboBoxes();
            string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJ1c2VybmFtZSI6ImthbmVraTIwMDQxIiwiaWF0IjoxNzI5OTE2MzM3LCJleHAiOjE3MzAwMDI3Mzd9.TvGX3VYEfGt7V4Pw9Wx5UW_D6V61pZ3o04Oph34mDTHRoRJPBuCFv8HLcHxudTKc7YpFsNym3QST6HO5aFwSVXz3Wv5EaoIzKNFCSBxFIi9ybji-A4LA7TpGZQ8hUgb317l_uSLGmC1Ko-3O7OrCrExqL9p2PWOivQ0Iv7R6z8QAwEZgOEMOzT_0NvQobiUkUK6uJtcFEHA65YLwr9KL68sfGacgcBcfsy0lsejK7eCm8Nu4Yf8etlvTzgU-Nt0zD-3xjS-g54y4I9NxZ-yKCDC4OyAkfw8uH1b5i5_XoRDU1ege54OrXhRkqhX1uAs3G33seGRjkbTEEQ2R77qS1mFBpEM4WxNtlt3IKcGGgwbNPxHXB219redsngatMm3CTz09PHwSf0hmX6q6r1ZG-U7ceh98iLzJIXX-vOTS9BcdAk29jYkFQ1yo3ubezzFQfd4gC3T7nzmmS6UJODsxxbqBlrfVot5JHR9QnHM0EWs3mBApWO3s-PTUKyyw-kPMuEDKt6elxRr_LktlQnwReEMD2tGcgqi6Ntn3kf81nTb-TqDZ8uWFYV-Ae9uyae1RvlsV4Q-vGPkQ7u_PSXvAiQ5ZP4q1qwcsD6ukwAtlYXY9QfLR4rT7tLOm7GY-3OTwS18lbz75-L5yjfhYk6jh2Jt1pkdJkXzilAmWzAt5puo";
            api = new FacturacionApi(token);
            decimal montoTotal = logOVenta.Instancia.ObtenerMontoTotalPorId(_idVenta);
            txtTotalGravada.Text = montoTotal.ToString("C"); // Formatear como moneda
            decimal montoTotalGravado = Convert.ToDecimal(txtTotalGravada.Text.Replace("S/", "").Trim());
            // Calcular IGV (18% del monto total gravado)
            decimal igv = montoTotalGravado * 0.18m;

            // Calcular subtotal
            decimal subtotal = montoTotalGravado + igv;

            // Mostrar los resultados en los TextBoxes correspondientes (ajusta los nombres según tu formulario)
            txtIGV.Text = igv.ToString("C"); // Formatea como moneda
            txtSubTotal.Text = subtotal.ToString("C"); // Formatea como moneda

            //this.FormClosing += Carrito_FormClosing;
        }

        private void ListarVentas()
        {
            try
            {
                List<entOVenta> lista = logOVenta.Instancia.ListarVentasPorId(_idVenta);
                dgvDetalleventa.DataSource = lista; // Asumiendo que dgvDetalleventa es tu DataGridView
                dgvDetalleventa.Columns["Documento"].Visible = false;
                dgvDetalleventa.Columns["NombreCompleto"].Visible = false;
                dgvDetalleventa.Columns["NombreCliente"].Visible = false;
                dgvDetalleventa.Columns["MontoCambio"].Visible = false;
                dgvDetalleventa.Columns["MontoPago"].Visible = false;
                dgvDetalleventa.Columns["FRegistroV"].Visible = false;
                dgvDetalleventa.Columns["MontoTotal"].Visible = false;
                dgvDetalleventa.Columns["Descripcion"].Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al listar las ventas: {ex.Message}");
            }
        }

        private void InicializarComboBoxes()
        {
            // Llenado de ComboBox comboBox2 (Categorias)
            comboTipoComprobante.Items.Clear();
            List<string> Comprobante = logComprobante.Instancia.ObtenerComprobante();
            foreach (string compr in Comprobante)
            {
                comboTipoComprobante.Items.Add(compr);
            }

            comboMetodoPago.Items.Clear();
            List<string> metodo = logMetPago.Instancia.ObtenerMetodosPago();
            foreach (string met in metodo)
            {
                comboMetodoPago.Items.Add(met);
            }
        }

        private void Carrito_Load(object sender, EventArgs e)
        {
        }

        private void comboTipoComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Solo ejecuta si hay un tipo de comprobante seleccionado
            if (comboTipoComprobante.SelectedItem != null)
            {
                string tipoComprobante = comboTipoComprobante.SelectedItem.ToString();

                // Llama al método de la capa lógica para generar el número de comprobante
                string nuevoNumero = logComprobante.Instancia.GenerarNumeroComprobante(tipoComprobante);

                // Muestra el nuevo número en txtSerie
                txtSerie.Text = nuevoNumero;
            }
        }

        private void btnEmitirComprobante_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDocumento.Text.Trim()) || string.IsNullOrEmpty(txtNombre.Text.Trim()) ||
                string.IsNullOrEmpty(txtDireccion.Text.Trim()) || string.IsNullOrEmpty(txtTipoDoc.Text.Trim()) ||
                comboTipoComprobante.SelectedIndex == -1 || comboMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, rellene todos los campos del Cliente y Pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Crear una lista para almacenar los detalles de los productos
                var detallesProductos = new List<object>();

                // Iterar sobre las filas del DataGridView
                foreach (DataGridViewRow row in dgvDetalleventa.Rows)
                {
                    // Asegúrate de no procesar la fila de nuevo registro si está presente
                    if (!row.IsNewRow)
                    {
                        decimal precioVenta = Convert.ToDecimal(row.Cells["PrecioVenta"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                        detallesProductos.Add(new
                        {
                            codProducto = row.Cells["OventaID"].Value?.ToString(),
                            descripcion = row.Cells["Descripcion"].Value?.ToString(),
                            cantidad = cantidad,
                            mtoValorUnitario = precioVenta,
                            mtoValorVenta = precioVenta * cantidad,
                            mtoBaseIgv = precioVenta * cantidad,
                            porcentajeIgv = 18m,
                            igv = (precioVenta * cantidad) * 0.18m,
                            tipAfeIgv = 10,
                            totalImpuestos = (precioVenta * cantidad) * 0.18m,
                            mtoPrecioUnitario = precioVenta * 1.18m
                        });
                    }
                }

                // Obtener los totales desde los TextBox
                decimal mtoOperGravadas = Convert.ToDecimal(txtTotalGravada.Text.Replace("S/", "").Trim());
                decimal mtoIGV = Convert.ToDecimal(txtIGV.Text.Replace("S/", "").Trim());
                decimal subTotal = Convert.ToDecimal(txtSubTotal.Text.Replace("S/", "").Trim());

                var facturacionData = new
                {
                    ublVersion = "2.1",
                    tipoOperacion = "0101",
                    tipoDoc = "03",
                    serie = txtSerie.Text,
                    correlativo = "1",
                    fechaEmision = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"),
                    formaPago = new
                    {
                        moneda = "PEN",
                        tipo = comboMetodoPago.Text.Trim(),
                    },
                    tipoMoneda = "PEN",
                    client = new
                    {
                        tipoDoc = txtTipoDoc.Text.Trim(),
                        numDoc = txtDocumento.Text.Trim(),
                        rznSocial = txtNombre.Text.Trim(),
                        address = new
                        {
                            direccion = txtDireccion.Text.Trim(),
                            provincia = "LIMA",
                            departamento = "LIMA",
                            distrito = "LIMA",
                            ubigueo = "150101"
                        }
                    },
                    company = new
                    {
                        ruc = 20482329731,
                        razonSocial = "Minerva",
                        nombreComercial = "Minerva",
                        address = new
                        {
                            direccion = "Av. America Oeste Mz H Lt 27, Trujillo, Peru",
                            provincia = "Trujillo",
                            departamento = "La Libertad",
                            distrito = "Trujillo",
                            ubigueo = "150101"
                        }
                    },
                    mtoOperGravadas = mtoOperGravadas,
                    mtoIGV = mtoIGV,
                    valorVenta = mtoOperGravadas,
                    totalImpuestos = mtoIGV,
                    subTotal = subTotal,
                    mtoImpVenta = subTotal,
                    details = detallesProductos,
                    legends = new[]
                    {
                new
                {
                    code = "1000",
                    value = ConvertirNumeroALetras(subTotal) + " SOLES"
                }
            }
                };
                entComprobanteventa comprobante = new entComprobanteventa
                {
                    id_venta = _idVenta,
                    descripcion = comboTipoComprobante.SelectedItem.ToString(),
                    numero_comprobante = txtSerie.Text,
                    fecha_emision = dateTimePicker2.Value,
                    subtotal = Convert.ToDecimal(txtSubTotal.Text.Replace("S/", "").Trim()),
                    igv = Convert.ToDecimal(txtIGV.Text.Replace("S/", "").Trim()),
                    total = Convert.ToDecimal(txtTotalGravada.Text.Replace("S/", "").Trim())
                };
                int idComprobante = logComprobante.Instancia.RegistrarComprobantePago(comprobante);

                MessageBox.Show($"Comprobante registrado con ID: {idComprobante}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string url = "https://facturacion.apisperu.com/api/v1/invoice/pdf";
                dynamic respuesta = api.Post(url, facturacionData);

                // Verificar si el PDF fue guardado correctamente
                if (respuesta != null && respuesta.pdf_url != null)
                {
                    string pdfPath = respuesta.pdf_url.ToString();

                    // Asegurarse de que la ruta sea absoluta
                    if (!Path.IsPathRooted(pdfPath))
                    {
                        pdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), pdfPath);
                    }

                    MessageBox.Show($"PDF generado y guardado como: {pdfPath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir el PDF con el visor predeterminado
                    try
                    {
                        var psi = new System.Diagnostics.ProcessStartInfo
                        {
                            UseShellExecute = true,
                            FileName = pdfPath
                        };
                        System.Diagnostics.Process.Start(psi);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al abrir el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Respuesta de la API: {JsonConvert.SerializeObject(respuesta, Formatting.Indented)}", "Respuesta de la API", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al emitir factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Método para convertir número a letras (debes implementar esta función)
        private string ConvertirNumeroALetras(decimal numero)
        {
            // Implementa la lógica para convertir el número a letras
            // Por ejemplo: "CIENTO DIECIOCHO CON 00/100"
            return "IMPLEMENTAR CONVERSIÓN A LETRAS";
        }

        private List<object> ObtenerItems()
        {
            var items = new List<object>();
            // Asumiendo que tienes un DataGridView llamado dgvItems
            foreach (DataGridViewRow row in dgvDetalleventa.Rows)
            {
                if (!row.IsNewRow)
                {
                    items.Add(new
                    {
                        producto = row.Cells["NombreCliente"].Value.ToString(),
                        cantidad = row.Cells["Cantidad"].Value.ToString(),
                        precio_base = row.Cells["PrecioBase"].Value.ToString(),
                        codigo_sunat = row.Cells["CodigoSunat"].Value.ToString(),
                        codigo_producto = row.Cells["CodigoProducto"].Value.ToString(),
                        codigo_unidad = row.Cells["CodigoUnidad"].Value.ToString(),
                        tipo_igv_codigo = "10" // Asumiendo gravado - operación onerosa, ajusta según sea necesario
                    });
                }
            }
            return items;
        }
        private void btnBuscarDoc_Click(object sender, EventArgs e)
        {
            // Obtener el documento del TextBox (suponiendo que se llama txtDocumento)
            string documento = txtDocumento.Text.Trim();

            // Validar que el documento no esté vacío
            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Por favor, ingrese un documento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear una instancia de logCliente (ajusta esto según cómo se inicializa en tu aplicación)
            var logCliente = new logCliente(); // Asegúrate de que esta línea sea correcta

            // Buscar el cliente por documento usando el método de la capa lógica
            entCliente cliente = logCliente.BuscarClientePorID(documento);

            // Validar si se encontró el cliente
            if (cliente != null)
            {
                // Mostrar los datos en los TextBox correspondientes
                txtTipoDoc.Text = cliente.TipoDoc; // Asumiendo que txtTipoDoc es un TextBox
                txtNombre.Text = $"{cliente.Nombre} {cliente.Apellidos}"; // Asumiendo que tienes un TextBox para el nombre
                txtDireccion.Text = cliente.Direccion; // Asumiendo que txtDireccion es un TextBox
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

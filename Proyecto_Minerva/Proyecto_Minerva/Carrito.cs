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
        private FacturacionApi api;
        public Carrito()
        {
            InitializeComponent();
            ListarVentas();
            InicializarComboBoxes();
            string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJ1c2VybmFtZSI6ImthbmVraTIwMDQxIiwiaWF0IjoxNzI5MTQyMjE5LCJleHAiOjE3MjkyMjg2MTl9.eONR2W9e8jhBOeT2pUYaPB1yYTSRciK4F6uQikPriVl2IfWOTyK8C7YGy524d3-CrNlWfuVwOqI8w-NOx4_7VWuWck_ta9BSKdUoinJyIn_N4FJRoN_n2JaXaKXjvX-nG5GQNT4n5wbQJIVI5tXBU9gu628zAFgHgzV7bwJrsa-6vt2KJHFNdOJaZ47nBfgI_AfKjMbvG2DyeLjwlVnij3MFfr3UyhGI1CQznZCWKbNN5uR9OBkAxax68KcMdBDj4L0KXE0HgSG8SBkLbWv773495pGhnLXeWdGpy9nBcqu11FuIeHW-VqY44mggzy91Th0cS1CzssU6IN29ogOlfpZS115jzAbfcQok5WiOY9TDzq60Uhi4aM63pOLvc6UY0aYgGloCRofoN0nQhnBRJdbEjllbBBrYjrEgcOP_wLD_jmNyLj03Tg8zy_7QRYTMYxf0WipE0eGRCvYmwSFT-KVKOD8IUOHWWTn0UnMsiei0sv1_fyXhtpfDaMAls3XERwxPDpqGE4YR6cr7rOV2JJzY7epA_v_GSnSC7DyylK8dchnUzodzN2yAUS03T_hyJ8fGkvN6KhWxnS4jNg48sl7aW8Gc4yG0KMPTPdJPkMwR65tdFOI1lNHBUi_u8fBVxTwNvGse13-hU4gctsNkAXKrK0Pzqs716zyfe36ZNPQ";
            api = new FacturacionApi(token);
        }
        private void ListarVentas()
        {
            try
            {
                List<entOVenta> lista = logOVenta.Instancia.ListarVentas();
                dgvDetalleventa.DataSource = lista;

                // Ocultar columnas específicas
                dgvDetalleventa.Columns["FRegistroV"].Visible = false;
                dgvDetalleventa.Columns["MontoCambio"].Visible = false;
                dgvDetalleventa.Columns["Documento"].Visible = false;
                dgvDetalleventa.Columns["NombreCompleto"].Visible = false;
                dgvDetalleventa.Columns["MontoPago"].Visible = false;
                dgvDetalleventa.Columns["NombreCliente"].Visible = false;
                dgvDetalleventa.Columns["OventaID"].Width = 60;
                dgvDetalleventa.Columns["PrendaID"].Width = 60;
                dgvDetalleventa.Columns["Descripcion"].Width = 210;
                dgvDetalleventa.Columns["Cantidad"].Width = 60;
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

        private void btnEmitirComprobante_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDocumento.Text.Trim()) || string.IsNullOrEmpty(txtNombre.Text.Trim()) ||
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
                        decimal montoTotal = Convert.ToDecimal(row.Cells["MontoTotal"].Value);

                        detallesProductos.Add(new
                        {
                            codProducto = row.Cells["OventaID"].Value?.ToString(),
                            descripcion = row.Cells["Descripcion"].Value?.ToString(),
                            cantidad = cantidad,
                            mtoValorUnitario = precioVenta,
                            mtoValorVenta = montoTotal,
                            mtoBaseIgv = montoTotal,
                            porcentajeIgv = 18m,
                            igv = montoTotal * 0.18m,
                            tipAfeIgv = 10,
                            totalImpuestos = montoTotal * 0.18m,
                            mtoPrecioUnitario = precioVenta * 1.18m
                        });
                    }
                }

                // Calcular los totales
                decimal mtoOperGravadas = detallesProductos.Sum(d => (decimal)((dynamic)d).mtoValorVenta);
                decimal mtoIGV = detallesProductos.Sum(d => (decimal)((dynamic)d).igv);
                decimal subTotal = mtoOperGravadas + mtoIGV;

                var facturacionData = new
                {
                    ublVersion = "2.1",
                    tipoOperacion = "0101",
                    tipoDoc = "03",
                    serie = "B001",
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

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
    public partial class Detalleventa : Form
    {
        private FacturacionApi api;
        public Detalleventa()
        {
            InitializeComponent();
            ListarVentas();
            InicializarComboBoxes();
            string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJ1c2VybmFtZSI6ImthbmVraTIwMDQxIiwiaWF0IjoxNzI4NzQwNzA1LCJleHAiOjE3Mjg4MjcxMDV9.QbnpEJBd0W2EIlBA_q94apmsDViYvkJpRV4uCRCronmsSVdGpKekVy3Xdsj7k_e82oawUDplWOhk_h2q7nTAsrb7vzwIO96ScM1Hn2SfROrpOYfqaxvMP6DkCuAd9WxGAgwILtyIxDRwDySVGPvXz9WSJP0DPC3F88cbcKI2MWvMff3nFk5T6McCB94j-tSnQcZSbeFQ16r7o0k97YYcn2WN6UOnotVXLih8uR1SAyseYXMUG_UvnFtCeOAB7ChuO1s5TUeQ9YDGIvK9E5zS8dVxUU1D_WO1K84qEnkDZHFugXrGlcVwtmqTgrdIgus3fGDUBV6mCq-QSnRYDAInzFXTIrHRgfXRJZIhApCobHijdfDPLUkE_JqEtBVMwXm42opFlddkiFvlWkqFRhYkYgdosY_Rk7ImQ-555y_AVwZhbTZzBSBKu0aXsqVhozgVECgbrrXqB7UrRIQHdnO4uv2NmI1SdUUlePFaVr2VGUWeJzM0fKXGSVoD5th1N_xlQiM481E1QvPWvGD7vubt-CA2_ZkAGRBh0ejbrdknsbG8q94gPyMQ7pOpLd4xRV2ZW7SPfXgtQ32fIMSP1hzfgPnnOosSn9YXg5w6ovecPtsMEs0XV2vvh-r3HMbNYKs62muCvTnmjyp_3M1RgY-OOqsdW8QT6RfIcPa0ZvKdeec";
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
            comboBox1.Items.Clear();
            List<string> Comprobante = logComprobante.Instancia.ObtenerComprobante();
            foreach (string compr in Comprobante)
            {
                comboBox1.Items.Add(compr);
            }

            comboBox2.Items.Clear();
            List<string> metodo = logMetPago.Instancia.ObtenerMetodosPago();
            foreach (string met in metodo)
            {
                comboBox2.Items.Add(met);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
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
                        tipo = comboBox2.Text.Trim(),
                    },
                    tipoMoneda = "PEN",
                    client = new
                    {
                        tipoDoc = textBox4.Text.Trim(),
                        numDoc = textBox5.Text.Trim(),
                        rznSocial = textBox1.Text.Trim(),
                        address = new
                        {
                            direccion = textBox3.Text.Trim(),
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

        private void Detalleventa_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            // Obtener el documento del TextBox (suponiendo que se llama txtDocumento)
            string documento = textBox5.Text.Trim();

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
                textBox4.Text = cliente.TipoDoc; // Asumiendo que txtTipoDoc es un TextBox
                textBox1.Text = $"{cliente.Nombre} {cliente.Apellidos}"; // Asumiendo que tienes un TextBox para el nombre
                textBox3.Text = cliente.Direccion; // Asumiendo que txtDireccion es un TextBox
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }

}

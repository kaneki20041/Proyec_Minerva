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
            api = new FacturacionApi();
        }
        private void ListarVentas()
        {
            try
            {
                List<entOVenta> lista = logOVenta.Instancia.ListarVentas();
                dgvDetalleventa.DataSource = lista;

                // Ocultar columnas específicas
                dgvDetalleventa.Columns["Documento"].Visible = false;
                dgvDetalleventa.Columns["NombreCompleto"].Visible = false;
                dgvDetalleventa.Columns["MontoTotal"].Visible = false;
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
                var facturacionData = new
                {
                    empresa = new
                    {
                        ruc = "20604051984",
                        razon_social = "FACTURACION ELECTRONICA MONSTRUO E.I.R.L.",
                        nombre_comercial = "FACTURACION INTEGRAL",
                        domicilio_fiscal = "AV. LA MOLINA NRO. 570",
                        ubigeo = "150114",
                        urbanizacion = "RESIDENCIAL MONTERRICO",
                        distrito = "LA MOLINA",
                        provincia = "LIMA",
                        departamento = "LIMA",
                        modo = "0",
                        usu_secundario_produccion_user = "MODDATOS",
                        usu_secundario_produccion_password = "MODDATOS"
                    },
                    cliente = new
                    {
                        razon_social_nombres = "Hector De La Cruz",
                        numero_documento = "10407086274",
                        codigo_tipo_entidad = "6",
                        cliente_direccion = "Av. Morales Duarez 168"
                    },
                    venta = new
                    {
                        serie = "FF03",
                        numero = "53953",
                        fecha_emision = "2023-01-26",
                        hora_emision = "10:02:49",
                        fecha_vencimiento = "",
                        moneda_id = "2",
                        forma_pago_id = "1",
                        total_gravada = "500",
                        total_igv = "90",
                        total_exonerada = "",
                        total_inafecta = "",
                        tipo_documento_codigo = "01",
                        nota = "notas o comentarios"
                    },
                    items = new[]
                    {
                new
                {
                    producto = "ALARMA PREMIUM 360 /AUTO C/ACC. 2 LLAV P/TY",
                    cantidad = "1",
                    precio_base = "100",
                    codigo_sunat = "-",
                    codigo_producto = "cc1",
                    codigo_unidad = "ZZ",
                    tipo_igv_codigo = "10"
                },
                new
                {
                    producto = "CLAXON DE TRES CORNETAS PLASTICO ROJO 12V(600/765)",
                    cantidad = "2",
                    precio_base = "200",
                    codigo_sunat = "46171606",
                    codigo_producto = "H-003001981 22-10",
                    codigo_unidad = "NIU",
                    tipo_igv_codigo = "10"
                }
            }
                };

                string url = "https://facturaciondirecta.com/API_SUNAT/post.php";
                string respuestaCompleta = api.Post(url, facturacionData);

                // Extraer solo la parte JSON de la respuesta
                int indexFinJson = respuestaCompleta.IndexOf("</document_content>");
                string jsonPart = indexFinJson != -1 ? respuestaCompleta.Substring(0, indexFinJson) : respuestaCompleta;

                // Intentar deserializar la parte JSON
                dynamic respuestaJson = JsonConvert.DeserializeObject(jsonPart);

                if (respuestaJson != null && respuestaJson.data != null && respuestaJson.data.ruta_pdf != null)
                {
                    string rutaPdf = respuestaJson.data.ruta_pdf.ToString();
                    MessageBox.Show($"La factura ha sido generada exitosamente.\n\nPuede acceder al PDF en la siguiente URL:\n{rutaPdf}", "Factura Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Si no se pudo extraer la ruta del PDF, buscar directamente en la respuesta completa
                    string pdfUrlPattern = @"http://facturaciondirecta\.com/API_SUNAT/files/facturacion_electronica/PDF/\S+\.pdf";
                    Match match = Regex.Match(respuestaCompleta, pdfUrlPattern);

                    if (match.Success)
                    {
                        string rutaPdf = match.Value;
                        MessageBox.Show($"La factura ha sido generada exitosamente.\n\nPuede acceder al PDF en la siguiente URL:\n{rutaPdf}", "Factura Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar la URL del PDF en la respuesta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al emitir factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }

}

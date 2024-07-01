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
    public partial class Ventauniforme : Form
    {
        public Ventauniforme()
        {
            InitializeComponent();
        }

        private void ListarVentas()
        {
            try
            {
                List<entOVenta> lista = logOVenta.Instancia.ListarVentas();
                dataGridView1.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al listar las ventas: {ex.Message}");
            }
        }

        private void btnBuscCliV_Click(object sender, EventArgs e)
        {
            int clienteID;
            if (!int.TryParse(textBox7.Text, out clienteID))
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo ID del Cliente.");
                return;
            }

            try
            {
                entCliente cliente = logCliente.Instancia.BuscarClientePorID(clienteID);
                if (cliente != null)
                {
                    textBox1.Text = cliente.Nombre;
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

        private void btn_buscarPrenVen_Click(object sender, EventArgs e)
        {
            int prendaID;
            if (!int.TryParse(textBox4.Text, out prendaID))
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo ID de la Prenda.");
                return;
            }

            try
            {
                entPrendas prenda = logPrendas.Instancia.BuscarPrendaPorID(prendaID);
                if (prenda != null)
                {
                    textBox10.Text = prenda.Prenda;
                    textBox3.Text = prenda.PrecioVenta.ToString("F2");
                    textBox5.Text = prenda.Stock.ToString();
                    textBox2.Text = prenda.Talla;
                    textBox11.Text = prenda.Colegio; // Asigna Colegio
                    textBox12.Text = prenda.Categoria; // Asigna Categoria
                }
                else
                {
                    MessageBox.Show("Prenda no encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear nueva venta
                entOVenta nuevaVenta = new entOVenta
                {
                    Nombre = textBox1.Text,
                    Prenda = textBox10.Text,
                    Talla = textBox2.Text,
                    Precioventa = decimal.Parse(textBox3.Text),
                    Cantidad = int.Parse(domainUpDown1.Text),
                    MetodoPago = textBox9.Text,
                    Monto = decimal.Parse(textBox6.Text),
                    FRegistroV = DateTime.Now,
                    TipoComprobante = textBox8.Text,
                    Colegio = textBox11.Text,
                    Categoria = textBox12.Text,
                };

                // Registrar la venta
                logOVenta.Instancia.RegistrarVenta(nuevaVenta);

                // Mostrar mensaje de éxito
                MessageBox.Show("Venta registrada exitosamente.");

                // Actualizar lista de ventas
                ListarVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al registrar la venta: {ex.Message}");
            }
        }

        private void domainUpDown1_SelectedItemChanged_1(object sender, EventArgs e)
        {
            try
            {
                int cantidad = int.Parse(domainUpDown1.Text);
                decimal precio = decimal.Parse(textBox3.Text);
                decimal monto = cantidad * precio;
                textBox6.Text = monto.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al calcular el monto: {ex.Message}");
            }
        }
    }
}

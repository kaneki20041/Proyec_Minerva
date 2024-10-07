
using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            ListarVentas();
        }

        private void Ventauniforme_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnEliminar);

            ListarVentas();
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
                    //Nombre = textBox1.Text,
                    //Prenda = textBox10.Text,
                    //Talla = textBox2.Text,
                    //Precioventa = decimal.Parse(textBox3.Text),
                    //Cantidad = int.Parse(domainUpDown1.Text),
                    //MetodoPago = textBox9.Text,
                    //Monto = decimal.Parse(textBox6.Text),
                    //FRegistroV = DateTime.Now,
                    //TipoComprobante = textBox8.Text,
                    //Colegio = textBox11.Text,
                    //Categoria = textBox12.Text,
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


        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Obtener el ID de la venta a eliminar
                int oventaID = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["OventaID"].Value);

                try
                {
                    // Llamar al método para eliminar la venta
                    logOVenta.Instancia.EliminarVenta(oventaID);

                    // Actualizar la lista de ventas
                    ListarVentas();

                    MessageBox.Show("Venta eliminada exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al eliminar la venta: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Suponiendo que tienes una lista de ventas que quieres registrar como detalles
                List<entOVenta> ventas = logOVenta.Instancia.ListarVentas();

                foreach (var venta in ventas)
                {
                    // Crear un nuevo detalle de venta con el mismo OventaID
                    entOVenta detalleVenta = new entOVenta
                    {
                        //OventaID = venta.OventaID,
                        //Nombre = venta.Nombre,
                        //Monto = venta.Monto ?? 0,
                        //Prenda = venta.Prenda,
                        //Precioventa = venta.Precioventa,
                        //MetodoPago = venta.MetodoPago,
                        //Cantidad = venta.Cantidad ?? 0,
                        //FRegistroV = venta.FRegistroV,
                        //Talla = venta.Talla,
                        //Colegio = venta.Colegio,
                        //Categoria = venta.Categoria
                    };

                    logOVenta.Instancia.RegistrarDetalleVenta(detalleVenta);

                    // Descontar la cantidad del stock de la prenda
                    //logPrendas.Instancia.ActualizarStock(venta.Prenda, venta.Cantidad ?? 0);
                }

                // Limpiar el DataGridView después de registrar los detalles de venta
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                MessageBox.Show("Detalles de venta registrados exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al registrar los detalles de la venta: {ex.Message}");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
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
    }
}

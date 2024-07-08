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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Minerva
{
    public partial class CompraPrenda : Form
    {
        public CompraPrenda()
        {
            InitializeComponent();
        }

        private void BuscProveedor_Click(object sender, EventArgs e)
        {
            int proveedorID;
            if (!int.TryParse(textBox5.Text, out proveedorID))
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo ID del Proveedor.");
                return;
            }

            try
            {
                entProveedor proveedor = logProveedor.Instancia.BuscarProveedorPorID(proveedorID);
                if (proveedor != null)
                {
                    textBox6.Text = proveedor.RUC.ToString();
                    textBox7.Text = proveedor.RazonSocial;
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

        private void BuscarMetPago_Click(object sender, EventArgs e)
        {
            try
            {
                int metPagoID = int.Parse(textBox3.Text.Trim());
                EntMetPago metodoPago = logMetPago.Instancia.BuscarMetodoPagoPorID(metPagoID);

                if (metodoPago != null)
                {
                    textBox9.Text = metodoPago.metodopago;
                }
                else
                {
                    MessageBox.Show("Método de pago no encontrado.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_buscarPrenVen_Click(object sender, EventArgs e)
        {
            int prendaID;
            if (!int.TryParse(textBox15.Text, out prendaID))
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo ID de la Prenda.");
                return;
            }

            try
            {
                entPrendas prenda = logPrendas.Instancia.BuscarPrendaPorID(prendaID);
                if (prenda != null)
                {
                    textBox14.Text = prenda.Prenda;
                    textBox12.Text = prenda.PrecioCompra.ToString("F2");
                    textBox11.Text = prenda.Stock.ToString();
                    textBox13.Text = prenda.Talla;
                    textBox1.Text = prenda.Categoria;
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

        private void AgreCompra_Click(object sender, EventArgs e)
        {
            //entCompra dCom = new entCompra();
            //entPrendas Pren = new entPrendas();

            //if ((this.textBox5.Text.Trim() != "") && (textBox15.Text.Trim() != "") && (txtCantidad.Text.Trim() != ""))
            //{
            //    if ((Convert.ToInt32(txtCantidad.Text) > 0) && (Convert.ToInt32(txtCantidad.Text) <= Convert.ToInt32(textBox11.Text)))
            //    {
            //        if (confilas == 0)
            //        {
            
            //            TablaCompra.Rows.Add(textBox15.Text, textBox14, txtCantidad.Text, textBox12.Text);
            //            decimal subTotal = Convert.ToDecimal(TablaCompra.Rows[confilas].Cells[2].Value) * Convert.ToDecimal(TablaCompra.Rows[confilas].Cells[3].Value);
            //            TablaCompra.Rows[confilas].Cells[4].Value = subTotal;
            //            confilas++;
            //        }
            //        else
            //        {
            //            TablaDetallePedido.Rows.Add(txtProductoid.Text, txtDescProducto, txtCantidad.Text, txtPrecio.Text);
            //            decimal subTotal = Convert.ToDecimal(TablaDetallePedido.Rows[confilas].Cells[2].Value) * Convert.ToDecimal(TablaDetallePedido.Rows[confilas].Cells[3].Value);
            //            TablaDetallePedido.Rows[confilas].Cells[4].Value = subTotal;
            //            confilas++;
            //        }

            //        //Limpiar();
            //    }
            //    Total = 0;
            //    foreach (DataGridViewRow Fila in TablaDetallePedido.Rows)
            //    {

            //        Total += Convert.ToDecimal(Fila.Cells[4].Value);
            //    }
            //    txtTotal.Text = Total.ToString();
        }
    }
}


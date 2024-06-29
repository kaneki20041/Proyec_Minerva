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
    }
}

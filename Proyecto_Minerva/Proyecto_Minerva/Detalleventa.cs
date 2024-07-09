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
    public partial class Detalleventa : Form
    {
        public Detalleventa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int oventaID;
            if (!int.TryParse(textBox1.Text, out oventaID))
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo ID de la Venta.");
                return;
            }

            try
            {
                List<entDetalleVenta> detalles = logDetalleVenta.Instancia.ListarDetalleVenta(oventaID);
                if (detalles.Count > 0)
                {
                    dgvDetalleventa.DataSource = detalles;
                }
                else
                {
                    MessageBox.Show("No se encontraron detalles para la venta ingresada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al listar los detalles de la venta: {ex.Message}");
            }
            this.dgvDetalleventa.Columns["DetalleVentaID"].Visible = false;
        }
    }
}

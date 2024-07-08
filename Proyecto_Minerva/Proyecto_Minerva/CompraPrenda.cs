using CapaDatos;
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
        entCompra Compra = new entCompra();
        entDetCom dCom = new entDetCom();
        int proveedorID;
        public CompraPrenda()
        {
            InitializeComponent();
        }

        private void BuscProveedor_Click(object sender, EventArgs e)
        {

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
                    textBox4.Text = prenda.Colegio;
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
        public static int confilas = 0;
        public static decimal Total = 0;
        private void AgreCompra_Click(object sender, EventArgs e)
        {
            entCompra dCom = new entCompra();
            entPrendas Pren = new entPrendas();

            if ((this.textBox5.Text.Trim() != "") && (textBox15.Text.Trim() != "") && (txtCantidad.Text.Trim() != ""))
            {
                if ((Convert.ToInt32(txtCantidad.Text) > 0) && (Convert.ToInt32(txtCantidad.Text) <= Convert.ToInt32(textBox11.Text)))
                {
                    if (confilas == 0)
                    {

                        tablaCompras.Rows.Add(textBox15.Text, textBox14.Text, textBox4.Text, textBox1.Text, textBox13.Text, txtCantidad.Text, textBox12.Text);
                        decimal subTotal = Convert.ToDecimal(tablaCompras.Rows[confilas].Cells[5].Value) * Convert.ToDecimal(tablaCompras.Rows[confilas].Cells[6].Value);
                        tablaCompras.Rows[confilas].Cells[7].Value = subTotal;
                        confilas++;
                    }
                    else
                    {
                        tablaCompras.Rows.Add(textBox15.Text, textBox14.Text, textBox4.Text, textBox1.Text, textBox13.Text, txtCantidad.Text, textBox12.Text);
                        decimal subTotal = Convert.ToDecimal(tablaCompras.Rows[confilas].Cells[5].Value) * Convert.ToDecimal(tablaCompras.Rows[confilas].Cells[6].Value);
                        tablaCompras.Rows[confilas].Cells[7].Value = subTotal;
                        confilas++;
                    }

                    //Limpiar();
                }
                Total = 0;
                foreach (DataGridViewRow Fila in tablaCompras.Rows)
                {

                    Total += Convert.ToDecimal(Fila.Cells[7].Value);
                }
                textBox2.Text = Total.ToString();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (confilas > 0)
            {
                Total = Total - Convert.ToDecimal(tablaCompras.Rows[tablaCompras.CurrentRow.Index].Cells[7].Value);
                //txtTotal.Text = "S/." + Total.ToString();
                textBox2.Text = Total.ToString();
                tablaCompras.Rows.RemoveAt(tablaCompras.CurrentRow.Index);
                confilas--;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            int idCom;
            try
            {
                entCompra Com = new entCompra();
                entProveedor p = new entProveedor();
                EntMetPago m = new EntMetPago();

                Com.fechCompra = Convert.ToDateTime(dateTimePicker1.Value);
                Com.Monto = Convert.ToDouble(textBox2.Text);

                p.ID = int.Parse(textBox5.Text);
                m.MetPagoid = int.Parse(textBox3.Text);

                Com.ID = p;
                Com.ID.ID = p.ID;
                Com.Metpagoid = m;
                Com.Metpagoid.MetPagoid = m.MetPagoid;


                idCom = logCompras.Instancia.InsertarCompra(Com);

                GrabarDetalle(idCom);

                Close();
                ActualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
                throw ex;
            }
        }
        private void GrabarDetalle(int cod)
        {
            foreach (DataGridViewRow Fila in tablaCompras.Rows)
            {
                entDetCom dCom = new entDetCom();
                dCom.idCompra = cod;
                entPrendas pren = new entPrendas();

                try
                {
                    if (Fila.Cells[0].Value != null && int.TryParse(Fila.Cells[0].Value.ToString(), out int prendaID))
                    {
                        pren.PrendaID = prendaID;
                    }
                    else
                    {
                        throw new FormatException("El ID de la prenda no es válido o es nulo.");
                    }

                    if (Fila.Cells[2].Value != null && int.TryParse(Fila.Cells[2].Value.ToString(), out int cantPren))
                    {
                        dCom.cantPren = cantPren;
                    }
                    else
                    {
                        throw new FormatException("La cantidad de la prenda no es válida o es nula.");
                    }

                    if (Fila.Cells[3].Value != null && decimal.TryParse(Fila.Cells[3].Value.ToString(), out decimal precPren))
                    {
                        dCom.precPren = precPren;
                    }
                    else
                    {
                        throw new FormatException("El precio de la prenda no es válido o es nulo.");
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error en el formato de datos: " + ex.Message);
                    return;
                }

                dCom.PrendaID = pren;

                try
                {
                    logCompras.Instancia.InsertarDetCompra(dCom);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar detalle de compra: " + ex.Message);
                }
            }
        }
        private void ActualizarGrid()
        {

            //MessageBox.Show("formulario de datos se cierra....de si encuentra instancia");
            DetalleCompra formGridPedido = Application.OpenForms.OfType<DetalleCompra>().FirstOrDefault();

            if (formGridPedido != null)  //Si encuentra una instancia abierta
            {
                //MessageBox.Show("Instancia abierta!!! instancia");
                formGridPedido.ListarCompras();
                formGridPedido.Refresh();
            }
        }


    }
}


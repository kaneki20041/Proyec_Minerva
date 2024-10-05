using CapaDatos;
using CapaEntidad;
using CapaLogica;

namespace Proyecto_Minerva
{
    public partial class CompraPrenda : Form
    {
        entCompra Compra = new entCompra();
        entDetCompra dCom = new entDetCompra();
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
                    textBox4.Text = prenda.Colegio;
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

                        tablaCompras.Rows.Add(textBox15.Text, textBox14.Text, textBox1.Text, textBox4.Text, textBox13.Text, txtCantidad.Text, textBox12.Text);
                        decimal subTotal = Convert.ToDecimal(tablaCompras.Rows[confilas].Cells[5].Value) * Convert.ToDecimal(tablaCompras.Rows[confilas].Cells[6].Value);
                        tablaCompras.Rows[confilas].Cells[7].Value = subTotal;
                        confilas++;
                    }
                    else
                    {
                        tablaCompras.Rows.Add(textBox15.Text, textBox14.Text, textBox1.Text, textBox4.Text, textBox13.Text, txtCantidad.Text, textBox12.Text);
                        decimal subTotal = Convert.ToDecimal(tablaCompras.Rows[confilas].Cells[5].Value) * Convert.ToDecimal(tablaCompras.Rows[confilas].Cells[6].Value);
                        tablaCompras.Rows[confilas].Cells[7].Value = subTotal;
                        confilas++;
                    }


                }
                Total = 0;
                foreach (DataGridViewRow Fila in tablaCompras.Rows)
                {

                    Total += Convert.ToInt32(Fila.Cells[7].Value);
                }
                textBox2.Text = Total.ToString();

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (confilas > 0)
            {
                Total -= Convert.ToDecimal(tablaCompras.Rows[tablaCompras.CurrentRow.Index].Cells[7].Value);
                //txtTotal.Text = "S/." + Total.ToString();
                textBox2.Text = Total.ToString();
                tablaCompras.Rows.RemoveAt(tablaCompras.CurrentRow.Index);
                confilas--;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idCom;
            try
            {
                entCompra Com = new entCompra();
                entProveedor p = new entProveedor();
                EntMetPago met = new EntMetPago();
                entUsuario u = new entUsuario();

                // Asignar valores
                Com.fechCompra = Convert.ToDateTime(dateTimePicker1.Value);
                Com.Monto = Convert.ToDecimal(textBox2.Text);

                // Asignar directamente los IDs
                p.ID = int.Parse(textBox5.Text); // Asignar ID del proveedor
                p.RazonSocial = textBox7.Text;
                met.MetPagoid = int.Parse(textBox3.Text); // Asignar ID del método de pago
                u.UsuarioID = int.Parse(txtUsuarioID.Text); // Asignar el ID del usuario

                Com.UsuarioID = u; // Si necesitas el objeto completo
                Com.Metpagoid= met;
                Com.ID = p;
                Com.RazonSocial = p;

                // Llamar al método de inserción
                idCom = logCompra.Instancia.InsertarCompra(Com);

                // Graba el detalle si es necesario
                GrabarDetalle(idCom);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
                throw;
            }
        }


        private void GrabarDetalle(int cod)
        {

            foreach (DataGridViewRow Fila in tablaCompras.Rows)
            {
                var tes = Fila.Cells[0].Value;
                dCom.idCompra = cod;
                entPrendas prod = new entPrendas();
                entPrendas pren = new entPrendas();


                if (Fila.Cells[0].Value != null)
                {
                    prod.PrendaID = Convert.ToInt32(Fila.Cells[0].Value.ToString());
                    pren.Prenda = Fila.Cells[1].Value.ToString(); 
                    dCom.PrendaID = prod;
                    dCom.Prenda = pren;
                    dCom.PrendaID.PrendaID = prod.PrendaID;
                    dCom.Prenda.Prenda = pren.Prenda;

                    dCom.cantPrenda = Convert.ToInt32(Fila.Cells[5].Value.ToString());
                    dCom.precPrenda = Convert.ToDecimal(Fila.Cells[6].Value.ToString());


                    logCompra.Instancia.InsertarDetCompra(dCom);
                }


            }


        }
        public void Limpiar()
        {
            this.tablaCompras.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }


}







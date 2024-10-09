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
            dCom = new entDetCompra();
        }

        private void BuscProveedor_Click(object sender, EventArgs e)
        {
            string ruc = txtRUC.Text.Trim();
            string nombre = txtNombreRUC.Text.Trim();

            // Verifica si ambos campos están vacíos
            if (string.IsNullOrWhiteSpace(ruc) && string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, ingresa un RUC o un nombre válido.");
                return;
            }

            try
            {
                entProveedor proveedor = null;

                // Busca por RUC si se ingresó
                if (!string.IsNullOrWhiteSpace(ruc))
                {
                    proveedor = logProveedor.Instancia.BuscarProveedorPorRUC(ruc);
                }
                // Busca por nombre si se ingresó
                else if (!string.IsNullOrWhiteSpace(nombre))
                {
                    proveedor = logProveedor.Instancia.BuscarProveedorPorNombre(nombre);
                }

                // Verifica si se encontró al proveedor
                if (proveedor != null)
                {
                    txtNombreRUC.Text = proveedor.NomPro.ToString();
                    txtRUC.Text = proveedor.RUC.ToString();
                    txtRazonRUC.Text = proveedor.RazonSocial;
                }
                else
                {
                    MessageBox.Show("Proveedor no encontrado.");
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
            string descripcion = textBox14.Text.Trim();
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo ID de la Prenda.");
                return;
            }

            try
            {
                entPrendas prenda = logPrendas.Instancia.BuscarPrendaPorDescripcion(descripcion);
                if (prenda != null)
                {
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

        public int confilas = 0;
        public decimal Total = 0;

        private void AgreCompra_Click(object sender, EventArgs e)
        {
            entCompra dCom = new entCompra();
            entPrendas Pren = new entPrendas();

            if ((this.txtRUC.Text.Trim() != "") && (txtCantidad.Text.Trim() != ""))
            {
                if ((Convert.ToInt32(txtCantidad.Text) > 0) && (Convert.ToInt32(txtCantidad.Text) <= Convert.ToInt32(textBox11.Text)))
                {
                    if (confilas == 0)
                    {

                        tablaCompras.Rows.Add(textBox14.Text, textBox1.Text, textBox4.Text, textBox13.Text, txtCantidad.Text, textBox12.Text);
                        decimal subTotal = Convert.ToDecimal(tablaCompras.Rows[confilas].Cells[4].Value) * Convert.ToDecimal(tablaCompras.Rows[confilas].Cells[5].Value);
                        tablaCompras.Rows[confilas].Cells[6].Value = subTotal;
                        confilas++;
                    }
                    else
                    {
                        tablaCompras.Rows.Add(textBox14.Text, textBox1.Text, textBox4.Text, textBox13.Text, txtCantidad.Text, textBox12.Text);
                        decimal subTotal = Convert.ToDecimal(tablaCompras.Rows[confilas].Cells[4].Value) * Convert.ToDecimal(tablaCompras.Rows[confilas].Cells[5].Value);
                        tablaCompras.Rows[confilas].Cells[6].Value = subTotal;
                        confilas++;
                    }
                }
                Total = 0;
                foreach (DataGridViewRow Fila in tablaCompras.Rows)
                {

                    Total += Convert.ToInt32(Fila.Cells[6].Value);
                }
                textBox2.Text = Total.ToString();

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (confilas > 0)
            {
                Total -= Convert.ToDecimal(tablaCompras.Rows[tablaCompras.CurrentRow.Index].Cells[6].Value);
                //txtTotal.Text = "S/." + Total.ToString();
                textBox2.Text = Total.ToString();
                tablaCompras.Rows.RemoveAt(tablaCompras.CurrentRow.Index);
                confilas--;
            }
        }//quitar

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos requeridos antes de proceder
                if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(txtRUC.Text) ||
                    string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(txtUsuarioID.Text))
                {
                    MessageBox.Show("Todos los campos son requeridos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que haya detalles en la tabla
                if (tablaCompras.Rows.Count <= 1) // Considerando la fila nueva
                {
                    MessageBox.Show("Debe agregar al menos un detalle de compra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear y poblar el objeto de compra
                entCompra Com = new entCompra();
                entProveedor p = new entProveedor();
                EntMetPago met = new EntMetPago();
                entUsuario u = new entUsuario();

                try
                {
                    Com.fechCompra = dateTimePicker1.Value;
                    Com.Monto = Convert.ToDecimal(textBox2.Text);
                    p.RUC = txtRUC.Text;
                    p.RazonSocial = txtRazonRUC.Text;
                    met.MetPagoid = int.Parse(textBox3.Text);
                    u.UsuarioID = int.Parse(txtUsuarioID.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, verifique que los valores numéricos sean correctos",
                                  "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Com.UsuarioID = u;
                Com.Metpagoid = met;
                Com.ID = p;
                Com.RazonSocial = p;

                // Iniciar la transacción de grabación
                int idCom = logCompra.Instancia.InsertarCompra(Com);

                if (idCom <= 0)
                {
                    MessageBox.Show("Error al registrar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Si la compra se registró correctamente, grabar los detalles
                if (GrabarDetalle(idCom))
                {
                    MessageBox.Show("Compra registrada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Si hubo algún error en los detalles, informar al usuario
                    MessageBox.Show("La compra se registró pero hubo errores en algunos detalles. " +
                                  "Por favor, revise los mensajes de error mostrados.",
                                  "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool GrabarDetalle(int cod)
        {
            bool todoCorrecto = true;
            List<string> errores = new List<string>();

            try
            {
                foreach (DataGridViewRow fila in tablaCompras.Rows)
                {
                    if (fila.IsNewRow || fila.Cells[0].Value == null)
                        continue;

                    try
                    {
                        // Crear nuevo objeto para cada detalle
                        entDetCompra detalleCompra = new entDetCompra();
                        detalleCompra.idCompra = cod;

                        // Validar y obtener la descripción
                        if (string.IsNullOrWhiteSpace(fila.Cells[0].Value?.ToString()))
                        {
                            errores.Add($"Fila {fila.Index + 1}: La descripción está vacía");
                            todoCorrecto = false;
                            continue;
                        }

                        entPrendas pren = new entPrendas();
                        pren.Descripcion = fila.Cells[0].Value.ToString().Trim();
                        detalleCompra.Prenda = pren;

                        // Validar y obtener la cantidad y precio
                        if (!int.TryParse(fila.Cells[4].Value?.ToString(), out int cantidad))
                        {
                            errores.Add($"Fila {fila.Index + 1}: Cantidad inválida");
                            todoCorrecto = false;
                            continue;
                        }

                        if (!decimal.TryParse(fila.Cells[5].Value?.ToString(), out decimal precio))
                        {
                            errores.Add($"Fila {fila.Index + 1}: Precio inválido");
                            todoCorrecto = false;
                            continue;
                        }

                        if (cantidad <= 0 || precio <= 0)
                        {
                            errores.Add($"Fila {fila.Index + 1}: Cantidad y precio deben ser mayores a 0");
                            todoCorrecto = false;
                            continue;
                        }

                        detalleCompra.cantPrenda = cantidad;
                        detalleCompra.precPrenda = precio;

                        // Intentar insertar el detalle
                        try
                        {
                            logCompra.Instancia.InsertarDetCompra(detalleCompra);
                        }
                        catch (Exception ex)
                        {
                            errores.Add($"Fila {fila.Index + 1}: Error al grabar el detalle - {ex.Message}");
                            todoCorrecto = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        errores.Add($"Fila {fila.Index + 1}: {ex.Message}");
                        todoCorrecto = false;
                    }
                }

                if (errores.Count > 0)
                {
                    string mensajeError = "Se encontraron los siguientes errores:\n\n" +
                                        string.Join("\n", errores);
                    MessageBox.Show(mensajeError, "Errores en detalles", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return todoCorrecto;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general al grabar detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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







using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormPago : Form
    {
        private readonly MercadoPagoService _mpService;
        private decimal _amount;
        private int _idVenta;
        private string _customerEmail;
        /*
        public FormPago(decimal amount, int idVenta, string customerEmail)
        {
            InitializeComponents();
            _mpService = new MercadoPagoService();
            _amount = amount;
            _idVenta = idVenta;
            _customerEmail = customerEmail;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Panel principal
            this.Size = new System.Drawing.Size(600, 400);
            this.Text = "Pago con MercadoPago";

            // Tabs para métodos de pago
            TabControl tabControl = new TabControl
            {
                Dock = DockStyle.Fill
            };

            // Tab de Tarjeta
            TabPage cardTab = new TabPage("Pago con Tarjeta");
            InitializeCardTab(cardTab);

            // Tab de Yape
            TabPage yapeTab = new TabPage("Pago con Yape");
            InitializeYapeTab(yapeTab);

            tabControl.TabPages.Add(cardTab);
            tabControl.TabPages.Add(yapeTab);

            this.Controls.Add(tabControl);
        }

        private void InitializeCardTab(TabPage tab)
        {
            // Campos para tarjeta
            TextBox txtCardNumber = new TextBox
            {
                Location = new System.Drawing.Point(120, 30),
                Size = new System.Drawing.Size(200, 20),
                PlaceholderText = "Número de tarjeta"
            };

            TextBox txtExpiry = new TextBox
            {
                Location = new System.Drawing.Point(120, 70),
                Size = new System.Drawing.Size(100, 20),
                PlaceholderText = "MM/YY"
            };

            TextBox txtCVV = new TextBox
            {
                Location = new System.Drawing.Point(120, 110),
                Size = new System.Drawing.Size(60, 20),
                PlaceholderText = "CVV",
                UseSystemPasswordChar = true
            };

            ComboBox cboInstallments = new ComboBox
            {
                Location = new System.Drawing.Point(120, 150),
                Size = new System.Drawing.Size(121, 21)
            };
            cboInstallments.Items.AddRange(new object[] { 1, 3, 6, 12 });
            cboInstallments.SelectedIndex = 0;

            Button btnPayCard = new Button
            {
                Text = "Pagar con Tarjeta",
                Location = new System.Drawing.Point(120, 190),
                Size = new System.Drawing.Size(150, 30)
            };
            btnPayCard.Click += async (s, e) => await ProcessCardPaymentClick(txtCardNumber.Text, txtExpiry.Text, txtCVV.Text, (int)cboInstallments.SelectedItem);

            tab.Controls.AddRange(new Control[] {
                txtCardNumber, txtExpiry, txtCVV,
                cboInstallments, btnPayCard
            });
        }

        private void InitializeYapeTab(TabPage tab)
        {
            PictureBox qrBox = new PictureBox
            {
                Size = new System.Drawing.Size(200, 200),
                Location = new System.Drawing.Point(120, 30),
                BorderStyle = BorderStyle.FixedSingle
            };

            Button btnPayYape = new Button
            {
                Text = "Pagar con Yape",
                Location = new System.Drawing.Point(120, 250),
                Size = new System.Drawing.Size(150, 30)
            };
            btnPayYape.Click += async (s, e) => await ProcessYapePaymentClick();

            Label lblInstructions = new Label
            {
                Text = "Escanea el código QR con tu app de Yape",
                Location = new System.Drawing.Point(120, 240),
                AutoSize = true
            };

            tab.Controls.AddRange(new Control[] {
                qrBox, btnPayYape, lblInstructions
            });
        }

        /*private async Task ProcessCardPaymentClick(string cardNumber, string expiry, string cvv, int installments)
        {
            try
            {
                // En un caso real, aquí procesarías el cardToken con el SDK de MercadoPago
                string cardToken = "dummy_card_token"; // Esto debe venir del SDK de MP

                var payment = await _mpService.ProcessCardPayment(_amount, cardToken, installments, _customerEmail);

                if (payment.Status == "approved")
                {
                    MessageBox.Show("Pago aprobado!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Actualizar el estado de la venta en tu base de datos
                    UpdateVentaStatus(_idVenta, payment.Id.ToString());
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"El pago no fue aprobado. Estado: {payment.Status}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ProcessYapePaymentClick()
        {
            try
            {
                var payment = await _mpService.ProcessYapePayment(_amount, _customerEmail);

                if (payment.Status == "pending")
                {
                    // Mostrar QR o instrucciones de Yape
                    MessageBox.Show("Por favor, completa el pago en tu app de Yape", "Yape", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Aquí deberías implementar un mecanismo para verificar cuando el pago se complete
                    // Podrías usar polling o webhooks según tu implementación
                }
                else if (payment.Status == "approved")
                {
                    MessageBox.Show("Pago aprobado!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateVentaStatus(_idVenta, payment.Id.ToString());
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"El pago no fue aprobado. Estado: {payment.Status}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */
        private void UpdateVentaStatus(int idVenta, string paymentId)
        {
            // Aquí deberías implementar la actualización del estado de la venta en tu base de datos
            // Por ejemplo:
            // logOVenta.Instancia.ActualizarEstadoPago(idVenta, "PAGADO", paymentId);
        }
    }
}

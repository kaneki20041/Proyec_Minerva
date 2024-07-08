namespace Proyecto_Minerva
{
    partial class Detalleventa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtidventa = new TextBox();
            txtComprobante = new TextBox();
            txtFecha = new TextBox();
            txtCliente = new TextBox();
            dgvDetalleventa = new DataGridView();
            groupBox1 = new GroupBox();
            btnBuscVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleventa).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(262, 18);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 0;
            label1.Text = "DETALLE VENTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 85);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "Comprobante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 29);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "ID Venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 114);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 61);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "Fecha";
            // 
            // txtidventa
            // 
            txtidventa.Location = new Point(75, 26);
            txtidventa.Name = "txtidventa";
            txtidventa.Size = new Size(62, 23);
            txtidventa.TabIndex = 6;
            // 
            // txtComprobante
            // 
            txtComprobante.Location = new Point(96, 82);
            txtComprobante.Name = "txtComprobante";
            txtComprobante.Size = new Size(100, 23);
            txtComprobante.TabIndex = 8;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(96, 53);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(121, 23);
            txtFecha.TabIndex = 9;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(96, 111);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(67, 23);
            txtCliente.TabIndex = 11;
            // 
            // dgvDetalleventa
            // 
            dgvDetalleventa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleventa.Location = new Point(271, 60);
            dgvDetalleventa.Name = "dgvDetalleventa";
            dgvDetalleventa.RowTemplate.Height = 25;
            dgvDetalleventa.Size = new Size(415, 233);
            dgvDetalleventa.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscVenta);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(txtFecha);
            groupBox1.Controls.Add(txtComprobante);
            groupBox1.Controls.Add(txtidventa);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 149);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info general venta";
            // 
            // btnBuscVenta
            // 
            btnBuscVenta.Location = new Point(143, 25);
            btnBuscVenta.Name = "btnBuscVenta";
            btnBuscVenta.Size = new Size(75, 23);
            btnBuscVenta.TabIndex = 12;
            btnBuscVenta.Text = "Buscar";
            btnBuscVenta.UseVisualStyleBackColor = true;
            // 
            // SalidMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 336);
            Controls.Add(groupBox1);
            Controls.Add(dgvDetalleventa);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalidMaterial";
            Text = "SalidMaterial";
            ((System.ComponentModel.ISupportInitialize)dgvDetalleventa).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtidventa;
        private TextBox txtComprobante;
        private TextBox txtFecha;
        private TextBox txtCliente;
        private DataGridView dgvDetalleventa;
        private GroupBox groupBox1;
        private Button btnBuscVenta;
    }
}
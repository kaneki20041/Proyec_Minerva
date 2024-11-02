namespace Proyecto_Minerva
{
    partial class DetalleCompra
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
            detallito = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtEmail = new TextBox();
            label13 = new Label();
            btnBuscarDoc = new FontAwesome.Sharp.IconButton();
            txtDireccion = new TextBox();
            label5 = new Label();
            label11 = new Label();
            label6 = new Label();
            txtRUC = new TextBox();
            label10 = new Label();
            txtSerie = new TextBox();
            txtSubTotal = new TextBox();
            txtIGV = new TextBox();
            txtTotalGravada = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            btnEmitirComprobante = new Button();
            gbIDVenta = new GroupBox();
            comboMetodoPago = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)detallito).BeginInit();
            groupBox1.SuspendLayout();
            gbIDVenta.SuspendLayout();
            SuspendLayout();
            // 
            // detallito
            // 
            detallito.BackgroundColor = Color.MintCream;
            detallito.BorderStyle = BorderStyle.None;
            detallito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detallito.Location = new Point(3, 224);
            detallito.Name = "detallito";
            detallito.RowHeadersWidth = 51;
            detallito.RowTemplate.Height = 25;
            detallito.Size = new Size(685, 325);
            detallito.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(706, 319);
            label1.Name = "label1";
            label1.Size = new Size(30, 17);
            label1.TabIndex = 56;
            label1.Text = "IGV";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(btnBuscarDoc);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtRUC);
            groupBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(337, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 177);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFO PROVEEDOR";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(98, 143);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(355, 22);
            txtEmail.TabIndex = 61;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(35, 146);
            label13.Name = "label13";
            label13.Size = new Size(49, 17);
            label13.TabIndex = 60;
            label13.Text = "Correo";
            // 
            // btnBuscarDoc
            // 
            btnBuscarDoc.BackColor = Color.PowderBlue;
            btnBuscarDoc.Cursor = Cursors.Hand;
            btnBuscarDoc.FlatStyle = FlatStyle.Popup;
            btnBuscarDoc.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarDoc.IconColor = Color.Black;
            btnBuscarDoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarDoc.IconSize = 15;
            btnBuscarDoc.Location = new Point(246, 38);
            btnBuscarDoc.Name = "btnBuscarDoc";
            btnBuscarDoc.Size = new Size(34, 23);
            btnBuscarDoc.TabIndex = 57;
            btnBuscarDoc.UseVisualStyleBackColor = false;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(98, 105);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(355, 22);
            txtDireccion.TabIndex = 44;
            // 
            // txtRazonSocial
            // 

            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 70);
            label5.Name = "label5";
            label5.Size = new Size(83, 17);
            label5.TabIndex = 42;
            label5.Text = "Razon Social";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 41);
            label11.Name = "label11";
            label11.Size = new Size(32, 17);
            label11.TabIndex = 0;
            label11.Text = "RUC";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 107);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 32;
            label6.Text = "Direccion";
            // 
            // txtRUC
            // 
            txtRUC.Location = new Point(97, 39);
            txtRUC.Name = "txtRUC";
            txtRUC.Size = new Size(131, 22);
            txtRUC.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(39, 15);
            label10.Name = "label10";
            label10.Size = new Size(43, 16);
            label10.TabIndex = 54;
            label10.Text = "Serie:";
            // 
            // txtSerie
            // 
            txtSerie.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSerie.Location = new Point(88, 11);
            txtSerie.Name = "txtSerie";
            txtSerie.ReadOnly = true;
            txtSerie.Size = new Size(100, 24);
            txtSerie.TabIndex = 53;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubTotal.Location = new Point(706, 395);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(124, 22);
            txtSubTotal.TabIndex = 52;
            // 
            // txtIGV
            // 
            txtIGV.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtIGV.Location = new Point(706, 339);
            txtIGV.Name = "txtIGV";
            txtIGV.Size = new Size(124, 22);
            txtIGV.TabIndex = 48;
            // 
            // txtTotalGravada
            // 
            txtTotalGravada.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalGravada.Location = new Point(706, 286);
            txtTotalGravada.Name = "txtTotalGravada";
            txtTotalGravada.Size = new Size(124, 22);
            txtTotalGravada.TabIndex = 50;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(706, 377);
            label9.Name = "label9";
            label9.Size = new Size(59, 17);
            label9.TabIndex = 51;
            label9.Text = "SubTotal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(706, 338);
            label8.Name = "label8";
            label8.Size = new Size(30, 17);
            label8.TabIndex = 49;
            label8.Text = "IGV";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(706, 268);
            label7.Name = "label7";
            label7.Size = new Size(94, 17);
            label7.TabIndex = 47;
            label7.Text = "Total Gravada";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(731, 12);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(99, 23);
            dateTimePicker2.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(595, 15);
            label3.Name = "label3";
            label3.Size = new Size(129, 17);
            label3.TabIndex = 45;
            label3.Text = "Fecha - Hora Emision";
            // 
            // btnEmitirComprobante
            // 
            btnEmitirComprobante.BackColor = Color.PowderBlue;
            btnEmitirComprobante.FlatAppearance.BorderSize = 0;
            btnEmitirComprobante.FlatStyle = FlatStyle.Flat;
            btnEmitirComprobante.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmitirComprobante.Location = new Point(706, 438);
            btnEmitirComprobante.Margin = new Padding(3, 2, 3, 2);
            btnEmitirComprobante.Name = "btnEmitirComprobante";
            btnEmitirComprobante.Size = new Size(124, 58);
            btnEmitirComprobante.TabIndex = 43;
            btnEmitirComprobante.Text = "EMITIR COMPROBANTE";
            btnEmitirComprobante.UseVisualStyleBackColor = false;
            // 
            // gbIDVenta
            // 
            gbIDVenta.Controls.Add(textBox1);
            gbIDVenta.Controls.Add(comboMetodoPago);
            gbIDVenta.Controls.Add(label4);
            gbIDVenta.Controls.Add(label2);
            gbIDVenta.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbIDVenta.Location = new Point(23, 60);
            gbIDVenta.Name = "gbIDVenta";
            gbIDVenta.Size = new Size(308, 144);
            gbIDVenta.TabIndex = 44;
            gbIDVenta.TabStop = false;
            gbIDVenta.Text = "INFORMACION PAGO";
            // 
            // comboMetodoPago
            // 
            comboMetodoPago.FormattingEnabled = true;
            comboMetodoPago.Location = new Point(146, 86);
            comboMetodoPago.Name = "comboMetodoPago";
            comboMetodoPago.Size = new Size(131, 25);
            comboMetodoPago.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(53, 89);
            label4.Name = "label4";
            label4.Size = new Size(90, 17);
            label4.TabIndex = 30;
            label4.Text = "Metodo Pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 50);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 23;
            label2.Text = "Tipo Comprobante";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 22);
            textBox1.TabIndex = 42;
            textBox1.Text = "FACTURA";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // DetalleCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(851, 573);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Controls.Add(txtSerie);
            Controls.Add(txtSubTotal);
            Controls.Add(txtIGV);
            Controls.Add(txtTotalGravada);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dateTimePicker2);
            Controls.Add(label3);
            Controls.Add(btnEmitirComprobante);
            Controls.Add(gbIDVenta);
            Controls.Add(detallito);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetalleCompra";
            Text = "IngMaterial";
            ((System.ComponentModel.ISupportInitialize)detallito).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbIDVenta.ResumeLayout(false);
            gbIDVenta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView detallito;
        private DataGridViewTextBoxColumn Telefono;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private Label label13;
        private Label label12;
        private TextBox txtTipoDoc;
        private FontAwesome.Sharp.IconButton btnBuscarDoc;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label label5;
        private Label label11;
        private Label label6;
        private TextBox txtRUC;
        private Label label10;
        private TextBox txtSerie;
        private TextBox txtSubTotal;
        private TextBox txtIGV;
        private TextBox txtTotalGravada;
        private Label label9;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Button btnEmitirComprobante;
        private GroupBox gbIDVenta;
        private ComboBox comboMetodoPago;
        private ComboBox comboTipoComprobante;
        private Label label4;
        private Label label2;
        private TextBox textBox1;
    }
}
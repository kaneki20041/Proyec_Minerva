namespace Proyecto_Minerva
{
    partial class Carrito
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
            dgvDetalleventa = new DataGridView();
            gbIDVenta = new GroupBox();
            comboMetodoPago = new ComboBox();
            comboTipoComprobante = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            txtDocumento = new TextBox();
            label6 = new Label();
            btnEmitirComprobante = new Button();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtIGV = new TextBox();
            txtTotalGravada = new TextBox();
            txtSubTotal = new TextBox();
            txtSerie = new TextBox();
            label10 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            txtEmail = new TextBox();
            label13 = new Label();
            label12 = new Label();
            txtTipoDoc = new TextBox();
            btnBuscarDoc = new FontAwesome.Sharp.IconButton();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            label11 = new Label();
            label1 = new Label();
            btnPagar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleventa).BeginInit();
            gbIDVenta.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDetalleventa
            // 
            dgvDetalleventa.BackgroundColor = Color.MintCream;
            dgvDetalleventa.BorderStyle = BorderStyle.None;
            dgvDetalleventa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleventa.Location = new Point(10, 253);
            dgvDetalleventa.Name = "dgvDetalleventa";
            dgvDetalleventa.RowHeadersWidth = 51;
            dgvDetalleventa.RowTemplate.Height = 25;
            dgvDetalleventa.Size = new Size(667, 308);
            dgvDetalleventa.TabIndex = 17;
            // 
            // gbIDVenta
            // 
            gbIDVenta.Controls.Add(comboMetodoPago);
            gbIDVenta.Controls.Add(comboTipoComprobante);
            gbIDVenta.Controls.Add(label4);
            gbIDVenta.Controls.Add(label2);
            gbIDVenta.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbIDVenta.Location = new Point(12, 48);
            gbIDVenta.Name = "gbIDVenta";
            gbIDVenta.Size = new Size(308, 144);
            gbIDVenta.TabIndex = 21;
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
            // comboTipoComprobante
            // 
            comboTipoComprobante.FormattingEnabled = true;
            comboTipoComprobante.Location = new Point(147, 47);
            comboTipoComprobante.Name = "comboTipoComprobante";
            comboTipoComprobante.Size = new Size(130, 25);
            comboTipoComprobante.TabIndex = 40;
            comboTipoComprobante.SelectedIndexChanged += comboTipoComprobante_SelectedIndexChanged;
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
            // txtDocumento
            // 
            txtDocumento.Location = new Point(90, 31);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(131, 22);
            txtDocumento.TabIndex = 33;
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
            // btnEmitirComprobante
            // 
            btnEmitirComprobante.BackColor = Color.PowderBlue;
            btnEmitirComprobante.FlatAppearance.BorderSize = 0;
            btnEmitirComprobante.FlatStyle = FlatStyle.Flat;
            btnEmitirComprobante.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmitirComprobante.Location = new Point(695, 492);
            btnEmitirComprobante.Margin = new Padding(3, 2, 3, 2);
            btnEmitirComprobante.Name = "btnEmitirComprobante";
            btnEmitirComprobante.Size = new Size(124, 58);
            btnEmitirComprobante.TabIndex = 20;
            btnEmitirComprobante.Text = "EMITIR COMPROBANTE";
            btnEmitirComprobante.UseVisualStyleBackColor = false;
            btnEmitirComprobante.Click += btnEmitirComprobante_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(584, 16);
            label3.Name = "label3";
            label3.Size = new Size(129, 17);
            label3.TabIndex = 24;
            label3.Text = "Fecha - Hora Emision";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(720, 13);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(99, 23);
            dateTimePicker2.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(695, 322);
            label7.Name = "label7";
            label7.Size = new Size(94, 17);
            label7.TabIndex = 33;
            label7.Text = "Total Gravada";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(695, 392);
            label8.Name = "label8";
            label8.Size = new Size(30, 17);
            label8.TabIndex = 34;
            label8.Text = "IGV";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(695, 431);
            label9.Name = "label9";
            label9.Size = new Size(59, 17);
            label9.TabIndex = 35;
            label9.Text = "SubTotal";
            // 
            // txtIGV
            // 
            txtIGV.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtIGV.Location = new Point(695, 393);
            txtIGV.Name = "txtIGV";
            txtIGV.Size = new Size(124, 22);
            txtIGV.TabIndex = 34;
            // 
            // txtTotalGravada
            // 
            txtTotalGravada.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalGravada.Location = new Point(695, 340);
            txtTotalGravada.Name = "txtTotalGravada";
            txtTotalGravada.Size = new Size(124, 22);
            txtTotalGravada.TabIndex = 35;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubTotal.Location = new Point(695, 449);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(124, 22);
            txtSubTotal.TabIndex = 36;
            // 
            // txtSerie
            // 
            txtSerie.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSerie.Location = new Point(88, 209);
            txtSerie.Name = "txtSerie";
            txtSerie.ReadOnly = true;
            txtSerie.Size = new Size(100, 24);
            txtSerie.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(39, 213);
            label10.Name = "label10";
            label10.Size = new Size(43, 16);
            label10.TabIndex = 38;
            label10.Text = "Serie:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 70);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 42;
            label5.Text = "Nombre";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtTipoDoc);
            groupBox1.Controls.Add(btnBuscarDoc);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDocumento);
            groupBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(326, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 177);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFO CLIENTE";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(90, 143);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(382, 22);
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(291, 33);
            label12.Name = "label12";
            label12.Size = new Size(60, 17);
            label12.TabIndex = 59;
            label12.Text = "Tipo Doc";
            // 
            // txtTipoDoc
            // 
            txtTipoDoc.Location = new Point(357, 30);
            txtTipoDoc.Name = "txtTipoDoc";
            txtTipoDoc.Size = new Size(115, 22);
            txtTipoDoc.TabIndex = 58;
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
            btnBuscarDoc.Location = new Point(239, 30);
            btnBuscarDoc.Name = "btnBuscarDoc";
            btnBuscarDoc.Size = new Size(34, 23);
            btnBuscarDoc.TabIndex = 57;
            btnBuscarDoc.UseVisualStyleBackColor = false;
            btnBuscarDoc.Click += btnBuscarDoc_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(90, 104);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(382, 22);
            txtDireccion.TabIndex = 44;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(90, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(382, 22);
            txtNombre.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 33);
            label11.Name = "label11";
            label11.Size = new Size(79, 17);
            label11.TabIndex = 0;
            label11.Text = "Documento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(695, 373);
            label1.Name = "label1";
            label1.Size = new Size(30, 17);
            label1.TabIndex = 40;
            label1.Text = "IGV";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.PowderBlue;
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.Location = new Point(707, 267);
            btnPagar.Margin = new Padding(3, 2, 3, 2);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(103, 41);
            btnPagar.TabIndex = 41;
            btnPagar.Text = "PAGAR VENTA";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // Carrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(851, 573);
            Controls.Add(btnPagar);
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
            Controls.Add(dgvDetalleventa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Carrito";
            Load += Carrito_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalleventa).EndInit();
            gbIDVenta.ResumeLayout(false);
            gbIDVenta.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvDetalleventa;
        private GroupBox gbIDVenta;
        private TextBox txtDocumento;
        private Label label6;
        private Label label4;
        private Label label2;
        private Button btnEmitirComprobante;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtIGV;
        private TextBox txtTotalGravada;
        private TextBox txtSubTotal;
        private TextBox txtSerie;
        private Label label10;
        private ComboBox comboMetodoPago;
        private ComboBox comboTipoComprobante;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label label11;
        private FontAwesome.Sharp.IconButton btnBuscarDoc;
        private Label label12;
        private TextBox txtTipoDoc;
        private Label label1;
        private Button btnPagar;
        private TextBox txtEmail;
        private Label label13;
    }
}
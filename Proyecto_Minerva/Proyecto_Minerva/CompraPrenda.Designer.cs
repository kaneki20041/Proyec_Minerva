namespace Proyecto_Minerva
{
    partial class CompraPrenda
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
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            BuscarMetPago = new Button();
            txtRUC = new TextBox();
            txtRazonRUC = new TextBox();
            groupBox3 = new GroupBox();
            textBox4 = new TextBox();
            txtCantidad = new TextBox();
            label9 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label12 = new Label();
            label14 = new Label();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            label15 = new Label();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            label17 = new Label();
            label18 = new Label();
            btn_buscarPrenVen = new Button();
            textBox9 = new TextBox();
            label13 = new Label();
            label11 = new Label();
            groupBox1 = new GroupBox();
            txtUsuarioID = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox2 = new GroupBox();
            txtNombreRUC = new TextBox();
            label1 = new Label();
            BuscProveedor = new Button();
            AgreCompra = new Button();
            button4 = new Button();
            button5 = new Button();
            tablaCompras = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaCompras).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 70);
            label2.Name = "label2";
            label2.Size = new Size(63, 17);
            label2.TabIndex = 1;
            label2.Text = "UsuarioID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 65);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 4;
            label5.Text = "RUC";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 93);
            label6.Name = "label6";
            label6.Size = new Size(83, 17);
            label6.TabIndex = 5;
            label6.Text = "Razon Social";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(162, 38);
            label7.Name = "label7";
            label7.Size = new Size(45, 17);
            label7.TabIndex = 6;
            label7.Text = "Fecha";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 51);
            label8.Name = "label8";
            label8.Size = new Size(20, 17);
            label8.TabIndex = 7;
            label8.Text = "ID";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(726, 443);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(98, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(49, 48);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(38, 22);
            textBox3.TabIndex = 11;
            // 
            // BuscarMetPago
            // 
            BuscarMetPago.BackColor = Color.LightCyan;
            BuscarMetPago.FlatAppearance.BorderSize = 0;
            BuscarMetPago.FlatStyle = FlatStyle.Flat;
            BuscarMetPago.Font = new Font("Century Gothic", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            BuscarMetPago.Location = new Point(25, 76);
            BuscarMetPago.Name = "BuscarMetPago";
            BuscarMetPago.Size = new Size(62, 33);
            BuscarMetPago.TabIndex = 15;
            BuscarMetPago.Text = "Buscar";
            BuscarMetPago.UseVisualStyleBackColor = false;
            BuscarMetPago.Click += BuscarMetPago_Click;
            // 
            // txtRUC
            // 
            txtRUC.Location = new Point(101, 62);
            txtRUC.Name = "txtRUC";
            txtRUC.Size = new Size(166, 22);
            txtRUC.TabIndex = 17;
            // 
            // txtRazonRUC
            // 
            txtRazonRUC.Location = new Point(101, 90);
            txtRazonRUC.Multiline = true;
            txtRazonRUC.Name = "txtRazonRUC";
            txtRazonRUC.ReadOnly = true;
            txtRazonRUC.Size = new Size(264, 50);
            txtRazonRUC.TabIndex = 18;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(txtCantidad);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(textBox11);
            groupBox3.Controls.Add(textBox12);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(textBox13);
            groupBox3.Controls.Add(textBox14);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(btn_buscarPrenVen);
            groupBox3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(13, 177);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(697, 161);
            groupBox3.TabIndex = 45;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion de Prenda";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(110, 89);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(166, 22);
            textBox4.TabIndex = 56;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(503, 75);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(128, 22);
            txtCantidad.TabIndex = 50;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(49, 92);
            label9.Name = "label9";
            label9.Size = new Size(55, 17);
            label9.TabIndex = 55;
            label9.Text = "Colegio";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 117);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(166, 22);
            textBox1.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 120);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 48;
            label4.Text = "Categoria";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(433, 78);
            label12.Name = "label12";
            label12.Size = new Size(64, 17);
            label12.TabIndex = 43;
            label12.Text = "Cantidad";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(455, 106);
            label14.Name = "label14";
            label14.Size = new Size(42, 17);
            label14.TabIndex = 41;
            label14.Text = "Stock";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(503, 103);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(128, 22);
            textBox11.TabIndex = 40;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(503, 45);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(128, 22);
            textBox12.TabIndex = 39;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(431, 48);
            label15.Name = "label15";
            label15.Size = new Size(66, 17);
            label15.TabIndex = 38;
            label15.Text = "P.Compra";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(110, 61);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(166, 22);
            textBox13.TabIndex = 37;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(110, 31);
            textBox14.Multiline = true;
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(166, 22);
            textBox14.TabIndex = 32;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(54, 36);
            label17.Name = "label17";
            label17.Size = new Size(50, 17);
            label17.TabIndex = 2;
            label17.Text = "Prenda";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(69, 64);
            label18.Name = "label18";
            label18.Size = new Size(35, 17);
            label18.TabIndex = 5;
            label18.Text = "Talla";
            // 
            // btn_buscarPrenVen
            // 
            btn_buscarPrenVen.BackColor = Color.LightCyan;
            btn_buscarPrenVen.Cursor = Cursors.Hand;
            btn_buscarPrenVen.FlatAppearance.BorderSize = 0;
            btn_buscarPrenVen.FlatStyle = FlatStyle.Flat;
            btn_buscarPrenVen.Location = new Point(295, 29);
            btn_buscarPrenVen.Name = "btn_buscarPrenVen";
            btn_buscarPrenVen.Size = new Size(62, 24);
            btn_buscarPrenVen.TabIndex = 0;
            btn_buscarPrenVen.Text = "Buscar";
            btn_buscarPrenVen.UseVisualStyleBackColor = false;
            btn_buscarPrenVen.Click += btn_buscarPrenVen_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(213, 98);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(121, 22);
            textBox9.TabIndex = 50;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(117, 101);
            label13.Name = "label13";
            label13.Size = new Size(90, 17);
            label13.TabIndex = 49;
            label13.Text = "Metodo Pago";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(750, 420);
            label11.Name = "label11";
            label11.Size = new Size(47, 17);
            label11.TabIndex = 44;
            label11.Text = "Monto";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUsuarioID);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(BuscarMetPago);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(13, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 154);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion de Compra";
            // 
            // txtUsuarioID
            // 
            txtUsuarioID.Location = new Point(213, 67);
            txtUsuarioID.Name = "txtUsuarioID";
            txtUsuarioID.Size = new Size(121, 22);
            txtUsuarioID.TabIndex = 51;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(213, 35);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 22);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNombreRUC);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(BuscProveedor);
            groupBox2.Controls.Add(txtRazonRUC);
            groupBox2.Controls.Add(txtRUC);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(444, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(380, 154);
            groupBox2.TabIndex = 50;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion de Proveedor";
            // 
            // txtNombreRUC
            // 
            txtNombreRUC.Location = new Point(101, 34);
            txtNombreRUC.Name = "txtNombreRUC";
            txtNombreRUC.Size = new Size(166, 22);
            txtNombreRUC.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 37);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 51;
            label1.Text = "Nombre";
            // 
            // BuscProveedor
            // 
            BuscProveedor.BackColor = Color.LightCyan;
            BuscProveedor.FlatAppearance.BorderSize = 0;
            BuscProveedor.FlatStyle = FlatStyle.Flat;
            BuscProveedor.Location = new Point(290, 41);
            BuscProveedor.Name = "BuscProveedor";
            BuscProveedor.Size = new Size(63, 29);
            BuscProveedor.TabIndex = 50;
            BuscProveedor.Text = "Buscar";
            BuscProveedor.UseVisualStyleBackColor = false;
            BuscProveedor.Click += BuscProveedor_Click;
            // 
            // AgreCompra
            // 
            AgreCompra.BackColor = Color.LightBlue;
            AgreCompra.FlatAppearance.BorderSize = 0;
            AgreCompra.FlatStyle = FlatStyle.Flat;
            AgreCompra.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AgreCompra.Location = new Point(726, 194);
            AgreCompra.Name = "AgreCompra";
            AgreCompra.Size = new Size(98, 40);
            AgreCompra.TabIndex = 51;
            AgreCompra.Text = "Agregar";
            AgreCompra.UseVisualStyleBackColor = false;
            AgreCompra.Click += AgreCompra_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(726, 472);
            button4.Name = "button4";
            button4.Size = new Size(98, 35);
            button4.TabIndex = 52;
            button4.Text = "Grabar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(726, 240);
            button5.Name = "button5";
            button5.Size = new Size(98, 39);
            button5.TabIndex = 53;
            button5.Text = "Quitar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // tablaCompras
            // 
            tablaCompras.BackgroundColor = Color.MintCream;
            tablaCompras.BorderStyle = BorderStyle.None;
            tablaCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaCompras.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4, Column5, Column7, Column6, Column8 });
            tablaCompras.Location = new Point(13, 357);
            tablaCompras.Name = "tablaCompras";
            tablaCompras.RowTemplate.Height = 25;
            tablaCompras.Size = new Size(697, 204);
            tablaCompras.TabIndex = 54;
            // 
            // Column2
            // 
            Column2.HeaderText = "Prenda";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Categoria";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Colegio";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Talla";
            Column5.Name = "Column5";
            // 
            // Column7
            // 
            Column7.HeaderText = "Cantidad";
            Column7.Name = "Column7";
            // 
            // Column6
            // 
            Column6.HeaderText = "Precio";
            Column6.Name = "Column6";
            // 
            // Column8
            // 
            Column8.HeaderText = "Subtotal";
            Column8.Name = "Column8";
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(726, 285);
            button1.Name = "button1";
            button1.Size = new Size(98, 41);
            button1.TabIndex = 55;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CompraPrenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(851, 573);
            Controls.Add(button1);
            Controls.Add(tablaCompras);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(AgreCompra);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(textBox2);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CompraPrenda";
            Text = "Cambio";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button BuscarMetPago;
        private TextBox txtRUC;
        private TextBox txtRazonRUC;
        private GroupBox groupBox3;
        private TextBox textBox9;
        private Label label13;
        private Label label11;
        private Label label12;
        private Label label14;
        private TextBox textBox11;
        private TextBox textBox12;
        private Label label15;
        private TextBox textBox13;
        private TextBox textBox14;
        private Label label17;
        private Label label18;
        private Button btn_buscarPrenVen;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private Button BuscProveedor;
        private Button AgreCompra;
        private Button button4;
        private Button button5;
        private DataGridView tablaCompras;
        private TextBox textBox1;
        private Label label4;
        private TextBox txtCantidad;
        private TextBox textBox4;
        private Label label9;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Colegio;
        private DataGridViewTextBoxColumn Talla;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PCompra;
        private DataGridViewTextBoxColumn Subtotal;
        private Button button1;
        private TextBox txtUsuarioID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private TextBox txtNombreRUC;
        private Label label1;
    }
}
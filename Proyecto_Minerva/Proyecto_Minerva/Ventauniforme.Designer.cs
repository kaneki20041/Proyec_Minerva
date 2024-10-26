namespace Proyecto_Minerva
{
    partial class Ventauniforme
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
            txtNombre = new TextBox();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            txtDocumento = new TextBox();
            txtDescripcion = new TextBox();
            groupBox1 = new GroupBox();
            txtNumVenta = new TextBox();
            label1 = new Label();
            txtVendedor = new TextBox();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            btnBuscarDni = new FontAwesome.Sharp.IconButton();
            groupBox2 = new GroupBox();
            label12 = new Label();
            txtTalla = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            label9 = new Label();
            label10 = new Label();
            groupBox3 = new GroupBox();
            txtCantidad = new TextBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label15 = new Label();
            txtCategoria = new TextBox();
            label14 = new Label();
            txtColegio = new TextBox();
            textBox6 = new TextBox();
            label11 = new Label();
            button2 = new Button();
            tablaVentas = new DataGridView();
            Descripcion = new DataGridViewTextBoxColumn();
            Colegio = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Talla = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            button3 = new Button();
            label13 = new Label();
            label16 = new Label();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaVentas).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 25);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 2;
            label2.Text = "Descripcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 118);
            label5.Name = "label5";
            label5.Size = new Size(35, 17);
            label5.TabIndex = 5;
            label5.Text = "Talla";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 61);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(162, 22);
            txtNombre.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.PowderBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(735, 471);
            button1.Name = "button1";
            button1.Size = new Size(93, 57);
            button1.TabIndex = 14;
            button1.Text = "Registrar Venta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 30);
            label6.Name = "label6";
            label6.Size = new Size(79, 17);
            label6.TabIndex = 15;
            label6.Text = "Documento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(215, 31);
            label7.Name = "label7";
            label7.Size = new Size(45, 17);
            label7.TabIndex = 16;
            label7.Text = "Fecha";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(100, 28);
            txtDocumento.Multiline = true;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(108, 22);
            txtDocumento.TabIndex = 20;
            txtDocumento.KeyPress += txtDocumento_KeyPress;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(103, 23);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(198, 22);
            txtDescripcion.TabIndex = 32;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNumVenta);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtVendedor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(64, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 104);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion de Venta";
            // 
            // txtNumVenta
            // 
            txtNumVenta.Location = new Point(92, 28);
            txtNumVenta.Name = "txtNumVenta";
            txtNumVenta.ReadOnly = true;
            txtNumVenta.Size = new Size(100, 22);
            txtNumVenta.TabIndex = 60;
            txtNumVenta.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 31);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 59;
            label1.Text = "Nº Venta";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(169, 62);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.ReadOnly = true;
            txtVendedor.Size = new Size(151, 22);
            txtVendedor.TabIndex = 58;
            txtVendedor.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 65);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 54;
            label4.Text = "Vendedor";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(266, 28);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(100, 22);
            dateTimePicker2.TabIndex = 36;
            dateTimePicker2.UseWaitCursor = true;
            // 
            // btnBuscarDni
            // 
            btnBuscarDni.BackColor = Color.PowderBlue;
            btnBuscarDni.Cursor = Cursors.Hand;
            btnBuscarDni.FlatStyle = FlatStyle.Popup;
            btnBuscarDni.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarDni.IconColor = Color.Black;
            btnBuscarDni.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarDni.IconSize = 15;
            btnBuscarDni.Location = new Point(214, 27);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(34, 23);
            btnBuscarDni.TabIndex = 55;
            btnBuscarDni.UseVisualStyleBackColor = false;
            btnBuscarDni.Click += btnBuscarDni_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscarDni);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtDocumento);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(515, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(278, 104);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion de Cliente";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 62);
            label12.Name = "label12";
            label12.Size = new Size(56, 17);
            label12.TabIndex = 35;
            label12.Text = "Nombre";
            // 
            // txtTalla
            // 
            txtTalla.Location = new Point(103, 115);
            txtTalla.Name = "txtTalla";
            txtTalla.ReadOnly = true;
            txtTalla.Size = new Size(98, 22);
            txtTalla.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 76);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 38;
            label3.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(425, 73);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(148, 22);
            txtPrecio.TabIndex = 39;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(425, 105);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(148, 22);
            txtStock.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(377, 108);
            label9.Name = "label9";
            label9.Size = new Size(42, 17);
            label9.TabIndex = 41;
            label9.Text = "Stock";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(356, 45);
            label10.Name = "label10";
            label10.Size = new Size(64, 17);
            label10.TabIndex = 43;
            label10.Text = "Cantidad";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtCantidad);
            groupBox3.Controls.Add(iconButton2);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(txtCategoria);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(txtColegio);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtStock);
            groupBox3.Controls.Add(txtPrecio);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtTalla);
            groupBox3.Controls.Add(txtDescripcion);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label5);
            groupBox3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(64, 131);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(602, 152);
            groupBox3.TabIndex = 44;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion de Prenda";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(425, 42);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(148, 22);
            txtCantidad.TabIndex = 57;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.PowderBlue;
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.FlatStyle = FlatStyle.Popup;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 15;
            iconButton2.Location = new Point(307, 22);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(34, 23);
            iconButton2.TabIndex = 56;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(28, 88);
            label15.Name = "label15";
            label15.Size = new Size(69, 17);
            label15.TabIndex = 51;
            label15.Text = "Categoria";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(103, 85);
            txtCategoria.Multiline = true;
            txtCategoria.Name = "txtCategoria";
            txtCategoria.ReadOnly = true;
            txtCategoria.Size = new Size(198, 22);
            txtCategoria.TabIndex = 52;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(42, 55);
            label14.Name = "label14";
            label14.Size = new Size(55, 17);
            label14.TabIndex = 38;
            label14.Text = "Colegio";
            // 
            // txtColegio
            // 
            txtColegio.Location = new Point(103, 55);
            txtColegio.Multiline = true;
            txtColegio.Name = "txtColegio";
            txtColegio.ReadOnly = true;
            txtColegio.Size = new Size(198, 22);
            txtColegio.TabIndex = 38;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(731, 373);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(100, 22);
            textBox6.TabIndex = 48;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(731, 410);
            label11.Name = "label11";
            label11.Size = new Size(62, 17);
            label11.TabIndex = 44;
            label11.Text = "Sub Total";
            // 
            // button2
            // 
            button2.BackColor = Color.PowderBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(690, 216);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(93, 42);
            button2.TabIndex = 45;
            button2.Text = "Quitar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // tablaVentas
            // 
            tablaVentas.BackgroundColor = Color.MintCream;
            tablaVentas.BorderStyle = BorderStyle.None;
            tablaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaVentas.Columns.AddRange(new DataGridViewColumn[] { Descripcion, Colegio, Categoria, Talla, Cantidad, Precio, SubTotal });
            tablaVentas.Location = new Point(13, 297);
            tablaVentas.Name = "tablaVentas";
            tablaVentas.RowHeadersWidth = 51;
            tablaVentas.RowTemplate.Height = 25;
            tablaVentas.Size = new Size(703, 264);
            tablaVentas.TabIndex = 47;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 150;
            // 
            // Colegio
            // 
            Colegio.HeaderText = "Colegio";
            Colegio.Name = "Colegio";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // Talla
            // 
            Talla.HeaderText = "Talla";
            Talla.Name = "Talla";
            Talla.Width = 60;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 80;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.Width = 80;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.Width = 80;
            // 
            // button3
            // 
            button3.BackColor = Color.PowderBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(690, 157);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(93, 43);
            button3.TabIndex = 48;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(731, 353);
            label13.Name = "label13";
            label13.Size = new Size(97, 17);
            label13.TabIndex = 49;
            label13.Text = "Monto Cambio";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(731, 295);
            label16.Name = "label16";
            label16.Size = new Size(81, 17);
            label16.TabIndex = 50;
            label16.Text = "Monto Pago";
            // 
            // textBox13
            // 
            textBox13.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox13.Location = new Point(731, 315);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(100, 22);
            textBox13.TabIndex = 51;
            // 
            // textBox14
            // 
            textBox14.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox14.Location = new Point(731, 430);
            textBox14.Name = "textBox14";
            textBox14.ReadOnly = true;
            textBox14.Size = new Size(100, 22);
            textBox14.TabIndex = 52;
            // 
            // Ventauniforme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(853, 573);
            Controls.Add(textBox14);
            Controls.Add(textBox13);
            Controls.Add(button3);
            Controls.Add(tablaVentas);
            Controls.Add(label16);
            Controls.Add(button2);
            Controls.Add(groupBox3);
            Controls.Add(label13);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label11);
            Controls.Add(button1);
            Controls.Add(textBox6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventauniforme";
            Load += Ventauniforme_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label5;
        private TextBox txtNombre;
        private Button button1;
        private Label label6;
        private Label label7;
        private TextBox txtDocumento;
        private TextBox txtDescripcion;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker2;
        private Label label12;
        private TextBox txtTalla;
        private Label label3;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Label label9;
        private Label label10;
        private GroupBox groupBox3;
        private Label label11;
        private TextBox textBox6;
        private Button button2;
        private TextBox txtColegio;
        private Label label15;
        private TextBox txtCategoria;
        private Label label14;
        private DataGridView tablaVentas;
        private Button button3;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnBuscarDni;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label13;
        private Label label16;
        private TextBox textBox13;
        private TextBox textBox14;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Colegio;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Talla;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn SubTotal;
        private TextBox txtCantidad;
        private TextBox txtVendedor;
        private Label label1;
        private TextBox txtNumVenta;
    }
}
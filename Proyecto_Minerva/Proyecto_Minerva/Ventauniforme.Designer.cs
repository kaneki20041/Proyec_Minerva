﻿namespace Proyecto_Minerva
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
            textBox1 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            textBox7 = new TextBox();
            textBox10 = new TextBox();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            btnBuscarDni = new FontAwesome.Sharp.IconButton();
            groupBox2 = new GroupBox();
            label12 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            groupBox3 = new GroupBox();
            txtCantidad = new TextBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label15 = new Label();
            textBox12 = new TextBox();
            label14 = new Label();
            textBox11 = new TextBox();
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
            label2.Location = new Point(40, 26);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 2;
            label2.Text = "Descripcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 120);
            label5.Name = "label5";
            label5.Size = new Size(35, 17);
            label5.TabIndex = 5;
            label5.Text = "Talla";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 61);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 22);
            textBox1.TabIndex = 6;
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
            label6.Location = new Point(31, 37);
            label6.Name = "label6";
            label6.Size = new Size(79, 17);
            label6.TabIndex = 15;
            label6.Text = "Documento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(89, 30);
            label7.Name = "label7";
            label7.Size = new Size(45, 17);
            label7.TabIndex = 16;
            label7.Text = "Fecha";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(115, 34);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(101, 22);
            textBox7.TabIndex = 20;
            textBox7.TextChanged += textBox7_TextChanged;
            textBox7.KeyPress += textBox7_KeyPress;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(125, 23);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(173, 22);
            textBox10.TabIndex = 32;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(64, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 104);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion de Venta";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(155, 59);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(131, 22);
            textBox4.TabIndex = 58;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 62);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 54;
            label4.Text = "Vendedor";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(155, 30);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(131, 22);
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
            btnBuscarDni.Location = new Point(222, 32);
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
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(420, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(352, 104);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion de Cliente";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(46, 64);
            label12.Name = "label12";
            label12.Size = new Size(56, 17);
            label12.TabIndex = 35;
            label12.Text = "Nombre";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 115);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(85, 22);
            textBox2.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 74);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 38;
            label3.Text = "Precio";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(426, 71);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(148, 22);
            textBox3.TabIndex = 39;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(426, 103);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(148, 22);
            textBox5.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(378, 106);
            label9.Name = "label9";
            label9.Size = new Size(42, 17);
            label9.TabIndex = 41;
            label9.Text = "Stock";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(357, 43);
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
            groupBox3.Controls.Add(textBox12);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(textBox11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBox10);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label5);
            groupBox3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(77, 131);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(589, 152);
            groupBox3.TabIndex = 44;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion de Prenda";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(426, 40);
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
            iconButton2.Location = new Point(304, 22);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(34, 23);
            iconButton2.TabIndex = 56;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(38, 88);
            label15.Name = "label15";
            label15.Size = new Size(69, 17);
            label15.TabIndex = 51;
            label15.Text = "Categoria";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(125, 85);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(148, 22);
            textBox12.TabIndex = 52;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(52, 55);
            label14.Name = "label14";
            label14.Size = new Size(55, 17);
            label14.TabIndex = 38;
            label14.Text = "Colegio";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(125, 55);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(148, 22);
            textBox11.TabIndex = 38;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(731, 376);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 48;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(728, 412);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
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
            tablaVentas.Location = new Point(13, 315);
            tablaVentas.Name = "tablaVentas";
            tablaVentas.RowHeadersWidth = 51;
            tablaVentas.RowTemplate.Height = 25;
            tablaVentas.Size = new Size(703, 246);
            tablaVentas.TabIndex = 47;
            tablaVentas.CellContentClick += dataGridView1_CellContentClick;
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
            label13.Location = new Point(728, 350);
            label13.Name = "label13";
            label13.Size = new Size(88, 15);
            label13.TabIndex = 49;
            label13.Text = "Monto Cambio";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(730, 289);
            label16.Name = "label16";
            label16.Size = new Size(73, 15);
            label16.TabIndex = 50;
            label16.Text = "Monto Pago";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(731, 315);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(100, 23);
            textBox13.TabIndex = 51;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(731, 430);
            textBox14.Name = "textBox14";
            textBox14.ReadOnly = true;
            textBox14.Size = new Size(100, 23);
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
            Load += Ventauniforme_Load_1;
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
        private TextBox textBox1;
        private Button button1;
        private Label label6;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBox10;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker2;
        private Label label12;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox5;
        private Label label9;
        private Label label10;
        private GroupBox groupBox3;
        private Label label11;
        private TextBox textBox6;
        private Button button2;
        private TextBox textBox11;
        private Label label15;
        private TextBox textBox12;
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
        private TextBox textBox4;
    }
}
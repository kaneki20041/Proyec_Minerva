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
            btn_buscarPrenVen = new Button();
            label2 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            textBox7 = new TextBox();
            textBox4 = new TextBox();
            textBox10 = new TextBox();
            groupBox1 = new GroupBox();
            btnBuscarDni = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            groupBox2 = new GroupBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label12 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            groupBox3 = new GroupBox();
            label15 = new Label();
            textBox12 = new TextBox();
            label14 = new Label();
            textBox11 = new TextBox();
            textBox6 = new TextBox();
            domainUpDown1 = new DomainUpDown();
            label11 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_buscarPrenVen
            // 
            btn_buscarPrenVen.BackColor = Color.LightCyan;
            btn_buscarPrenVen.Cursor = Cursors.Hand;
            btn_buscarPrenVen.FlatAppearance.BorderSize = 0;
            btn_buscarPrenVen.FlatStyle = FlatStyle.Flat;
            btn_buscarPrenVen.Font = new Font("Century Gothic", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_buscarPrenVen.Location = new Point(42, 82);
            btn_buscarPrenVen.Name = "btn_buscarPrenVen";
            btn_buscarPrenVen.Size = new Size(76, 37);
            btn_buscarPrenVen.TabIndex = 0;
            btn_buscarPrenVen.Text = "Buscar";
            btn_buscarPrenVen.UseVisualStyleBackColor = false;
            btn_buscarPrenVen.Click += btn_buscarPrenVen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 22);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 2;
            label2.Text = "Prenda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 54);
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
            button1.Location = new Point(740, 350);
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
            label7.Location = new Point(102, 23);
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
            // 
            // textBox4
            // 
            textBox4.Location = new Point(68, 48);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(50, 22);
            textBox4.TabIndex = 22;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(237, 19);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(148, 22);
            textBox10.TabIndex = 32;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscarDni);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(64, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 104);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion de Venta";
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
            btnBuscarDni.Location = new Point(209, 47);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(34, 23);
            btnBuscarDni.TabIndex = 55;
            btnBuscarDni.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 50);
            label4.Name = "label4";
            label4.Size = new Size(20, 17);
            label4.TabIndex = 54;
            label4.Text = "ID";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(153, 72);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(131, 22);
            textBox8.TabIndex = 37;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(153, 47);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(50, 22);
            textBox9.TabIndex = 53;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(153, 21);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(131, 22);
            dateTimePicker2.TabIndex = 36;
            dateTimePicker2.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(60, 77);
            label8.Name = "label8";
            label8.Size = new Size(87, 17);
            label8.TabIndex = 19;
            label8.Text = "MetodoPago";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(iconButton1);
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
            // iconButton1
            // 
            iconButton1.BackColor = Color.PowderBlue;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 15;
            iconButton1.Location = new Point(222, 34);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(34, 23);
            iconButton1.TabIndex = 56;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 51);
            label1.Name = "label1";
            label1.Size = new Size(20, 17);
            label1.TabIndex = 36;
            label1.Text = "ID";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(237, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(148, 22);
            textBox2.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(419, 57);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 38;
            label3.Text = "Precio";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(471, 54);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(148, 22);
            textBox3.TabIndex = 39;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(471, 82);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(148, 22);
            textBox5.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(423, 85);
            label9.Name = "label9";
            label9.Size = new Size(42, 17);
            label9.TabIndex = 41;
            label9.Text = "Stock";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(402, 22);
            label10.Name = "label10";
            label10.Size = new Size(64, 17);
            label10.TabIndex = 43;
            label10.Text = "Cantidad";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(textBox12);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(textBox11);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(domainUpDown1);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textBox10);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(btn_buscarPrenVen);
            groupBox3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(64, 131);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(696, 164);
            groupBox3.TabIndex = 44;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion de Prenda";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(162, 110);
            label15.Name = "label15";
            label15.Size = new Size(69, 17);
            label15.TabIndex = 51;
            label15.Text = "Categoria";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(237, 107);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(148, 22);
            textBox12.TabIndex = 52;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(176, 82);
            label14.Name = "label14";
            label14.Size = new Size(55, 17);
            label14.TabIndex = 38;
            label14.Text = "Colegio";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(237, 79);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(148, 22);
            textBox11.TabIndex = 38;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(471, 110);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(148, 22);
            textBox6.TabIndex = 48;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(471, 19);
            domainUpDown1.Margin = new Padding(3, 2, 3, 2);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(148, 22);
            domainUpDown1.TabIndex = 47;
            domainUpDown1.Tag = "";
            domainUpDown1.Text = "0";
            domainUpDown1.TextAlign = HorizontalAlignment.Right;
            domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(418, 113);
            label11.Name = "label11";
            label11.Size = new Size(47, 17);
            label11.TabIndex = 44;
            label11.Text = "Monto";
            // 
            // button2
            // 
            button2.BackColor = Color.PowderBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(740, 412);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(93, 42);
            button2.TabIndex = 45;
            button2.Text = "Quitar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MintCream;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 315);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(712, 246);
            dataGridView1.TabIndex = 47;
            // 
            // button3
            // 
            button3.BackColor = Color.PowderBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(740, 458);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(93, 43);
            button3.TabIndex = 48;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Ventauniforme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(851, 573);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventauniforme";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_buscarPrenVen;
        private Label label2;
        private Label label5;
        private TextBox textBox1;
        private Button button1;
        private Label label6;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBox4;
        private TextBox textBox10;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker2;
        private Label label12;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox5;
        private Label label9;
        private Label label10;
        private GroupBox groupBox3;
        private Label label11;
        private DomainUpDown domainUpDown1;
        private TextBox textBox6;
        private Button button2;
        private TextBox textBox11;
        private Label label15;
        private TextBox textBox12;
        private Label label14;
        private DataGridView dataGridView1;
        private Button button3;
        private TextBox textBox8;
        private Label label8;
        private Label label4;
        private TextBox textBox9;
        private FontAwesome.Sharp.IconButton btnBuscarDni;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
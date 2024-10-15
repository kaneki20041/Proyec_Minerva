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
            dgvDetalleventa = new DataGridView();
            gbIDVenta = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            button3 = new Button();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label10 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label12 = new Label();
            textBox4 = new TextBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label11 = new Label();
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
            dgvDetalleventa.Location = new Point(10, 259);
            dgvDetalleventa.Name = "dgvDetalleventa";
            dgvDetalleventa.RowHeadersWidth = 51;
            dgvDetalleventa.RowTemplate.Height = 25;
            dgvDetalleventa.Size = new Size(660, 286);
            dgvDetalleventa.TabIndex = 17;
            // 
            // gbIDVenta
            // 
            gbIDVenta.Controls.Add(comboBox2);
            gbIDVenta.Controls.Add(comboBox1);
            gbIDVenta.Controls.Add(label4);
            gbIDVenta.Controls.Add(label2);
            gbIDVenta.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbIDVenta.Location = new Point(10, 71);
            gbIDVenta.Name = "gbIDVenta";
            gbIDVenta.Size = new Size(322, 126);
            gbIDVenta.TabIndex = 21;
            gbIDVenta.TabStop = false;
            gbIDVenta.Text = "INFORMACION PAGO";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(134, 73);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(131, 25);
            comboBox2.TabIndex = 41;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(135, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(49, 77);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 30;
            label4.Text = "Metodo Pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 38);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 23;
            label2.Text = "Tipo Comprobante";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(98, 31);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(131, 23);
            textBox5.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 112);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 32;
            label6.Text = "Direccion";
            // 
            // button3
            // 
            button3.BackColor = Color.PowderBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(695, 487);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(124, 58);
            button3.TabIndex = 20;
            button3.Text = "EMITIR COMPROBANTE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(548, 15);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 24;
            label3.Text = "Fecha - hora emision";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(684, 12);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(99, 23);
            dateTimePicker2.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(695, 300);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 33;
            label7.Text = "Total gravada";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(695, 372);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 34;
            label8.Text = "IGV";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(695, 416);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 35;
            label9.Text = "SUB TOTAL";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(695, 390);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(115, 23);
            textBox6.TabIndex = 34;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(695, 330);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(115, 23);
            textBox7.TabIndex = 35;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(695, 445);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(124, 23);
            textBox8.TabIndex = 36;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(88, 24);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(100, 25);
            textBox9.TabIndex = 37;
            textBox9.Text = "B001-1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(33, 26);
            label10.Name = "label10";
            label10.Size = new Size(49, 21);
            label10.TabIndex = 38;
            label10.Text = "SERIE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 70);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 42;
            label5.Text = "Nombre";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(iconButton2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Location = new Point(396, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 155);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFO CLIENTE";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(230, 70);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 59;
            label12.Text = "Tipo Doc";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(287, 67);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 58;
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
            iconButton2.Location = new Point(240, 31);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(34, 23);
            iconButton2.TabIndex = 57;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(85, 104);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(131, 23);
            textBox3.TabIndex = 44;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 34);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 0;
            label11.Text = "Documento";
            // 
            // Detalleventa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(851, 573);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dateTimePicker2);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(gbIDVenta);
            Controls.Add(dgvDetalleventa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Detalleventa";
            Text = "SalidMaterial";
            Load += Detalleventa_Load;
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
        private TextBox textBox5;
        private Label label6;
        private Label label4;
        private Label label2;
        private Button button3;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label10;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label11;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label12;
        private TextBox textBox4;
    }
}
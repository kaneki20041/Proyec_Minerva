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
            textBox1 = new TextBox();
            gbIDVenta = new GroupBox();
            label11 = new Label();
            textBox10 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            button3 = new Button();
            label1 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox2 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label10 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleventa).BeginInit();
            gbIDVenta.SuspendLayout();
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
            // textBox1
            // 
            textBox1.Location = new Point(148, 39);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(105, 22);
            textBox1.TabIndex = 19;
            // 
            // gbIDVenta
            // 
            gbIDVenta.Controls.Add(comboBox2);
            gbIDVenta.Controls.Add(comboBox1);
            gbIDVenta.Controls.Add(label11);
            gbIDVenta.Controls.Add(textBox10);
            gbIDVenta.Controls.Add(textBox5);
            gbIDVenta.Controls.Add(label6);
            gbIDVenta.Controls.Add(label5);
            gbIDVenta.Controls.Add(label4);
            gbIDVenta.Controls.Add(textBox1);
            gbIDVenta.Controls.Add(label2);
            gbIDVenta.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbIDVenta.Location = new Point(10, 71);
            gbIDVenta.Name = "gbIDVenta";
            gbIDVenta.Size = new Size(809, 170);
            gbIDVenta.TabIndex = 21;
            gbIDVenta.TabStop = false;
            gbIDVenta.Text = "INFORMACION PAGO";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(546, 18);
            label11.Name = "label11";
            label11.Size = new Size(38, 17);
            label11.TabIndex = 39;
            label11.Text = "Nota";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(546, 44);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(241, 95);
            textBox10.TabIndex = 34;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(390, 44);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(131, 22);
            textBox5.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(277, 44);
            label6.Name = "label6";
            label6.Size = new Size(85, 17);
            label6.TabIndex = 32;
            label6.Text = "Tipo moneda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 43);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 31;
            label5.Text = "VENTA ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(274, 89);
            label4.Name = "label4";
            label4.Size = new Size(93, 19);
            label4.TabIndex = 30;
            label4.Text = "Metodo Pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 88);
            label2.Name = "label2";
            label2.Size = new Size(124, 19);
            label2.TabIndex = 23;
            label2.Text = "Tipo Comprobante";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 22;
            label1.Text = "NUMERO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 35);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 24;
            label3.Text = "Fecha - hora emision";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(757, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(82, 23);
            dateTimePicker1.TabIndex = 25;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(640, 32);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(99, 23);
            dateTimePicker2.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.MintCream;
            textBox2.Location = new Point(105, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(104, 23);
            textBox2.TabIndex = 27;
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
            textBox9.Location = new Point(281, 27);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(226, 29);
            label10.Name = "label10";
            label10.Size = new Size(49, 21);
            label10.TabIndex = 38;
            label10.Text = "SERIE";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(147, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 40;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(390, 85);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 25);
            comboBox2.TabIndex = 41;
            // 
            // Detalleventa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(851, 573);
            Controls.Add(label10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvDetalleventa;
        private TextBox textBox1;
        private GroupBox gbIDVenta;
        private TextBox textBox5;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button button3;
        private Label label1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox2;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label10;
        private Label label11;
        private TextBox textBox10;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}
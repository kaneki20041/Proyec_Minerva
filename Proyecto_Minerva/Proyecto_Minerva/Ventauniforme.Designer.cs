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
            label4 = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Prenda = new DataGridViewTextBoxColumn();
            Talla = new DataGridViewTextBoxColumn();
            T_Doc = new DataGridViewTextBoxColumn();
            Motorizado = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewTextBoxColumn();
            btn_buscarcliente = new Button();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btn_Stock = new Button();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox7 = new TextBox();
            textBox4 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label9 = new Label();
            textBox8 = new TextBox();
            label11 = new Label();
            textBox10 = new TextBox();
            textBox5 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnBuscMot = new Button();
            dateTimePicker2 = new DateTimePicker();
            label12 = new Label();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(312, 4);
            label4.Name = "label4";
            label4.Size = new Size(119, 21);
            label4.TabIndex = 10;
            label4.Text = "Venta Uniforme";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Cliente, DNI, Prenda, Talla, T_Doc, Motorizado, Direccion, Horario });
            dataGridView1.Location = new Point(5, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(671, 153);
            dataGridView1.TabIndex = 11;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 30;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.Width = 110;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            DNI.Width = 50;
            // 
            // Prenda
            // 
            Prenda.HeaderText = "Prenda";
            Prenda.Name = "Prenda";
            Prenda.Width = 110;
            // 
            // Talla
            // 
            Talla.HeaderText = "Talla";
            Talla.Name = "Talla";
            Talla.Width = 28;
            // 
            // T_Doc
            // 
            T_Doc.HeaderText = "Documento";
            T_Doc.Name = "T_Doc";
            T_Doc.Width = 60;
            // 
            // Motorizado
            // 
            Motorizado.HeaderText = "Motorizado";
            Motorizado.Name = "Motorizado";
            Motorizado.Width = 80;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.Width = 95;
            // 
            // Horario
            // 
            Horario.HeaderText = "Horario";
            Horario.Name = "Horario";
            Horario.Width = 65;
            // 
            // btn_buscarcliente
            // 
            btn_buscarcliente.Cursor = Cursors.Hand;
            btn_buscarcliente.Location = new Point(328, 19);
            btn_buscarcliente.Name = "btn_buscarcliente";
            btn_buscarcliente.Size = new Size(66, 23);
            btn_buscarcliente.TabIndex = 0;
            btn_buscarcliente.Text = "Buscar";
            btn_buscarcliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Prenda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(224, 82);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 5;
            label5.Text = "Talla";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 22);
            textBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(595, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(78, 23);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.UseWaitCursor = true;
            // 
            // btn_Stock
            // 
            btn_Stock.Cursor = Cursors.Hand;
            btn_Stock.Location = new Point(231, 48);
            btn_Stock.Name = "btn_Stock";
            btn_Stock.Size = new Size(117, 27);
            btn_Stock.TabIndex = 13;
            btn_Stock.Text = "Revisar catalogo";
            btn_Stock.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(561, 133);
            button1.Name = "button1";
            button1.Size = new Size(109, 26);
            button1.TabIndex = 14;
            button1.Text = "Registrar venta";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(550, 10);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 15;
            label6.Text = "Fecha";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(230, 26);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 16;
            label7.Text = "DNI";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 84);
            label8.Name = "label8";
            label8.Size = new Size(93, 13);
            label8.TabIndex = 19;
            label8.Text = "Tipo Documento";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(54, 50);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(169, 22);
            textBox7.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(260, 78);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(36, 23);
            textBox4.TabIndex = 22;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(12, 7);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(73, 19);
            radioButton1.TabIndex = 23;
            radioButton1.TabStop = true;
            radioButton1.Text = "V. Tienda";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(91, 7);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(80, 19);
            radioButton2.TabIndex = 24;
            radioButton2.Text = "V. Delivery";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1, 22);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 25;
            label9.Text = "Motorizado";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(69, 19);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(106, 22);
            textBox8.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 49);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 30;
            label11.Text = "Ubicacion";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(258, 19);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(62, 22);
            textBox10.TabIndex = 32;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(105, 78);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(95, 22);
            textBox5.TabIndex = 33;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox10);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btn_Stock);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_buscarcliente);
            groupBox1.Location = new Point(8, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 115);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion venta";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscMot);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(420, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(249, 98);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion de envio";
            // 
            // btnBuscMot
            // 
            btnBuscMot.Location = new Point(181, 19);
            btnBuscMot.Name = "btnBuscMot";
            btnBuscMot.Size = new Size(62, 23);
            btnBuscMot.TabIndex = 37;
            btnBuscMot.Text = "Buscar";
            btnBuscMot.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(69, 70);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(88, 23);
            dateTimePicker2.TabIndex = 36;
            dateTimePicker2.UseWaitCursor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 76);
            label12.Name = "label12";
            label12.Size = new Size(47, 15);
            label12.TabIndex = 35;
            label12.Text = "Horario";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(69, 46);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(166, 22);
            textBox6.TabIndex = 32;
            textBox6.Text = "       ";
            // 
            // Ventauniforme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(681, 324);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventauniforme";
            Load += Ventauniforme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private DataGridView dataGridView1;
        private Button btn_buscarcliente;
        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Button btn_Stock;
        private Button button1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox7;
        private TextBox textBox4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label9;
        private TextBox textBox8;
        private Label label11;
        private TextBox textBox10;
        private TextBox textBox5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker2;
        private Label label12;
        private TextBox textBox6;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Prenda;
        private DataGridViewTextBoxColumn Talla;
        private DataGridViewTextBoxColumn T_Doc;
        private DataGridViewTextBoxColumn Motorizado;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Horario;
        private Button btnBuscMot;
    }
}
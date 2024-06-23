namespace Proyecto_Minerva
{
    partial class Proveedor
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnBuscProov = new Button();
            groupBox2 = new GroupBox();
            textBox6 = new TextBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            RUC = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Rubro = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(245, 7);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 0;
            label1.Text = "Proveedores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 22);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 52);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "RUC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 80);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Rubro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 56);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 79);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(87, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(87, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(75, 51);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(83, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(75, 77);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(93, 23);
            textBox5.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(441, 13);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 11;
            label7.Text = "Fecha";
            // 
            // button1
            // 
            button1.Location = new Point(15, 9);
            button1.Name = "button1";
            button1.Size = new Size(114, 31);
            button1.TabIndex = 12;
            button1.Text = "Nuevo proveedor";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(591, 60);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(591, 89);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 14;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(591, 118);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 15;
            button4.Text = "Remover";
            button4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(497, 7);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(98, 23);
            dateTimePicker1.TabIndex = 16;
            dateTimePicker1.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(btnBuscProov);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(10, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 167);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info personal";
            // 
            // btnBuscProov
            // 
            btnBuscProov.Location = new Point(181, 50);
            btnBuscProov.Name = "btnBuscProov";
            btnBuscProov.Size = new Size(70, 23);
            btnBuscProov.TabIndex = 9;
            btnBuscProov.Text = "Buscar";
            btnBuscProov.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(308, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(229, 107);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Contacto";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(75, 22);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(148, 23);
            textBox6.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 26);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 11;
            label8.Text = "Direccion";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RUC, Nombre, Rubro, Direccion, Telefono, Email });
            dataGridView1.Location = new Point(35, 229);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(569, 102);
            dataGridView1.TabIndex = 19;
            // 
            // RUC
            // 
            RUC.HeaderText = "RUC";
            RUC.Name = "RUC";
            RUC.Width = 65;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombres";
            Nombre.Name = "Nombre";
            Nombre.Width = 120;
            // 
            // Rubro
            // 
            Rubro.HeaderText = "Rubro";
            Rubro.Name = "Rubro";
            Rubro.Width = 65;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.Width = 135;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.Width = 65;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.Width = 75;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(87, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(87, 23);
            comboBox1.TabIndex = 10;
            // 
            // Proveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 363);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Proveedor";
            Text = "Proveedor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private Button btnBuscProov;
        private GroupBox groupBox2;
        private TextBox textBox6;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn RUC;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Rubro;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Email;
        private ComboBox comboBox1;
    }
}
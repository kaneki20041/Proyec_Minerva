namespace Proyecto_Minerva
{
    partial class Registrocliente
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
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            DNI = new DataGridViewTextBoxColumn();
            Nombres_Apellido = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Celular = new DataGridViewTextBoxColumn();
            btn_AgregarCliente = new Button();
            btnModifCliente = new Button();
            btnInhabilitarCliente = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            groupBox2 = new GroupBox();
            btnNuevoCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(273, 4);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "Registro Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 23);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombres  y Apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 52);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 79);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 57);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "Celular";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 28);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(502, 14);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 7;
            label8.Text = "F. Registro";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(570, 8);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(98, 23);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DNI, Nombres_Apellido, Direccion, Email, Celular });
            dataGridView1.Location = new Point(22, 287);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(687, 77);
            dataGridView1.TabIndex = 15;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            DNI.Width = 60;
            // 
            // Nombres_Apellido
            // 
            Nombres_Apellido.HeaderText = "Nombre y Apellidos";
            Nombres_Apellido.Name = "Nombres_Apellido";
            Nombres_Apellido.Width = 215;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.Width = 190;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.Width = 80;
            // 
            // Celular
            // 
            Celular.HeaderText = "Celular";
            Celular.Name = "Celular";
            Celular.Width = 70;
            // 
            // btn_AgregarCliente
            // 
            btn_AgregarCliente.Location = new Point(593, 56);
            btn_AgregarCliente.Name = "btn_AgregarCliente";
            btn_AgregarCliente.Size = new Size(75, 23);
            btn_AgregarCliente.TabIndex = 16;
            btn_AgregarCliente.Text = "Agregar";
            btn_AgregarCliente.UseVisualStyleBackColor = true;
            // 
            // btnModifCliente
            // 
            btnModifCliente.Location = new Point(593, 85);
            btnModifCliente.Name = "btnModifCliente";
            btnModifCliente.Size = new Size(75, 23);
            btnModifCliente.TabIndex = 17;
            btnModifCliente.Text = "Modificar";
            btnModifCliente.UseVisualStyleBackColor = true;
            // 
            // btnInhabilitarCliente
            // 
            btnInhabilitarCliente.Location = new Point(593, 114);
            btnInhabilitarCliente.Name = "btnInhabilitarCliente";
            btnInhabilitarCliente.Size = new Size(75, 23);
            btnInhabilitarCliente.TabIndex = 18;
            btnInhabilitarCliente.Text = "Inhabilitar";
            btnInhabilitarCliente.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(68, 25);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(109, 23);
            textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(68, 54);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(366, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(208, 96);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contacto";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(132, 19);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(205, 23);
            textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(132, 48);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 24;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(132, 79);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(205, 23);
            textBox6.TabIndex = 25;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(15, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 162);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion personal";
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.Location = new Point(22, 7);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(102, 23);
            btnNuevoCliente.TabIndex = 27;
            btnNuevoCliente.Text = "Nuevo Cliente";
            btnNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // Registrocliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(741, 385);
            Controls.Add(btnNuevoCliente);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnInhabilitarCliente);
            Controls.Add(btnModifCliente);
            Controls.Add(btn_AgregarCliente);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registrocliente";
            Text = "Registrocliente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Button btn_AgregarCliente;
        private Button btnModifCliente;
        private Button btnInhabilitarCliente;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private GroupBox groupBox2;
        private Button btnNuevoCliente;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Nombres_Apellido;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Celular;
    }
}
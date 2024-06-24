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
            btn_AgregarCliente = new Button();
            btnModifCliente = new Button();
            btnInhabilitarCliente = new Button();
            txtEmail = new TextBox();
            txtCel = new TextBox();
            groupBox1 = new GroupBox();
            txtIdCliente = new TextBox();
            txtNombre = new TextBox();
            groupBox2 = new GroupBox();
            txtDireccion = new TextBox();
            label11 = new Label();
            txtDocumento = new TextBox();
            label10 = new Label();
            txtApellido = new TextBox();
            label9 = new Label();
            btnNuevoCliente = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label7 = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(291, 4);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "Registro Clientes";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 24);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "ID cliente";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 52);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 85);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Nombres";
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
            label8.Location = new Point(528, 14);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 7;
            label8.Text = "F. Registro";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(614, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(98, 23);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(769, 150);
            dataGridView1.TabIndex = 15;
            // 
            // btn_AgregarCliente
            // 
            btn_AgregarCliente.Location = new Point(683, 64);
            btn_AgregarCliente.Name = "btn_AgregarCliente";
            btn_AgregarCliente.Size = new Size(75, 23);
            btn_AgregarCliente.TabIndex = 16;
            btn_AgregarCliente.Text = "Agregar";
            btn_AgregarCliente.UseVisualStyleBackColor = true;
            // 
            // btnModifCliente
            // 
            btnModifCliente.Location = new Point(683, 93);
            btnModifCliente.Name = "btnModifCliente";
            btnModifCliente.Size = new Size(75, 23);
            btnModifCliente.TabIndex = 17;
            btnModifCliente.Text = "Modificar";
            btnModifCliente.UseVisualStyleBackColor = true;
            // 
            // btnInhabilitarCliente
            // 
            btnInhabilitarCliente.Location = new Point(683, 122);
            btnInhabilitarCliente.Name = "btnInhabilitarCliente";
            btnInhabilitarCliente.Size = new Size(75, 23);
            btnInhabilitarCliente.TabIndex = 18;
            btnInhabilitarCliente.Text = "Inhabilitar";
            btnInhabilitarCliente.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(68, 25);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 23);
            txtEmail.TabIndex = 20;
            // 
            // txtCel
            // 
            txtCel.Location = new Point(68, 54);
            txtCel.Name = "txtCel";
            txtCel.Size = new Size(118, 23);
            txtCel.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCel);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(410, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 123);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contacto";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(98, 22);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(80, 23);
            txtIdCliente.TabIndex = 23;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 118);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(158, 23);
            txtNombre.TabIndex = 25;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(txtDocumento);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(txtIdCliente);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(22, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(369, 154);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion personal";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(69, 86);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(179, 23);
            txtDireccion.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 89);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 32;
            label11.Text = "Dirección";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(259, 50);
            txtDocumento.Margin = new Padding(3, 2, 3, 2);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(104, 23);
            txtDocumento.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(186, 25);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 28;
            label10.Text = "Documento";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(98, 82);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(158, 23);
            txtApellido.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 120);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 26;
            label9.Text = "Apellidos";
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(98, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(92, 23);
            comboBox1.TabIndex = 34;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(259, 22);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(99, 23);
            comboBox2.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(199, 54);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 36;
            label7.Text = "Nº Doc";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(439, 177);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 19);
            checkBox1.TabIndex = 28;
            checkBox1.Text = "Estado Cliente";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Registrocliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(793, 385);
            Controls.Add(checkBox1);
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
            Load += Registrocliente_Load;
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
        private TextBox txtEmail;
        private TextBox txtCel;
        private GroupBox groupBox1;
        private TextBox txtIdCliente;
        private TextBox txtNombre;
        private GroupBox groupBox2;
        private Button btnNuevoCliente;
        private TextBox txtDocumento;
        private Label label10;
        private TextBox txtApellido;
        private Label label9;
        private TextBox txtDireccion;
        private Label label11;
        private Label label7;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
    }
}
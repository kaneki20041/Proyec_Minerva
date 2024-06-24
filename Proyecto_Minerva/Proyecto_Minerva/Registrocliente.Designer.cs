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
            txtEmail = new TextBox();
            txtCel = new TextBox();
            groupBox1 = new GroupBox();
            txtIdCliente = new TextBox();
            txtNombre = new TextBox();
            groupBox2 = new GroupBox();
            btnNuevoCliente = new Button();
            groupBox3 = new GroupBox();
            label7 = new Label();
            dateTimePicker3 = new DateTimePicker();
            label9 = new Label();
            txtApellido = new TextBox();
            label10 = new Label();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            txtTipoCliente = new TextBox();
            label11 = new Label();
            txtDireccion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(333, 6);
            label1.Name = "label1";
            label1.Size = new Size(174, 30);
            label1.TabIndex = 0;
            label1.Text = "Registro Clientes";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 32);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "ID cliente";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 69);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "Tipo Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 108);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Nombres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 76);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 4;
            label5.Text = "Celular";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 37);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(604, 19);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 7;
            label8.Text = "F. Registro";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(702, 14);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(111, 27);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DNI, Nombres_Apellido, Direccion, Email, Celular });
            dataGridView1.Location = new Point(12, 382);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(855, 103);
            dataGridView1.TabIndex = 15;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.MinimumWidth = 6;
            DNI.Name = "DNI";
            DNI.Width = 60;
            // 
            // Nombres_Apellido
            // 
            Nombres_Apellido.HeaderText = "Nombre y Apellidos";
            Nombres_Apellido.MinimumWidth = 6;
            Nombres_Apellido.Name = "Nombres_Apellido";
            Nombres_Apellido.Width = 215;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.Width = 190;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 80;
            // 
            // Celular
            // 
            Celular.HeaderText = "Celular";
            Celular.MinimumWidth = 6;
            Celular.Name = "Celular";
            Celular.Width = 70;
            // 
            // btn_AgregarCliente
            // 
            btn_AgregarCliente.Location = new Point(781, 75);
            btn_AgregarCliente.Margin = new Padding(3, 4, 3, 4);
            btn_AgregarCliente.Name = "btn_AgregarCliente";
            btn_AgregarCliente.Size = new Size(86, 31);
            btn_AgregarCliente.TabIndex = 16;
            btn_AgregarCliente.Text = "Agregar";
            btn_AgregarCliente.UseVisualStyleBackColor = true;
            // 
            // btnModifCliente
            // 
            btnModifCliente.Location = new Point(781, 113);
            btnModifCliente.Margin = new Padding(3, 4, 3, 4);
            btnModifCliente.Name = "btnModifCliente";
            btnModifCliente.Size = new Size(86, 31);
            btnModifCliente.TabIndex = 17;
            btnModifCliente.Text = "Modificar";
            btnModifCliente.UseVisualStyleBackColor = true;
            // 
            // btnInhabilitarCliente
            // 
            btnInhabilitarCliente.Location = new Point(781, 152);
            btnInhabilitarCliente.Margin = new Padding(3, 4, 3, 4);
            btnInhabilitarCliente.Name = "btnInhabilitarCliente";
            btnInhabilitarCliente.Size = new Size(86, 31);
            btnInhabilitarCliente.TabIndex = 18;
            btnInhabilitarCliente.Text = "Inhabilitar";
            btnInhabilitarCliente.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(78, 33);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(186, 27);
            txtEmail.TabIndex = 20;
            // 
            // txtCel
            // 
            txtCel.Location = new Point(78, 72);
            txtCel.Margin = new Padding(3, 4, 3, 4);
            txtCel.Name = "txtCel";
            txtCel.Size = new Size(134, 27);
            txtCel.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCel);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(470, 55);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(289, 128);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contacto";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(139, 29);
            txtIdCliente.Margin = new Padding(3, 4, 3, 4);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(114, 27);
            txtIdCliente.TabIndex = 23;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(139, 108);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(272, 27);
            txtNombre.TabIndex = 25;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDireccion);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtTipoCliente);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(txtIdCliente);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(17, 55);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(431, 302);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion personal";
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.Location = new Point(25, 9);
            btnNuevoCliente.Margin = new Padding(3, 4, 3, 4);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(117, 31);
            btnNuevoCliente.TabIndex = 27;
            btnNuevoCliente.Text = "Nuevo Cliente";
            btnNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateTimePicker3);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(470, 208);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(238, 127);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos adicionales";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 34);
            label7.Name = "label7";
            label7.Size = new Size(150, 20);
            label7.TabIndex = 0;
            label7.Text = "Fecha registro cliente";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "dd-MM-yyyy";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(30, 72);
            dateTimePicker3.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(111, 27);
            dateTimePicker3.TabIndex = 29;
            dateTimePicker3.UseWaitCursor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 156);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 26;
            label9.Text = "Apellidos";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(139, 153);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(272, 27);
            txtApellido.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 207);
            label10.Name = "label10";
            label10.Size = new Size(87, 20);
            label10.TabIndex = 28;
            label10.Text = "Documento";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(139, 204);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(112, 27);
            textBox5.TabIndex = 29;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(261, 204);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 27);
            textBox7.TabIndex = 30;
            // 
            // txtTipoCliente
            // 
            txtTipoCliente.Location = new Point(139, 69);
            txtTipoCliente.Margin = new Padding(3, 4, 3, 4);
            txtTipoCliente.Multiline = true;
            txtTipoCliente.Name = "txtTipoCliente";
            txtTipoCliente.Size = new Size(114, 27);
            txtTipoCliente.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 250);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 32;
            label11.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(139, 250);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(272, 27);
            txtDireccion.TabIndex = 33;
            // 
            // Registrocliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(906, 513);
            Controls.Add(groupBox3);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Registrocliente";
            Text = "Registrocliente";
            Load += Registrocliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Nombres_Apellido;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Celular;
        private GroupBox groupBox3;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBox5;
        private Label label10;
        private TextBox txtApellido;
        private Label label9;
        private DateTimePicker dateTimePicker3;
        private TextBox txtDireccion;
        private Label label11;
        private TextBox txtTipoCliente;
    }
}
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dgvCliente = new DataGridView();
            btn_AgregarCliente = new Button();
            btnModifCliente = new Button();
            btnInhabilitarCliente = new Button();
            txtEmail = new TextBox();
            txtCel = new TextBox();
            groupBox1 = new GroupBox();
            label11 = new Label();
            txtDireccion = new TextBox();
            txtBuscarIDCli = new TextBox();
            txtNombre = new TextBox();
            groupBox2 = new GroupBox();
            chkEstado = new CheckBox();
            btnBuscarCli = new Button();
            label7 = new Label();
            cbxDocumento = new ComboBox();
            cbxTipoCliente = new ComboBox();
            txtDocumento = new TextBox();
            label10 = new Label();
            txtApellido = new TextBox();
            label9 = new Label();
            btnNuevoCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 32);
            label2.Name = "label2";
            label2.Size = new Size(20, 17);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 60);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 2;
            label3.Text = "Tipo Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 91);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 3;
            label4.Text = "Nombres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 96);
            label5.Name = "label5";
            label5.Size = new Size(50, 17);
            label5.TabIndex = 4;
            label5.Text = "Celular";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 67);
            label6.Name = "label6";
            label6.Size = new Size(39, 17);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(681, 15);
            label8.Name = "label8";
            label8.Size = new Size(45, 17);
            label8.TabIndex = 7;
            label8.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(734, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(98, 23);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.UseWaitCursor = true;
            // 
            // dgvCliente
            // 
            dgvCliente.BackgroundColor = Color.MintCream;
            dgvCliente.BorderStyle = BorderStyle.None;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(21, 260);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersWidth = 51;
            dgvCliente.RowTemplate.Height = 25;
            dgvCliente.Size = new Size(680, 296);
            dgvCliente.TabIndex = 15;
            // 
            // btn_AgregarCliente
            // 
            btn_AgregarCliente.BackColor = Color.PowderBlue;
            btn_AgregarCliente.FlatAppearance.BorderSize = 0;
            btn_AgregarCliente.FlatStyle = FlatStyle.Flat;
            btn_AgregarCliente.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AgregarCliente.Location = new Point(725, 353);
            btn_AgregarCliente.Name = "btn_AgregarCliente";
            btn_AgregarCliente.Size = new Size(98, 40);
            btn_AgregarCliente.TabIndex = 16;
            btn_AgregarCliente.Text = "Agregar";
            btn_AgregarCliente.UseVisualStyleBackColor = false;
            btn_AgregarCliente.Click += btn_AgregarCliente_Click;
            // 
            // btnModifCliente
            // 
            btnModifCliente.BackColor = Color.PowderBlue;
            btnModifCliente.FlatAppearance.BorderSize = 0;
            btnModifCliente.FlatStyle = FlatStyle.Flat;
            btnModifCliente.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModifCliente.Location = new Point(725, 399);
            btnModifCliente.Name = "btnModifCliente";
            btnModifCliente.Size = new Size(98, 40);
            btnModifCliente.TabIndex = 17;
            btnModifCliente.Text = "Modificar";
            btnModifCliente.UseVisualStyleBackColor = false;
            btnModifCliente.Click += btnModifCliente_Click;
            // 
            // btnInhabilitarCliente
            // 
            btnInhabilitarCliente.BackColor = Color.PowderBlue;
            btnInhabilitarCliente.FlatAppearance.BorderSize = 0;
            btnInhabilitarCliente.FlatStyle = FlatStyle.Flat;
            btnInhabilitarCliente.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInhabilitarCliente.Location = new Point(725, 445);
            btnInhabilitarCliente.Name = "btnInhabilitarCliente";
            btnInhabilitarCliente.Size = new Size(98, 40);
            btnInhabilitarCliente.TabIndex = 18;
            btnInhabilitarCliente.Text = "Inhabilitar";
            btnInhabilitarCliente.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(93, 64);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 22);
            txtEmail.TabIndex = 20;
            // 
            // txtCel
            // 
            txtCel.Location = new Point(93, 93);
            txtCel.Name = "txtCel";
            txtCel.Size = new Size(163, 22);
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
            groupBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(426, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 215);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contacto";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 125);
            label11.Name = "label11";
            label11.Size = new Size(66, 17);
            label11.TabIndex = 32;
            label11.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(93, 122);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(163, 22);
            txtDireccion.TabIndex = 33;
            // 
            // txtBuscarIDCli
            // 
            txtBuscarIDCli.Location = new Point(107, 29);
            txtBuscarIDCli.Name = "txtBuscarIDCli";
            txtBuscarIDCli.Size = new Size(158, 22);
            txtBuscarIDCli.TabIndex = 23;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(158, 22);
            txtNombre.TabIndex = 25;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkEstado);
            groupBox2.Controls.Add(btnBuscarCli);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cbxDocumento);
            groupBox2.Controls.Add(cbxTipoCliente);
            groupBox2.Controls.Add(txtDocumento);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(txtBuscarIDCli);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(21, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(385, 215);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(290, 118);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(67, 21);
            chkEstado.TabIndex = 28;
            chkEstado.Text = "Estado";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCli
            // 
            btnBuscarCli.BackColor = Color.LightCyan;
            btnBuscarCli.FlatAppearance.BorderSize = 0;
            btnBuscarCli.FlatStyle = FlatStyle.Flat;
            btnBuscarCli.Location = new Point(281, 28);
            btnBuscarCli.Margin = new Padding(3, 2, 3, 2);
            btnBuscarCli.Name = "btnBuscarCli";
            btnBuscarCli.Size = new Size(82, 23);
            btnBuscarCli.TabIndex = 37;
            btnBuscarCli.Text = "Buscar";
            btnBuscarCli.UseVisualStyleBackColor = false;
            btnBuscarCli.Click += btnBuscarCli_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 182);
            label7.Name = "label7";
            label7.Size = new Size(49, 17);
            label7.TabIndex = 36;
            label7.Text = "Nº Doc";
            // 
            // cbxDocumento
            // 
            cbxDocumento.FormattingEnabled = true;
            cbxDocumento.Location = new Point(107, 146);
            cbxDocumento.Name = "cbxDocumento";
            cbxDocumento.Size = new Size(158, 25);
            cbxDocumento.TabIndex = 35;
            // 
            // cbxTipoCliente
            // 
            cbxTipoCliente.FormattingEnabled = true;
            cbxTipoCliente.Location = new Point(107, 57);
            cbxTipoCliente.Name = "cbxTipoCliente";
            cbxTipoCliente.Size = new Size(158, 25);
            cbxTipoCliente.TabIndex = 34;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(107, 179);
            txtDocumento.Margin = new Padding(3, 2, 3, 2);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(158, 22);
            txtDocumento.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 149);
            label10.Name = "label10";
            label10.Size = new Size(79, 17);
            label10.TabIndex = 28;
            label10.Text = "Documento";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(107, 116);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(158, 22);
            txtApellido.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 119);
            label9.Name = "label9";
            label9.Size = new Size(63, 17);
            label9.TabIndex = 26;
            label9.Text = "Apellidos";
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.PowderBlue;
            btnNuevoCliente.FlatAppearance.BorderSize = 0;
            btnNuevoCliente.FlatStyle = FlatStyle.Flat;
            btnNuevoCliente.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoCliente.Location = new Point(725, 307);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(98, 40);
            btnNuevoCliente.TabIndex = 27;
            btnNuevoCliente.Text = "Nuevo";
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // Registrocliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(851, 573);
            Controls.Add(btnNuevoCliente);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnInhabilitarCliente);
            Controls.Add(btnModifCliente);
            Controls.Add(btn_AgregarCliente);
            Controls.Add(dgvCliente);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registrocliente";
            Text = "Registrocliente";
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgvCliente;
        private Button btn_AgregarCliente;
        private Button btnModifCliente;
        private Button btnInhabilitarCliente;
        private TextBox txtEmail;
        private TextBox txtCel;
        private GroupBox groupBox1;
        private TextBox txtBuscarIDCli;
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
        private ComboBox cbxDocumento;
        private ComboBox cbxTipoCliente;
        private CheckBox chkEstado;
        private Button btnBuscarCli;
    }
}
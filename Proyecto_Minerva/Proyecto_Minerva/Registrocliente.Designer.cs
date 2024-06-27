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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btn_AgregarCliente = new System.Windows.Forms.Button();
            this.btnModifCliente = new System.Windows.Forms.Button();
            this.btnInhabilitarCliente = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtBuscarIDCli = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxDocumento = new System.Windows.Forms.ComboBox();
            this.cbxTipoCliente = new System.Windows.Forms.ComboBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(333, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(603, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "F. Registro";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(702, 13);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 27);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.UseWaitCursor = true;
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(14, 277);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.RowTemplate.Height = 25;
            this.dgvCliente.Size = new System.Drawing.Size(879, 200);
            this.dgvCliente.TabIndex = 15;
            // 
            // btn_AgregarCliente
            // 
            this.btn_AgregarCliente.Location = new System.Drawing.Point(870, 88);
            this.btn_AgregarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.Size = new System.Drawing.Size(86, 31);
            this.btn_AgregarCliente.TabIndex = 16;
            this.btn_AgregarCliente.Text = "Agregar";
            this.btn_AgregarCliente.UseVisualStyleBackColor = true;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_AgregarCliente_Click);
            // 
            // btnModifCliente
            // 
            this.btnModifCliente.Location = new System.Drawing.Point(870, 127);
            this.btnModifCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModifCliente.Name = "btnModifCliente";
            this.btnModifCliente.Size = new System.Drawing.Size(86, 31);
            this.btnModifCliente.TabIndex = 17;
            this.btnModifCliente.Text = "Modificar";
            this.btnModifCliente.UseVisualStyleBackColor = true;
            this.btnModifCliente.Click += new System.EventHandler(this.btnModifCliente_Click);
            // 
            // btnInhabilitarCliente
            // 
            this.btnInhabilitarCliente.Location = new System.Drawing.Point(870, 166);
            this.btnInhabilitarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInhabilitarCliente.Name = "btnInhabilitarCliente";
            this.btnInhabilitarCliente.Size = new System.Drawing.Size(86, 31);
            this.btnInhabilitarCliente.TabIndex = 18;
            this.btnInhabilitarCliente.Text = "Inhabilitar";
            this.btnInhabilitarCliente.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(78, 33);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 27);
            this.txtEmail.TabIndex = 20;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(78, 72);
            this.txtCel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(134, 27);
            this.txtCel.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(558, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(289, 164);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contacto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(79, 115);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(204, 27);
            this.txtDireccion.TabIndex = 33;
            // 
            // txtBuscarIDCli
            // 
            this.txtBuscarIDCli.Location = new System.Drawing.Point(112, 29);
            this.txtBuscarIDCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscarIDCli.Name = "txtBuscarIDCli";
            this.txtBuscarIDCli.Size = new System.Drawing.Size(91, 27);
            this.txtBuscarIDCli.TabIndex = 23;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 112);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 27);
            this.txtNombre.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarCli);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbxDocumento);
            this.groupBox2.Controls.Add(this.cbxTipoCliente);
            this.groupBox2.Controls.Add(this.txtDocumento);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtApellido);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.txtBuscarIDCli);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(25, 64);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(527, 205);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion personal";
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.Location = new System.Drawing.Point(223, 28);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(94, 29);
            this.btnBuscarCli.TabIndex = 37;
            this.btnBuscarCli.Text = "Buscar";
            this.btnBuscarCli.UseVisualStyleBackColor = true;
            this.btnBuscarCli.Click += new System.EventHandler(this.btnBuscarCli_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Nº Doc";
            // 
            // cbxDocumento
            // 
            this.cbxDocumento.FormattingEnabled = true;
            this.cbxDocumento.Location = new System.Drawing.Point(378, 79);
            this.cbxDocumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxDocumento.Name = "cbxDocumento";
            this.cbxDocumento.Size = new System.Drawing.Size(113, 28);
            this.cbxDocumento.TabIndex = 35;
            // 
            // cbxTipoCliente
            // 
            this.cbxTipoCliente.FormattingEnabled = true;
            this.cbxTipoCliente.Location = new System.Drawing.Point(112, 68);
            this.cbxTipoCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxTipoCliente.Name = "cbxTipoCliente";
            this.cbxTipoCliente.Size = new System.Drawing.Size(105, 28);
            this.cbxTipoCliente.TabIndex = 34;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(378, 117);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(118, 27);
            this.txtDocumento.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Documento";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(112, 160);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 27);
            this.txtApellido.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Apellidos";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(25, 9);
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(117, 31);
            this.btnNuevoCliente.TabIndex = 27;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(591, 239);
            this.chkEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(126, 24);
            this.chkEstado.TabIndex = 28;
            this.chkEstado.Text = "Estado Cliente";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // Registrocliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1040, 513);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInhabilitarCliente);
            this.Controls.Add(this.btnModifCliente);
            this.Controls.Add(this.btn_AgregarCliente);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Registrocliente";
            this.Text = "Registrocliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
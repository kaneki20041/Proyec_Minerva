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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            label7 = new Label();
            btnNuevo = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnInhabilitar = new Button();
            dateTimePicker1 = new DateTimePicker();
            grupBoxDatos = new GroupBox();
            btnBuscarPorRUC = new Button();
            cbEstado = new CheckBox();
            txtRazonSocial = new TextBox();
            txtRUC = new TextBox();
            label11 = new Label();
            comboBoxRubro = new ComboBox();
            btnBuscProov = new Button();
            grupBoxDatos2 = new GroupBox();
            txtDireccion = new TextBox();
            label8 = new Label();
            label10 = new Label();
            dvgProveedor = new DataGridView();
            label1 = new Label();
            txtCodigoUbigeo = new TextBox();
            groupBoxUbigeo = new GroupBox();
            btnBuscUbigeo = new Button();
            txtProvincia = new TextBox();
            txtDistrito = new TextBox();
            label13 = new Label();
            label12 = new Label();
            txtDepartamento = new TextBox();
            btnCancelar = new Button();
            grupBoxDatos.SuspendLayout();
            grupBoxDatos2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgProveedor).BeginInit();
            groupBoxUbigeo.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 65);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 1;
            label2.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 156);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 2;
            label3.Text = "RUC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 96);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 3;
            label4.Text = "Rubro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 54);
            label5.Name = "label5";
            label5.Size = new Size(59, 17);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 83);
            label6.Name = "label6";
            label6.Size = new Size(39, 17);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(105, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(218, 22);
            txtNombre.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(78, 77);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(174, 22);
            txtEmail.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(78, 49);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(174, 22);
            txtTelefono.TabIndex = 10;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(681, 15);
            label7.Name = "label7";
            label7.Size = new Size(45, 17);
            label7.TabIndex = 11;
            label7.Text = "Fecha";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.PowderBlue;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.Location = new Point(736, 296);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 44);
            btnNuevo.TabIndex = 12;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.PowderBlue;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(736, 346);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 44);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.PowderBlue;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(736, 396);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 44);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnInhabilitar
            // 
            btnInhabilitar.BackColor = Color.PowderBlue;
            btnInhabilitar.FlatAppearance.BorderSize = 0;
            btnInhabilitar.FlatStyle = FlatStyle.Flat;
            btnInhabilitar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInhabilitar.Location = new Point(736, 446);
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Size = new Size(94, 44);
            btnInhabilitar.TabIndex = 15;
            btnInhabilitar.Text = "Inhabilitar";
            btnInhabilitar.UseVisualStyleBackColor = false;
            btnInhabilitar.Click += btnInhabilitar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(732, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(98, 23);
            dateTimePicker1.TabIndex = 16;
            dateTimePicker1.UseWaitCursor = true;
            // 
            // grupBoxDatos
            // 
            grupBoxDatos.Controls.Add(btnBuscarPorRUC);
            grupBoxDatos.Controls.Add(cbEstado);
            grupBoxDatos.Controls.Add(txtRazonSocial);
            grupBoxDatos.Controls.Add(txtRUC);
            grupBoxDatos.Controls.Add(label11);
            grupBoxDatos.Controls.Add(comboBoxRubro);
            grupBoxDatos.Controls.Add(btnBuscProov);
            grupBoxDatos.Controls.Add(txtNombre);
            grupBoxDatos.Controls.Add(label4);
            grupBoxDatos.Controls.Add(label3);
            grupBoxDatos.Controls.Add(label2);
            grupBoxDatos.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grupBoxDatos.Location = new Point(12, 35);
            grupBoxDatos.Name = "grupBoxDatos";
            grupBoxDatos.Size = new Size(424, 238);
            grupBoxDatos.TabIndex = 17;
            grupBoxDatos.TabStop = false;
            grupBoxDatos.Text = "Informacion";
            // 
            // btnBuscarPorRUC
            // 
            btnBuscarPorRUC.BackColor = Color.LightCyan;
            btnBuscarPorRUC.FlatAppearance.BorderSize = 0;
            btnBuscarPorRUC.FlatStyle = FlatStyle.Flat;
            btnBuscarPorRUC.Location = new Point(329, 153);
            btnBuscarPorRUC.Name = "btnBuscarPorRUC";
            btnBuscarPorRUC.Size = new Size(70, 23);
            btnBuscarPorRUC.TabIndex = 22;
            btnBuscarPorRUC.Text = "Buscar";
            btnBuscarPorRUC.UseVisualStyleBackColor = false;
            btnBuscarPorRUC.Click += btnBuscarPorRUC_Click;
            // 
            // cbEstado
            // 
            cbEstado.AutoSize = true;
            cbEstado.Checked = true;
            cbEstado.CheckState = CheckState.Checked;
            cbEstado.Location = new Point(105, 186);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(67, 21);
            cbEstado.TabIndex = 21;
            cbEstado.Text = "Estado";
            cbEstado.UseVisualStyleBackColor = true;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(105, 125);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(218, 22);
            txtRazonSocial.TabIndex = 14;
            // 
            // txtRUC
            // 
            txtRUC.Location = new Point(105, 153);
            txtRUC.Name = "txtRUC";
            txtRUC.Size = new Size(218, 22);
            txtRUC.TabIndex = 13;
            txtRUC.KeyPress += txtRUC_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 128);
            label11.Name = "label11";
            label11.Size = new Size(83, 17);
            label11.TabIndex = 12;
            label11.Text = "Razon Social";
            // 
            // comboBoxRubro
            // 
            comboBoxRubro.FormattingEnabled = true;
            comboBoxRubro.Location = new Point(105, 93);
            comboBoxRubro.Name = "comboBoxRubro";
            comboBoxRubro.Size = new Size(218, 25);
            comboBoxRubro.TabIndex = 10;
            // 
            // btnBuscProov
            // 
            btnBuscProov.BackColor = Color.LightCyan;
            btnBuscProov.FlatAppearance.BorderSize = 0;
            btnBuscProov.FlatStyle = FlatStyle.Flat;
            btnBuscProov.Location = new Point(329, 62);
            btnBuscProov.Name = "btnBuscProov";
            btnBuscProov.Size = new Size(70, 23);
            btnBuscProov.TabIndex = 9;
            btnBuscProov.Text = "Buscar";
            btnBuscProov.UseVisualStyleBackColor = false;
            btnBuscProov.Click += btnBuscProov_Click;
            // 
            // grupBoxDatos2
            // 
            grupBoxDatos2.Controls.Add(txtDireccion);
            grupBoxDatos2.Controls.Add(label8);
            grupBoxDatos2.Controls.Add(txtTelefono);
            grupBoxDatos2.Controls.Add(txtEmail);
            grupBoxDatos2.Controls.Add(label6);
            grupBoxDatos2.Controls.Add(label5);
            grupBoxDatos2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grupBoxDatos2.Location = new Point(447, 35);
            grupBoxDatos2.Name = "grupBoxDatos2";
            grupBoxDatos2.Size = new Size(374, 112);
            grupBoxDatos2.TabIndex = 18;
            grupBoxDatos2.TabStop = false;
            grupBoxDatos2.Text = "Contacto";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(78, 21);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(290, 22);
            txtDireccion.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 24);
            label8.Name = "label8";
            label8.Size = new Size(66, 17);
            label8.TabIndex = 11;
            label8.Text = "Direccion";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 85);
            label10.Name = "label10";
            label10.Size = new Size(51, 17);
            label10.TabIndex = 20;
            label10.Text = "Ciudad";
            // 
            // dvgProveedor
            // 
            dvgProveedor.BackgroundColor = Color.MintCream;
            dvgProveedor.BorderStyle = BorderStyle.None;
            dvgProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProveedor.Location = new Point(12, 279);
            dvgProveedor.Name = "dvgProveedor";
            dvgProveedor.RowHeadersWidth = 51;
            dvgProveedor.RowTemplate.Height = 25;
            dvgProveedor.Size = new Size(699, 282);
            dvgProveedor.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 24);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 22;
            label1.Text = "Ubigeo";
            // 
            // txtCodigoUbigeo
            // 
            txtCodigoUbigeo.Location = new Point(106, 21);
            txtCodigoUbigeo.Name = "txtCodigoUbigeo";
            txtCodigoUbigeo.Size = new Size(87, 22);
            txtCodigoUbigeo.TabIndex = 23;
            // 
            // groupBoxUbigeo
            // 
            groupBoxUbigeo.Controls.Add(btnBuscUbigeo);
            groupBoxUbigeo.Controls.Add(txtProvincia);
            groupBoxUbigeo.Controls.Add(txtDistrito);
            groupBoxUbigeo.Controls.Add(label13);
            groupBoxUbigeo.Controls.Add(label12);
            groupBoxUbigeo.Controls.Add(txtDepartamento);
            groupBoxUbigeo.Controls.Add(label10);
            groupBoxUbigeo.Controls.Add(txtCodigoUbigeo);
            groupBoxUbigeo.Controls.Add(label1);
            groupBoxUbigeo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxUbigeo.Location = new Point(447, 153);
            groupBoxUbigeo.Name = "groupBoxUbigeo";
            groupBoxUbigeo.Size = new Size(392, 120);
            groupBoxUbigeo.TabIndex = 24;
            groupBoxUbigeo.TabStop = false;
            groupBoxUbigeo.Text = "Ubigeo";
            // 
            // btnBuscUbigeo
            // 
            btnBuscUbigeo.BackColor = Color.LightCyan;
            btnBuscUbigeo.FlatAppearance.BorderSize = 0;
            btnBuscUbigeo.FlatStyle = FlatStyle.Flat;
            btnBuscUbigeo.Location = new Point(199, 21);
            btnBuscUbigeo.Name = "btnBuscUbigeo";
            btnBuscUbigeo.Size = new Size(64, 22);
            btnBuscUbigeo.TabIndex = 22;
            btnBuscUbigeo.Text = "Buscar";
            btnBuscUbigeo.UseVisualStyleBackColor = false;
            btnBuscUbigeo.Click += btnBuscUbigeo_Click;
            // 
            // txtProvincia
            // 
            txtProvincia.Location = new Point(257, 82);
            txtProvincia.Name = "txtProvincia";
            txtProvincia.Size = new Size(122, 22);
            txtProvincia.TabIndex = 28;
            // 
            // txtDistrito
            // 
            txtDistrito.Location = new Point(67, 82);
            txtDistrito.Name = "txtDistrito";
            txtDistrito.Size = new Size(121, 22);
            txtDistrito.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 55);
            label13.Name = "label13";
            label13.Size = new Size(97, 17);
            label13.TabIndex = 26;
            label13.Text = "Departamento";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(191, 85);
            label12.Name = "label12";
            label12.Size = new Size(64, 17);
            label12.TabIndex = 25;
            label12.Text = "Provincia";
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(106, 52);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(273, 22);
            txtDepartamento.TabIndex = 24;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.PowderBlue;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(736, 496);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 44);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Proveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(851, 573);
            Controls.Add(btnCancelar);
            Controls.Add(groupBoxUbigeo);
            Controls.Add(dvgProveedor);
            Controls.Add(grupBoxDatos2);
            Controls.Add(grupBoxDatos);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnInhabilitar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(btnNuevo);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Proveedor";
            Text = "Proveedor";
            grupBoxDatos.ResumeLayout(false);
            grupBoxDatos.PerformLayout();
            grupBoxDatos2.ResumeLayout(false);
            grupBoxDatos2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgProveedor).EndInit();
            groupBoxUbigeo.ResumeLayout(false);
            groupBoxUbigeo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private Label label7;
        private Button btnNuevo;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnInhabilitar;
        private DateTimePicker dateTimePicker1;
        private GroupBox grupBoxDatos;
        private GroupBox grupBoxDatos2;
        private TextBox txtDireccion;
        private Label label8;
        private DataGridView dvgProveedor;
        private ComboBox comboBoxRubro;
        private TextBox txtRazonSocial;
        private TextBox txtRUC;
        private Label label11;
        private Button btnBuscProov;
        private Label label10;
        private CheckBox cbEstado;
        private Label label1;
        private TextBox txtCodigoUbigeo;
        private GroupBox groupBoxUbigeo;
        private Button btnBuscUbigeo;
        private TextBox txtProvincia;
        private TextBox txtDistrito;
        private Label label13;
        private Label label12;
        private TextBox txtDepartamento;
        private Button btnCancelar;
        private Button btnBuscarPorRUC;
    }
}
namespace CapaPresentacion
{
    partial class RegistroUsuarios
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
            gboDetalleUsuario = new GroupBox();
            txtUsuario = new TextBox();
            label10 = new Label();
            btnBuscarDni = new FontAwesome.Sharp.IconButton();
            txtID = new TextBox();
            label7 = new Label();
            cbEstado = new ComboBox();
            cbRol = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            txtPass = new TextBox();
            txtNombre = new TextBox();
            txtDocumento = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnInhabilitar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            dgvUsuarios = new DataGridView();
            btnCancelar = new Button();
            btnNuevoUsuari = new Button();
            dtFecha = new DateTimePicker();
            gboxBusqueda = new GroupBox();
            txtBusqueda = new TextBox();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnBuscarUsuario = new FontAwesome.Sharp.IconButton();
            cbBusqueda = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            gboDetalleUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            gboxBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // gboDetalleUsuario
            // 
            gboDetalleUsuario.Controls.Add(txtUsuario);
            gboDetalleUsuario.Controls.Add(label10);
            gboDetalleUsuario.Controls.Add(btnBuscarDni);
            gboDetalleUsuario.Controls.Add(txtID);
            gboDetalleUsuario.Controls.Add(label7);
            gboDetalleUsuario.Controls.Add(cbEstado);
            gboDetalleUsuario.Controls.Add(cbRol);
            gboDetalleUsuario.Controls.Add(label6);
            gboDetalleUsuario.Controls.Add(label5);
            gboDetalleUsuario.Controls.Add(txtCorreo);
            gboDetalleUsuario.Controls.Add(label4);
            gboDetalleUsuario.Controls.Add(txtPass);
            gboDetalleUsuario.Controls.Add(txtNombre);
            gboDetalleUsuario.Controls.Add(txtDocumento);
            gboDetalleUsuario.Controls.Add(label3);
            gboDetalleUsuario.Controls.Add(label2);
            gboDetalleUsuario.Controls.Add(label1);
            gboDetalleUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gboDetalleUsuario.Location = new Point(39, 50);
            gboDetalleUsuario.Name = "gboDetalleUsuario";
            gboDetalleUsuario.Size = new Size(548, 238);
            gboDetalleUsuario.TabIndex = 13;
            gboDetalleUsuario.TabStop = false;
            gboDetalleUsuario.Text = "Detalle del Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(253, 40);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(151, 22);
            txtUsuario.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(196, 42);
            label10.Name = "label10";
            label10.Size = new Size(51, 17);
            label10.TabIndex = 14;
            label10.Text = "Usuario";
            // 
            // btnBuscarDni
            // 
            btnBuscarDni.BackColor = Color.PowderBlue;
            btnBuscarDni.FlatStyle = FlatStyle.Popup;
            btnBuscarDni.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarDni.IconColor = Color.Black;
            btnBuscarDni.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarDni.IconSize = 15;
            btnBuscarDni.Location = new Point(241, 91);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(34, 23);
            btnBuscarDni.TabIndex = 13;
            btnBuscarDni.UseVisualStyleBackColor = false;
            btnBuscarDni.Click += btnBuscarDni_Click_1;
            // 
            // txtID
            // 
            txtID.Location = new Point(111, 42);
            txtID.Name = "txtID";
            txtID.Size = new Size(47, 22);
            txtID.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 42);
            label7.Name = "label7";
            label7.Size = new Size(20, 17);
            label7.TabIndex = 11;
            label7.Text = "ID";
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(340, 186);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(129, 25);
            cbEstado.TabIndex = 7;
            // 
            // cbRol
            // 
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(340, 135);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(132, 25);
            cbRol.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(375, 166);
            label6.Name = "label6";
            label6.Size = new Size(48, 17);
            label6.TabIndex = 10;
            label6.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 117);
            label5.Name = "label5";
            label5.Size = new Size(26, 17);
            label5.TabIndex = 9;
            label5.Text = "Rol";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(40, 141);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(195, 22);
            txtCorreo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 121);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 7;
            label4.Text = "Correo";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(40, 189);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(195, 22);
            txtPass.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(305, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 22);
            txtNombre.TabIndex = 3;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(38, 92);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(197, 22);
            txtDocumento.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 169);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 72);
            label2.Name = "label2";
            label2.Size = new Size(118, 17);
            label2.TabIndex = 2;
            label2.Text = "Nombre completo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 72);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 1;
            label1.Text = "Documento";
            // 
            // btnInhabilitar
            // 
            btnInhabilitar.BackColor = Color.PowderBlue;
            btnInhabilitar.FlatAppearance.BorderSize = 0;
            btnInhabilitar.FlatStyle = FlatStyle.Flat;
            btnInhabilitar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInhabilitar.Location = new Point(737, 453);
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Size = new Size(98, 40);
            btnInhabilitar.TabIndex = 19;
            btnInhabilitar.Text = "Inhabilitar";
            btnInhabilitar.UseVisualStyleBackColor = false;
            btnInhabilitar.Click += btnInhabilitar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.PowderBlue;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(737, 407);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 40);
            btnModificar.TabIndex = 18;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.PowderBlue;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(737, 361);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 40);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = Color.MintCream;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 294);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(701, 267);
            dgvUsuarios.TabIndex = 20;
            dgvUsuarios.CellDoubleClick += dgvUsuarios_CellDoubleClick;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.PowderBlue;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(737, 499);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 40);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnNuevoUsuari
            // 
            btnNuevoUsuari.BackColor = Color.PowderBlue;
            btnNuevoUsuari.FlatAppearance.BorderSize = 0;
            btnNuevoUsuari.FlatStyle = FlatStyle.Flat;
            btnNuevoUsuari.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoUsuari.Location = new Point(737, 315);
            btnNuevoUsuari.Name = "btnNuevoUsuari";
            btnNuevoUsuari.Size = new Size(98, 40);
            btnNuevoUsuari.TabIndex = 14;
            btnNuevoUsuari.Text = "Nuevo";
            btnNuevoUsuari.UseVisualStyleBackColor = false;
            btnNuevoUsuari.Click += btnNuevoUsuari_Click;
            // 
            // dtFecha
            // 
            dtFecha.CustomFormat = "dd-MM-yyyy";
            dtFecha.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtFecha.Format = DateTimePickerFormat.Custom;
            dtFecha.Location = new Point(737, 12);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(104, 22);
            dtFecha.TabIndex = 15;
            dtFecha.UseWaitCursor = true;
            // 
            // gboxBusqueda
            // 
            gboxBusqueda.Controls.Add(txtBusqueda);
            gboxBusqueda.Controls.Add(btnLimpiar);
            gboxBusqueda.Controls.Add(btnBuscarUsuario);
            gboxBusqueda.Controls.Add(cbBusqueda);
            gboxBusqueda.Controls.Add(label8);
            gboxBusqueda.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gboxBusqueda.Location = new Point(593, 50);
            gboxBusqueda.Name = "gboxBusqueda";
            gboxBusqueda.Size = new Size(221, 199);
            gboxBusqueda.TabIndex = 21;
            gboxBusqueda.TabStop = false;
            gboxBusqueda.Text = "Buscar Usuario";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(30, 100);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(159, 22);
            txtBusqueda.TabIndex = 14;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.PowderBlue;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 15;
            btnLimpiar.Location = new Point(122, 149);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(34, 23);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.BackColor = Color.PowderBlue;
            btnBuscarUsuario.FlatStyle = FlatStyle.Popup;
            btnBuscarUsuario.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarUsuario.IconColor = Color.Black;
            btnBuscarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarUsuario.IconSize = 15;
            btnBuscarUsuario.Location = new Point(63, 149);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(34, 23);
            btnBuscarUsuario.TabIndex = 14;
            btnBuscarUsuario.UseVisualStyleBackColor = false;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // cbBusqueda
            // 
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Location = new Point(30, 65);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(159, 25);
            cbBusqueda.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 45);
            label8.Name = "label8";
            label8.Size = new Size(73, 17);
            label8.TabIndex = 12;
            label8.Text = "Buscar por:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(684, 14);
            label9.Name = "label9";
            label9.Size = new Size(45, 17);
            label9.TabIndex = 22;
            label9.Text = "Fecha";
            // 
            // RegistroUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(851, 573);
            Controls.Add(label9);
            Controls.Add(gboxBusqueda);
            Controls.Add(gboDetalleUsuario);
            Controls.Add(btnInhabilitar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnCancelar);
            Controls.Add(btnNuevoUsuari);
            Controls.Add(dtFecha);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistroUsuarios";
            Text = "RegistroUsuarios";
            Load += RegistroUsuarios_Load;
            gboDetalleUsuario.ResumeLayout(false);
            gboDetalleUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            gboxBusqueda.ResumeLayout(false);
            gboxBusqueda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gboDetalleUsuario;
        private ComboBox cbEstado;
        private ComboBox cbRol;
        private Label label6;
        private Label label5;
        private TextBox txtCorreo;
        private Label label4;
        private TextBox txtPass;
        private TextBox txtNombre;
        private TextBox txtDocumento;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnInhabilitar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dgvUsuarios;
        private Button btnCancelar;
        private Button btnNuevoUsuari;
        private DateTimePicker dtFecha;
        private FontAwesome.Sharp.IconButton btnBuscarDni;
        private TextBox txtID;
        private Label label7;
        private GroupBox gboxBusqueda;
        private ComboBox cbBusqueda;
        private Label label8;
        private TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBuscarUsuario;
        private Label label9;
        private TextBox txtUsuario;
        private Label label10;
    }
}
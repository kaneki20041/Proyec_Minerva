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
            gboDetalleUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            gboxBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // gboDetalleUsuario
            // 
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
            gboDetalleUsuario.Location = new Point(45, 58);
            gboDetalleUsuario.Name = "gboDetalleUsuario";
            gboDetalleUsuario.Size = new Size(657, 196);
            gboDetalleUsuario.TabIndex = 13;
            gboDetalleUsuario.TabStop = false;
            gboDetalleUsuario.Text = "Detalle del Usuario";
            // 
            // btnBuscarDni
            // 
            btnBuscarDni.BackColor = Color.PowderBlue;
            btnBuscarDni.FlatStyle = FlatStyle.Popup;
            btnBuscarDni.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarDni.IconColor = Color.Black;
            btnBuscarDni.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarDni.IconSize = 15;
            btnBuscarDni.Location = new Point(270, 51);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(34, 23);
            btnBuscarDni.TabIndex = 13;
            btnBuscarDni.UseVisualStyleBackColor = false;
            btnBuscarDni.Click += btnBuscarDni_Click_1;
            // 
            // txtID
            // 
            txtID.Location = new Point(39, 52);
            txtID.Name = "txtID";
            txtID.Size = new Size(47, 22);
            txtID.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 34);
            label7.Name = "label7";
            label7.Size = new Size(20, 17);
            label7.TabIndex = 11;
            label7.Text = "ID";
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(122, 143);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(129, 25);
            cbEstado.TabIndex = 7;
            // 
            // cbRol
            // 
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(380, 143);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(132, 25);
            cbRol.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 146);
            label6.Name = "label6";
            label6.Size = new Size(48, 17);
            label6.TabIndex = 10;
            label6.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(348, 146);
            label5.Name = "label5";
            label5.Size = new Size(26, 17);
            label5.TabIndex = 9;
            label5.Text = "Rol";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(325, 104);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(284, 22);
            txtCorreo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 84);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 7;
            label4.Text = "Correo";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(39, 104);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(265, 22);
            txtPass.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(327, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(282, 22);
            txtNombre.TabIndex = 3;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(113, 52);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(151, 22);
            txtDocumento.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 84);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 34);
            label2.Name = "label2";
            label2.Size = new Size(118, 17);
            label2.TabIndex = 2;
            label2.Text = "Nombre completo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 34);
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
            btnInhabilitar.Location = new Point(718, 425);
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
            btnModificar.Location = new Point(718, 360);
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
            btnAgregar.Location = new Point(718, 297);
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
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(256, 276);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(446, 226);
            dgvUsuarios.TabIndex = 20;
            dgvUsuarios.CellDoubleClick += dgvUsuarios_CellDoubleClick;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.PowderBlue;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(718, 182);
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
            btnNuevoUsuari.Location = new Point(718, 121);
            btnNuevoUsuari.Name = "btnNuevoUsuari";
            btnNuevoUsuari.Size = new Size(98, 40);
            btnNuevoUsuari.TabIndex = 14;
            btnNuevoUsuari.Text = "Nuevo";
            btnNuevoUsuari.UseVisualStyleBackColor = false;
            btnNuevoUsuari.Click += btnNuevoUsuari_Click;
            // 
            // dtFecha
            // 
            dtFecha.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtFecha.Location = new Point(528, 30);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(257, 22);
            dtFecha.TabIndex = 15;
            // 
            // gboxBusqueda
            // 
            gboxBusqueda.Controls.Add(txtBusqueda);
            gboxBusqueda.Controls.Add(btnLimpiar);
            gboxBusqueda.Controls.Add(btnBuscarUsuario);
            gboxBusqueda.Controls.Add(cbBusqueda);
            gboxBusqueda.Controls.Add(label8);
            gboxBusqueda.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gboxBusqueda.Location = new Point(45, 297);
            gboxBusqueda.Name = "gboxBusqueda";
            gboxBusqueda.Size = new Size(182, 189);
            gboxBusqueda.TabIndex = 21;
            gboxBusqueda.TabStop = false;
            gboxBusqueda.Text = "Buscar Usuario";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(6, 93);
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
            btnLimpiar.Location = new Point(98, 137);
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
            btnBuscarUsuario.Location = new Point(39, 137);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(34, 23);
            btnBuscarUsuario.TabIndex = 14;
            btnBuscarUsuario.UseVisualStyleBackColor = false;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // cbBusqueda
            // 
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Location = new Point(6, 53);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(159, 25);
            cbBusqueda.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 33);
            label8.Name = "label8";
            label8.Size = new Size(73, 17);
            label8.TabIndex = 12;
            label8.Text = "Buscar por:";
            // 
            // RegistroUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(851, 547);
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
    }
}
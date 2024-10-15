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
            dtpFecha = new DateTimePicker();
            dgvCliente = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnInhabilitar = new Button();
            txtEmail = new TextBox();
            txtCel = new TextBox();
            gbContacto = new GroupBox();
            label11 = new Label();
            txtDireccion = new TextBox();
            txtBuscarDocumento = new TextBox();
            txtNombre = new TextBox();
            gboInformacion = new GroupBox();
            btnBuscarDni = new FontAwesome.Sharp.IconButton();
            txtID = new TextBox();
            label1 = new Label();
            label7 = new Label();
            cbxDocumento = new ComboBox();
            cbxTipoCliente = new ComboBox();
            txtDocumento = new TextBox();
            label10 = new Label();
            txtApellido = new TextBox();
            label9 = new Label();
            chkEstado = new CheckBox();
            btnBuscarCli = new Button();
            btnNuevoCliente = new Button();
            gboDatosBusqueda = new GroupBox();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            gbContacto.SuspendLayout();
            gboInformacion.SuspendLayout();
            gboDatosBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 35);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 1;
            label2.Text = "Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 26);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 2;
            label3.Text = "Tipo Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(262, 77);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 3;
            label4.Text = "Nombres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 58);
            label5.Name = "label5";
            label5.Size = new Size(50, 17);
            label5.TabIndex = 4;
            label5.Text = "Celular";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 29);
            label6.Name = "label6";
            label6.Size = new Size(39, 17);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(446, 16);
            label8.Name = "label8";
            label8.Size = new Size(115, 17);
            label8.TabIndex = 7;
            label8.Text = "Fecha de Registro";
            // 
            // dtpFecha
            // 
            dtpFecha.Cursor = Cursors.Hand;
            dtpFecha.CustomFormat = "dd-MM-yyyy";
            dtpFecha.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Location = new Point(567, 11);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(256, 22);
            dtpFecha.TabIndex = 13;
            dtpFecha.UseWaitCursor = true;
            // 
            // dgvCliente
            // 
            dgvCliente.BackgroundColor = Color.MintCream;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(21, 312);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersWidth = 51;
            dgvCliente.RowTemplate.Height = 25;
            dgvCliente.Size = new Size(674, 244);
            dgvCliente.TabIndex = 15;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.PowderBlue;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(725, 351);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 40);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btn_AgregarCliente_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.PowderBlue;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(725, 409);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 40);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModifCliente_Click;
            // 
            // btnInhabilitar
            // 
            btnInhabilitar.BackColor = Color.PowderBlue;
            btnInhabilitar.Cursor = Cursors.Hand;
            btnInhabilitar.FlatAppearance.BorderSize = 0;
            btnInhabilitar.FlatStyle = FlatStyle.Flat;
            btnInhabilitar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInhabilitar.Location = new Point(725, 466);
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Size = new Size(98, 40);
            btnInhabilitar.TabIndex = 18;
            btnInhabilitar.Text = "Inhabilitar";
            btnInhabilitar.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(114, 26);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 22);
            txtEmail.TabIndex = 20;
            // 
            // txtCel
            // 
            txtCel.Location = new Point(114, 55);
            txtCel.Name = "txtCel";
            txtCel.Size = new Size(163, 22);
            txtCel.TabIndex = 21;
            txtCel.KeyPress += txtCel_KeyPress;
            // 
            // gbContacto
            // 
            gbContacto.Controls.Add(txtCel);
            gbContacto.Controls.Add(label11);
            gbContacto.Controls.Add(txtDireccion);
            gbContacto.Controls.Add(txtEmail);
            gbContacto.Controls.Add(label6);
            gbContacto.Controls.Add(label5);
            gbContacto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbContacto.Location = new Point(51, 185);
            gbContacto.Name = "gbContacto";
            gbContacto.Size = new Size(326, 121);
            gbContacto.TabIndex = 22;
            gbContacto.TabStop = false;
            gbContacto.Text = "Contacto";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(31, 87);
            label11.Name = "label11";
            label11.Size = new Size(66, 17);
            label11.TabIndex = 32;
            label11.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(114, 84);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(163, 22);
            txtDireccion.TabIndex = 33;
            // 
            // txtBuscarDocumento
            // 
            txtBuscarDocumento.Location = new Point(117, 31);
            txtBuscarDocumento.Name = "txtBuscarDocumento";
            txtBuscarDocumento.Size = new Size(128, 22);
            txtBuscarDocumento.TabIndex = 23;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(329, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(174, 22);
            txtNombre.TabIndex = 25;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // gboInformacion
            // 
            gboInformacion.Controls.Add(btnBuscarDni);
            gboInformacion.Controls.Add(txtID);
            gboInformacion.Controls.Add(label1);
            gboInformacion.Controls.Add(label7);
            gboInformacion.Controls.Add(cbxDocumento);
            gboInformacion.Controls.Add(cbxTipoCliente);
            gboInformacion.Controls.Add(txtDocumento);
            gboInformacion.Controls.Add(label10);
            gboInformacion.Controls.Add(txtApellido);
            gboInformacion.Controls.Add(label9);
            gboInformacion.Controls.Add(txtNombre);
            gboInformacion.Controls.Add(label4);
            gboInformacion.Controls.Add(label3);
            gboInformacion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gboInformacion.Location = new Point(21, 54);
            gboInformacion.Name = "gboInformacion";
            gboInformacion.Size = new Size(802, 125);
            gboInformacion.TabIndex = 26;
            gboInformacion.TabStop = false;
            gboInformacion.Text = "Informacion";
            // 
            // btnBuscarDni
            // 
            btnBuscarDni.BackColor = Color.PowderBlue;
            btnBuscarDni.Cursor = Cursors.Hand;
            btnBuscarDni.FlatStyle = FlatStyle.Popup;
            btnBuscarDni.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarDni.IconColor = Color.Black;
            btnBuscarDni.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarDni.IconSize = 15;
            btnBuscarDni.Location = new Point(206, 74);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(34, 23);
            btnBuscarDni.TabIndex = 39;
            btnBuscarDni.UseVisualStyleBackColor = false;
            btnBuscarDni.Click += btnBuscarDni_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(108, 24);
            txtID.Name = "txtID";
            txtID.Size = new Size(50, 22);
            txtID.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 26);
            label1.Name = "label1";
            label1.Size = new Size(20, 17);
            label1.TabIndex = 38;
            label1.Text = "ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 78);
            label7.Name = "label7";
            label7.Size = new Size(49, 17);
            label7.TabIndex = 36;
            label7.Text = "Nº Doc";
            // 
            // cbxDocumento
            // 
            cbxDocumento.FormattingEnabled = true;
            cbxDocumento.Location = new Point(561, 24);
            cbxDocumento.Name = "cbxDocumento";
            cbxDocumento.Size = new Size(158, 25);
            cbxDocumento.TabIndex = 35;
            // 
            // cbxTipoCliente
            // 
            cbxTipoCliente.FormattingEnabled = true;
            cbxTipoCliente.Location = new Point(292, 24);
            cbxTipoCliente.Name = "cbxTipoCliente";
            cbxTipoCliente.Size = new Size(158, 25);
            cbxTipoCliente.TabIndex = 34;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(66, 75);
            txtDocumento.Margin = new Padding(3, 2, 3, 2);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(134, 22);
            txtDocumento.TabIndex = 30;
            txtDocumento.KeyPress += txtDocumento_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(476, 26);
            label10.Name = "label10";
            label10.Size = new Size(79, 17);
            label10.TabIndex = 28;
            label10.Text = "Documento";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(586, 75);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(175, 22);
            txtApellido.TabIndex = 27;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(517, 78);
            label9.Name = "label9";
            label9.Size = new Size(63, 17);
            label9.TabIndex = 26;
            label9.Text = "Apellidos";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Checked = true;
            chkEstado.CheckState = CheckState.Checked;
            chkEstado.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chkEstado.Location = new Point(741, 186);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(67, 21);
            chkEstado.TabIndex = 28;
            chkEstado.Text = "Estado";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCli
            // 
            btnBuscarCli.BackColor = Color.PowderBlue;
            btnBuscarCli.Cursor = Cursors.Hand;
            btnBuscarCli.FlatAppearance.BorderSize = 0;
            btnBuscarCli.FlatStyle = FlatStyle.Flat;
            btnBuscarCli.Location = new Point(281, 31);
            btnBuscarCli.Margin = new Padding(3, 2, 3, 2);
            btnBuscarCli.Name = "btnBuscarCli";
            btnBuscarCli.Size = new Size(82, 23);
            btnBuscarCli.TabIndex = 37;
            btnBuscarCli.Text = "Buscar";
            btnBuscarCli.UseVisualStyleBackColor = false;
            btnBuscarCli.Click += btnBuscarCli_Click;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.PowderBlue;
            btnNuevoCliente.Cursor = Cursors.Hand;
            btnNuevoCliente.FlatAppearance.BorderSize = 0;
            btnNuevoCliente.FlatStyle = FlatStyle.Flat;
            btnNuevoCliente.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoCliente.Location = new Point(31, 12);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(158, 29);
            btnNuevoCliente.TabIndex = 27;
            btnNuevoCliente.Text = "Nuevo";
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // gboDatosBusqueda
            // 
            gboDatosBusqueda.Controls.Add(label2);
            gboDatosBusqueda.Controls.Add(btnBuscarCli);
            gboDatosBusqueda.Controls.Add(txtBuscarDocumento);
            gboDatosBusqueda.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gboDatosBusqueda.Location = new Point(419, 213);
            gboDatosBusqueda.Name = "gboDatosBusqueda";
            gboDatosBusqueda.Size = new Size(389, 78);
            gboDatosBusqueda.TabIndex = 28;
            gboDatosBusqueda.TabStop = false;
            gboDatosBusqueda.Text = "Datos de Búsqueda";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.PowderBlue;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(219, 12);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(158, 29);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Registrocliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(851, 573);
            Controls.Add(btnCancelar);
            Controls.Add(gboDatosBusqueda);
            Controls.Add(btnNuevoCliente);
            Controls.Add(chkEstado);
            Controls.Add(gboInformacion);
            Controls.Add(gbContacto);
            Controls.Add(btnInhabilitar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvCliente);
            Controls.Add(dtpFecha);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registrocliente";
            Text = "Registrocliente";
            Load += Registrocliente_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            gbContacto.ResumeLayout(false);
            gbContacto.PerformLayout();
            gboInformacion.ResumeLayout(false);
            gboInformacion.PerformLayout();
            gboDatosBusqueda.ResumeLayout(false);
            gboDatosBusqueda.PerformLayout();
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
        private DateTimePicker dtpFecha;
        private DataGridView dgvCliente;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnInhabilitar;
        private TextBox txtEmail;
        private TextBox txtCel;
        private GroupBox gbContacto;
        private TextBox txtBuscarDocumento;
        private TextBox txtNombre;
        private GroupBox gboInformacion;
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
        private GroupBox gboDatosBusqueda;
        private TextBox txtID;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnBuscarDni;
        private Button btnCancelar;
    }
}
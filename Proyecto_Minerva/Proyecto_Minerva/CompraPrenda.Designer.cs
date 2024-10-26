namespace Proyecto_Minerva
{
    partial class CompraPrenda
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmbMonto = new TextBox();
            txtRUC = new TextBox();
            txtRazonRUC = new TextBox();
            gbInfoPrenda = new GroupBox();
            txtColegio = new TextBox();
            txtCantidad = new TextBox();
            label9 = new Label();
            txtCategoria = new TextBox();
            label4 = new Label();
            label12 = new Label();
            btnLimpiar = new Button();
            label14 = new Label();
            txtStock = new TextBox();
            btnQuitar = new Button();
            txtPrecioCompra = new TextBox();
            label15 = new Label();
            AgreCompra = new Button();
            btn_buscarPrenVen = new Button();
            txtTalla = new TextBox();
            txtNombrePrenda = new TextBox();
            label17 = new Label();
            label18 = new Label();
            label13 = new Label();
            label11 = new Label();
            gbInfoUser = new GroupBox();
            label3 = new Label();
            txtVendedor = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            gbInfoProveedor = new GroupBox();
            txtNombreRUC = new TextBox();
            label1 = new Label();
            BuscProveedor = new Button();
            btnGrabar = new Button();
            tablaCompras = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            cmbMetodoPago = new ComboBox();
            btnNuevo = new Button();
            btnCancelar = new Button();
            gbInfoPrenda.SuspendLayout();
            gbInfoUser.SuspendLayout();
            gbInfoProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaCompras).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 60);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 1;
            label2.Text = "Vendedor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 66);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 4;
            label5.Text = "RUC";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 94);
            label6.Name = "label6";
            label6.Size = new Size(83, 17);
            label6.TabIndex = 5;
            label6.Text = "Razon Social";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(513, 13);
            label7.Name = "label7";
            label7.Size = new Size(45, 17);
            label7.TabIndex = 6;
            label7.Text = "Fecha";
            // 
            // cmbMonto
            // 
            cmbMonto.Location = new Point(731, 257);
            cmbMonto.Name = "cmbMonto";
            cmbMonto.ReadOnly = true;
            cmbMonto.Size = new Size(98, 23);
            cmbMonto.TabIndex = 10;
            // 
            // txtRUC
            // 
            txtRUC.Location = new Point(105, 63);
            txtRUC.Name = "txtRUC";
            txtRUC.Size = new Size(166, 22);
            txtRUC.TabIndex = 17;
            txtRUC.KeyPress += txtRUC_KeyPress;
            // 
            // txtRazonRUC
            // 
            txtRazonRUC.Location = new Point(105, 91);
            txtRazonRUC.Multiline = true;
            txtRazonRUC.Name = "txtRazonRUC";
            txtRazonRUC.ReadOnly = true;
            txtRazonRUC.Size = new Size(264, 50);
            txtRazonRUC.TabIndex = 18;
            // 
            // gbInfoPrenda
            // 
            gbInfoPrenda.Controls.Add(txtColegio);
            gbInfoPrenda.Controls.Add(txtCantidad);
            gbInfoPrenda.Controls.Add(label9);
            gbInfoPrenda.Controls.Add(txtCategoria);
            gbInfoPrenda.Controls.Add(label4);
            gbInfoPrenda.Controls.Add(label12);
            gbInfoPrenda.Controls.Add(btnLimpiar);
            gbInfoPrenda.Controls.Add(label14);
            gbInfoPrenda.Controls.Add(txtStock);
            gbInfoPrenda.Controls.Add(btnQuitar);
            gbInfoPrenda.Controls.Add(txtPrecioCompra);
            gbInfoPrenda.Controls.Add(label15);
            gbInfoPrenda.Controls.Add(AgreCompra);
            gbInfoPrenda.Controls.Add(btn_buscarPrenVen);
            gbInfoPrenda.Controls.Add(txtTalla);
            gbInfoPrenda.Controls.Add(txtNombrePrenda);
            gbInfoPrenda.Controls.Add(label17);
            gbInfoPrenda.Controls.Add(label18);
            gbInfoPrenda.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbInfoPrenda.Location = new Point(23, 183);
            gbInfoPrenda.Name = "gbInfoPrenda";
            gbInfoPrenda.Size = new Size(671, 161);
            gbInfoPrenda.TabIndex = 45;
            gbInfoPrenda.TabStop = false;
            gbInfoPrenda.Text = "Informacion de Prenda";
            // 
            // txtColegio
            // 
            txtColegio.Location = new Point(92, 89);
            txtColegio.Name = "txtColegio";
            txtColegio.ReadOnly = true;
            txtColegio.Size = new Size(166, 22);
            txtColegio.TabIndex = 56;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(407, 89);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(128, 22);
            txtCantidad.TabIndex = 50;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 92);
            label9.Name = "label9";
            label9.Size = new Size(55, 17);
            label9.TabIndex = 55;
            label9.Text = "Colegio";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(92, 117);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.ReadOnly = true;
            txtCategoria.Size = new Size(166, 22);
            txtCategoria.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 120);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 48;
            label4.Text = "Categoria";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(337, 92);
            label12.Name = "label12";
            label12.Size = new Size(64, 17);
            label12.TabIndex = 43;
            label12.Text = "Cantidad";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.LightBlue;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(553, 109);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(98, 41);
            btnLimpiar.TabIndex = 55;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += button1_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(359, 120);
            label14.Name = "label14";
            label14.Size = new Size(42, 17);
            label14.TabIndex = 41;
            label14.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(407, 117);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(128, 22);
            txtStock.TabIndex = 40;
            // 
            // btnQuitar
            // 
            btnQuitar.BackColor = Color.LightBlue;
            btnQuitar.FlatAppearance.BorderSize = 0;
            btnQuitar.FlatStyle = FlatStyle.Flat;
            btnQuitar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuitar.Location = new Point(553, 65);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(98, 39);
            btnQuitar.TabIndex = 53;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += button5_Click;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(407, 59);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.ReadOnly = true;
            txtPrecioCompra.Size = new Size(128, 22);
            txtPrecioCompra.TabIndex = 39;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(335, 62);
            label15.Name = "label15";
            label15.Size = new Size(66, 17);
            label15.TabIndex = 38;
            label15.Text = "P.Compra";
            // 
            // AgreCompra
            // 
            AgreCompra.BackColor = Color.LightBlue;
            AgreCompra.FlatAppearance.BorderSize = 0;
            AgreCompra.FlatStyle = FlatStyle.Flat;
            AgreCompra.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AgreCompra.Location = new Point(553, 22);
            AgreCompra.Name = "AgreCompra";
            AgreCompra.Size = new Size(98, 40);
            AgreCompra.TabIndex = 51;
            AgreCompra.Text = "Agregar";
            AgreCompra.UseVisualStyleBackColor = false;
            AgreCompra.Click += AgreCompra_Click;
            // 
            // btn_buscarPrenVen
            // 
            btn_buscarPrenVen.BackColor = Color.LightCyan;
            btn_buscarPrenVen.Cursor = Cursors.Hand;
            btn_buscarPrenVen.FlatAppearance.BorderSize = 0;
            btn_buscarPrenVen.FlatStyle = FlatStyle.Flat;
            btn_buscarPrenVen.Location = new Point(269, 28);
            btn_buscarPrenVen.Name = "btn_buscarPrenVen";
            btn_buscarPrenVen.Size = new Size(62, 29);
            btn_buscarPrenVen.TabIndex = 0;
            btn_buscarPrenVen.Text = "Buscar";
            btn_buscarPrenVen.UseVisualStyleBackColor = false;
            btn_buscarPrenVen.Click += btn_buscarPrenVen_Click;
            // 
            // txtTalla
            // 
            txtTalla.Location = new Point(92, 61);
            txtTalla.Name = "txtTalla";
            txtTalla.ReadOnly = true;
            txtTalla.Size = new Size(166, 22);
            txtTalla.TabIndex = 37;
            // 
            // txtNombrePrenda
            // 
            txtNombrePrenda.Location = new Point(92, 31);
            txtNombrePrenda.Multiline = true;
            txtNombrePrenda.Name = "txtNombrePrenda";
            txtNombrePrenda.Size = new Size(166, 22);
            txtNombrePrenda.TabIndex = 32;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(36, 36);
            label17.Name = "label17";
            label17.Size = new Size(50, 17);
            label17.TabIndex = 2;
            label17.Text = "Prenda";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(51, 64);
            label18.Name = "label18";
            label18.Size = new Size(35, 17);
            label18.TabIndex = 5;
            label18.Text = "Talla";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(735, 186);
            label13.Name = "label13";
            label13.Size = new Size(90, 17);
            label13.TabIndex = 49;
            label13.Text = "Metodo Pago";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(755, 237);
            label11.Name = "label11";
            label11.Size = new Size(47, 17);
            label11.TabIndex = 44;
            label11.Text = "Monto";
            // 
            // gbInfoUser
            // 
            gbInfoUser.Controls.Add(label3);
            gbInfoUser.Controls.Add(txtVendedor);
            gbInfoUser.Controls.Add(label2);
            gbInfoUser.Controls.Add(dateTimePicker1);
            gbInfoUser.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbInfoUser.Location = new Point(441, 13);
            gbInfoUser.Name = "gbInfoUser";
            gbInfoUser.Size = new Size(237, 164);
            gbInfoUser.TabIndex = 49;
            gbInfoUser.TabStop = false;
            gbInfoUser.Text = "Informacion de Compra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 96);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 52;
            label3.Text = "Fecha";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(93, 57);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(121, 22);
            txtVendedor.TabIndex = 51;
            txtVendedor.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(93, 94);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(101, 22);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.UseWaitCursor = true;
            // 
            // gbInfoProveedor
            // 
            gbInfoProveedor.Controls.Add(txtNombreRUC);
            gbInfoProveedor.Controls.Add(label1);
            gbInfoProveedor.Controls.Add(BuscProveedor);
            gbInfoProveedor.Controls.Add(txtRazonRUC);
            gbInfoProveedor.Controls.Add(txtRUC);
            gbInfoProveedor.Controls.Add(label6);
            gbInfoProveedor.Controls.Add(label5);
            gbInfoProveedor.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbInfoProveedor.Location = new Point(23, 13);
            gbInfoProveedor.Name = "gbInfoProveedor";
            gbInfoProveedor.Size = new Size(396, 164);
            gbInfoProveedor.TabIndex = 50;
            gbInfoProveedor.TabStop = false;
            gbInfoProveedor.Text = "Informacion de Proveedor";
            // 
            // txtNombreRUC
            // 
            txtNombreRUC.Location = new Point(105, 35);
            txtNombreRUC.Name = "txtNombreRUC";
            txtNombreRUC.Size = new Size(166, 22);
            txtNombreRUC.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 38);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 51;
            label1.Text = "Nombre";
            // 
            // BuscProveedor
            // 
            BuscProveedor.BackColor = Color.LightCyan;
            BuscProveedor.FlatAppearance.BorderSize = 0;
            BuscProveedor.FlatStyle = FlatStyle.Flat;
            BuscProveedor.Location = new Point(291, 32);
            BuscProveedor.Name = "BuscProveedor";
            BuscProveedor.Size = new Size(63, 29);
            BuscProveedor.TabIndex = 50;
            BuscProveedor.Text = "Buscar";
            BuscProveedor.UseVisualStyleBackColor = false;
            BuscProveedor.Click += BuscProveedor_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.LightBlue;
            btnGrabar.FlatAppearance.BorderSize = 0;
            btnGrabar.FlatStyle = FlatStyle.Flat;
            btnGrabar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGrabar.Location = new Point(731, 292);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(98, 41);
            btnGrabar.TabIndex = 52;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // tablaCompras
            // 
            tablaCompras.BackgroundColor = Color.MintCream;
            tablaCompras.BorderStyle = BorderStyle.None;
            tablaCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaCompras.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4, Column5, Column7, Column6, Column8 });
            tablaCompras.Location = new Point(55, 358);
            tablaCompras.Name = "tablaCompras";
            tablaCompras.RowTemplate.Height = 25;
            tablaCompras.Size = new Size(742, 185);
            tablaCompras.TabIndex = 54;
            // 
            // Column2
            // 
            Column2.HeaderText = "Prenda";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Categoria";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Colegio";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Talla";
            Column5.Name = "Column5";
            // 
            // Column7
            // 
            Column7.HeaderText = "Cantidad";
            Column7.Name = "Column7";
            // 
            // Column6
            // 
            Column6.HeaderText = "Precio";
            Column6.Name = "Column6";
            // 
            // Column8
            // 
            Column8.HeaderText = "Subtotal";
            Column8.Name = "Column8";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Location = new Point(731, 206);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(98, 23);
            cmbMetodoPago.TabIndex = 52;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.LightBlue;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.Location = new Point(731, 61);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(98, 40);
            btnNuevo.TabIndex = 56;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightBlue;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(731, 107);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 41);
            btnCancelar.TabIndex = 57;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // CompraPrenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(868, 565);
            Controls.Add(btnCancelar);
            Controls.Add(btnNuevo);
            Controls.Add(cmbMetodoPago);
            Controls.Add(label7);
            Controls.Add(label13);
            Controls.Add(tablaCompras);
            Controls.Add(btnGrabar);
            Controls.Add(gbInfoProveedor);
            Controls.Add(gbInfoUser);
            Controls.Add(gbInfoPrenda);
            Controls.Add(cmbMonto);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CompraPrenda";
            Text = "Cambio";
            Load += CompraPrenda_Load;
            gbInfoPrenda.ResumeLayout(false);
            gbInfoPrenda.PerformLayout();
            gbInfoUser.ResumeLayout(false);
            gbInfoUser.PerformLayout();
            gbInfoProveedor.ResumeLayout(false);
            gbInfoProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox cmbMonto;
        private TextBox txtRUC;
        private TextBox txtRazonRUC;
        private GroupBox gbInfoPrenda;
        private Label label13;
        private Label label11;
        private Label label12;
        private Label label14;
        private TextBox txtStock;
        private TextBox txtPrecioCompra;
        private Label label15;
        private TextBox txtTalla;
        private TextBox txtNombrePrenda;
        private Label label17;
        private Label label18;
        private Button btn_buscarPrenVen;
        private GroupBox gbInfoUser;
        private DateTimePicker dateTimePicker1;
        private GroupBox gbInfoProveedor;
        private Button BuscProveedor;
        private Button AgreCompra;
        private Button btnGrabar;
        private Button btnQuitar;
        private DataGridView tablaCompras;
        private TextBox txtCategoria;
        private Label label4;
        private TextBox txtCantidad;
        private TextBox txtColegio;
        private Label label9;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Colegio;
        private DataGridViewTextBoxColumn Talla;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PCompra;
        private DataGridViewTextBoxColumn Subtotal;
        private Button btnLimpiar;
        private TextBox txtVendedor;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private TextBox txtNombreRUC;
        private Label label1;
        private ComboBox cmbMetodoPago;
        private Button btnNuevo;
        private Button btnCancelar;
        private Label label3;
    }
}
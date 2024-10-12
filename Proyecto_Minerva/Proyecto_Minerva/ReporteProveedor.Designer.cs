namespace CapaPresentacion
{
    partial class ReporteProveedor
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
            gboxBusqueda = new GroupBox();
            txtBusqueda = new TextBox();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnBuscarUsuario = new FontAwesome.Sharp.IconButton();
            cbBusqueda = new ComboBox();
            label8 = new Label();
            dgvProveedor = new DataGridView();
            btnSalir = new FontAwesome.Sharp.IconButton();
            gboxBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            SuspendLayout();
            // 
            // gboxBusqueda
            // 
            gboxBusqueda.BackColor = Color.MintCream;
            gboxBusqueda.Controls.Add(txtBusqueda);
            gboxBusqueda.Controls.Add(btnLimpiar);
            gboxBusqueda.Controls.Add(btnBuscarUsuario);
            gboxBusqueda.Controls.Add(cbBusqueda);
            gboxBusqueda.Controls.Add(label8);
            gboxBusqueda.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gboxBusqueda.Location = new Point(35, 22);
            gboxBusqueda.Name = "gboxBusqueda";
            gboxBusqueda.Size = new Size(535, 75);
            gboxBusqueda.TabIndex = 23;
            gboxBusqueda.TabStop = false;
            gboxBusqueda.Text = "Buscar Proveedor";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(341, 31);
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
            btnLimpiar.Location = new Point(290, 30);
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
            btnBuscarUsuario.Location = new Point(241, 30);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(34, 23);
            btnBuscarUsuario.TabIndex = 14;
            btnBuscarUsuario.UseVisualStyleBackColor = false;
            // 
            // cbBusqueda
            // 
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Location = new Point(98, 30);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(137, 25);
            cbBusqueda.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 33);
            label8.Name = "label8";
            label8.Size = new Size(73, 17);
            label8.TabIndex = 12;
            label8.Text = "Buscar por:";
            // 
            // dgvProveedor
            // 
            dgvProveedor.BackgroundColor = Color.MintCream;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Location = new Point(35, 103);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.RowHeadersWidth = 51;
            dgvProveedor.RowTemplate.Height = 25;
            dgvProveedor.Size = new Size(699, 282);
            dgvProveedor.TabIndex = 24;
            dgvProveedor.CellDoubleClick += dgvProveedor_CellDoubleClick;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.MintCream;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingArrowLoopLeft;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnSalir.IconSize = 30;
            btnSalir.Location = new Point(686, 37);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(48, 40);
            btnSalir.TabIndex = 25;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // ReporteProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(783, 412);
            Controls.Add(btnSalir);
            Controls.Add(dgvProveedor);
            Controls.Add(gboxBusqueda);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReporteProveedor";
            Text = "ReporteProveedor";
            gboxBusqueda.ResumeLayout(false);
            gboxBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxBusqueda;
        private TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBuscarUsuario;
        private ComboBox cbBusqueda;
        private Label label8;
        private DataGridView dgvProveedor;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}
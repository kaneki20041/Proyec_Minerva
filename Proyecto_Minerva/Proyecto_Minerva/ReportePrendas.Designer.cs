namespace CapaPresentacion
{
    partial class ReportePrendas
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
            btnSalir = new FontAwesome.Sharp.IconButton();
            dgvPrendas = new DataGridView();
            gboxBusqueda = new GroupBox();
            txtBusqueda = new TextBox();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            cbBusqueda = new ComboBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPrendas).BeginInit();
            gboxBusqueda.SuspendLayout();
            SuspendLayout();
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
            btnSalir.Location = new Point(684, 29);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(48, 40);
            btnSalir.TabIndex = 28;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvPrendas
            // 
            dgvPrendas.BackgroundColor = Color.MintCream;
            dgvPrendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrendas.Location = new Point(33, 95);
            dgvPrendas.Name = "dgvPrendas";
            dgvPrendas.RowHeadersWidth = 51;
            dgvPrendas.RowTemplate.Height = 25;
            dgvPrendas.Size = new Size(699, 282);
            dgvPrendas.TabIndex = 27;
            dgvPrendas.CellDoubleClick += dgvPrendas_CellDoubleClick;
            // 
            // gboxBusqueda
            // 
            gboxBusqueda.BackColor = Color.MintCream;
            gboxBusqueda.Controls.Add(txtBusqueda);
            gboxBusqueda.Controls.Add(btnLimpiar);
            gboxBusqueda.Controls.Add(cbBusqueda);
            gboxBusqueda.Controls.Add(label8);
            gboxBusqueda.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gboxBusqueda.Location = new Point(33, 14);
            gboxBusqueda.Name = "gboxBusqueda";
            gboxBusqueda.Size = new Size(535, 75);
            gboxBusqueda.TabIndex = 26;
            gboxBusqueda.TabStop = false;
            gboxBusqueda.Text = "Buscar Prendas";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(264, 33);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(159, 22);
            txtBusqueda.TabIndex = 14;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.PowderBlue;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 15;
            btnLimpiar.Location = new Point(457, 32);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(34, 23);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscarUsuario
            // 
            // cbBusqueda
            // 
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Items.AddRange(new object[] { "Talla", "Categoria", "Descripcion" });
            cbBusqueda.Location = new Point(98, 30);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(137, 25);
            cbBusqueda.TabIndex = 14;
            cbBusqueda.SelectedIndexChanged += cbBusqueda_SelectedIndexChanged;
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
            // ReportePrendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(783, 412);
            Controls.Add(btnSalir);
            Controls.Add(dgvPrendas);
            Controls.Add(gboxBusqueda);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportePrendas";
            Text = "ReportePrendas";
            ((System.ComponentModel.ISupportInitialize)dgvPrendas).EndInit();
            gboxBusqueda.ResumeLayout(false);
            gboxBusqueda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSalir;
        private DataGridView dgvPrendas;
        private GroupBox gboxBusqueda;
        private TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private ComboBox cbBusqueda;
        private Label label8;
    }
}
namespace CapaPresentacion
{
    partial class Inventario
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
            dgvInventario = new DataGridView();
            label1 = new Label();
            cbBusqueda = new ComboBox();
            gbBuscar = new GroupBox();
            groupBox2 = new GroupBox();
            btnEliminarFiltro = new Button();
            txtBuscar = new TextBox();
            btnActualizar = new Button();
            gbPrenda = new GroupBox();
            txtNuevoPrecio = new TextBox();
            txtPrecio = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            btnActualizarForm = new Button();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            gbBuscar.SuspendLayout();
            groupBox2.SuspendLayout();
            gbPrenda.SuspendLayout();
            SuspendLayout();
            // 
            // dgvInventario
            // 
            dgvInventario.BackgroundColor = Color.MintCream;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(28, 143);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowTemplate.Height = 25;
            dgvInventario.Size = new Size(629, 357);
            dgvInventario.TabIndex = 0;
            dgvInventario.CellDoubleClick += dgvInventario_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 26);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 1;
            label1.Text = "Buscar por:";
            // 
            // cbBusqueda
            // 
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Location = new Point(20, 46);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(121, 25);
            cbBusqueda.TabIndex = 2;
            cbBusqueda.SelectedIndexChanged += cbBusqueda_SelectedIndexChanged;
            // 
            // gbBuscar
            // 
            gbBuscar.Controls.Add(groupBox2);
            gbBuscar.Controls.Add(cbBusqueda);
            gbBuscar.Controls.Add(label1);
            gbBuscar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gbBuscar.Location = new Point(678, 143);
            gbBuscar.Name = "gbBuscar";
            gbBuscar.Size = new Size(161, 289);
            gbBuscar.TabIndex = 3;
            gbBuscar.TabStop = false;
            gbBuscar.Text = "Buscar";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminarFiltro);
            groupBox2.Controls.Add(txtBuscar);
            groupBox2.Location = new Point(12, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(134, 176);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ingrese dato";
            // 
            // btnEliminarFiltro
            // 
            btnEliminarFiltro.BackColor = Color.LightBlue;
            btnEliminarFiltro.FlatAppearance.BorderSize = 0;
            btnEliminarFiltro.FlatStyle = FlatStyle.Flat;
            btnEliminarFiltro.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarFiltro.Location = new Point(6, 105);
            btnEliminarFiltro.Name = "btnEliminarFiltro";
            btnEliminarFiltro.Size = new Size(120, 32);
            btnEliminarFiltro.TabIndex = 51;
            btnEliminarFiltro.Text = "Eliminar filtro";
            btnEliminarFiltro.UseVisualStyleBackColor = false;
            btnEliminarFiltro.Click += btnEliminarFiltro_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(8, 43);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(120, 23);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.LightBlue;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.Location = new Point(681, 453);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(143, 38);
            btnActualizar.TabIndex = 51;
            btnActualizar.Text = "Actualizar Prenda";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // gbPrenda
            // 
            gbPrenda.Controls.Add(txtNuevoPrecio);
            gbPrenda.Controls.Add(txtPrecio);
            gbPrenda.Controls.Add(label5);
            gbPrenda.Controls.Add(label4);
            gbPrenda.Controls.Add(txtDescripcion);
            gbPrenda.Controls.Add(label3);
            gbPrenda.Controls.Add(txtID);
            gbPrenda.Controls.Add(label2);
            gbPrenda.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gbPrenda.Location = new Point(28, 29);
            gbPrenda.Name = "gbPrenda";
            gbPrenda.Size = new Size(629, 100);
            gbPrenda.TabIndex = 52;
            gbPrenda.TabStop = false;
            gbPrenda.Text = "Información Prenda";
            // 
            // txtNuevoPrecio
            // 
            txtNuevoPrecio.Location = new Point(457, 52);
            txtNuevoPrecio.Name = "txtNuevoPrecio";
            txtNuevoPrecio.Size = new Size(114, 23);
            txtNuevoPrecio.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(302, 52);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(114, 23);
            txtPrecio.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(457, 32);
            label5.Name = "label5";
            label5.Size = new Size(95, 17);
            label5.TabIndex = 5;
            label5.Text = "Nuevo Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 32);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 4;
            label4.Text = "Precio";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(97, 52);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(168, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 32);
            label3.Name = "label3";
            label3.Size = new Size(83, 17);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // txtID
            // 
            txtID.Location = new Point(24, 52);
            txtID.Name = "txtID";
            txtID.Size = new Size(37, 23);
            txtID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 32);
            label2.Name = "label2";
            label2.Size = new Size(21, 17);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // btnActualizarForm
            // 
            btnActualizarForm.BackColor = Color.LightBlue;
            btnActualizarForm.FlatAppearance.BorderSize = 0;
            btnActualizarForm.FlatStyle = FlatStyle.Flat;
            btnActualizarForm.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizarForm.Location = new Point(696, 40);
            btnActualizarForm.Name = "btnActualizarForm";
            btnActualizarForm.Size = new Size(120, 32);
            btnActualizarForm.TabIndex = 53;
            btnActualizarForm.Text = "Actualizar";
            btnActualizarForm.UseVisualStyleBackColor = false;
            btnActualizarForm.Click += btnActualizarForm_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LightBlue;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(698, 85);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 32);
            btnBuscar.TabIndex = 54;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(851, 563);
            Controls.Add(btnBuscar);
            Controls.Add(btnActualizarForm);
            Controls.Add(gbPrenda);
            Controls.Add(btnActualizar);
            Controls.Add(gbBuscar);
            Controls.Add(dgvInventario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventario";
            Text = "Inventario";
            Load += Inventario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            gbBuscar.ResumeLayout(false);
            gbBuscar.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbPrenda.ResumeLayout(false);
            gbPrenda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInventario;
        private Label label1;
        private ComboBox cbBusqueda;
        private GroupBox gbBuscar;
        private GroupBox groupBox2;
        private TextBox txtBuscar;
        private Button btnEliminarFiltro;
        private Button btnActualizar;
        private GroupBox gbPrenda;
        private Label label2;
        private Label label3;
        private TextBox txtID;
        private Label label4;
        private TextBox txtDescripcion;
        private TextBox txtNuevoPrecio;
        private TextBox txtPrecio;
        private Label label5;
        private Button btnActualizarForm;
        private Button btnBuscar;
    }
}
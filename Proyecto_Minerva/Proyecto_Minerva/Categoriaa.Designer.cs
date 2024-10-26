namespace CapaPresentacion
{
    partial class Categoriaa
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
            dgvCategoria = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnDeshabilitar = new Button();
            checkBox1 = new CheckBox();
            txtCategoria = new TextBox();
            gbDatos = new GroupBox();
            btnNuevo = new Button();
            btnCancelar = new Button();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            gbDatos.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCategoria
            // 
            dgvCategoria.BackgroundColor = Color.MintCream;
            dgvCategoria.BorderStyle = BorderStyle.None;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(353, 50);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.ReadOnly = true;
            dgvCategoria.Size = new Size(448, 477);
            dgvCategoria.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LightBlue;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(23, 146);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 42);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgrega_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.LightBlue;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(134, 146);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(105, 42);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.BackColor = Color.LightBlue;
            btnDeshabilitar.FlatAppearance.BorderSize = 0;
            btnDeshabilitar.FlatStyle = FlatStyle.Flat;
            btnDeshabilitar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeshabilitar.Location = new Point(81, 194);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(105, 42);
            btnDeshabilitar.TabIndex = 6;
            btnDeshabilitar.Text = "Deshabilitar";
            btnDeshabilitar.UseVisualStyleBackColor = false;
            btnDeshabilitar.Click += btnDeshabilitar_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(98, 106);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 21);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Estado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(42, 69);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(187, 22);
            txtCategoria.TabIndex = 8;
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(label15);
            gbDatos.Controls.Add(txtCategoria);
            gbDatos.Controls.Add(checkBox1);
            gbDatos.Controls.Add(btnDeshabilitar);
            gbDatos.Controls.Add(btnAgregar);
            gbDatos.Controls.Add(btnModificar);
            gbDatos.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbDatos.Location = new Point(27, 126);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(268, 272);
            gbDatos.TabIndex = 9;
            gbDatos.TabStop = false;
            gbDatos.Text = "Datos";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.LightBlue;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.Location = new Point(53, 418);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(105, 42);
            btnNuevo.TabIndex = 10;
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
            btnCancelar.Location = new Point(164, 418);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 42);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(42, 49);
            label15.Name = "label15";
            label15.Size = new Size(69, 17);
            label15.TabIndex = 39;
            label15.Text = "Categoria";
            // 
            // Categoriaa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(851, 573);
            Controls.Add(btnCancelar);
            Controls.Add(btnNuevo);
            Controls.Add(gbDatos);
            Controls.Add(dgvCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Categoriaa";
            Text = "Categoriaa";
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvCategoria;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnDeshabilitar;
        private CheckBox checkBox1;
        private TextBox txtCategoria;
        private GroupBox gbDatos;
        private Button btnNuevo;
        private Button btnCancelar;
        private Label label15;
    }
}
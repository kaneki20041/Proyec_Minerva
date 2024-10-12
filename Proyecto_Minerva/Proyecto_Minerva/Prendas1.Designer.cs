namespace CapaPresentacion
{
    partial class Prendas1
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
            btnAgregarPre = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            groupBox1 = new GroupBox();
            cbxEstado = new CheckBox();
            txtPrecioCompra = new TextBox();
            label6 = new Label();
            txtDescripcion = new TextBox();
            txtPrevioVenta = new TextBox();
            label4 = new Label();
            label8 = new Label();
            txtStock = new TextBox();
            button2 = new Button();
            label13 = new Label();
            label16 = new Label();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            button3 = new Button();
            BtnRemovPro = new Button();
            btnEditPro = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregarPre
            // 
            btnAgregarPre.BackColor = Color.PowderBlue;
            btnAgregarPre.FlatAppearance.BorderSize = 0;
            btnAgregarPre.FlatStyle = FlatStyle.Flat;
            btnAgregarPre.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarPre.Location = new Point(706, 60);
            btnAgregarPre.Margin = new Padding(3, 2, 3, 2);
            btnAgregarPre.Name = "btnAgregarPre";
            btnAgregarPre.Size = new Size(94, 41);
            btnAgregarPre.TabIndex = 88;
            btnAgregarPre.Text = "Agregar";
            btnAgregarPre.UseVisualStyleBackColor = false;
            btnAgregarPre.Click += btnAgregarPre_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MintCream;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 253);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(815, 297);
            dataGridView1.TabIndex = 87;
            // 
            // button1
            // 
            button1.BackColor = Color.PowderBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(706, 156);
            button1.Name = "button1";
            button1.Size = new Size(94, 42);
            button1.TabIndex = 85;
            button1.Text = "Deshabilitar";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxEstado);
            groupBox1.Controls.Add(txtPrecioCompra);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtPrevioVenta);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(70, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 211);
            groupBox1.TabIndex = 84;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion de prenda";
            // 
            // cbxEstado
            // 
            cbxEstado.AutoSize = true;
            cbxEstado.Checked = true;
            cbxEstado.CheckState = CheckState.Checked;
            cbxEstado.Location = new Point(448, 156);
            cbxEstado.Margin = new Padding(3, 2, 3, 2);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(67, 21);
            cbxEstado.TabIndex = 87;
            cbxEstado.Text = "Estado";
            cbxEstado.UseVisualStyleBackColor = true;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(147, 168);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(184, 22);
            txtPrecioCompra.TabIndex = 76;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 171);
            label6.Name = "label6";
            label6.Size = new Size(115, 17);
            label6.TabIndex = 86;
            label6.Text = "Precio de compra";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(109, 32);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(250, 25);
            txtDescripcion.TabIndex = 77;
            // 
            // txtPrevioVenta
            // 
            txtPrevioVenta.Location = new Point(147, 139);
            txtPrevioVenta.Name = "txtPrevioVenta";
            txtPrevioVenta.Size = new Size(184, 22);
            txtPrevioVenta.TabIndex = 84;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 35);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 76;
            label4.Text = "Descripcion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 142);
            label8.Name = "label8";
            label8.Size = new Size(104, 17);
            label8.TabIndex = 82;
            label8.Text = "Precio de venta";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(423, 75);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(143, 22);
            txtStock.TabIndex = 81;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCyan;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(365, 29);
            button2.Name = "button2";
            button2.Size = new Size(68, 28);
            button2.TabIndex = 66;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(400, 116);
            label13.Name = "label13";
            label13.Size = new Size(35, 17);
            label13.TabIndex = 73;
            label13.Text = "Talla";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(375, 81);
            label16.Name = "label16";
            label16.Size = new Size(42, 17);
            label16.TabIndex = 80;
            label16.Text = "Stock";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "12", "14", "16", "S", "M", "L", "XL" });
            comboBox3.Location = new Point(456, 113);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(59, 25);
            comboBox3.TabIndex = 72;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(115, 64);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(216, 25);
            comboBox2.TabIndex = 71;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(115, 99);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 25);
            comboBox1.TabIndex = 70;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(48, 102);
            label12.Name = "label12";
            label12.Size = new Size(55, 17);
            label12.TabIndex = 69;
            label12.Text = "Colegio";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(34, 67);
            label11.Name = "label11";
            label11.Size = new Size(69, 17);
            label11.TabIndex = 68;
            label11.Text = "Categoria";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(738, 233);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 64;
            label9.Text = "ID";
            // 
            // button3
            // 
            button3.BackColor = Color.PowderBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(706, 12);
            button3.Name = "button3";
            button3.Size = new Size(94, 41);
            button3.TabIndex = 83;
            button3.Text = "Nuevo";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // BtnRemovPro
            // 
            BtnRemovPro.BackColor = Color.PowderBlue;
            BtnRemovPro.FlatAppearance.BorderSize = 0;
            BtnRemovPro.FlatStyle = FlatStyle.Flat;
            BtnRemovPro.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRemovPro.Location = new Point(706, 205);
            BtnRemovPro.Name = "BtnRemovPro";
            BtnRemovPro.Size = new Size(94, 42);
            BtnRemovPro.TabIndex = 81;
            BtnRemovPro.Text = "Cancelar";
            BtnRemovPro.UseVisualStyleBackColor = false;
            BtnRemovPro.Click += BtnRemovPro_Click;
            // 
            // btnEditPro
            // 
            btnEditPro.BackColor = Color.PowderBlue;
            btnEditPro.FlatAppearance.BorderSize = 0;
            btnEditPro.FlatStyle = FlatStyle.Flat;
            btnEditPro.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditPro.Location = new Point(706, 107);
            btnEditPro.Name = "btnEditPro";
            btnEditPro.Size = new Size(94, 42);
            btnEditPro.TabIndex = 80;
            btnEditPro.Text = "Modificar";
            btnEditPro.UseVisualStyleBackColor = false;
            btnEditPro.Click += btnEditPro_Click;
            // 
            // Prendas1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(851, 573);
            Controls.Add(btnAgregarPre);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(BtnRemovPro);
            Controls.Add(btnEditPro);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Prendas1";
            Text = "Prendas1";
            Load += Prendas1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarPre;
        private DataGridView dataGridView1;
        private Button button1;
        private GroupBox groupBox1;
        private CheckBox cbxEstado;
        private TextBox txtPrecioCompra;
        private Label label6;
        private TextBox txtDescripcion;
        private TextBox txtPrevioVenta;
        private Label label4;
        private Label label8;
        private TextBox txtStock;
        private Label label13;
        private Label label16;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label12;
        private Label label11;
        private Button button2;
        private Label label9;
        private Button button3;
        private Button BtnRemovPro;
        private Button btnEditPro;
    }
}
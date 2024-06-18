namespace Proyecto_Minerva
{
    partial class Produc_mat
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            radbtnProd = new RadioButton();
            radioButton2 = new RadioButton();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            IDmat = new DataGridViewTextBoxColumn();
            Material = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            btnAgrePro = new Button();
            btnEditPro = new Button();
            BtnRemovPro = new Button();
            btnRemovMat = new Button();
            btnEditMat = new Button();
            btnAgreMat = new Button();
            label4 = new Label();
            textBox7 = new TextBox();
            button1 = new Button();
            label9 = new Label();
            textBox8 = new TextBox();
            button2 = new Button();
            label10 = new Label();
            ID = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Talla = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 71);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Uniforme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 106);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 133);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Talla";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(436, 9);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 4;
            label5.Text = "Materiales";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(352, 67);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 5;
            label6.Text = "Material";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(352, 94);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 6;
            label7.Text = "Stock";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(332, 127);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 7;
            label8.Text = "Descripcion";
            // 
            // radbtnProd
            // 
            radbtnProd.AutoSize = true;
            radbtnProd.Checked = true;
            radbtnProd.Location = new Point(260, 12);
            radbtnProd.Name = "radbtnProd";
            radbtnProd.Size = new Size(80, 19);
            radbtnProd.TabIndex = 8;
            radbtnProd.TabStop = true;
            radbtnProd.Text = "Uniformes";
            radbtnProd.UseVisualStyleBackColor = true;
            radbtnProd.CheckedChanged += radbtnProd_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(260, 37);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(79, 19);
            radioButton2.TabIndex = 9;
            radioButton2.Text = "Materiales";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Producto, Stock, Talla });
            dataGridView1.Location = new Point(9, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(298, 180);
            dataGridView1.TabIndex = 10;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { IDmat, Material, Descripcion, Cantidad });
            dataGridView2.Location = new Point(319, 162);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(318, 178);
            dataGridView2.TabIndex = 11;
            // 
            // IDmat
            // 
            IDmat.HeaderText = "ID Mat";
            IDmat.Name = "IDmat";
            IDmat.Width = 45;
            // 
            // Material
            // 
            Material.HeaderText = "Material";
            Material.Name = "Material";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 80;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Stock";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 50;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 23);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(69, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(83, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(69, 128);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(57, 23);
            textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(407, 63);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(111, 23);
            textBox3.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(407, 90);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(69, 23);
            textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(407, 117);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 39);
            textBox6.TabIndex = 18;
            // 
            // btnAgrePro
            // 
            btnAgrePro.Location = new Point(198, 77);
            btnAgrePro.Name = "btnAgrePro";
            btnAgrePro.Size = new Size(75, 23);
            btnAgrePro.TabIndex = 19;
            btnAgrePro.Text = "Agregar";
            btnAgrePro.UseVisualStyleBackColor = true;
            // 
            // btnEditPro
            // 
            btnEditPro.Location = new Point(198, 106);
            btnEditPro.Name = "btnEditPro";
            btnEditPro.Size = new Size(75, 23);
            btnEditPro.TabIndex = 20;
            btnEditPro.Text = "Editar";
            btnEditPro.UseVisualStyleBackColor = true;
            // 
            // BtnRemovPro
            // 
            BtnRemovPro.Location = new Point(198, 132);
            BtnRemovPro.Name = "BtnRemovPro";
            BtnRemovPro.Size = new Size(75, 23);
            BtnRemovPro.TabIndex = 21;
            BtnRemovPro.Text = "Eliminar";
            BtnRemovPro.UseVisualStyleBackColor = true;
            // 
            // btnRemovMat
            // 
            btnRemovMat.Location = new Point(574, 132);
            btnRemovMat.Name = "btnRemovMat";
            btnRemovMat.Size = new Size(75, 23);
            btnRemovMat.TabIndex = 24;
            btnRemovMat.Text = "Eliminar";
            btnRemovMat.UseVisualStyleBackColor = true;
            // 
            // btnEditMat
            // 
            btnEditMat.Location = new Point(575, 107);
            btnEditMat.Name = "btnEditMat";
            btnEditMat.Size = new Size(75, 23);
            btnEditMat.TabIndex = 23;
            btnEditMat.Text = "Editar";
            btnEditMat.UseVisualStyleBackColor = true;
            // 
            // btnAgreMat
            // 
            btnAgreMat.Location = new Point(575, 81);
            btnAgreMat.Name = "btnAgreMat";
            btnAgreMat.Size = new Size(75, 23);
            btnAgreMat.TabIndex = 22;
            btnAgreMat.Text = "Agregar";
            btnAgreMat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 44);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 25;
            label4.Text = "ID";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(406, 37);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(70, 23);
            textBox7.TabIndex = 26;
            // 
            // button1
            // 
            button1.Location = new Point(514, 37);
            button1.Name = "button1";
            button1.Size = new Size(66, 23);
            button1.TabIndex = 27;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 45);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 28;
            label9.Text = "ID";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(69, 41);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(57, 23);
            textBox8.TabIndex = 29;
            // 
            // button2
            // 
            button2.Location = new Point(132, 41);
            button2.Name = "button2";
            button2.Size = new Size(50, 23);
            button2.TabIndex = 30;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(82, 9);
            label10.Name = "label10";
            label10.Size = new Size(83, 21);
            label10.TabIndex = 31;
            label10.Text = "Uniformes";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 40;
            // 
            // Producto
            // 
            Producto.HeaderText = "Uniforme";
            Producto.Name = "Producto";
            Producto.Width = 120;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.Width = 60;
            // 
            // Talla
            // 
            Talla.HeaderText = "Talla";
            Talla.Name = "Talla";
            Talla.Width = 35;
            // 
            // Produc_mat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 352);
            Controls.Add(label10);
            Controls.Add(button2);
            Controls.Add(textBox8);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(label4);
            Controls.Add(btnRemovMat);
            Controls.Add(btnEditMat);
            Controls.Add(btnAgreMat);
            Controls.Add(BtnRemovPro);
            Controls.Add(btnEditPro);
            Controls.Add(btnAgrePro);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(radioButton2);
            Controls.Add(radbtnProd);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Produc_mat";
            Text = "Produc_mat";
            Load += Produc_mat_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private RadioButton radbtnProd;
        private RadioButton radioButton2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button btnAgrePro;
        private Button btnEditPro;
        private Button BtnRemovPro;
        private DataGridViewTextBoxColumn IDmat;
        private DataGridViewTextBoxColumn Material;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Cantidad;
        private Button btnRemovMat;
        private Button btnEditMat;
        private Button btnAgreMat;
        private Label label4;
        private TextBox textBox7;
        private Button button1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Talla;
        private Label label9;
        private TextBox textBox8;
        private Button button2;
        private Label label10;
    }
}
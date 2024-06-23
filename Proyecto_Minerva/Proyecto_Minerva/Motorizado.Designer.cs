namespace Proyecto_Minerva
{
    partial class Motorizado
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
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnBuscMot = new Button();
            Codigo = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            F_ing = new DataGridViewTextBoxColumn();
            Empresa = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            btnAgreMot = new Button();
            btnEditMot = new Button();
            btnElimMot = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox9 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label12 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            BuscDsc = new Button();
            btnElimDsc = new Button();
            btnEditDsc = new Button();
            btnAgreDsc = new Button();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            F__inic = new DataGridViewTextBoxColumn();
            F_fin = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(110, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 0;
            label1.Text = "Motorizados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 24);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Cod Motorizado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 55);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 79);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 108);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Empresa";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(73, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(124, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(109, 76);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(54, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(109, 105);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(76, 23);
            textBox4.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(btnBuscMot);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(4, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 139);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombres, F_ing, Empresa, Telefono });
            dataGridView1.Location = new Point(4, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(398, 166);
            dataGridView1.TabIndex = 10;
            // 
            // btnBuscMot
            // 
            btnBuscMot.Location = new Point(239, 46);
            btnBuscMot.Name = "btnBuscMot";
            btnBuscMot.Size = new Size(60, 23);
            btnBuscMot.TabIndex = 11;
            btnBuscMot.Text = "Buscar";
            btnBuscMot.UseVisualStyleBackColor = true;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.Width = 50;
            // 
            // Nombres
            // 
            Nombres.HeaderText = "Nombres";
            Nombres.Name = "Nombres";
            Nombres.Width = 110;
            // 
            // F_ing
            // 
            F_ing.HeaderText = "F. ingreso";
            F_ing.Name = "F_ing";
            F_ing.Width = 70;
            // 
            // Empresa
            // 
            Empresa.HeaderText = "Empresa";
            Empresa.Name = "Empresa";
            Empresa.Width = 65;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.Width = 60;
            // 
            // btnAgreMot
            // 
            btnAgreMot.Location = new Point(316, 68);
            btnAgreMot.Name = "btnAgreMot";
            btnAgreMot.Size = new Size(75, 23);
            btnAgreMot.TabIndex = 11;
            btnAgreMot.Text = "Agregar";
            btnAgreMot.UseVisualStyleBackColor = true;
            // 
            // btnEditMot
            // 
            btnEditMot.Location = new Point(316, 103);
            btnEditMot.Name = "btnEditMot";
            btnEditMot.Size = new Size(75, 23);
            btnEditMot.TabIndex = 12;
            btnEditMot.Text = "Editar";
            btnEditMot.UseVisualStyleBackColor = true;
            // 
            // btnElimMot
            // 
            btnElimMot.Location = new Point(316, 132);
            btnElimMot.Name = "btnElimMot";
            btnElimMot.Size = new Size(75, 23);
            btnElimMot.TabIndex = 13;
            btnElimMot.Text = "Eliminar";
            btnElimMot.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(520, 10);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 14;
            label6.Text = "Descuentos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 53);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 15;
            label7.Text = "Descuento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 24);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 16;
            label8.Text = "ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(200, 7);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 17;
            label9.Text = "F. Inicio";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(197, 59);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 18;
            label10.Text = "F. Limite";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(27, 79);
            label11.Name = "label11";
            label11.Size = new Size(33, 15);
            label11.TabIndex = 19;
            label11.Text = "Valor";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(78, 20);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(46, 23);
            textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(79, 48);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 21;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(79, 75);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(207, 105);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(78, 23);
            dateTimePicker1.TabIndex = 25;
            dateTimePicker1.UseWaitCursor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(207, 84);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 26;
            label12.Text = "F. Ingreso";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(185, 28);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(78, 23);
            dateTimePicker2.TabIndex = 27;
            dateTimePicker2.UseWaitCursor = true;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "dd-MM-yyyy";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(185, 78);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(78, 23);
            dateTimePicker3.TabIndex = 28;
            dateTimePicker3.UseWaitCursor = true;
            // 
            // BuscDsc
            // 
            BuscDsc.Location = new Point(130, 20);
            BuscDsc.Name = "BuscDsc";
            BuscDsc.Size = new Size(50, 23);
            BuscDsc.TabIndex = 29;
            BuscDsc.Text = "Busca";
            BuscDsc.UseVisualStyleBackColor = true;
            // 
            // btnElimDsc
            // 
            btnElimDsc.Location = new Point(704, 121);
            btnElimDsc.Name = "btnElimDsc";
            btnElimDsc.Size = new Size(75, 23);
            btnElimDsc.TabIndex = 32;
            btnElimDsc.Text = "Eliminar";
            btnElimDsc.UseVisualStyleBackColor = true;
            // 
            // btnEditDsc
            // 
            btnEditDsc.Location = new Point(704, 92);
            btnEditDsc.Name = "btnEditDsc";
            btnEditDsc.Size = new Size(75, 23);
            btnEditDsc.TabIndex = 31;
            btnEditDsc.Text = "Editar";
            btnEditDsc.UseVisualStyleBackColor = true;
            // 
            // btnAgreDsc
            // 
            btnAgreDsc.Location = new Point(704, 57);
            btnAgreDsc.Name = "btnAgreDsc";
            btnAgreDsc.Size = new Size(75, 23);
            btnAgreDsc.TabIndex = 30;
            btnAgreDsc.Text = "Agregar";
            btnAgreDsc.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BuscDsc);
            groupBox2.Controls.Add(dateTimePicker3);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(423, 43);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(272, 117);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ID, Descuento, Valor, F__inic, F_fin });
            dataGridView2.Location = new Point(410, 169);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(377, 177);
            dataGridView2.TabIndex = 34;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 50;
            // 
            // Descuento
            // 
            Descuento.HeaderText = "Descuento";
            Descuento.Name = "Descuento";
            Descuento.Width = 85;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.Width = 55;
            // 
            // F__inic
            // 
            F__inic.HeaderText = "F. Inicio";
            F__inic.Name = "F__inic";
            F__inic.Width = 72;
            // 
            // F_fin
            // 
            F_fin.HeaderText = "F.Limite";
            F_fin.Name = "F_fin";
            F_fin.Width = 72;
            // 
            // Motorizado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 360);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox2);
            Controls.Add(btnElimDsc);
            Controls.Add(btnEditDsc);
            Controls.Add(btnAgreDsc);
            Controls.Add(label6);
            Controls.Add(btnElimMot);
            Controls.Add(btnEditMot);
            Controls.Add(btnAgreMot);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Motorizado";
            Text = "Motorizado";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button btnBuscMot;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn F_ing;
        private DataGridViewTextBoxColumn Empresa;
        private DataGridViewTextBoxColumn Telefono;
        private Button btnAgreMot;
        private Button btnEditMot;
        private Button btnElimMot;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox9;
        private Label label12;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private Button BuscDsc;
        private Button btnElimDsc;
        private Button btnEditDsc;
        private Button btnAgreDsc;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn F__inic;
        private DataGridViewTextBoxColumn F_fin;
    }
}
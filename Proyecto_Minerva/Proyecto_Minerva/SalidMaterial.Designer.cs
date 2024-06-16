namespace Proyecto_Minerva
{
    partial class SalidMaterial
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
            label6 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Material = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            F_sol = new DataGridViewTextBoxColumn();
            Motivo = new DataGridViewTextBoxColumn();
            Cant_sol = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(260, 11);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 0;
            label1.Text = "Salida Materiales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 144);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "F. Solicitud";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 21);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Material";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 15);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "F. Salida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 170);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 4;
            label5.Text = "Motivo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 56);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 5;
            label6.Text = "Descripcion";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(123, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(97, 163);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(97, 50);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 80);
            textBox4.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 196);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 10;
            label7.Text = "Cantidad Sol.";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(97, 191);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(67, 23);
            textBox5.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(81, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(98, 23);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.UseWaitCursor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(97, 136);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(98, 23);
            dateTimePicker2.TabIndex = 16;
            dateTimePicker2.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Material, Descripcion, F_sol, Motivo, Cant_sol });
            dataGridView1.Location = new Point(245, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(415, 240);
            dataGridView1.TabIndex = 17;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 25;
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
            // F_sol
            // 
            F_sol.HeaderText = "F.Solicitud";
            F_sol.Name = "F_sol";
            F_sol.Width = 60;
            // 
            // Motivo
            // 
            Motivo.HeaderText = "Motivo";
            Motivo.Name = "Motivo";
            Motivo.Width = 60;
            // 
            // Cant_sol
            // 
            Cant_sol.HeaderText = "C. Solicita";
            Cant_sol.Name = "Cant_sol";
            Cant_sol.Width = 47;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(8, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 224);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info Solicitud";
            // 
            // button1
            // 
            button1.Location = new Point(57, 270);
            button1.Name = "button1";
            button1.Size = new Size(139, 27);
            button1.TabIndex = 19;
            button1.Text = "Registrar O. Salida";
            button1.UseVisualStyleBackColor = true;
            // 
            // SalidMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 303);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalidMaterial";
            Text = "SalidMaterial";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Material;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn F_sol;
        private DataGridViewTextBoxColumn Motivo;
        private DataGridViewTextBoxColumn Cant_sol;
        private GroupBox groupBox1;
        private Button button1;
    }
}
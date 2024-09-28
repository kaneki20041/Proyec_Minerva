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
            btnAgrega = new Button();
            button2 = new Button();
            button3 = new Button();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCategoria
            // 
            dgvCategoria.BackgroundColor = Color.MintCream;
            dgvCategoria.BorderStyle = BorderStyle.None;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(282, 43);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.Size = new Size(524, 477);
            dgvCategoria.TabIndex = 3;
            // 
            // btnAgrega
            // 
            btnAgrega.BackColor = Color.LightBlue;
            btnAgrega.FlatAppearance.BorderSize = 0;
            btnAgrega.FlatStyle = FlatStyle.Flat;
            btnAgrega.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgrega.Location = new Point(80, 315);
            btnAgrega.Name = "btnAgrega";
            btnAgrega.Size = new Size(105, 42);
            btnAgrega.TabIndex = 4;
            btnAgrega.Text = "Agregar";
            btnAgrega.UseVisualStyleBackColor = false;
            btnAgrega.Click += btnAgrega_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(80, 363);
            button2.Name = "button2";
            button2.Size = new Size(105, 42);
            button2.TabIndex = 5;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(80, 411);
            button3.Name = "button3";
            button3.Size = new Size(105, 42);
            button3.TabIndex = 6;
            button3.Text = "Deshabilitar";
            button3.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(72, 87);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 21);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Estado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 22);
            textBox1.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(31, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(217, 137);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Descripcion";
            // 
            // Categoriaa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(851, 573);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnAgrega);
            Controls.Add(dgvCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Categoriaa";
            Text = "Categoriaa";
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvCategoria;
        private Button btnAgrega;
        private Button button2;
        private Button button3;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private GroupBox groupBox1;
    }
}
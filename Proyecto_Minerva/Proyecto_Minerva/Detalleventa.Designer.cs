namespace Proyecto_Minerva
{
    partial class Detalleventa
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
            dgvDetalleventa = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            gbIDVenta = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleventa).BeginInit();
            gbIDVenta.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDetalleventa
            // 
            dgvDetalleventa.BackgroundColor = Color.MintCream;
            dgvDetalleventa.BorderStyle = BorderStyle.None;
            dgvDetalleventa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleventa.Location = new Point(286, 38);
            dgvDetalleventa.Name = "dgvDetalleventa";
            dgvDetalleventa.RowHeadersWidth = 51;
            dgvDetalleventa.RowTemplate.Height = 25;
            dgvDetalleventa.Size = new Size(523, 500);
            dgvDetalleventa.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.PowderBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(55, 97);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(88, 36);
            button1.TabIndex = 18;
            button1.Text = "Mostrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 53);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 22);
            textBox1.TabIndex = 19;
            // 
            // gbIDVenta
            // 
            gbIDVenta.Controls.Add(button1);
            gbIDVenta.Controls.Add(textBox1);
            gbIDVenta.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbIDVenta.Location = new Point(45, 186);
            gbIDVenta.Name = "gbIDVenta";
            gbIDVenta.Size = new Size(200, 155);
            gbIDVenta.TabIndex = 21;
            gbIDVenta.TabStop = false;
            gbIDVenta.Text = "ID Venta";
            // 
            // Detalleventa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(851, 573);
            Controls.Add(gbIDVenta);
            Controls.Add(dgvDetalleventa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Detalleventa";
            Text = "SalidMaterial";
            ((System.ComponentModel.ISupportInitialize)dgvDetalleventa).EndInit();
            gbIDVenta.ResumeLayout(false);
            gbIDVenta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvDetalleventa;
        private Button button1;
        private TextBox textBox1;
        private GroupBox gbIDVenta;
    }
}
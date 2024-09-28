namespace Proyecto_Minerva
{
    partial class Desc_Formpago
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
            label3 = new Label();
            label4 = new Label();
            cbkEstMetPago = new CheckBox();
            txtid = new TextBox();
            txtMetpago = new TextBox();
            dgvMetPago = new DataGridView();
            btnCancelFpag = new Button();
            btnModFpag = new Button();
            btnAgreMpag = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1 = new GroupBox();
            btnEstado = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvMetPago).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 65);
            label3.Name = "label3";
            label3.Size = new Size(20, 17);
            label3.TabIndex = 39;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(158, 94);
            label4.Name = "label4";
            label4.Size = new Size(91, 17);
            label4.TabIndex = 40;
            label4.Text = "Metodo pago";
            // 
            // cbkEstMetPago
            // 
            cbkEstMetPago.AutoSize = true;
            cbkEstMetPago.Checked = true;
            cbkEstMetPago.CheckState = CheckState.Checked;
            cbkEstMetPago.Location = new Point(286, 119);
            cbkEstMetPago.Name = "cbkEstMetPago";
            cbkEstMetPago.Size = new Size(67, 21);
            cbkEstMetPago.TabIndex = 41;
            cbkEstMetPago.Text = "Estado";
            cbkEstMetPago.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            txtid.Location = new Point(258, 62);
            txtid.Name = "txtid";
            txtid.Size = new Size(130, 22);
            txtid.TabIndex = 42;
            txtid.TextChanged += textBox1_TextChanged;
            // 
            // txtMetpago
            // 
            txtMetpago.Location = new Point(258, 91);
            txtMetpago.Name = "txtMetpago";
            txtMetpago.Size = new Size(130, 22);
            txtMetpago.TabIndex = 43;
            // 
            // dgvMetPago
            // 
            dgvMetPago.BackgroundColor = Color.MintCream;
            dgvMetPago.BorderStyle = BorderStyle.None;
            dgvMetPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMetPago.Location = new Point(19, 34);
            dgvMetPago.Name = "dgvMetPago";
            dgvMetPago.RowTemplate.Height = 25;
            dgvMetPago.Size = new Size(634, 284);
            dgvMetPago.TabIndex = 44;
            // 
            // btnCancelFpag
            // 
            btnCancelFpag.BackColor = Color.LightCyan;
            btnCancelFpag.FlatAppearance.BorderSize = 0;
            btnCancelFpag.FlatStyle = FlatStyle.Flat;
            btnCancelFpag.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelFpag.Location = new Point(536, 101);
            btnCancelFpag.Name = "btnCancelFpag";
            btnCancelFpag.Size = new Size(101, 36);
            btnCancelFpag.TabIndex = 47;
            btnCancelFpag.Text = "Cancelar";
            btnCancelFpag.UseVisualStyleBackColor = false;
            btnCancelFpag.Click += btnCancelFpag_Click;
            // 
            // btnModFpag
            // 
            btnModFpag.BackColor = Color.LightCyan;
            btnModFpag.FlatAppearance.BorderSize = 0;
            btnModFpag.FlatStyle = FlatStyle.Flat;
            btnModFpag.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModFpag.Location = new Point(429, 102);
            btnModFpag.Name = "btnModFpag";
            btnModFpag.Size = new Size(101, 34);
            btnModFpag.TabIndex = 46;
            btnModFpag.Text = "Modificar";
            btnModFpag.UseVisualStyleBackColor = false;
            btnModFpag.Click += btnModFpag_Click;
            // 
            // btnAgreMpag
            // 
            btnAgreMpag.BackColor = Color.LightCyan;
            btnAgreMpag.FlatAppearance.BorderSize = 0;
            btnAgreMpag.FlatStyle = FlatStyle.Flat;
            btnAgreMpag.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgreMpag.Location = new Point(429, 62);
            btnAgreMpag.Name = "btnAgreMpag";
            btnAgreMpag.Size = new Size(101, 34);
            btnAgreMpag.TabIndex = 45;
            btnAgreMpag.Text = "Agregar";
            btnAgreMpag.UseVisualStyleBackColor = false;
            btnAgreMpag.Click += btnAgreMpag_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(676, 175);
            button4.Name = "button4";
            button4.Size = new Size(85, 36);
            button4.TabIndex = 50;
            button4.Text = "Editar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(676, 133);
            button5.Name = "button5";
            button5.Size = new Size(85, 36);
            button5.TabIndex = 49;
            button5.Text = "Nuevo";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightCyan;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(536, 62);
            button6.Name = "button6";
            button6.Size = new Size(101, 34);
            button6.TabIndex = 48;
            button6.Text = "Deshabilitar";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEstado);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(dgvMetPago);
            groupBox1.Location = new Point(23, 214);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 339);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Text = "Metodos de pago";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnEstado
            // 
            btnEstado.BackColor = Color.LightBlue;
            btnEstado.FlatAppearance.BorderSize = 0;
            btnEstado.FlatStyle = FlatStyle.Flat;
            btnEstado.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEstado.Location = new Point(676, 217);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(85, 36);
            btnEstado.TabIndex = 51;
            btnEstado.Text = "Estado";
            btnEstado.UseVisualStyleBackColor = false;
            btnEstado.Click += btnEstado_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCancelFpag);
            groupBox2.Controls.Add(txtMetpago);
            groupBox2.Controls.Add(btnModFpag);
            groupBox2.Controls.Add(txtid);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(cbkEstMetPago);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnAgreMpag);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(23, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(780, 181);
            groupBox2.TabIndex = 52;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion";
            // 
            // Desc_Formpago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(851, 573);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Desc_Formpago";
            Text = "Motorizado";
            Load += Desc_Formpago_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMetPago).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Label label4;
        private CheckBox cbkEstMetPago;
        private TextBox txtid;
        private TextBox txtMetpago;
        private DataGridView dgvMetPago;
        private Button btnCancelFpag;
        private Button btnModFpag;
        private Button btnAgreMpag;
        private Button button4;
        private Button button5;
        private Button button6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnEstado;
    }
}
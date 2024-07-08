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
            label2 = new Label();
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
            groupBox2 = new GroupBox();
            btnEstado = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMetPago).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(116, 19);
            label2.Name = "label2";
            label2.Size = new Size(161, 28);
            label2.TabIndex = 38;
            label2.Text = "Metodo de pago";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 29);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 39;
            label3.Text = "ID M. Pago";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 68);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 40;
            label4.Text = "Metodo pago";
            // 
            // cbkEstMetPago
            // 
            cbkEstMetPago.AutoSize = true;
            cbkEstMetPago.Checked = true;
            cbkEstMetPago.CheckState = CheckState.Checked;
            cbkEstMetPago.Location = new Point(62, 107);
            cbkEstMetPago.Name = "cbkEstMetPago";
            cbkEstMetPago.Size = new Size(103, 19);
            cbkEstMetPago.TabIndex = 41;
            cbkEstMetPago.Text = "Estado F. pago";
            cbkEstMetPago.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            txtid.Location = new Point(104, 26);
            txtid.Name = "txtid";
            txtid.Size = new Size(78, 23);
            txtid.TabIndex = 42;
            txtid.TextChanged += textBox1_TextChanged;
            // 
            // txtMetpago
            // 
            txtMetpago.Location = new Point(104, 65);
            txtMetpago.Name = "txtMetpago";
            txtMetpago.Size = new Size(130, 23);
            txtMetpago.TabIndex = 43;
            // 
            // dgvMetPago
            // 
            dgvMetPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMetPago.Location = new Point(25, 28);
            dgvMetPago.Name = "dgvMetPago";
            dgvMetPago.RowTemplate.Height = 25;
            dgvMetPago.Size = new Size(314, 162);
            dgvMetPago.TabIndex = 44;
            // 
            // btnCancelFpag
            // 
            btnCancelFpag.Location = new Point(253, 97);
            btnCancelFpag.Name = "btnCancelFpag";
            btnCancelFpag.Size = new Size(75, 23);
            btnCancelFpag.TabIndex = 47;
            btnCancelFpag.Text = "Cancelar";
            btnCancelFpag.UseVisualStyleBackColor = true;
            btnCancelFpag.Click += btnCancelFpag_Click;
            // 
            // btnModFpag
            // 
            btnModFpag.Location = new Point(253, 58);
            btnModFpag.Name = "btnModFpag";
            btnModFpag.Size = new Size(75, 23);
            btnModFpag.TabIndex = 46;
            btnModFpag.Text = "Modificar";
            btnModFpag.UseVisualStyleBackColor = true;
            btnModFpag.Click += btnModFpag_Click;
            // 
            // btnAgreMpag
            // 
            btnAgreMpag.Location = new Point(253, 23);
            btnAgreMpag.Name = "btnAgreMpag";
            btnAgreMpag.Size = new Size(75, 23);
            btnAgreMpag.TabIndex = 45;
            btnAgreMpag.Text = "Agregar";
            btnAgreMpag.UseVisualStyleBackColor = true;
            btnAgreMpag.Click += btnAgreMpag_Click;
            // 
            // button4
            // 
            button4.Location = new Point(146, 215);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 50;
            button4.Text = "Editar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(42, 215);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 49;
            button5.Text = "Nuevo";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(253, 126);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 48;
            button6.Text = "Deshabilitar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEstado);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(dgvMetPago);
            groupBox1.Location = new Point(371, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 264);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Text = "Metodos de pago";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCancelFpag);
            groupBox2.Controls.Add(btnModFpag);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(btnAgreMpag);
            groupBox2.Controls.Add(txtMetpago);
            groupBox2.Controls.Add(txtid);
            groupBox2.Controls.Add(cbkEstMetPago);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 166);
            groupBox2.TabIndex = 52;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion M.Pago";
            // 
            // btnEstado
            // 
            btnEstado.Location = new Point(251, 215);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(75, 23);
            btnEstado.TabIndex = 51;
            btnEstado.Text = "Estado";
            btnEstado.UseVisualStyleBackColor = true;
            btnEstado.Click += btnEstado_Click;
            // 
            // Desc_Formpago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 331);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Desc_Formpago";
            Text = "Motorizado";
            Load += Desc_Formpago_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMetPago).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
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
namespace Proyecto_Minerva
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btn_venderu;
            Button btn_Cliente;
            Button btn_IngMaterial;
            Button btnSalidaMaterial;
            Button btn_Matyprod;
            Button button2;
            Button btnMotorizado;
            Button btnDetalleComp;
            Button btnUsuarios;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            btnCategoria = new Button();
            panel1 = new Panel();
            lblUser = new Label();
            pictureBox5 = new PictureBox();
            btnMinimizar = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel8 = new Panel();
            panel12 = new Panel();
            panel7 = new Panel();
            panel11 = new Panel();
            panel10 = new Panel();
            panel9 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panelconteiner = new Panel();
            btn_venderu = new Button();
            btn_Cliente = new Button();
            btn_IngMaterial = new Button();
            btnSalidaMaterial = new Button();
            btn_Matyprod = new Button();
            button2 = new Button();
            btnMotorizado = new Button();
            btnDetalleComp = new Button();
            btnUsuarios = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_venderu
            // 
            btn_venderu.Cursor = Cursors.Hand;
            btn_venderu.FlatAppearance.BorderSize = 0;
            btn_venderu.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btn_venderu.FlatStyle = FlatStyle.Flat;
            btn_venderu.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_venderu.Location = new Point(12, 49);
            btn_venderu.Name = "btn_venderu";
            btn_venderu.Size = new Size(176, 37);
            btn_venderu.TabIndex = 0;
            btn_venderu.Text = "Vender Prendas";
            btn_venderu.TextAlign = ContentAlignment.MiddleRight;
            btn_venderu.UseVisualStyleBackColor = true;
            btn_venderu.Click += btn_venderu_Click;
            // 
            // btn_Cliente
            // 
            btn_Cliente.Cursor = Cursors.Hand;
            btn_Cliente.FlatAppearance.BorderSize = 0;
            btn_Cliente.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btn_Cliente.FlatStyle = FlatStyle.Flat;
            btn_Cliente.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cliente.Location = new Point(12, 135);
            btn_Cliente.Name = "btn_Cliente";
            btn_Cliente.Size = new Size(176, 37);
            btn_Cliente.TabIndex = 3;
            btn_Cliente.Text = "Registrar Cliente";
            btn_Cliente.TextAlign = ContentAlignment.MiddleRight;
            btn_Cliente.UseVisualStyleBackColor = true;
            btn_Cliente.Click += btn_Cliente_Click;
            // 
            // btn_IngMaterial
            // 
            btn_IngMaterial.Cursor = Cursors.Hand;
            btn_IngMaterial.FlatAppearance.BorderSize = 0;
            btn_IngMaterial.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btn_IngMaterial.FlatStyle = FlatStyle.Flat;
            btn_IngMaterial.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_IngMaterial.Location = new Point(12, 352);
            btn_IngMaterial.Name = "btn_IngMaterial";
            btn_IngMaterial.Size = new Size(176, 37);
            btn_IngMaterial.TabIndex = 4;
            btn_IngMaterial.Text = "Detalle Compras";
            btn_IngMaterial.TextAlign = ContentAlignment.MiddleRight;
            btn_IngMaterial.UseVisualStyleBackColor = true;
            btn_IngMaterial.Click += btn_IngMaterial_Click;
            // 
            // btnSalidaMaterial
            // 
            btnSalidaMaterial.Cursor = Cursors.Hand;
            btnSalidaMaterial.FlatAppearance.BorderSize = 0;
            btnSalidaMaterial.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnSalidaMaterial.FlatStyle = FlatStyle.Flat;
            btnSalidaMaterial.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalidaMaterial.Location = new Point(12, 309);
            btnSalidaMaterial.Name = "btnSalidaMaterial";
            btnSalidaMaterial.Size = new Size(176, 37);
            btnSalidaMaterial.TabIndex = 6;
            btnSalidaMaterial.Text = "Detalle Ventas";
            btnSalidaMaterial.TextAlign = ContentAlignment.MiddleRight;
            btnSalidaMaterial.UseVisualStyleBackColor = true;
            btnSalidaMaterial.Click += btnSalidaMaterial_Click;
            // 
            // btn_Matyprod
            // 
            btn_Matyprod.Cursor = Cursors.Hand;
            btn_Matyprod.FlatAppearance.BorderSize = 0;
            btn_Matyprod.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btn_Matyprod.FlatStyle = FlatStyle.Flat;
            btn_Matyprod.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Matyprod.Location = new Point(12, 178);
            btn_Matyprod.Name = "btn_Matyprod";
            btn_Matyprod.Size = new Size(176, 37);
            btn_Matyprod.TabIndex = 7;
            btn_Matyprod.Text = "Prendas";
            btn_Matyprod.TextAlign = ContentAlignment.MiddleRight;
            btn_Matyprod.UseVisualStyleBackColor = true;
            btn_Matyprod.Click += btn_Matyprod_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 223);
            button2.Name = "button2";
            button2.Size = new Size(176, 37);
            button2.TabIndex = 8;
            button2.Text = "Proveedores";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnMotorizado
            // 
            btnMotorizado.Cursor = Cursors.Hand;
            btnMotorizado.FlatAppearance.BorderSize = 0;
            btnMotorizado.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnMotorizado.FlatStyle = FlatStyle.Flat;
            btnMotorizado.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMotorizado.Location = new Point(12, 266);
            btnMotorizado.Name = "btnMotorizado";
            btnMotorizado.Size = new Size(176, 37);
            btnMotorizado.TabIndex = 9;
            btnMotorizado.Text = "Metodo Pago";
            btnMotorizado.TextAlign = ContentAlignment.MiddleRight;
            btnMotorizado.UseVisualStyleBackColor = true;
            btnMotorizado.Click += btnMotorizado_Click;
            // 
            // btnDetalleComp
            // 
            btnDetalleComp.Cursor = Cursors.Hand;
            btnDetalleComp.FlatAppearance.BorderSize = 0;
            btnDetalleComp.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnDetalleComp.FlatStyle = FlatStyle.Flat;
            btnDetalleComp.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetalleComp.Location = new Point(12, 92);
            btnDetalleComp.Name = "btnDetalleComp";
            btnDetalleComp.Size = new Size(176, 37);
            btnDetalleComp.TabIndex = 10;
            btnDetalleComp.Text = "Comprar Prendas";
            btnDetalleComp.TextAlign = ContentAlignment.MiddleRight;
            btnDetalleComp.UseVisualStyleBackColor = true;
            btnDetalleComp.Click += btnDetalleComp_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.Location = new Point(12, 6);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(176, 37);
            btnUsuarios.TabIndex = 12;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnCategoria
            // 
            btnCategoria.Cursor = Cursors.Hand;
            btnCategoria.FlatAppearance.BorderSize = 0;
            btnCategoria.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnCategoria.FlatStyle = FlatStyle.Flat;
            btnCategoria.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategoria.Location = new Point(16, 395);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(176, 37);
            btnCategoria.TabIndex = 11;
            btnCategoria.Text = "Categorias";
            btnCategoria.TextAlign = ContentAlignment.MiddleRight;
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(btnMinimizar);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1039, 54);
            panel1.TabIndex = 0;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Century Gothic", 11.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(751, 18);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(146, 21);
            lblUser.TabIndex = 15;
            lblUser.Text = "lblNombreUsuario";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(962, 13);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(924, 13);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(32, 32);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 3;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(962, 15);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(999, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Khaki;
            panel2.Controls.Add(btnUsuarios);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel12);
            panel2.Controls.Add(btnCategoria);
            panel2.Controls.Add(btnDetalleComp);
            panel2.Controls.Add(btn_venderu);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel11);
            panel2.Controls.Add(btnMotorizado);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btn_Matyprod);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(btnSalidaMaterial);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(btn_IngMaterial);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btn_Cliente);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 573);
            panel2.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.Highlight;
            panel8.Location = new Point(0, 6);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 37);
            panel8.TabIndex = 13;
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.Highlight;
            panel12.Location = new Point(0, 395);
            panel12.Name = "panel12";
            panel12.Size = new Size(10, 37);
            panel12.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Highlight;
            panel7.Location = new Point(0, 352);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 37);
            panel7.TabIndex = 7;
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.Highlight;
            panel11.Location = new Point(0, 309);
            panel11.Name = "panel11";
            panel11.Size = new Size(10, 37);
            panel11.TabIndex = 6;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.Highlight;
            panel10.Location = new Point(0, 178);
            panel10.Name = "panel10";
            panel10.Size = new Size(10, 37);
            panel10.TabIndex = 4;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.Highlight;
            panel9.Location = new Point(0, 135);
            panel9.Name = "panel9";
            panel9.Size = new Size(10, 37);
            panel9.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Highlight;
            panel6.Location = new Point(0, 266);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 37);
            panel6.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Highlight;
            panel5.Location = new Point(0, 223);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 37);
            panel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Highlight;
            panel4.Location = new Point(0, 92);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 37);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Location = new Point(0, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 37);
            panel3.TabIndex = 1;
            // 
            // panelconteiner
            // 
            panelconteiner.BackColor = Color.MintCream;
            panelconteiner.Dock = DockStyle.Fill;
            panelconteiner.Location = new Point(188, 54);
            panelconteiner.Name = "panelconteiner";
            panelconteiner.Size = new Size(851, 573);
            panelconteiner.TabIndex = 2;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 627);
            Controls.Add(panelconteiner);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Principal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button btn_venderu;
        private Panel panel3;
        private PictureBox btnMinimizar;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private Panel panel10;
        private Panel panel9;
        private Panel panel11;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Panel panel7;
        private Panel panel12;
        private Button btnCategoria;
        private Label lblUser;
        private Panel panel8;
        private Panel panelconteiner;
    }
}
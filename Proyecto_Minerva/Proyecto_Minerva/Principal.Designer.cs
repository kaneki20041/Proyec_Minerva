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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            panel1 = new Panel();
            lblUser = new Label();
            pictureBox5 = new PictureBox();
            btnMinimizar = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            btnVenderPrendas = new FontAwesome.Sharp.IconButton();
            btnComprarPrendas = new FontAwesome.Sharp.IconButton();
            btn_Cliente = new FontAwesome.Sharp.IconButton();
            btnPrendas = new FontAwesome.Sharp.IconButton();
            btnProveedores = new FontAwesome.Sharp.IconButton();
            btnMetodoPago = new FontAwesome.Sharp.IconButton();
            btnSalidaMaterial = new FontAwesome.Sharp.IconButton();
            btn_IngMaterial = new FontAwesome.Sharp.IconButton();
            btnCategoria = new FontAwesome.Sharp.IconButton();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
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
            panel2.Controls.Add(btnVenderPrendas);
            panel2.Controls.Add(btnComprarPrendas);
            panel2.Controls.Add(btn_Cliente);
            panel2.Controls.Add(btnPrendas);
            panel2.Controls.Add(btnProveedores);
            panel2.Controls.Add(btnMetodoPago);
            panel2.Controls.Add(btnSalidaMaterial);
            panel2.Controls.Add(btn_IngMaterial);
            panel2.Controls.Add(btnCategoria);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel12);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel11);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 573);
            panel2.TabIndex = 1;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnUsuarios.IconColor = Color.Black;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.IconSize = 30;
            btnUsuarios.ImageAlign = ContentAlignment.TopLeft;
            btnUsuarios.Location = new Point(12, 6);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(176, 37);
            btnUsuarios.TabIndex = 23;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnVenderPrendas
            // 
            btnVenderPrendas.Cursor = Cursors.Hand;
            btnVenderPrendas.FlatAppearance.BorderSize = 0;
            btnVenderPrendas.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnVenderPrendas.FlatStyle = FlatStyle.Flat;
            btnVenderPrendas.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVenderPrendas.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            btnVenderPrendas.IconColor = Color.Black;
            btnVenderPrendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVenderPrendas.IconSize = 28;
            btnVenderPrendas.ImageAlign = ContentAlignment.TopLeft;
            btnVenderPrendas.Location = new Point(12, 49);
            btnVenderPrendas.Name = "btnVenderPrendas";
            btnVenderPrendas.Size = new Size(176, 37);
            btnVenderPrendas.TabIndex = 22;
            btnVenderPrendas.Text = "Vender Prendas";
            btnVenderPrendas.TextAlign = ContentAlignment.MiddleRight;
            btnVenderPrendas.UseVisualStyleBackColor = true;
            btnVenderPrendas.Click += btnVenderPrendas_Click;
            // 
            // btnComprarPrendas
            // 
            btnComprarPrendas.Cursor = Cursors.Hand;
            btnComprarPrendas.FlatAppearance.BorderSize = 0;
            btnComprarPrendas.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnComprarPrendas.FlatStyle = FlatStyle.Flat;
            btnComprarPrendas.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnComprarPrendas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnComprarPrendas.IconColor = Color.Black;
            btnComprarPrendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnComprarPrendas.IconSize = 28;
            btnComprarPrendas.ImageAlign = ContentAlignment.TopLeft;
            btnComprarPrendas.Location = new Point(12, 92);
            btnComprarPrendas.Name = "btnComprarPrendas";
            btnComprarPrendas.Size = new Size(176, 37);
            btnComprarPrendas.TabIndex = 21;
            btnComprarPrendas.Text = "Comprar Prendras";
            btnComprarPrendas.TextAlign = ContentAlignment.MiddleRight;
            btnComprarPrendas.UseVisualStyleBackColor = true;
            btnComprarPrendas.Click += btnComprarPrendas_Click;
            // 
            // btn_Cliente
            // 
            btn_Cliente.Cursor = Cursors.Hand;
            btn_Cliente.FlatAppearance.BorderSize = 0;
            btn_Cliente.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btn_Cliente.FlatStyle = FlatStyle.Flat;
            btn_Cliente.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cliente.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            btn_Cliente.IconColor = Color.Black;
            btn_Cliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Cliente.IconSize = 30;
            btn_Cliente.ImageAlign = ContentAlignment.TopLeft;
            btn_Cliente.Location = new Point(12, 135);
            btn_Cliente.Name = "btn_Cliente";
            btn_Cliente.Size = new Size(176, 37);
            btn_Cliente.TabIndex = 20;
            btn_Cliente.Text = "Registrar Cliente";
            btn_Cliente.TextAlign = ContentAlignment.MiddleRight;
            btn_Cliente.UseVisualStyleBackColor = true;
            btn_Cliente.Click += btn_Cliente_Click;
            // 
            // btnPrendas
            // 
            btnPrendas.Cursor = Cursors.Hand;
            btnPrendas.FlatAppearance.BorderSize = 0;
            btnPrendas.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnPrendas.FlatStyle = FlatStyle.Flat;
            btnPrendas.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrendas.IconChar = FontAwesome.Sharp.IconChar.Tshirt;
            btnPrendas.IconColor = Color.Black;
            btnPrendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrendas.IconSize = 30;
            btnPrendas.ImageAlign = ContentAlignment.TopLeft;
            btnPrendas.Location = new Point(12, 178);
            btnPrendas.Name = "btnPrendas";
            btnPrendas.Size = new Size(176, 37);
            btnPrendas.TabIndex = 19;
            btnPrendas.Text = "Prendas";
            btnPrendas.TextAlign = ContentAlignment.MiddleRight;
            btnPrendas.UseVisualStyleBackColor = true;
            btnPrendas.Click += btnPrendas_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Cursor = Cursors.Hand;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedores.IconChar = FontAwesome.Sharp.IconChar.Truck;
            btnProveedores.IconColor = Color.Black;
            btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProveedores.IconSize = 30;
            btnProveedores.ImageAlign = ContentAlignment.TopLeft;
            btnProveedores.Location = new Point(12, 223);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(176, 37);
            btnProveedores.TabIndex = 18;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = ContentAlignment.MiddleRight;
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnMetodoPago
            // 
            btnMetodoPago.Cursor = Cursors.Hand;
            btnMetodoPago.FlatAppearance.BorderSize = 0;
            btnMetodoPago.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnMetodoPago.FlatStyle = FlatStyle.Flat;
            btnMetodoPago.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMetodoPago.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            btnMetodoPago.IconColor = Color.Black;
            btnMetodoPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMetodoPago.IconSize = 25;
            btnMetodoPago.ImageAlign = ContentAlignment.BottomLeft;
            btnMetodoPago.Location = new Point(12, 266);
            btnMetodoPago.Name = "btnMetodoPago";
            btnMetodoPago.Size = new Size(176, 37);
            btnMetodoPago.TabIndex = 17;
            btnMetodoPago.Text = "Metodo Pago";
            btnMetodoPago.TextAlign = ContentAlignment.MiddleRight;
            btnMetodoPago.UseVisualStyleBackColor = true;
            btnMetodoPago.Click += btnMetodoPago_Click;
            // 
            // btnSalidaMaterial
            // 
            btnSalidaMaterial.Cursor = Cursors.Hand;
            btnSalidaMaterial.FlatAppearance.BorderSize = 0;
            btnSalidaMaterial.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnSalidaMaterial.FlatStyle = FlatStyle.Flat;
            btnSalidaMaterial.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalidaMaterial.IconChar = FontAwesome.Sharp.IconChar.Info;
            btnSalidaMaterial.IconColor = Color.Black;
            btnSalidaMaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalidaMaterial.IconSize = 25;
            btnSalidaMaterial.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalidaMaterial.Location = new Point(12, 309);
            btnSalidaMaterial.Name = "btnSalidaMaterial";
            btnSalidaMaterial.Size = new Size(176, 37);
            btnSalidaMaterial.TabIndex = 16;
            btnSalidaMaterial.Text = "Pago Ventas";
            btnSalidaMaterial.TextAlign = ContentAlignment.MiddleRight;
            btnSalidaMaterial.UseVisualStyleBackColor = true;
            btnSalidaMaterial.Click += btnSalidaMaterial_Click;
            // 
            // btn_IngMaterial
            // 
            btn_IngMaterial.Cursor = Cursors.Hand;
            btn_IngMaterial.FlatAppearance.BorderSize = 0;
            btn_IngMaterial.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btn_IngMaterial.FlatStyle = FlatStyle.Flat;
            btn_IngMaterial.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_IngMaterial.IconChar = FontAwesome.Sharp.IconChar.Info;
            btn_IngMaterial.IconColor = Color.Black;
            btn_IngMaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_IngMaterial.IconSize = 25;
            btn_IngMaterial.ImageAlign = ContentAlignment.MiddleLeft;
            btn_IngMaterial.Location = new Point(12, 352);
            btn_IngMaterial.Name = "btn_IngMaterial";
            btn_IngMaterial.Size = new Size(176, 37);
            btn_IngMaterial.TabIndex = 15;
            btn_IngMaterial.Text = "Detalle Compras";
            btn_IngMaterial.TextAlign = ContentAlignment.MiddleRight;
            btn_IngMaterial.UseVisualStyleBackColor = true;
            btn_IngMaterial.Click += btn_IngMaterial_Click;
            // 
            // btnCategoria
            // 
            btnCategoria.Cursor = Cursors.Hand;
            btnCategoria.FlatAppearance.BorderSize = 0;
            btnCategoria.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnCategoria.FlatStyle = FlatStyle.Flat;
            btnCategoria.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategoria.IconChar = FontAwesome.Sharp.IconChar.List;
            btnCategoria.IconColor = Color.Black;
            btnCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCategoria.IconSize = 25;
            btnCategoria.ImageAlign = ContentAlignment.BottomLeft;
            btnCategoria.Location = new Point(12, 395);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(176, 37);
            btnCategoria.TabIndex = 14;
            btnCategoria.Text = "Categorias";
            btnCategoria.TextAlign = ContentAlignment.MiddleRight;
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.Click += btnCategoria_Click;
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
        private Label lblUser;
        private Panel panel8;
        private Panel panelconteiner;
        private FontAwesome.Sharp.IconButton btnCategoria;
        private FontAwesome.Sharp.IconButton btn_IngMaterial;
        private FontAwesome.Sharp.IconButton btnSalidaMaterial;
        private FontAwesome.Sharp.IconButton btnMetodoPago;
        private FontAwesome.Sharp.IconButton btnProveedores;
        private FontAwesome.Sharp.IconButton btnPrendas;
        private FontAwesome.Sharp.IconButton btn_Cliente;
        private FontAwesome.Sharp.IconButton btnComprarPrendas;
        private FontAwesome.Sharp.IconButton btnVenderPrendas;
        private FontAwesome.Sharp.IconButton btnUsuarios;
    }
}
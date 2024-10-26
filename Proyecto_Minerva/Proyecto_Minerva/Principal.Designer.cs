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
            MenuLateral = new Panel();
            btnInventario = new FontAwesome.Sharp.IconButton();
            panelInventario = new Panel();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            btnVenderPrendas = new FontAwesome.Sharp.IconButton();
            btnComprarPrendas = new FontAwesome.Sharp.IconButton();
            btnCliente = new FontAwesome.Sharp.IconButton();
            btnPrendas = new FontAwesome.Sharp.IconButton();
            btnProveedores = new FontAwesome.Sharp.IconButton();
            btnMetodoPago = new FontAwesome.Sharp.IconButton();
            btnCarrito = new FontAwesome.Sharp.IconButton();
            btn_IngMaterial = new FontAwesome.Sharp.IconButton();
            btnCategoria = new FontAwesome.Sharp.IconButton();
            panelUsuario = new Panel();
            panelCategoria = new Panel();
            panelPagoComp = new Panel();
            panelPagoVent = new Panel();
            panelPrenda = new Panel();
            panelCliente = new Panel();
            panelMet = new Panel();
            panelProvee = new Panel();
            panelComprar = new Panel();
            panelVender = new Panel();
            panelconteiner = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            MenuLateral.SuspendLayout();
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
            lblUser.Location = new Point(551, 15);
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
            // MenuLateral
            // 
            MenuLateral.BackColor = Color.Khaki;
            MenuLateral.Controls.Add(btnInventario);
            MenuLateral.Controls.Add(panelInventario);
            MenuLateral.Controls.Add(btnUsuarios);
            MenuLateral.Controls.Add(btnVenderPrendas);
            MenuLateral.Controls.Add(btnComprarPrendas);
            MenuLateral.Controls.Add(btnCliente);
            MenuLateral.Controls.Add(btnPrendas);
            MenuLateral.Controls.Add(btnProveedores);
            MenuLateral.Controls.Add(btnMetodoPago);
            MenuLateral.Controls.Add(btnCarrito);
            MenuLateral.Controls.Add(btn_IngMaterial);
            MenuLateral.Controls.Add(btnCategoria);
            MenuLateral.Controls.Add(panelUsuario);
            MenuLateral.Controls.Add(panelCategoria);
            MenuLateral.Controls.Add(panelPagoComp);
            MenuLateral.Controls.Add(panelPagoVent);
            MenuLateral.Controls.Add(panelPrenda);
            MenuLateral.Controls.Add(panelCliente);
            MenuLateral.Controls.Add(panelMet);
            MenuLateral.Controls.Add(panelProvee);
            MenuLateral.Controls.Add(panelComprar);
            MenuLateral.Controls.Add(panelVender);
            MenuLateral.Dock = DockStyle.Left;
            MenuLateral.Location = new Point(0, 54);
            MenuLateral.Name = "MenuLateral";
            MenuLateral.Size = new Size(188, 573);
            MenuLateral.TabIndex = 1;
            // 
            // btnInventario
            // 
            btnInventario.Cursor = Cursors.Hand;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnInventario.IconChar = FontAwesome.Sharp.IconChar.Archive;
            btnInventario.IconColor = Color.Black;
            btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInventario.IconSize = 25;
            btnInventario.ImageAlign = ContentAlignment.BottomLeft;
            btnInventario.Location = new Point(12, 438);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(176, 37);
            btnInventario.TabIndex = 25;
            btnInventario.Text = "Inventario";
            btnInventario.TextAlign = ContentAlignment.MiddleRight;
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // panelInventario
            // 
            panelInventario.BackColor = SystemColors.Highlight;
            panelInventario.Location = new Point(0, 438);
            panelInventario.Name = "panelInventario";
            panelInventario.Size = new Size(10, 37);
            panelInventario.TabIndex = 24;
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
            btnComprarPrendas.IconChar = FontAwesome.Sharp.IconChar.Chain;
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
            // btnCliente
            // 
            btnCliente.Cursor = Cursors.Hand;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCliente.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            btnCliente.IconColor = Color.Black;
            btnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCliente.IconSize = 30;
            btnCliente.ImageAlign = ContentAlignment.TopLeft;
            btnCliente.Location = new Point(12, 135);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(176, 37);
            btnCliente.TabIndex = 20;
            btnCliente.Text = "Registrar Cliente";
            btnCliente.TextAlign = ContentAlignment.MiddleRight;
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btn_Cliente_Click;
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
            // btnCarrito
            // 
            btnCarrito.Cursor = Cursors.Hand;
            btnCarrito.FlatAppearance.BorderSize = 0;
            btnCarrito.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnCarrito.FlatStyle = FlatStyle.Flat;
            btnCarrito.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCarrito.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnCarrito.IconColor = Color.Black;
            btnCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCarrito.IconSize = 25;
            btnCarrito.ImageAlign = ContentAlignment.MiddleLeft;
            btnCarrito.Location = new Point(12, 309);
            btnCarrito.Name = "btnCarrito";
            btnCarrito.Size = new Size(176, 37);
            btnCarrito.TabIndex = 16;
            btnCarrito.Text = "Carrito";
            btnCarrito.TextAlign = ContentAlignment.MiddleRight;
            btnCarrito.UseVisualStyleBackColor = true;
            btnCarrito.Click += btnSalidaMaterial_Click;
            // 
            // btnIngMaterial
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
            btn_IngMaterial.Name = "btnIngMaterial";
            btn_IngMaterial.Size = new Size(176, 37);
            btn_IngMaterial.TabIndex = 15;
            btn_IngMaterial.Text = "Pago Compras";
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
            // panelUsuario
            // 
            panelUsuario.BackColor = SystemColors.Highlight;
            panelUsuario.Location = new Point(0, 6);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(10, 37);
            panelUsuario.TabIndex = 13;
            // 
            // panelCategoria
            // 
            panelCategoria.BackColor = SystemColors.Highlight;
            panelCategoria.Location = new Point(0, 395);
            panelCategoria.Name = "panelCategoria";
            panelCategoria.Size = new Size(10, 37);
            panelCategoria.TabIndex = 8;
            // 
            // panelPagoComp
            // 
            panelPagoComp.BackColor = SystemColors.Highlight;
            panelPagoComp.Location = new Point(0, 352);
            panelPagoComp.Name = "panelPagoComp";
            panelPagoComp.Size = new Size(10, 37);
            panelPagoComp.TabIndex = 7;
            // 
            // panelPagoVent
            // 
            panelPagoVent.BackColor = SystemColors.Highlight;
            panelPagoVent.Location = new Point(0, 309);
            panelPagoVent.Name = "panelPagoVent";
            panelPagoVent.Size = new Size(10, 37);
            panelPagoVent.TabIndex = 6;
            // 
            // panelPrenda
            // 
            panelPrenda.BackColor = SystemColors.Highlight;
            panelPrenda.Location = new Point(0, 178);
            panelPrenda.Name = "panelPrenda";
            panelPrenda.Size = new Size(10, 37);
            panelPrenda.TabIndex = 4;
            // 
            // panelCliente
            // 
            panelCliente.BackColor = SystemColors.Highlight;
            panelCliente.Location = new Point(0, 135);
            panelCliente.Name = "panelCliente";
            panelCliente.Size = new Size(10, 37);
            panelCliente.TabIndex = 4;
            // 
            // panelMet
            // 
            panelMet.BackColor = SystemColors.Highlight;
            panelMet.Location = new Point(0, 266);
            panelMet.Name = "panelMet";
            panelMet.Size = new Size(10, 37);
            panelMet.TabIndex = 4;
            // 
            // panelProvee
            // 
            panelProvee.BackColor = SystemColors.Highlight;
            panelProvee.Location = new Point(0, 223);
            panelProvee.Name = "panelProvee";
            panelProvee.Size = new Size(10, 37);
            panelProvee.TabIndex = 3;
            // 
            // panelComprar
            // 
            panelComprar.BackColor = SystemColors.Highlight;
            panelComprar.Location = new Point(0, 92);
            panelComprar.Name = "panelComprar";
            panelComprar.Size = new Size(10, 37);
            panelComprar.TabIndex = 2;
            // 
            // panelVender
            // 
            panelVender.BackColor = SystemColors.Highlight;
            panelVender.Location = new Point(0, 49);
            panelVender.Name = "panelVender";
            panelVender.Size = new Size(10, 37);
            panelVender.TabIndex = 1;
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
            Controls.Add(MenuLateral);
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
            MenuLateral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel MenuLateral;
        private Panel panelVender;
        private PictureBox btnMinimizar;
        private Panel panelProvee;
        private Panel panelComprar;
        private Panel panelMet;
        private Panel panelPrenda;
        private Panel panelCliente;
        private Panel panelPagoVent;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Panel panelPagoComp;
        private Panel panelCategoria;
        private Label lblUser;
        private Panel panelUsuario;
        private Panel panelconteiner;
        private FontAwesome.Sharp.IconButton btnCategoria;
        private FontAwesome.Sharp.IconButton btn_IngMaterial;
        private FontAwesome.Sharp.IconButton btnCarrito;
        private FontAwesome.Sharp.IconButton btnMetodoPago;
        private FontAwesome.Sharp.IconButton btnProveedores;
        private FontAwesome.Sharp.IconButton btnPrendas;
        private FontAwesome.Sharp.IconButton btnCliente;
        private FontAwesome.Sharp.IconButton btnComprarPrendas;
        private FontAwesome.Sharp.IconButton btnVenderPrendas;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnInventario;
        private Panel panelInventario;
    }
}
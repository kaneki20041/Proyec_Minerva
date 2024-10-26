namespace CapaPresentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnSalir = new FontAwesome.Sharp.IconButton();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            btnMostrar = new FontAwesome.Sharp.IconButton();
            btnOcultar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkRed;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.X;
            btnSalir.IconColor = Color.White;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnSalir.IconSize = 25;
            btnSalir.Location = new Point(752, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(40, 36);
            btnSalir.TabIndex = 0;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Window;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.Gray;
            txtUsuario.Location = new Point(222, 365);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.RightToLeft = RightToLeft.No;
            txtUsuario.Size = new Size(346, 17);
            txtUsuario.TabIndex = 54;
            txtUsuario.Text = "Usuario";
            txtUsuario.Enter += txtDocumento_Enter;
            txtUsuario.KeyPress += txtDocumento_KeyPress;
            txtUsuario.Leave += txtDocumento_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(222, 405);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(346, 17);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Contraseña";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.KeyPress += txtPassword_KeyPress;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.SandyBrown;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatStyle = FlatStyle.Popup;
            btnIngresar.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.ControlText;
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnIngresar.IconColor = Color.Black;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 1;
            btnIngresar.Location = new Point(222, 453);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(346, 39);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            btnIngresar.KeyPress += btnIngresar_KeyPress;
            // 
            // btnMostrar
            // 
            btnMostrar.FlatAppearance.BorderSize = 0;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnMostrar.IconColor = Color.Black;
            btnMostrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMostrar.IconSize = 20;
            btnMostrar.Location = new Point(575, 404);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(32, 23);
            btnMostrar.TabIndex = 7;
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnOcultar
            // 
            btnOcultar.FlatAppearance.BorderSize = 0;
            btnOcultar.FlatStyle = FlatStyle.Flat;
            btnOcultar.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            btnOcultar.IconColor = Color.Black;
            btnOcultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOcultar.IconSize = 20;
            btnOcultar.Location = new Point(575, 404);
            btnOcultar.Name = "btnOcultar";
            btnOcultar.Size = new Size(32, 23);
            btnOcultar.TabIndex = 8;
            btnOcultar.UseVisualStyleBackColor = true;
            btnOcultar.Click += btnOcultar_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(221, 385);
            label1.Name = "label1";
            label1.Size = new Size(347, 2);
            label1.TabIndex = 55;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(222, 425);
            label2.Name = "label2";
            label2.Size = new Size(347, 2);
            label2.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(347, 311);
            label3.Name = "label3";
            label3.Size = new Size(101, 22);
            label3.TabIndex = 57;
            label3.Text = "Identifícate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(338, 105);
            label4.Name = "label4";
            label4.Size = new Size(122, 31);
            label4.TabIndex = 58;
            label4.Text = "SISTEMA";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(204, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(389, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(804, 647);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOcultar);
            Controls.Add(btnMostrar);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnSalir;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnMostrar;
        private FontAwesome.Sharp.IconButton btnOcultar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
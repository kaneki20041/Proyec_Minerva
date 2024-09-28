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
            groupBox1 = new GroupBox();
            btnOcultar = new FontAwesome.Sharp.IconButton();
            btnMostrar = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            txtPassword = new TextBox();
            txtDocumento = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnSalir = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(btnOcultar);
            groupBox1.Controls.Add(btnMostrar);
            groupBox1.Controls.Add(iconPictureBox1);
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtDocumento);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(24, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 401);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Grupo Minerva";
            // 
            // btnOcultar
            // 
            btnOcultar.FlatAppearance.BorderSize = 0;
            btnOcultar.FlatStyle = FlatStyle.Flat;
            btnOcultar.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            btnOcultar.IconColor = Color.Black;
            btnOcultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOcultar.IconSize = 20;
            btnOcultar.Location = new Point(208, 274);
            btnOcultar.Name = "btnOcultar";
            btnOcultar.Size = new Size(32, 23);
            btnOcultar.TabIndex = 8;
            btnOcultar.UseVisualStyleBackColor = true;
            btnOcultar.Click += btnOcultar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.FlatAppearance.BorderSize = 0;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnMostrar.IconColor = Color.Black;
            btnMostrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMostrar.IconSize = 20;
            btnMostrar.Location = new Point(208, 274);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(32, 23);
            btnMostrar.TabIndex = 7;
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Gray;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Tags;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 138;
            iconPictureBox1.Location = new Point(47, 35);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(147, 138);
            iconPictureBox1.TabIndex = 6;
            iconPictureBox1.TabStop = false;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.Highlight;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatStyle = FlatStyle.Popup;
            btnIngresar.ForeColor = SystemColors.ControlText;
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnIngresar.IconColor = Color.Black;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 22;
            btnIngresar.Location = new Point(47, 337);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(138, 26);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.TextAlign = ContentAlignment.MiddleRight;
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            btnIngresar.KeyPress += btnIngresar_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(24, 274);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(178, 26);
            txtPassword.TabIndex = 2;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // txtDocumento
            // 
            txtDocumento.BackColor = SystemColors.Window;
            txtDocumento.Location = new Point(24, 209);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.RightToLeft = RightToLeft.No;
            txtDocumento.Size = new Size(178, 26);
            txtDocumento.TabIndex = 1;
            txtDocumento.KeyPress += txtDocumento_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuBar;
            label3.Location = new Point(22, 252);
            label3.Name = "label3";
            label3.Size = new Size(92, 17);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Roboto Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuBar;
            label2.Location = new Point(22, 187);
            label2.Name = "label2";
            label2.Size = new Size(186, 17);
            label2.TabIndex = 1;
            label2.Text = "Documento de Identidad";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Maroon;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingArrowRight;
            btnSalir.IconColor = Color.White;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 30;
            btnSalir.Location = new Point(637, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(40, 36);
            btnSalir.TabIndex = 0;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(639, 51);
            label1.Name = "label1";
            label1.Size = new Size(35, 13);
            label1.TabIndex = 0;
            label1.Text = "Salir";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 452);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private TextBox txtPassword;
        private TextBox txtDocumento;
        private Label label3;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnMostrar;
        private FontAwesome.Sharp.IconButton btnOcultar;
    }
}
namespace Proyecto_Minerva
{
    partial class DetalleCompra
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
            tablon = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tablon).BeginInit();
            SuspendLayout();
            // 
            // tablon
            // 
            tablon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablon.Location = new Point(57, 32);
            tablon.Name = "tablon";
            tablon.Size = new Size(700, 290);
            tablon.TabIndex = 0;
            // 
            // DetalleCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 350);
            Controls.Add(tablon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetalleCompra";
            Text = "IngMaterial";
            ((System.ComponentModel.ISupportInitialize)tablon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tablon;
    }
}
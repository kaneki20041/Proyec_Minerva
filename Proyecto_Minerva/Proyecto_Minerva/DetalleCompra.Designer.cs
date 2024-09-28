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
            detallito = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)detallito).BeginInit();
            SuspendLayout();
            // 
            // detallito
            // 
            detallito.BackgroundColor = Color.MintCream;
            detallito.BorderStyle = BorderStyle.None;
            detallito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detallito.Location = new Point(33, 33);
            detallito.Name = "detallito";
            detallito.RowHeadersWidth = 51;
            detallito.RowTemplate.Height = 25;
            detallito.Size = new Size(786, 505);
            detallito.TabIndex = 29;
            // 
            // DetalleCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(851, 573);
            Controls.Add(detallito);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetalleCompra";
            Text = "IngMaterial";
            ((System.ComponentModel.ISupportInitialize)detallito).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView detallito;
        private DataGridViewTextBoxColumn Telefono;
    }
}
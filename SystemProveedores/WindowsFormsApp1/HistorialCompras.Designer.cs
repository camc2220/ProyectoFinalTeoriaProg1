namespace WindowsFormsApp1
{
    partial class HistorialCompras
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
            this.historialDeCompras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.historialDeCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // historialDeCompras
            // 
            this.historialDeCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historialDeCompras.Location = new System.Drawing.Point(-5, -1);
            this.historialDeCompras.Name = "historialDeCompras";
            this.historialDeCompras.Size = new System.Drawing.Size(365, 294);
            this.historialDeCompras.TabIndex = 0;
            // 
            // HistorialCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 292);
            this.Controls.Add(this.historialDeCompras);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HistorialCompras";
            this.Text = "HistorialCompras";
            this.Load += new System.EventHandler(this.HistorialCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historialDeCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView historialDeCompras;
    }
}
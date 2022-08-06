namespace WindowsFormsApp1
{
    partial class Lista_de_proveedores
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
            this.ListaProveedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaProveedores
            // 
            this.ListaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaProveedores.Location = new System.Drawing.Point(-1, 0);
            this.ListaProveedores.Name = "ListaProveedores";
            this.ListaProveedores.Size = new System.Drawing.Size(549, 293);
            this.ListaProveedores.TabIndex = 0;
            // 
            // Lista_de_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 292);
            this.Controls.Add(this.ListaProveedores);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Lista_de_proveedores";
            this.Text = "Lista_de_proveedores";
            this.Load += new System.EventHandler(this.Lista_de_proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaProveedores;
    }
}
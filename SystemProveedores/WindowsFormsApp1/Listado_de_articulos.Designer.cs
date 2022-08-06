namespace WindowsFormsApp1
{
    partial class Listado_de_articulos
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
            this.ListaArticulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListaArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaArticulos
            // 
            this.ListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaArticulos.Location = new System.Drawing.Point(0, -2);
            this.ListaArticulos.Name = "ListaArticulos";
            this.ListaArticulos.Size = new System.Drawing.Size(448, 295);
            this.ListaArticulos.TabIndex = 0;
            // 
            // Listado_de_articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 292);
            this.Controls.Add(this.ListaArticulos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Listado_de_articulos";
            this.Text = "Listado_de_articulos";
            this.Load += new System.EventHandler(this.Listado_de_articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaArticulos;
    }
}
namespace WindowsFormsApp1
{
    partial class NuevaOrdenDeCompra
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
            this.proveedor = new System.Windows.Forms.ComboBox();
            this.articulo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // proveedor
            // 
            this.proveedor.FormattingEnabled = true;
            this.proveedor.Location = new System.Drawing.Point(90, 60);
            this.proveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.proveedor.Name = "proveedor";
            this.proveedor.Size = new System.Drawing.Size(82, 21);
            this.proveedor.TabIndex = 0;
            // 
            // articulo
            // 
            this.articulo.FormattingEnabled = true;
            this.articulo.Location = new System.Drawing.Point(90, 105);
            this.articulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.articulo.Name = "articulo";
            this.articulo.Size = new System.Drawing.Size(82, 21);
            this.articulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Articulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad:";
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(90, 150);
            this.cantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(68, 20);
            this.cantidad.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NuevaOrdenDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.articulo);
            this.Controls.Add(this.proveedor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NuevaOrdenDeCompra";
            this.Text = "NuevaOrdenDeCompra";
            this.Load += new System.EventHandler(this.NuevaOrdenDeCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox proveedor;
        private System.Windows.Forms.ComboBox articulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Button button1;
    }
}
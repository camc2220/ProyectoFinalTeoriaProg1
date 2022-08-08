namespace WindowsFormsApp1
{
    partial class Agregar_articulos
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
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.TextBox();
            this.categoria = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " Nombre :";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(146, 125);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(197, 26);
            this.nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoria:";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(146, 238);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(197, 26);
            this.precio.TabIndex = 5;
            // 
            // categoria
            // 
            this.categoria.FormattingEnabled = true;
            this.categoria.Items.AddRange(new object[] {
            "Comida",
            "Bebida",
            "Limpieza",
            "Miscelaneos",
            "Embutidos",
            "Verduras"});
            this.categoria.Location = new System.Drawing.Point(146, 185);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(197, 28);
            this.categoria.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Agregar Nuevo Artículo";
            // 
            // Agregar_articulos
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(508, 418);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Name = "Agregar_articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar artículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.ComboBox categoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}
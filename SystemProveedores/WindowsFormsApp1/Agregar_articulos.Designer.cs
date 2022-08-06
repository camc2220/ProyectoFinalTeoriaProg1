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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Nombre :";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(97, 81);
            this.nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(68, 20);
            this.nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoria:";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(97, 155);
            this.precio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(68, 20);
            this.precio.TabIndex = 5;
            // 
            // categoria
            // 
            this.categoria.FormattingEnabled = true;
            this.categoria.Items.AddRange(new object[] {
            "Comida"});
            this.categoria.Location = new System.Drawing.Point(97, 120);
            this.categoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(82, 21);
            this.categoria.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Agregar_articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Agregar_articulos";
            this.Text = "Agregar_articulos";
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
    }
}
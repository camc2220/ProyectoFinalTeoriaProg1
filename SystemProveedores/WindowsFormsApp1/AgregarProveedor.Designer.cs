namespace WindowsFormsApp1
{
    partial class AgregarProveedor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.correoElectronico = new System.Windows.Forms.TextBox();
            this.rnc = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.personaDeContacto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "RNC:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo electronico:";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(272, 76);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(330, 26);
            this.nombre.TabIndex = 4;
            this.nombre.TextChanged += new System.EventHandler(this.nombreProveedor_TextChanged);
            // 
            // correoElectronico
            // 
            this.correoElectronico.Location = new System.Drawing.Point(272, 324);
            this.correoElectronico.Name = "correoElectronico";
            this.correoElectronico.Size = new System.Drawing.Size(252, 26);
            this.correoElectronico.TabIndex = 5;
            // 
            // rnc
            // 
            this.rnc.Location = new System.Drawing.Point(272, 133);
            this.rnc.Name = "rnc";
            this.rnc.Size = new System.Drawing.Size(212, 26);
            this.rnc.TabIndex = 6;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(272, 253);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(204, 26);
            this.telefono.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Persona de contacto:";
            // 
            // personaDeContacto
            // 
            this.personaDeContacto.Location = new System.Drawing.Point(272, 193);
            this.personaDeContacto.Name = "personaDeContacto";
            this.personaDeContacto.Size = new System.Drawing.Size(330, 26);
            this.personaDeContacto.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(161, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(363, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "Agregar Nuevo Proveedor";
            // 
            // AgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 449);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personaDeContacto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.rnc);
            this.Controls.Add(this.correoElectronico);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarProveedor";
            this.Text = "AgregarProveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox correoElectronico;
        private System.Windows.Forms.TextBox rnc;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox personaDeContacto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}
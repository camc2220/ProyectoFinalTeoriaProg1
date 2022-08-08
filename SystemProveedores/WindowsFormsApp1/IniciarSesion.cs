using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            string contrasena = "123456";
            textBox1.Text = textBox1.Text.Trim();
            textBox2.Text = textBox2.Text.Trim();

            if ((usuario == textBox1.Text) && (contrasena == textBox2.Text))
            {
                    Form Principal = new Form1();
                    Principal.ShowDialog();
                    textBox1.Text = "";
                    textBox2.Text = "";

                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Invalido");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }

            }
            
            
        }
    }


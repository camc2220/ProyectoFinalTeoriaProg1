using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Agregar_articulos : Form
    {
        public Agregar_articulos()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var articulo = new Articulo() { Nombre = nombre.Text, Precio = Int32.Parse(precio.Text), Categoria = categoria.Text };

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };

            const string url = "https://api-colmado.herokuapp.com/api/articulo";
            using (HttpClient client = new HttpClient())
            {
                var json = JsonSerializer.Serialize<Articulo>(articulo, options);

                HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, httpContent);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Articulo guardado");
                }
                else
                {
                    MessageBox.Show(response.StatusCode.ToString());
                }
            }
            Close();
        }
    }
}

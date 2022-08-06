using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NuevaOrdenDeCompra : Form
    {
        public NuevaOrdenDeCompra()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var compra = new Compra()
            {
                Proveedor = proveedor.Text,
                Articulo = articulo.Text,
                Cantidad = Int32.Parse(cantidad.Text)
            };

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };

            const string url = "https://api-colmado.herokuapp.com/api/compra";
            using (HttpClient client = new HttpClient())
            {
                var json = JsonSerializer.Serialize<Compra>(compra, options);

                HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, httpContent);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Compra guardada");
                }
                else
                {
                    MessageBox.Show(response.StatusCode.ToString());
                }
            }
            Close();
        }

        private async void NuevaOrdenDeCompra_Load(object sender, EventArgs e)
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };

            const string url = "https://api-colmado.herokuapp.com/api/proveedor";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var p = JsonSerializer.Deserialize<List<Proveedor>>(content, options);

                    var listaProveedor = new List<string>();

                    foreach (var proveedor in p)
                    {
                        listaProveedor.Add(proveedor.Nombre);

                    }
                    proveedor.DataSource = listaProveedor;
                }
            }
            const string urlA = "https://api-colmado.herokuapp.com/api/articulo";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(urlA);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var articulos = JsonSerializer.Deserialize<List<Articulo>>(content, options);

                    var listaArticulo = new List<string>();

                    foreach (var proveedor in articulos)
                    {
                        listaArticulo.Add(proveedor.Nombre);

                    }
                    articulo.DataSource = listaArticulo;
                }
            }
        }
    }
}

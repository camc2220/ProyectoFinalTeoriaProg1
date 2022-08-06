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
    public partial class Lista_de_proveedores : Form
    {

        private List<Proveedor> proveedores = new List<Proveedor>();
        public Lista_de_proveedores()
        {
            InitializeComponent();
        }

        private async void Lista_de_proveedores_Load(object sender, EventArgs e)
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
                    ListaProveedores.DataSource = p;
                    proveedores = p;
                }
            }
        }
    }
}

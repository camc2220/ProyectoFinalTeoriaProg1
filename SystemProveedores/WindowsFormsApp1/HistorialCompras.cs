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
    public partial class HistorialCompras : Form
    {
        public HistorialCompras()
        {
            InitializeComponent();
        }

        private async void HistorialCompras_Load(object sender, EventArgs e)
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };

            const string url = "https://api-colmado.herokuapp.com/api/compra";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var compras = JsonSerializer.Deserialize<List<Compra>>(content, options);
                    historialDeCompras.DataSource = compras;
                }
            }
        }
    }
}

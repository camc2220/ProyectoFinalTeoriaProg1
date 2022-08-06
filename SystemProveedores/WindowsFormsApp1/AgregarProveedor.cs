using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace WindowsFormsApp1
{
    public partial class AgregarProveedor : Form
    {
        public AgregarProveedor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var articulo = new Proveedor()
            {
                Nombre = nombre.Text,
                Rnc = Int32.Parse(rnc.Text),
                PersonaContacto = personaDeContacto.Text,
                Telefono = telefono.Text,
                CorreoElectronico = correoElectronico.Text,
            };

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };

            const string url = "https://api-colmado.herokuapp.com/api/proveedor";
            using (HttpClient client = new HttpClient())
            {
                var json = JsonSerializer.Serialize<Proveedor>(articulo, options);

                HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, httpContent);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Proveedor guardado");
                }
                else
                {
                    MessageBox.Show(response.StatusCode.ToString());
                }
            }
            Close();
        }

        private void nombreProveedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

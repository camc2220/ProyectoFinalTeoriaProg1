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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            
        }
     
        private void ordenesDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NewCompra = new NuevaOrdenDeCompra();
            NewCompra.ShowDialog();
        }

        private void listadoDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ListArt = new Listado_de_articulos();
            ListArt.ShowDialog();
        }

        private void agregarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AgregarProv = new AgregarProveedor();
            AgregarProv.ShowDialog();
        }

        private void listaDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ListProv = new Lista_de_proveedores();
            ListProv.ShowDialog();

        }

        private void AgregarArticulo_Click(object sender, EventArgs e)
        {
            Form AgregarArt = new Agregar_articulos();
            AgregarArt.ShowDialog();
        }

        private void historialDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form HistCompras = new HistorialCompras();
            HistCompras.ShowDialog();
        }
      
    }
}

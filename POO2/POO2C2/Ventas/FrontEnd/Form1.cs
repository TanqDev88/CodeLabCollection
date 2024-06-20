using Datos;
using Negocio;

namespace FrontEnd
{
    public partial class Form1 : Form
    {
        Articulos objetos = new Articulos();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostarArticulos()
        {
            dataGridView1.DataSource = objetos.MostrarArticulos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostarArticulos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void BGrabar_Click(object sender, EventArgs e)
        {
            objetos.InsertarArticulo(FNombre.Text, FPrecio.Text, FStock.Text);
            MessageBox.Show("Articulo cargado");
        }
    }
}

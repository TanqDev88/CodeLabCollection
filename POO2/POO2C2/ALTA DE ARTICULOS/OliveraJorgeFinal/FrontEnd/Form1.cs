using Negocio;

namespace FrontEnd
{
    public partial class FArticulos : Form
    {
        Articulos objetos = new Articulos();
        public FArticulos()
        {
            InitializeComponent();
        }

        private void MostrarArticulos()
        {
            dataGridView1.DataSource = objetos.MostrarArticulos();
        }

        private void FArticulos_Load(object sender, EventArgs e)
        {
            MostrarArticulos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BGrabar_Click(object sender, EventArgs e)
        {
            objetos.InsertarArticulo(Fnombre.Text, Fprecio.Text, FStock.Text);
            MessageBox.Show("Art�culo cargado");
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
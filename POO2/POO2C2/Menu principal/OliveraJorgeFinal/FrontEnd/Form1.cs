using Negocio;
using System.Windows.Forms;

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
    }
}

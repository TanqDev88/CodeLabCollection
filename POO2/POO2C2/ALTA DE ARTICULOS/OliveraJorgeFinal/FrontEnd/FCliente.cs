using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class FCliente : Form
    {
        Cliente objetos = new Cliente();
        public FCliente()
        {
            InitializeComponent();
        }

        private void MostrarClientes()
        {
            dataGridView1.DataSource = objetos.MostrarClientes();
        }


        private void FCliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }
    }
}

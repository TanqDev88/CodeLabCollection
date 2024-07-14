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
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de Salir?", "Salir", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void FMain_Load(object sender, EventArgs e)
        {

        }

        private void BArticulos_Click(object sender, EventArgs e)
        {
            FArticulos Farticulos = new FArticulos();
            Farticulos.ShowDialog();
        }

        private void Bclientes_Click(object sender, EventArgs e)
        {
            FCliente FCliente = new FCliente();
            FCliente.ShowDialog();
        }
    }
}

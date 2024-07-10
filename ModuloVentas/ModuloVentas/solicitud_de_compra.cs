using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloVentas
{
    public partial class solicitud_de_compra : Form
    {
        public solicitud_de_compra()
        {
            InitializeComponent();
        }

        private void solicitud_de_compra_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void regresarMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompra compra = new frmCompra();

            compra.Show();
            this.Close();
        }
    }
}

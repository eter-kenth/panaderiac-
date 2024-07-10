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
    public partial class pedido_solicitud_compra : Form
    {
        public pedido_solicitud_compra()
        {
            InitializeComponent();
        }

        private void regresarMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompra compra = new frmCompra();

            compra.Show();
            this.Close();
        }

        private void pedido_solicitud_compra_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

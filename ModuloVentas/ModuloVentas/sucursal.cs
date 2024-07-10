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
    public partial class sucursal : Form
    {
        public sucursal()
        {
            InitializeComponent();
        }

        private void regresarAlMenuDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompra compras = new frmCompra();

            compras.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solicitud enviada");
        }
    }
}

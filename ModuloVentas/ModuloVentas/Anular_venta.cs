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
    public partial class Anular_venta : Form
    {
        public Anular_venta()
        {
            InitializeComponent();
        }

        private void regresarAlMenuDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();

            ventas.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = " ";
            textBox6.Text = " ";
            textBox5.Text = " ";
            textBox2.Text = " ";
            
        }

        private void regresarAlMenuDeVentasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();

            ventas.Show();
            this.Close();
        }
    }
}

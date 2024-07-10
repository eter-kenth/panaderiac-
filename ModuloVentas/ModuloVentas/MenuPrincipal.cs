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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnsVentas_Click(object sender, EventArgs e)
        {
            

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Estan chavalos");
            this.Close();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            frmCaja caja = new frmCaja();

            caja.Show();
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            frmCompra compra = new frmCompra();

            compra.Show();
            this.Close();

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

            frmVentas frmventas = new frmVentas();

            frmventas.Show();
            this.Close();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            frmProduccion produccion = new frmProduccion();

            produccion.Show();
            this.Close();

        }

        private void lblProduccion_Click(object sender, EventArgs e)
        {

        }

        private void pctbPanVida_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCaja_Click(object sender, EventArgs e)
        {

        }
    }
}

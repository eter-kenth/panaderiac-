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
    public partial class frmCompra : Form
    {
        public frmCompra()
        {
            InitializeComponent();
        }

        private void regresarMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmMenuPrincipal menu = new frmMenuPrincipal();

            menu.Show();
            this.Close();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void panaderiaSedeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sucursal sucursal = new sucursal();

            sucursal.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmCompra_Load(object sender, EventArgs e)
        {

        }

        private void solicitudDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            solicitud_de_compra solicitudDeCompra = new solicitud_de_compra();

            solicitudDeCompra.Show();
            this.Close();
        }

        private void pedidoSolicitudDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pedido_solicitud_compra psCompra = new pedido_solicitud_compra();

            psCompra.Show();
            this.Close();

        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compras Compras = new compras();

            Compras.Show();
            this.Close();


        }
    }
}

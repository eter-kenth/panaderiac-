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
    public partial class historial_de_ventas : Form
    {
        public historial_de_ventas()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void regresarAlMenuDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();

            ventas.Show();
            this.Close();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configuraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

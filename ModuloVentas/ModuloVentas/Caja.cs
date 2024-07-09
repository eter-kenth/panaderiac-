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
    public partial class frmCaja : Form
    {
        public frmCaja()
        {
            InitializeComponent();
        }

        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmMenuPrincipal menu = new frmMenuPrincipal();

            menu.Show();
            this.Close();

        }
    }
}

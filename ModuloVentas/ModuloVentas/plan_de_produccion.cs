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
    public partial class plan_de_produccion : Form
    {
        public plan_de_produccion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void regresarMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion menuProduccion = new frmProduccion();

            menuProduccion.Show();
            this.Close();
        }
    }
}

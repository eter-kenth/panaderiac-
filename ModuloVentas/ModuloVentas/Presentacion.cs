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
    public partial class frmPresentacion : Form
    {

        private int conteo;
        public frmPresentacion()
        {
            InitializeComponent();
            conteo = 0;
        }

        private void frmPresentacion_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguienteForm_Click(object sender, EventArgs e)
        {

            frmMenuPrincipal form3 = new frmMenuPrincipal();

            form3.Show();
            this.Hide();

        }

        private void lblProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void prbPresentacion_Click(object sender, EventArgs e)
        {

        }

        private void tmrProgressBar_Tick(object sender, EventArgs e)
        {

            conteo++;
            lblProgressBar.Text = conteo.ToString();

            if(prbPresentacion.Value < 100)
            {

                prbPresentacion.Value++;

            }
            if(prbPresentacion.Value == 100)
            {
                tmrProgressBar.Stop();
                frmMenuPrincipal frmMP = new frmMenuPrincipal();
                frmMP.Show();
                this.Hide();

            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

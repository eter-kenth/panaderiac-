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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tipoVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuarioM_Click(object sender, EventArgs e)
        {

             

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }


        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mnrSalir_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmMenuPrincipal menu = new frmMenuPrincipal();

            menu.Show();
            this.Close();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void gestionDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresar_venta ingresarvent= new Ingresar_venta();

            ingresarvent.Show();
            this.Close();
        }

        private void anularVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anular_venta anular_vent = new Anular_venta();

            anular_vent.Show();
            this.Close();

        }

        private void historialDeVentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            historial_de_ventas historialvent = new historial_de_ventas();

            historialvent.Show();
            this.Close();

        }

        private void modificarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }
    }
}

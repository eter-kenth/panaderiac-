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
    public partial class frmControlAcceso : Form
    {
        public frmControlAcceso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btConectar_Click(object sender, EventArgs e)
        {

            if(txtUsuario.Text == "kgfs" && txtContraseña.Text == "02")
            {

                frmPresentacion form2 = new frmPresentacion();

                MessageBox.Show("Contraseña Correcta, Bienvenido al sistema  " + txtUsuario.Text);

                form2.Show();
                this.Hide();

            }
            else 
            {

                MessageBox.Show("Contraseña o Usuario incorrecta digite de nuevo");

                txtUsuario.Text = "";
                txtContraseña.Text = "";
            
            }

        }

        private void btSalir_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void frmControlAcceso_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

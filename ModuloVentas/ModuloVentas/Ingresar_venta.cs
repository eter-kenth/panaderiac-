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
    public partial class Ingresar_venta : Form
    {
        public Ingresar_venta()
        {
            InitializeComponent();
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            checkedListBox2.ItemCheck += checkedListBox2_ItemCheck;


        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
              
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        checkedListBox1.SetItemChecked(i, false);
                    }
                }
            }
        }
        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {

                for (int i = 0; i < checkedListBox2.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        checkedListBox2.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ingresar_venta_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void regresarAlMenuDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();

            ventas.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = dgvIngVentas.Rows.Add();
            int i = checkedListBox1.SelectedIndex;
            int i2 = checkedListBox2.SelectedIndex;
           
            dgvIngVentas.Rows[n].Cells[0].Value = textBox1.Text;
            dgvIngVentas.Rows[n].Cells[1].Value = textBox2.Text;
            dgvIngVentas.Rows[n].Cells[2].Value = textBox3.Text;

            if (i != -1)
            {
                dgvIngVentas.Rows[n].Cells[3].Value = checkedListBox1.Items[i].ToString();

            }
            dgvIngVentas.Rows[n].Cells[4].Value = textBox4.Text;

            if(i2 != -1)
            {
                dgvIngVentas.Rows[n].Cells[5].Value = checkedListBox2.Items[i].ToString();
            }
            dgvIngVentas.Rows[n].Cells[6].Value = textBox5.Text;
            dgvIngVentas.Rows[n].Cells[7].Value = textBox6.Text;
            dgvIngVentas.Rows[n].Cells[8].Value = textBox7.Text;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " "; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }
    }
}

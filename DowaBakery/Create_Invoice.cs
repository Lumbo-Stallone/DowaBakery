using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DowaBakery
{
    public partial class Create_Invoice : Form
    {
        public Create_Invoice()
        {
            InitializeComponent();
            CustomizedDesign();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (panelsubMenu.Visible == true)
            {
                hideSubMenu();
                // pictureBoxSearch.Visible = false; ;
            }
            else
            {
                showSubmenu();
                // pictureBoxSearch.Visible= false;
            }
        }
        private void hideSubMenu()
        {
            if (panelsubMenu.Visible == true)
            {
                panelsubMenu.Visible = false;
                panelsubMenu.BringToFront();

            }
        }
        private void showSubmenu()
        {
            if (panelsubMenu.Visible == false)
            {
                panelsubMenu.Visible = true;
                panelsubMenu.BringToFront();
                // pictureBoxSearch.Hide();
            }

        }
        private void CustomizedDesign()
        {
            panelsubMenu.Visible = false;
           // textboxSearch.Text = "Search";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelsubMenu_MouseLeave(object sender, EventArgs e)
        {
         
        }

        private void btnNewtransaction_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

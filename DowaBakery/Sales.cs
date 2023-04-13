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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            CustomizedDesign();
            CustomizedDesign();
            customizedDesigns();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void customizedDesigns()
        {
            if (textboxSearch.Text == "")
            {
                textboxSearch.Text = "Search";
                textboxSearch.ForeColor = Color.Silver;
            }
            else if (textboxSearch.Text == "Search")
            {
                textboxSearch.Text = "";
            }
        }

        private void textboxSearch_MouseHover(object sender, EventArgs e)
        {
            customizedDesigns();

        }

        private void textboxSearch_MouseLeave(object sender, EventArgs e)
        {
            customizedDesigns();
        }

        private void textboxSearch_MouseEnter(object sender, EventArgs e)
        {
            textboxSearch.ForeColor = Color.Black;
        }

        private void CustomizedDesign()
        {
            panelsubMenu.Visible = false;
            textboxSearch.Text = "Search";
        }
        private void hideSubMenu()
        {
            if (panelsubMenu.Visible==true)
            {
                panelsubMenu.Visible = false;
               
            }
        }
        private void showSubmenu()
        {
            if (panelsubMenu.Visible==false)
            {
                panelsubMenu.Visible = true;
                panelsubMenu.BringToFront();
               // pictureBoxSearch.Hide();
            }
           
        }

        private void btnNewtransaction_Click(object sender, EventArgs e)
        {
            if (panelsubMenu.Visible==true)
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

        private void panelchild_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Create_Invoice invoice = new Create_Invoice();
            invoice.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Payments payment = new Payments();
            payment.Show();
            payment.BringToFront();

        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            Estimate estimate = new Estimate();
            estimate.Show();

        }
    }
}

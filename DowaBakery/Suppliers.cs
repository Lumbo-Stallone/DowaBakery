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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
            customizedDesigns();
            CustomizedDesign();

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
            panelSearch.Focus();
            
        }

        private void CustomizedDesign()
        {
            panelsubMenu.Visible = false;
            textboxSearch.Text = "Search";
        }
        private void hideSubMenu()
        {
            if (panelsubMenu.Visible == true)
            {
                panelsubMenu.Visible = false;

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
        private void btnNewtransaction_Click(object sender, EventArgs e)
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

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

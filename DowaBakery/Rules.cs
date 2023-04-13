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
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
            customizedDesign();
        }

        private void Rules_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void customizedDesign()
        {
            panel3.BringToFront();
            textboxSearch.Text = "Search";
            panelsubMenu.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void customizedDesigns()
        {
            if (textboxSearch.Text=="")
            {
                textboxSearch.Text = "Search";
                textboxSearch.ForeColor = Color.Silver;
            }
            else if (textboxSearch.Text=="Search")
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
               
            }

        }

        private void buttonDropRules_Click_1(object sender, EventArgs e)
        {
            if (panelsubMenu.Visible == true)
            {
                hideSubMenu();
                //pictureBoxSearch.Visible = false; ;
            }
            else
            {
                showSubmenu();
                //pictureBoxSearch.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dimming effect behind the search form
            Form frm = new Form();
            try
            {
                using (New_rule sr = new New_rule())
                {
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Opacity = .50d;
                    frm.BackColor = Color.Black;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.TopMost = true;
                    frm.Show();


                    sr.Owner = frm;
                    sr.TopMost = true;
                    sr.ShowDialog();
                    frm.Dispose();



                }

            }
            catch (Exception )
            {

                MessageBox.Show("Connection problem");
            }

            finally
            {
                frm.Dispose();
            }
        }
    }
}

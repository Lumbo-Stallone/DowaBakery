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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
      
        private void label6_Click(object sender, EventArgs e)
        {

            label6.BackColor = Color.Green;
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "Search")
            {
                textBox1.Text = "";
                
            }
        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Search";
            }

        }

    }
}

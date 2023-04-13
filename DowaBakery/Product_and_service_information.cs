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
    public partial class Product_and_service_information : Form
    {
        public Product_and_service_information()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - this.Width, scrn.Bounds.Top);
                    return;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BringToFront();

        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;

        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.White;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Close();
           
            Form frm = new Form();
            using (Non_Invetory sr = new Non_Invetory())
            {

                frm.StartPosition = FormStartPosition.CenterParent;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Opacity = .50d;
                frm.BackColor = Color.Silver;
                frm.WindowState = FormWindowState.Maximized;
                frm.TopMost = true;
                frm.Show();
                this.Hide();


                sr.Owner = frm;
                sr.TopMost = true;
                sr.ShowDialog();
                frm.Dispose();





            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
            
            Form frm = new Form();

            using (Services sr = new Services())
            {

                frm.StartPosition = FormStartPosition.CenterParent;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Opacity = .50d;
                frm.BackColor = Color.Silver;
                frm.WindowState = FormWindowState.Maximized;
                frm.TopMost = true;
                frm.Show();
                this.Hide();


                sr.Owner = frm;
                sr.TopMost = true;
                sr.ShowDialog();
                frm.Dispose();

            }

        }
    }
}

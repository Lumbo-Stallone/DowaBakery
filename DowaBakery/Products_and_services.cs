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
    public partial class Products_and_services : Form
    {
        public Products_and_services()
        {
            InitializeComponent();
        }

        private void Products_and_services_Load(object sender, EventArgs e)
        {

        }

        private void btnNewtransaction_Click(object sender, EventArgs e)
        {
            //dimming effect behind the search form
            Form frm = new Form();
            try
            {
                using (Product_and_service_information sr = new Product_and_service_information())
                {
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Opacity = .50d;
                    frm.BackColor = Color.Black;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.AutoScroll = false;
                    frm.TopMost = true;
                    frm.Show();


                    sr.Owner = frm;
                    sr.TopMost = true;
                    sr.ShowDialog();
                    frm.Dispose();



                }

            }
            catch (Exception)
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

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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            using (AddEmplpyees sr = new AddEmplpyees())
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

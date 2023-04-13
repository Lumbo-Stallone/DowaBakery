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
    public partial class Non_Invetory : Form
    {
        public Non_Invetory()
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

        private void productserviceinfo_Load(object sender, EventArgs e)
        {

        }
    }
}

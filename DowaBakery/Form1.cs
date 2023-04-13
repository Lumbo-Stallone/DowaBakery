using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace DowaBakery
{
    public partial class HomePage : Form
    {
        Color c = ColorTranslator.FromHtml("#41434D");
        public bool dashboardclicked = false;
        public bool bankingclicked = false;
        public bool salesckicked = false;
        public bool expensescliked = false;
        public bool employeesclicked = false;
        public bool Reportsclicked = false;
        public bool taxesclicked = false;
        public bool accountingclicked = false;
        public bool appsclicked = false;
        public HomePage()
        {
            InitializeComponent();
            SpeechSynthesizer vol = new SpeechSynthesizer();
            vol.Volume = 100;
            vol.SpeakAsync("WELCOME , ENJOY WITH VDM APPLICATION");
            customizedDesign();
        }

        private void btn_dashboard_MouseHover(object sender, EventArgs e)
        {
            btn_dashboard.BackColor = Color.Black;
            btn_banking_menu.Hide();
            btn_banking_menu2.Hide();
            btn_sales_Menu1.Hide();
            btn_sales_Menu2.Hide();
            btn_sales_Menu3.Hide();
            btn_Expenses_Menu1.Hide();
            btn_Expenses_Menu2.Hide();
            btn_Accounting_Menu1.Hide();
            btn_Accounting_Menu2.Hide();
                
        }
 

        private void btn_dashboard_MouseLeave(object sender, EventArgs e)
        {
            if (dashboardclicked)
            {
                btn_dashboard.BackColor = Color.Black;

            }
            else
            {
                btn_dashboard.BackColor = Color.Empty;
            }
         
        }

        private void btn_Banking_MouseHover(object sender, EventArgs e)
        {
            btn_Banking.BackColor = Color.Black;
            btn_banking_menu.BringToFront();
            btn_banking_menu2.BringToFront();
            btn_banking_menu.Show();
            btn_banking_menu2.Show();
            btn_sales_Menu1.Hide();
            btn_sales_Menu2.Hide();
            btn_sales_Menu3.Hide();
            btn_Expenses_Menu1.Hide();
            btn_Expenses_Menu2.Hide();
            btn_Accounting_Menu1.Hide();
            btn_Accounting_Menu2.Hide();
        }

        private void btn_Banking_MouseLeave(object sender, EventArgs e)
        {

            if (bankingclicked)
            {
               
                btn_Banking.BackColor = Color.Black;
               
            }
            else
            {
                btn_Banking.BackColor = Color.Empty;
            }
           
           

        }

        private void btn_sales_MouseHover(object sender, EventArgs e)
        {
            btn_sales.BackColor = Color.Black;
            btn_banking_menu.Hide();
            btn_banking_menu2.Hide();
            btn_sales_Menu1.Show();
            btn_sales_Menu2.Show();
            btn_sales_Menu3.Show();
            btn_sales_Menu1.BringToFront();
            btn_sales_Menu2.BringToFront();
            btn_sales_Menu3.BringToFront();
            btn_Expenses_Menu1.Hide();
            btn_Expenses_Menu2.Hide();
            btn_Accounting_Menu1.Hide();
            btn_Accounting_Menu2.Hide();
        }

        private void btn_sales_MouseLeave(object sender, EventArgs e)
        {

            if (salesckicked)
            {
                btn_sales.BackColor = Color.Black;
               
            }
            else
            {
                btn_sales.BackColor = Color.Empty;
            }
          

        }

        private void btn_Expenses_MouseHover(object sender, EventArgs e)
        {
            btn_Expenses.BackColor = Color.Black;
            btn_banking_menu.Hide();
            btn_banking_menu2.Hide();
            btn_sales_Menu1.Hide();
            btn_sales_Menu2.Hide();
            btn_sales_Menu3.Hide();
             btn_sales_Menu1.Hide();
            btn_sales_Menu2.Hide();
            btn_sales_Menu3.Hide();
            btn_Expenses_Menu1.Show();
            btn_Expenses_Menu2.Show();
            btn_Expenses_Menu1.BringToFront();
            btn_Expenses_Menu2.BringToFront();
            btn_Accounting_Menu1.Hide();
            btn_Accounting_Menu2.Hide();

        }

        private void btn_Expenses_MouseLeave(object sender, EventArgs e)
        {

            if (expensescliked)
            {
                btn_Expenses.BackColor = Color.Black;
            }
            else
            {
                btn_Expenses.BackColor = Color.Empty;
            }
          
          
        }

        private void btn_employees_MouseHover(object sender, EventArgs e)
        {
            btn_employees.BackColor = Color.Black;
            btn_banking_menu.Hide();
            btn_banking_menu2.Hide();
            btn_sales_Menu1.Hide();
            btn_sales_Menu2.Hide();
            btn_sales_Menu3.Hide();
            btn_Expenses_Menu1.Hide();
            btn_Expenses_Menu2.Hide();
            btn_Accounting_Menu1.Hide();
            btn_Accounting_Menu2.Hide();

        }

        private void btn_employees_MouseLeave(object sender, EventArgs e)
        {

            if (employeesclicked)
            {
                btn_employees.BackColor = Color.Black;
            }
            else
            {
                btn_employees.BackColor = Color.Empty;
            }
            
        }

        private void btn_reports_MouseHover(object sender, EventArgs e)
        {
            btn_reports.BackColor = Color.Black;
            btn_banking_menu.Hide();
            btn_banking_menu2.Hide();
            btn_sales_Menu1.Hide();
            btn_sales_Menu2.Hide();
            btn_sales_Menu3.Hide();
            btn_Expenses_Menu1.Hide();
            btn_Expenses_Menu2.Hide();
            btn_Accounting_Menu1.Hide();
            btn_Accounting_Menu2.Hide();

        }

        private void btn_reports_MouseLeave(object sender, EventArgs e)
        {

            if (Reportsclicked)
            {
                btn_reports.BackColor = Color.Black;
            }
            else
            {
                btn_reports.BackColor = Color.Empty;
            }
          
        }

        private void btn_taxes_MouseHover(object sender, EventArgs e)
        {
            btn_taxes.BackColor = Color.Black;
            btn_banking_menu.Hide();
            btn_banking_menu2.Hide();
            btn_sales_Menu1.Hide();
            btn_sales_Menu2.Hide();
            btn_sales_Menu3.Hide();
            btn_Expenses_Menu1.Hide();
            btn_Expenses_Menu2.Hide();
            btn_Accounting_Menu1.Hide();
            btn_Accounting_Menu2.Hide();

        }

        private void btn_taxes_MouseLeave(object sender, EventArgs e)
        {

            if (taxesclicked)
            {
                btn_taxes.BackColor = Color.Black;
            }
            else
            {
                btn_taxes.BackColor = Color.Empty;
            }
           

        }

        private void btn_Accounting_MouseHover(object sender, EventArgs e)
        {
            btn_Accounting.BackColor = Color.Black;
            btn_banking_menu.Hide();
            btn_banking_menu2.Hide();
            btn_sales_Menu1.Hide();
            btn_sales_Menu2.Hide();
            btn_sales_Menu3.Hide();
            btn_Expenses_Menu1.Hide();
            btn_Expenses_Menu2.Hide();
            btn_Accounting_Menu1.Show();
            btn_Accounting_Menu2.Show();
            btn_Accounting_Menu1.BringToFront();
            btn_Accounting_Menu2.BringToFront();

        }

        private void btn_Accounting_MouseLeave(object sender, EventArgs e)
        {

            if (accountingclicked)
            {
                btn_Accounting.BackColor = Color.Black;
           
            }
            else
            {
                btn_Accounting.BackColor = Color.Empty;
            }
          


        }

        private void btn_apps_MouseHover(object sender, EventArgs e)
        {
            btn_apps.BackColor = Color.Black;
            btn_banking_menu.Hide();
            btn_banking_menu2.Hide();
            btn_sales_Menu1.Hide();
            btn_sales_Menu2.Hide();
            btn_sales_Menu3.Hide();
            btn_Expenses_Menu1.Hide();
            btn_Expenses_Menu2.Hide();
            btn_Accounting_Menu1.Hide();
            btn_Accounting_Menu2.Hide();

        }

        private void btn_apps_MouseLeave(object sender, EventArgs e)
        {

            if (appsclicked)
            {
                btn_apps.BackColor = Color.Black;
            }
            else
            {
                btn_apps.BackColor = Color.Empty;
            }
          
        }

       

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
           
            
            btn_Banking.BackColor = Color.Empty;
            btn_dashboard.BackColor = Color.Black;
            btn_sales.BackColor = Color.Empty;
            btn_Expenses.BackColor = Color.Empty;
            btn_employees.BackColor = Color.Empty;
            btn_reports.BackColor = Color.Empty;
            btn_taxes.BackColor = Color.Empty;
            btn_Accounting.BackColor = Color.Empty;
            btn_apps.BackColor = Color.Empty;

            //variables changing to false
            dashboardclicked = true;
            bankingclicked = false;
            salesckicked = false;
            expensescliked = false;
            employeesclicked = false;
            Reportsclicked = false;
            taxesclicked = false;
            accountingclicked = false;
            appsclicked = false;
            ///hide forms
            ///.....
            hideForms();

        }

        private void btn_Banking_Click(object sender, EventArgs e)
        {


            btn_Banking.BackColor = Color.Black;
            btn_dashboard.BackColor = Color.Empty;
            btn_sales.BackColor = Color.Empty;
            btn_Expenses.BackColor = Color.Empty;
            btn_employees.BackColor = Color.Empty;
            btn_reports.BackColor = Color.Empty;
            btn_taxes.BackColor = Color.Empty;
            btn_Accounting.BackColor = Color.Empty;
            btn_apps.BackColor = Color.Empty;

            //variables changing to false
            dashboardclicked = false;
            bankingclicked = true;
            salesckicked = false;
            expensescliked = false;
            employeesclicked = false;
            Reportsclicked = false;
            taxesclicked = false;
            accountingclicked = false;
            appsclicked = false;

            ///hide forms
            ///.....
            hideForms();



        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            
            btn_Banking.BackColor = Color.Empty;
            btn_dashboard.BackColor = Color.Empty;
            btn_sales.BackColor = Color.Black;
            btn_Expenses.BackColor = Color.Empty;
            btn_employees.BackColor = Color.Empty;
            btn_reports.BackColor = Color.Empty;
            btn_taxes.BackColor = Color.Empty;
            btn_Accounting.BackColor = Color.Empty;
            btn_apps.BackColor = Color.Empty;

            //variables changing to false
            dashboardclicked = false;
            bankingclicked = false;
            salesckicked = true;
            expensescliked = false;
            employeesclicked = false;
            Reportsclicked = false;
            taxesclicked = false;
            accountingclicked = false;
            appsclicked = false;

            


            ///hide forms
            ///.....
            hideForms();


            openChildForms(new Sales());
          



        }

        private void btn_Expenses_Click(object sender, EventArgs e)
        {

            btn_Banking.BackColor = Color.Empty;
            btn_dashboard.BackColor = Color.Empty;
            btn_sales.BackColor = Color.Empty;
            btn_Expenses.BackColor = Color.Black;
            btn_employees.BackColor = Color.Empty;
            btn_reports.BackColor = Color.Empty;
            btn_taxes.BackColor = Color.Empty;
            btn_Accounting.BackColor = Color.Empty;
            btn_apps.BackColor = Color.Empty;

            //variables changing to false
            dashboardclicked = false;
            bankingclicked = false;
            salesckicked = false;
            expensescliked = true;
            employeesclicked = false;
            Reportsclicked = false;
            taxesclicked = false;
            accountingclicked = false;
            appsclicked = false;


            ///hide forms
            ///.....
            hideForms();
            openChildForms(new Expenses());
            customizedDesign();
        }

        private void btn_employees_Click(object sender, EventArgs e)
        {
            btn_Banking.BackColor = Color.Empty;
            btn_dashboard.BackColor = Color.Empty;
            btn_sales.BackColor = Color.Empty;
            btn_Expenses.BackColor = Color.Empty;
            btn_employees.BackColor = Color.Black;
            btn_reports.BackColor = Color.Empty;
            btn_taxes.BackColor = Color.Empty;
            btn_Accounting.BackColor = Color.Empty;
            btn_apps.BackColor = Color.Empty;

            //variables changing to false
            dashboardclicked = false;
            bankingclicked = false;
            salesckicked = false;
            expensescliked = false;
            employeesclicked = true;
            Reportsclicked = false;
            taxesclicked = false;
            accountingclicked = false;
            appsclicked = false;

            ///hide forms
            ///.....
            hideForms();
            openChildForms(new Employees());
            customizedDesign();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {

            btn_Banking.BackColor = Color.Empty;
            btn_dashboard.BackColor = Color.Empty;
            btn_sales.BackColor = Color.Empty;
            btn_Expenses.BackColor = Color.Empty;
            btn_employees.BackColor = Color.Empty;
            btn_reports.BackColor = Color.Black;
            btn_taxes.BackColor = Color.Empty;
            btn_Accounting.BackColor = Color.Empty;
            btn_apps.BackColor = Color.Empty;

            //variables changing to false
            dashboardclicked = false;
            bankingclicked = false;
            salesckicked = false;
            expensescliked = false;
            employeesclicked = false;
            Reportsclicked = true;
            taxesclicked = false;
            accountingclicked = false;
            appsclicked = false;

            ///hide forms
            ///.....
            hideForms();
            customizedDesign();
        }

        private void btn_taxes_Click(object sender, EventArgs e)
        {
            btn_Banking.BackColor = Color.Empty;
            btn_dashboard.BackColor = Color.Empty;
            btn_sales.BackColor = Color.Empty;
            btn_Expenses.BackColor = Color.Empty;
            btn_employees.BackColor = Color.Empty;
            btn_reports.BackColor = Color.Empty;
            btn_taxes.BackColor = Color.Black;
            btn_Accounting.BackColor = Color.Empty;
            btn_apps.BackColor = Color.Empty;

            //variables changing to false
            dashboardclicked = false;
            bankingclicked = false;
            salesckicked = false;
            expensescliked = false;
            employeesclicked = false;
            Reportsclicked = false;
            taxesclicked = true;
            accountingclicked = false;
            appsclicked = false;


            ///hide forms
            ///.....
            hideForms();
            customizedDesign();
        }

        private void btn_Accounting_Click(object sender, EventArgs e)
        {
            btn_Banking.BackColor = Color.Empty;
            btn_dashboard.BackColor = Color.Empty;
            btn_sales.BackColor = Color.Empty;
            btn_Expenses.BackColor = Color.Empty;
            btn_employees.BackColor = Color.Empty;
            btn_reports.BackColor = Color.Empty;
            btn_taxes.BackColor = Color.Empty;
            btn_Accounting.BackColor = Color.Black;
            btn_apps.BackColor = Color.Empty;

            //variables changing to false
            dashboardclicked = false;
            bankingclicked = false;
            salesckicked = false;
            expensescliked = false;
            employeesclicked = false;
            Reportsclicked = false;
            taxesclicked = false;
            accountingclicked = true;
            appsclicked = false;


            ///hide forms
            ///.....
            hideForms();
            customizedDesign();
        }

        private void btn_apps_Click(object sender, EventArgs e)
        {
            btn_Banking.BackColor = Color.Empty;
            btn_dashboard.BackColor = Color.Empty;
            btn_sales.BackColor = Color.Empty;
            btn_Expenses.BackColor = Color.Empty;
            btn_employees.BackColor = Color.Empty;
            btn_reports.BackColor = Color.Empty;
            btn_taxes.BackColor = Color.Empty;
            btn_Accounting.BackColor = Color.Empty;
            btn_apps.BackColor = Color.Black;

            //variables changing to false
            dashboardclicked = false;
            bankingclicked = false;
            salesckicked = false;
            expensescliked = false;
            employeesclicked = false;
            Reportsclicked = false;
            taxesclicked = false;
            accountingclicked = false;
            appsclicked = true;
            customizedDesign();

            ///hide forms
            ///.....
            hideForms();
        }

        private void btn_banking_menu2_MouseHover(object sender, EventArgs e)
        {
            
          
            btn_banking_menu2.BackColor = Color.Black;
            btn_banking_menu.BackColor = c;
            btn_Banking.BackColor = Color.Black;
            btn_dashboard.BackColor = Color.Empty;
            btn_sales.BackColor = Color.Empty;
            btn_Expenses.BackColor = Color.Empty;
            btn_employees.BackColor = Color.Empty;
            btn_reports.BackColor = Color.Empty;
            btn_taxes.BackColor = Color.Empty;
            btn_Accounting.BackColor = Color.Empty;
            btn_apps.BackColor = Color.Empty;


        }

        private void btn_banking_menu_MouseHover(object sender, EventArgs e)
        {
            btn_banking_menu2.BackColor = c;
            btn_Banking.BackColor = Color.Black;
            btn_banking_menu.BackColor = Color.Black;
            btn_dashboard.BackColor = Color.Empty;
            btn_sales.BackColor = Color.Empty;
            btn_Expenses.BackColor = Color.Empty;
            btn_employees.BackColor = Color.Empty;
            btn_reports.BackColor = Color.Empty;
            btn_taxes.BackColor = Color.Empty;
            btn_Accounting.BackColor = Color.Empty;
            btn_apps.BackColor = Color.Empty;
        }

        private void btn_sales_Menu1_MouseHover(object sender, EventArgs e)
        {
            btn_sales_Menu1.BackColor = Color.Black;
            btn_sales_Menu2.BackColor = c;
            btn_sales_Menu3.BackColor = c;
            btn_sales.BackColor = Color.Black;
            btn_Banking.BackColor = Color.Empty;
            btn_dashboard.BackColor = Color.Empty;
            btn_Expenses.BackColor = Color.Empty;
            btn_employees.BackColor = Color.Empty;
            btn_reports.BackColor = Color.Empty;
            btn_taxes.BackColor = Color.Empty;
            btn_Accounting.BackColor = Color.Empty;
            btn_apps.BackColor = Color.Empty;


        }

        private void btn_sales_Menu2_MouseHover(object sender, EventArgs e)
        {
            btn_sales_Menu1.BackColor = c;
            btn_sales_Menu2.BackColor = Color.Black;
            btn_sales_Menu3.BackColor = c;
            btn_sales.BackColor = Color.Black;
            btn_Banking.BackColor = Color.Empty;
            btn_dashboard.BackColor = Color.Empty;
            btn_Expenses.BackColor = Color.Empty;
            btn_employees.BackColor = Color.Empty;
            btn_reports.BackColor = Color.Empty;
            btn_taxes.BackColor = Color.Empty;
            btn_Accounting.BackColor = Color.Empty;
            btn_apps.BackColor = Color.Empty;
        }

        private void btn_sales_Menu3_MouseHover(object sender, EventArgs e)
        {
            btn_sales_Menu1.BackColor = c;
            btn_sales_Menu2.BackColor = c;
            btn_sales_Menu3.BackColor = Color.Black;
            btn_sales.BackColor = Color.Black;
            btn_Banking.BackColor = Color.Empty;
            btn_dashboard.BackColor = Color.Empty;
            btn_Expenses.BackColor = Color.Empty;
            btn_employees.BackColor = Color.Empty;
            btn_reports.BackColor = Color.Empty;
            btn_taxes.BackColor = Color.Empty;
            btn_Accounting.BackColor = Color.Empty;
            btn_apps.BackColor = Color.Empty;
        }

        private void btn_Expenses_Menu1_MouseHover(object sender, EventArgs e)
        {
            btn_Expenses_Menu1.BackColor = Color.Black;
            btn_Expenses_Menu2.BackColor = c;
            btn_sales.BackColor = Color.Empty;
            btn_Banking.BackColor = Color.Empty;
            btn_dashboard.BackColor = Color.Empty;
            btn_Expenses.BackColor = Color.Black;
            btn_employees.BackColor = Color.Empty;
            btn_reports.BackColor = Color.Empty;
            btn_taxes.BackColor = Color.Empty;
            btn_Accounting.BackColor = Color.Empty;
            btn_apps.BackColor = Color.Empty;
        }

        private void btn_Expenses_Menu2_MouseHover(object sender, EventArgs e)
        {
            btn_Expenses_Menu1.BackColor = c;
            btn_Expenses_Menu2.BackColor = Color.Black;
            btn_sales.BackColor = Color.Empty;
            btn_Banking.BackColor = Color.Empty;
            btn_dashboard.BackColor = Color.Empty;
            btn_Expenses.BackColor = Color.Black;
            btn_employees.BackColor = Color.Empty;
            btn_reports.BackColor = Color.Empty;
            btn_taxes.BackColor = Color.Empty;
            btn_Accounting.BackColor = Color.Empty;
            btn_apps.BackColor = Color.Empty;
        }

        private void btn_Accounting_Menu1_MouseHover(object sender, EventArgs e)
        {
            btn_Accounting_Menu2.BackColor = c;
            btn_Accounting_Menu1.BackColor = Color.Black;
            btn_sales.BackColor = Color.Empty;
            btn_Banking.BackColor = Color.Empty;
            btn_dashboard.BackColor = Color.Empty;
            btn_Expenses.BackColor = Color.Empty;
            btn_employees.BackColor = Color.Empty;
            btn_reports.BackColor = Color.Empty;
            btn_taxes.BackColor = Color.Empty;
            btn_Accounting.BackColor = Color.Black;
            btn_apps.BackColor = Color.Empty;
           
        }

        private void btn_Accounting_Menu2_MouseHover(object sender, EventArgs e)
        {
            btn_Accounting_Menu2.BackColor = Color.Black;
            btn_Accounting_Menu1.BackColor = c;
            btn_sales.BackColor = Color.Empty;
            btn_Banking.BackColor = Color.Empty;
            btn_dashboard.BackColor = Color.Empty;
            btn_Expenses.BackColor = Color.Empty;
            btn_employees.BackColor = Color.Empty;
            btn_reports.BackColor = Color.Empty;
            btn_taxes.BackColor = Color.Empty;
            btn_Accounting.BackColor = Color.Black;
            btn_apps.BackColor = Color.Empty;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ///hide forms
            ///.....
            hideForms();

        }
        private Form activateForm = null;
        public void openChildForms(Form ChildForm)
        {
            if (activateForm != null)
                activateForm.Close();
            activateForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Add(ChildForm);
            panelChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        public void hideForms()
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }

        }

        private void btnAboutus_Click(object sender, EventArgs e)
        {
            ///hide forms
            ///.....
            hideForms();

            openChildForms(new About() );
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            hideForms();
            

           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dimming effect behind the search form
            Form frm = new Form();
            try
            {
                using (Search sr = new Search())
                {
                    frm.StartPosition = FormStartPosition.Manual;
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
            catch (Exception)
            {

                MessageBox.Show("Connection problem");
            }

            finally
            {
                frm.Dispose();
            }
            hideForms();
        }

        private void btn_banking_menu_Click(object sender, EventArgs e)
        {
            hideForms();
            openChildForms(new Rules());
            customizedDesign();
        }

        private void btn_sales_Menu2_Click(object sender, EventArgs e)
        {
            hideForms();
            openChildForms(new Customers());
            customizedDesign();
        }

        private void btn_sales_Menu3_Click(object sender, EventArgs e)
        {
            hideForms();
            openChildForms(new Products_and_services());
            customizedDesign();

        }

        private void btn_Expenses_Menu1_Click(object sender, EventArgs e)
        {
            hideForms();
            openChildForms(new Expenses());
            customizedDesign();
        }

        private void btn_Expenses_Menu2_Click(object sender, EventArgs e)
        {
            hideForms();
            openChildForms(new Suppliers());
            customizedDesign();
        }

        private void panelChildForm_MouseHover(object sender, EventArgs e)
        {
            customizedDesign();
        }
        public  void customizedDesign()
        {
            btn_banking_menu.Hide();
            btn_banking_menu2.Hide();
            btn_banking_menu.Hide();
            btn_banking_menu2.Hide();
            btn_sales_Menu1.Hide();
            btn_sales_Menu2.Hide();
            btn_sales_Menu3.Hide();
            btn_Expenses_Menu1.Hide();
            btn_Expenses_Menu2.Hide();
            btn_Accounting_Menu1.Hide();
            btn_Accounting_Menu2.Hide();
        }

        private void btn_sales_Menu1_Click(object sender, EventArgs e)
        {
            hideForms();
            openChildForms(new Sales());
            customizedDesign();
        }
    }
}

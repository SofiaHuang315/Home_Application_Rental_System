using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeApplianceRentalSystem
{
    public partial class CustomerLogin : Form
    {
        HomeApplianceDataSetTableAdapters.CustomerTableAdapter objCust = new HomeApplianceDataSetTableAdapters.CustomerTableAdapter();
        private int count = 0;
        public static String CustID, CustName;

        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerRegister cr = new CustomerRegister(); /// Opening customer register form when signup label link is clicked ///
            cr.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (count == 3)
            {
                MessageBox.Show("Invalid Login for three times! You have reached your limit", "Invalid Login"); /// Invalid logined for 3 times ///
            }
            else if (txtUsername.Text == "") /// If username textbox is null ///
            {
                MessageBox.Show("Please Enter your Username", "Customer Login");
            }
            else if (txtPassword.Text == "") /// If password textbox is null ///
            {
                MessageBox.Show("Please Enter your Password", "Customer Login");
            }
            else
            {
                /// Authenticating ///
                DataTable dt = new DataTable();
                dt = objCust.CustomerLogin(txtUsername.Text, txtPassword.Text);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successfully", "Customer Login"); /// Authentication process successful ///

                    dgvCustomer.DataSource = dt;
                    CustID = dgvCustomer[0, 0].Value.ToString();
                    CustName = dgvCustomer[1, 0].Value.ToString();

                    CustomerHome AL = new CustomerHome();
                    AL.Show();
                    this.Hide();
                }
                else
                {
                    count += 1;
                    MessageBox.Show("Invalid Login Attempt: " + count , "Invalid Login"); /// Showing invalid login attempt number if authentication failed ///
                }
            }
        }
        public void ClearTextBox()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

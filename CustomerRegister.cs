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
    public partial class CustomerRegister : Form
    {
        public CustomerRegister()
        {
            InitializeComponent();
            AutoID(); /// Calling Auto ID function ///
        }

        HomeApplianceDataSetTableAdapters.CustomerTableAdapter objCust = new HomeApplianceDataSetTableAdapters.CustomerTableAdapter();
        DataTable dt = new DataTable();

        public void AutoID()
        {
            DataTable dt = new DataTable();
            dt = objCust.GetData();
            if (dt.Rows.Count == 0)
            {
                lblCustomerID.Text = "Cu_001"; /// ID = Cu_001 ///
            }
            else
            {
                int size = dt.Rows.Count - 1;
                string OldID = dt.Rows[size][0].ToString();
                int NewID = Convert.ToInt32(OldID.Substring(3, 3)) + 1;
                string formattedNewID = NewID.ToString("D3");
                lblCustomerID.Text = "Cu_" + formattedNewID;
            }
        }
        public void ClearTextBox()
        {
            txtCustomerName.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CustomerLogin cl = new CustomerLogin(); /// Return back to Customer login page ///
            cl.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /// Condition checking for setting password /// 
            String pass = txtPassword.Text;
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Please enter your Customer Name", "Customer Registration");
                txtCustomerName.Focus();
            }
            else if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter your Username", "Customer Registration");
                txtUserName.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your Password", "Customer Registration");
                txtPassword.Focus();
            }
            else if (txtPassword.Text.Length < 8 || txtPassword.Text.Length > 16) /// Condition check for password lesser than 8 words and more than 16 words ///
            {
                MessageBox.Show("Please enter password between 8 and 16", "Customer Registration");
                txtPassword.Focus();
            }
            else if (!pass.Any(char.IsUpper))
            {
                MessageBox.Show("Please enter password at least one Uppercase letter", "Customer Registration");
                txtPassword.Focus();
            }
            else if (!pass.Any(Char.IsLower))
            {
                MessageBox.Show("Please enter password at least one Lower case letter", "Customer Registration");
                txtPassword.Focus();
            }
            else if (!pass.Any(Char.IsDigit))
            {
                MessageBox.Show("Please enter password at least one digit", "Customer Registration");
                txtPassword.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Please enter your Address", "Customer Registration");
                txtAddress.Focus();
            }
            else if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Please enter your Phone Number", "Customer Registration");
                txtPhoneNumber.Focus();
            }
            else
            {
                /// Submitting data to database /// 
                clsCustomerRegister CusData = new clsCustomerRegister();
                CusData.CustomerID = lblCustomerID.Text;
                CusData.CustomerName = txtCustomerName.Text;
                CusData.UserName = txtUserName.Text;
                CusData.Password = txtPassword.Text;
                CusData.Address = txtAddress.Text;
                CusData.PhoneNumber = txtPhoneNumber.Text;

                objCust.Insert(CusData.CustomerID, CusData.CustomerName, CusData.UserName, CusData.Password, CusData.Address, CusData.PhoneNumber);

                MessageBox.Show("Customer Data Saved Successfully.", "Customer Registration", MessageBoxButtons.OKCancel);
                ClearTextBox();
                AutoID();

            }   
        }
    }
}
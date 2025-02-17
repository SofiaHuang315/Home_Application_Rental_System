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
    public partial class AdminLogin : Form
    {
        HomeApplianceDataSetTableAdapters.AdminTableAdapter objAdm = new HomeApplianceDataSetTableAdapters.AdminTableAdapter();
        private int count = 0;
        public static String AdmID, AdmName;

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (count == 3) /// Condition checking if the invalid is exceeded more than 3 times ///
            {
                MessageBox.Show("Invalid Login three times! You have reached your limit" , "Invalid Login");
            }
            else if (txtUsername.Text == "") /// Condition checking if the username text box is empty ///
            {
                MessageBox.Show("Please Enter your Username", "Admin Login");
            }
            else if (txtPassword.Text == "") /// Condition checking if the password text box is empty ///
            {
                MessageBox.Show("Please Enter your Password", "Admin Login");
            }
            else
            {
                /// Authentication ///
                DataTable dt = new DataTable();
                dt = objAdm.AdminLogin(txtUsername.Text, txtPassword.Text);

                if (dt.Rows.Count == 1) 
                {
                    MessageBox.Show("Login Successfully!","Administration Login"); /// Authentication success message box ///

                    dgvAdmin.DataSource = dt;
                    AdmID = dgvAdmin[0, 0].Value.ToString();
                    AdmName = dgvAdmin[1, 0].Value.ToString();

                    AdminHome AL = new AdminHome();
                    AL.Show();
                    this.Hide();
                }
                else
                {
                    count += 1;
                    MessageBox.Show("Invalid Login Attempt: " + count , "Invalid Login"); /// Login authentication failure message box ///
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            /// Go to Admin register form if signup label was clicked ///
        {
            AdminRegister cr = new AdminRegister();
            cr.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}

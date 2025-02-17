using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HomeApplianceRentalSystem
{
    public partial class AdminRegister : Form
    {
        public AdminRegister()
        {
            InitializeComponent();
            AutoID(); /// Calling auto ID function for admins ///
        }

        HomeApplianceDataSetTableAdapters.AdminTableAdapter objAdm = new HomeApplianceDataSetTableAdapters.AdminTableAdapter();
        DataTable dt = new DataTable(); /// To form a table ///

        public void AutoID()
        {
            DataTable dt = new DataTable();
            dt = objAdm.GetData();
            if (dt.Rows.Count == 0) /// Condition checking for auto ID function ///
            {
                lblAdminID.Text = "Ad_001"; /// ID = Ad_001 ///
            }
            else
            {
                int size = dt.Rows.Count - 1;
                string OldID = dt.Rows[size][0].ToString();
                int NewID = Convert.ToInt32(OldID.Substring(3, 3)) + 1;
                string formattedNewID = NewID.ToString("D3");
                lblAdminID.Text = "Ad_" + formattedNewID;
            }
        }

        public void ClearTextBox()
        {
            txtAdminName.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            picStaffPhoto.Image = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
            /// Condition checking for admin registration form filling ///
        {
            String pass = txtPassword.Text;
            if (txtAdminName.Text == "")
            {
                MessageBox.Show("Please enter your Admin Name", "Admin Register");
                txtAdminName.Focus();
            }
            else if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter your Username", "Admin Register");
                txtUserName.Focus();
            }
 
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your Password", "Admin Register");
                txtPassword.Focus();
            }
 
            else if (txtPassword.Text.Length < 8 || txtPassword.Text.Length > 16) /// If password is less than 8 words and more than 16 words ///
            {
                MessageBox.Show("Please enter password between 8 and 16", "Admin Register");
                txtPassword.Focus();
            }
            else if (!pass.Any(char.IsUpper)) 
            {
                MessageBox.Show("Please enter password at least one Uppercase letter", "Admin Register");
                txtPassword.Focus();
            }
            else if (!pass.Any(Char.IsLower))
            {
                MessageBox.Show("Please enter password at least one Lower case letter", "Admin Register");
                txtPassword.Focus();
            }
            else if (!pass.Any(Char.IsDigit))
            {
                MessageBox.Show("Please enter password at least one digit", "Admin Register");
                txtPassword.Focus();
            }
 
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Please enter your Address", "Admin Register");
                txtAddress.Focus();
            }
 
            else if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Please enter your Phone Number", "Admin Register");
                txtPhoneNumber.Focus();
            }
 
            else
            {
                /// To enter data to database ///
                clsAdminRegister AdmData = new clsAdminRegister();
                AdmData.AdminID = lblAdminID.Text;
                AdmData.AdminName = txtAdminName.Text;
                AdmData.UserName = txtUserName.Text;
                AdmData.Password = txtPassword.Text;
                AdmData.Address = txtAddress.Text;
                AdmData.PhoneNumber = txtPhoneNumber.Text;
 
                /// To save image ///
                String Location = "D:\\L4DC\\DDOOCP\\MOE PWINT PHYU_P_DDOOCP_GA\\NEW PROGRAM\\HomeApplianceRentalSystem\\bin\\Debug";
                String path = Path.Combine(Location, txtAdminName.Text + ".jpg");
                Image img = picStaffPhoto.Image;
                img.Save(path);
 
                objAdm.Insert(AdmData.AdminID, AdmData.AdminName, AdmData.UserName, AdmData.Password, AdmData.Address, AdmData.PhoneNumber,path);
 
                MessageBox.Show("Admin Data Saved Successful.", "Admin Registration", MessageBoxButtons.OKCancel);
                ClearTextBox();
                AutoID();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin(); /// Return back to Admin login page ///
            al.Show();
            this.Hide();
        }

        private void picStaffPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox pic = sender as PictureBox;
            if (pic != null)
            {
                /// Filtering image extension (type) ///
                open.Filter = "(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pic.Image = Image.FromFile(open.FileName);
                }
            }
        }
    }
}
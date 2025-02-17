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
    public partial class ApplianceType : Form
    {
        public ApplianceType()
        {
            InitializeComponent();
            AutoID(); /// Calling Auto ID function ///
        }

        HomeApplianceDataSetTableAdapters.ApplianceTypeTableAdapter objapptype = new HomeApplianceDataSetTableAdapters.ApplianceTypeTableAdapter();
        DataTable dt = new DataTable();

        public static String appTypeID, appType;

        public void AutoID() /// Creating Auto ID function ///
        {
            DataTable dt = new DataTable();
            dt = objapptype.GetData();
            if (dt.Rows.Count == 0)
            {
                lblApplianceTypeID.Text = "AT_001"; /// ID = AT_001 ///
            }
            else
            {
                int size = dt.Rows.Count - 1;
                String OldID = dt.Rows[size][0].ToString();
                int NewID = Convert.ToInt32(OldID.Substring(3, 3));

                if (NewID >= 1 && NewID <= 9)
                {
                    lblApplianceTypeID.Text = "AT_00" + (NewID + 1); /// ID = AT_001 to AT_009 ///
                }

                else if (NewID >= 10 && NewID <= 99)
                {
                    lblApplianceTypeID.Text = "AT_0" + (NewID + 1); /// ID = AT_010 to AT_099 ///
                }

                else if (NewID >= 100 && NewID <= 999)
                {
                    lblApplianceTypeID.Text = "AT_" + (NewID + 1); /// ID = AT_100 to AT_999 ///
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome(); /// Back to Admin Home page ///
            ah.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtApplianceType.Text == "")
            {
                MessageBox.Show("Please enter Appliance Type", "Appliance Type Entry");
                txtApplianceType.Focus();
            }
            else
            {
                /// Submitting appliance ID and appliance type to the database ///
                objapptype.Insert(lblApplianceTypeID.Text, txtApplianceType.Text);

                MessageBox.Show("Appliance Type Data Saved Successful!", "Appliance Type Register", MessageBoxButtons.OKCancel);
                txtApplianceType.Text = "";

                if (dt.Rows.Count == 1)
                {
                    dgvApp.DataSource = dt;
                    appTypeID = dgvApp[0, 0].Value.ToString();
                    appType = dgvApp[1, 0].Value.ToString();
                }

                AutoID();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtApplianceType.Clear();
        }
    }
}

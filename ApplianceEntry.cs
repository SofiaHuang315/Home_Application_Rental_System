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
    public partial class ApplianceEntry : Form
    {
        public ApplianceEntry()
        {
            InitializeComponent();

            AutoID(); /// Calling Auto ID function ///
            lblAdminID.Text = AdminLogin.AdmID;

            dt = objapp.GetData();
            dgvAppliance.DataSource = dt;
            dgvAppliance.Refresh();
        }

        HomeApplianceDataSetTableAdapters.AppliancesTableAdapter objapp = new HomeApplianceDataSetTableAdapters.AppliancesTableAdapter();
        HomeApplianceDataSetTableAdapters.ApplianceTypeTableAdapter objapptype = new HomeApplianceDataSetTableAdapters.ApplianceTypeTableAdapter();
        HomeApplianceDataSetTableAdapters.AdminTableAdapter objAdmin = new HomeApplianceDataSetTableAdapters.AdminTableAdapter();
        DataTable dt = new DataTable(); /// To form a table ///

        String AppID;

        public void AutoID() /// Creating Auto ID function for appliances ///
        {
            DataTable dt = new DataTable();
            dt = objapp.GetData();
            if (dt.Rows.Count == 0)
            {
                lblApplianceID.Text = "AP_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                string OldID = dt.Rows[size][0].ToString();
                int NewID = Convert.ToInt32(OldID.Substring(3, 3)) + 1;
                string formattedNewID = NewID.ToString("D3");
                lblApplianceID.Text = "AP_" + formattedNewID;
            }
        }

        private void SetApplianceType() /// Setting appliance type ///
        {
            dt = objapptype.GetData();
            cboApplianceType.Items.Add("Please choose Appliance Type");
            /// Prepare for Data entry to appliance type database ///
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboApplianceType.Items.Add(dt.Rows[i][1].ToString());
            }
            cboApplianceType.SelectedIndex = 0;
        }

        public void ClearAppliance() /// Clear function ///
        {
            txtApplianceName.Clear();
            cboApplianceType.SelectedIndex = 0;
            txtPowerUsage.Clear();
            txtTypicalUsage.Clear();
            txtEstimatedAnnualCosts.Clear();
            txtModel.Clear();
            txtDimension.Clear();
            txtColour.Clear();
            txtEnergyConsumption.Clear();
            txtMonthlyFees.Clear();
            txtQuantity.Clear();
            picAppliancePhoto.Image = null;
        }

        private void btnSave_Click(object sender, EventArgs e) 
        /// Checking if the data is not null and submitting the data to the database ///
        {
            if (txtApplianceName.Text == "")
            {
                MessageBox.Show("Please enter Appliance Name", "Appliance Entry", MessageBoxButtons.OKCancel);
                txtApplianceName.Focus();
            }
            else if (txtPowerUsage.Text == "")
            {
                MessageBox.Show("Please enter Power Usage", "Appliance Entry", MessageBoxButtons.OKCancel);
                txtPowerUsage.Focus();
            }
            else if (txtTypicalUsage.Text == "")
            {
                MessageBox.Show("Please enter Typical Usage", "Appliance Entry", MessageBoxButtons.OKCancel);
                txtTypicalUsage.Focus();
            }
            else if (txtEstimatedAnnualCosts.Text == "")
            {
                MessageBox.Show("Please enter Estimated Annual Cost", "Appliance Entry", MessageBoxButtons.OKCancel);
                txtEstimatedAnnualCosts.Focus();
            }
            else if (txtModel.Text == "")
            {
                MessageBox.Show("Please enter Model", "Appliance Entry", MessageBoxButtons.OKCancel);
                txtModel.Focus();
            }
            else if (txtDimension.Text == "")
            {
                MessageBox.Show("Please enter Dimension", "Appliance Entry", MessageBoxButtons.OKCancel);
                txtDimension.Focus();
            }
            else if (txtColour.Text == "")
            {
                MessageBox.Show("Please enter colour", "Appliance Entry", MessageBoxButtons.OKCancel);
                txtColour.Focus();
            }
            else if (txtEnergyConsumption.Text == "")
            {
                MessageBox.Show("Please enter energy consumption", "Appliance Entry", MessageBoxButtons.OKCancel);
                txtEnergyConsumption.Focus();
            }
            else if (txtMonthlyFees.Text == "")
            {
                MessageBox.Show("Please enter Monthly fees", "Appliance Entry", MessageBoxButtons.OKCancel);
                txtMonthlyFees.Focus();
            }
            else if (cboApplianceType.SelectedIndex == 0)
            {
                MessageBox.Show("Please choose Appliance Type", "Appliance Entry", MessageBoxButtons.OKCancel);
                cboApplianceType.Focus();
            }
            else if (txtQuantity.Text == "")
            {
                MessageBox.Show("Please enter Quantity", "Appliance Entry", MessageBoxButtons.OKCancel);
                txtQuantity.Focus();
            }
            else
            {
                /// Preparing data to submit into database ///
                clsAppliance app = new clsAppliance();
                app.ApplianceID = lblApplianceID.Text;
                app.AppName = txtApplianceName.Text;
                app.PUsage = txtPowerUsage.Text;
                app.TUsage = txtTypicalUsage.Text;
                app.AnnualCost = Convert.ToInt32(txtEstimatedAnnualCosts.Text);
                app.Model = txtModel.Text;
                app.Dimen = txtDimension.Text;
                app.Colour = txtColour.Text;
                app.EnCon = txtEnergyConsumption.Text;
                app.MFee = Convert.ToInt32(txtMonthlyFees.Text);
                app.AdID = lblAdminID.Text;
                app.ATID = cboApplianceType.SelectedText;
                app.Quant = Convert.ToInt32(txtQuantity.Text);

                /// Saving image path ///
                String Location = "D:\\L4DC\\DDOOCP\\MOE PWINT PHYU_P_DDOOCP_GA\\NEW PROGRAM\\HomeApplianceRentalSystem\\bin\\Debug";
                String path = Path.Combine(Location, txtApplianceName.Text + ".jpg");
                Image img = picAppliancePhoto.Image;
                img.Save(path); 

                /// Submitting data to database ///
                int count;
                count = objapp.InsertAppliance(app.ApplianceID, app.AppName, app.PUsage, app.TUsage, app.AnnualCost, app.Model, app.Dimen, app.Colour, app.EnCon, app.MFee, AdminLogin.AdmID, AppID, path, app.Quant);
                if (count > 0)
                {
                    MessageBox.Show("Appliance Data Saved Successful", "Appliance Entry", MessageBoxButtons.OKCancel);
                    ClearAppliance();
                    AutoID();
                    dt = objapp.GetData();
                    dgvAppliance.DataSource = dt;
                    dgvAppliance.Refresh();
                }
                else
                {
                    MessageBox.Show("Invalid Data");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtApplianceName.Text == "")
            {
                MessageBox.Show("Please Enter Appliance Name", "Appliance Entry");
                txtApplianceName.Focus();
            }
            else
            {
                String Location = "D:\\L4DC\\DDOOCP\\MOE PWINT PHYU_P00200812_DDOOCP_GA\\NEW PROGRAM\\HomeApplianceRentalSystem\\bin\\Debug";
                String path = Path.Combine(Location, txtApplianceName.Text + ".jpg");
                Image img = picAppliancePhoto.Image;

                clsAppliance app = new clsAppliance();
                app.ApplianceID = lblApplianceID.Text;
                app.AppName = txtApplianceName.Text;
                app.PUsage = txtPowerUsage.Text;
                app.TUsage = txtTypicalUsage.Text;
                app.AnnualCost = Convert.ToInt32(txtEstimatedAnnualCosts.Text);
                app.Model = txtModel.Text;
                app.Dimen = txtDimension.Text;
                app.Colour = txtColour.Text;
                app.EnCon = txtEnergyConsumption.Text;
                app.MFee = Convert.ToInt32(txtMonthlyFees.Text);
                app.AdID = lblAdminID.Text;
                app.ATID = cboApplianceType.SelectedText;
                app.Quant = Convert.ToInt32(txtQuantity.Text);
              
                objapp.UpdateAppliance(app.AppName, app.PUsage, app.TUsage, app.AnnualCost, app.Model, app.Dimen, app.Colour, app.EnCon, app.MFee, AdminLogin.AdmID, AppID, path, app.Quant, app.ApplianceID);
                MessageBox.Show("Successfully Updated", "Appliance Update");
                AutoID();
                dgvAppliance.DataSource = objapp.GetData();
                dgvAppliance.Refresh();
                ClearAppliance();
                AutoID();

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
            }
        }

        private void picAppliancePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox pic = sender as PictureBox;
            if (pic != null) 
            {
                /// Filtering image extension formats ///
                open.Filter = "(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pic.Image = Image.FromFile(open.FileName);
                }
            }
        }

        private void ApplianceEntry_Load(object sender, EventArgs e)
        {
            txtApplianceName.Focus();
            SetApplianceType();
        }

        private void dgvAppliance_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /// Selecting the row on the mouseclick upon the cell of the row datagridview ///
            DataGridViewRow row = this.dgvAppliance.Rows[e.RowIndex];
            lblApplianceID.Text = row.Cells[0].Value.ToString();
            txtApplianceName.Text = row.Cells[1].Value.ToString();
            txtPowerUsage.Text = row.Cells[2].Value.ToString();
            txtTypicalUsage.Text = row.Cells[3].Value.ToString();
            txtEstimatedAnnualCosts.Text = row.Cells[4].Value.ToString();
            txtModel.Text = row.Cells[5].Value.ToString();
            txtDimension.Text = row.Cells[6].Value.ToString();
            txtColour.Text = row.Cells[7].Value.ToString();
            txtEnergyConsumption.Text = row.Cells[8].Value.ToString();
            txtMonthlyFees.Text = row.Cells[9].Value.ToString();
            lblAdminID.Text = row.Cells[10].Value.ToString();
            cboApplianceType.Text = row.Cells[11].Value.ToString();
            picAppliancePhoto.Image = Image.FromFile(row.Cells[12].Value.ToString());
            txtQuantity.Text = row.Cells[13].Value.ToString();
            

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false; /// Disabling save button ///
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblApplianceID.Text == "")
            {
                MessageBox.Show("Invalid Appliance ID", "Appliance Entry");
                lblApplianceID.Focus();
            }
            else
            {
                /// Deleted the data from datagridview ///
                objapp.DeleteAppliance(lblApplianceID.Text);
                MessageBox.Show("Successfully Deleted", "Appliance Deletion"); 
                dgvAppliance.DataSource = objapp.GetData();
                dgvAppliance.Refresh();
                AutoID();
                ClearAppliance();
                btnUpdate.Enabled = false; /// Disabling update button ///
                btnDelete.Enabled = false; /// Disabling delete button ///
                btnSave.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome(); /// Return back to Admin Home ///
            ah.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAppliance(); 
        }

        private void cboApplianceType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            /// Retrieving the data for appliance type and showing in the combo box ///
            String appName = cboApplianceType.SelectedItem.ToString();
            DataTable dt1 = new DataTable();
            dt1 = objapptype.CheckApplianceTypeName(appName);
            if (dt1.Rows.Count > 0)
            {
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    AppID = dt1.Rows[0][0].ToString();
                }
            }
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvAppliance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

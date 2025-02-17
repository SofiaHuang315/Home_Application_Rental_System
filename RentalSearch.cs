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
    public partial class RentalSearch : Form
    {
        public RentalSearch()
        {
            InitializeComponent();
            SetRentID();
            SetAppType();
        }

        HomeApplianceDataSetTableAdapters.RentalTableAdapter objRent = new HomeApplianceDataSetTableAdapters.RentalTableAdapter();
        HomeApplianceDataSetTableAdapters.RentalApplianceDetailsTableAdapter objRentDet = new HomeApplianceDataSetTableAdapters.RentalApplianceDetailsTableAdapter();
        HomeApplianceDataSetTableAdapters.ApplianceTypeTableAdapter objAppType = new HomeApplianceDataSetTableAdapters.ApplianceTypeTableAdapter();
        DataTable dt = new DataTable();

        private void SetRentID()
        {
            dt = objRent.GetData();

            cboSearchbyID.Items.Add("Please Choose Rent ID"); /// If no combo box is selected ///
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboSearchbyID.Items.Add(dt.Rows[i][0].ToString());
            }
            cboSearchbyID.SelectedIndex = 0;
        }

        private void SetAppType()
        {
            dt = objAppType.GetData();

            cboSearchbyType.Items.Add("Choose Appliance Type"); 
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboSearchbyType.Items.Add(dt.Rows[i][1].ToString());
            }
            cboSearchbyType.SelectedIndex = 0;
        }

        private void rdoSearchbyDate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dt = objRent.GetData();
            dgvDisplay.DataSource = dt;
            dgvDisplay.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdoSearchbyID.Checked) /// When search by ID radio button is selected ///
            {
                dt = objRentDet.SearchByRentID(Convert.ToString(cboSearchbyID.SelectedItem));
                dgvDisplay.DataSource = dt;
                dgvDisplay.Refresh();
            }
            else if (rdoSearchbyApplianceType.Checked) /// When search by Appliance Type button is selected ///
            {
                dt = objRentDet.SearchByAppType(Convert.ToString(cboSearchbyType.SelectedItem));
                dgvDisplay.DataSource = dt;
                dgvDisplay.Refresh();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome(); /// Return back to Admin home page ///
            ah.Show();
            this.Hide();
        }

        private void rdoSearchbyID_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

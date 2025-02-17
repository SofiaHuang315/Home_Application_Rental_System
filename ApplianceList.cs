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
    public partial class ApplianceList : Form
    {
        public ApplianceList()
        {
            InitializeComponent();
            SetApplianceType();
        }

        HomeApplianceDataSetTableAdapters.ApplianceTypeTableAdapter objapptype = new HomeApplianceDataSetTableAdapters.ApplianceTypeTableAdapter();
        HomeApplianceDataSetTableAdapters.ViewApplianceTableAdapter objvapp = new HomeApplianceDataSetTableAdapters.ViewApplianceTableAdapter();
        DataTable dt = new DataTable();

        private void SetApplianceType()
        {
            dt = objapptype.GetData();
            cboApplianceType.Items.Add("Please choose Appliance Type");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboApplianceType.Items.Add(dt.Rows[i][1].ToString());
            }
            cboApplianceType.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboApplianceType.SelectedIndex == -1) /// If combo box is not selected ///
            {
                MessageBox.Show("No Data", "Appliance Search");
            }
            else
            {
                dt = objvapp.GetDataBy_AppType(cboApplianceType.Text); /// Getting data from cboApplianceType ///
                dgvApplianceList.DataSource = dt;
                dgvApplianceList.Refresh();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dt = objvapp.GetData();
            dgvApplianceList.DataSource = dt;
            dgvApplianceList.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome(); /// Return back to Admin Home page ///
            ah.Show();
            this.Hide();
        }
    }
}

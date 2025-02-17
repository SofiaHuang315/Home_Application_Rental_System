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
    public partial class RentList : Form
    {
        HomeApplianceDataSetTableAdapters.ViewRentApplianceTableAdapter vra = new HomeApplianceDataSetTableAdapters.ViewRentApplianceTableAdapter();
        HomeApplianceDataSetTableAdapters.ViewRentDetailTableAdapter vrd = new HomeApplianceDataSetTableAdapters.ViewRentDetailTableAdapter();
        DataTable dt = new DataTable();
        DataRow dr;

        public RentList()
        {
            InitializeComponent();
        }

        public void RentDetailList() /// Method for creating data to appear on 2nd datagridview ///
        {
            dr = dt.NewRow();
            dt.Columns.Add("RentID").ToString();
            dt.Columns.Add("ApplianceName").ToString();
            dt.Columns.Add("ApplianceType").ToString();
            dt.Columns.Add("UnitPrice").ToString();
            dt.Columns.Add("UnitQuantity").ToString();
            dt.Columns.Add("UnitAmount").ToString();
            dgvDetailRentList.Refresh();
            dgvDetailRentList.DataSource = dt;
        }

        private void RentList_Load(object sender, EventArgs e)
        {
            RentDetailList(); /// Calling method of RentDetailList back ///
            dgvRentList.DataSource = vra.GetData(); 
            dgvRentList.Refresh();
        }

        private void dgvRentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vrl = dgvRentList.CurrentCell.RowIndex;
            String RID = dgvRentList.Rows[vrl].Cells["RentID"].Value.ToString(); /// Finding RentID that is clicked ///
            DataTable dtt = new DataTable();
            dtt = vrd.CheckRentID(RID); /// CheckRentID from view rent detail ///
            dt.Rows.Clear();
            if (dtt.Rows.Count > 0) /// if there is record ///
            {
                for (int i = 0; i < dtt.Rows.Count; i++)
                {
                    dr = dt.NewRow();
                    dr["RentID"] = dtt.Rows[i]["RentID"];
                    dr["ApplianceName"] = dtt.Rows[i]["ApplianceName"];
                    dr["ApplianceType"] = dtt.Rows[i]["ApplianceType"];
                    dr["UnitPrice"] = dtt.Rows[i]["UnitPrice"];
                    dr["UnitQuantity"] = dtt.Rows[i]["UnitQuantity"];
                    dr["UnitAmount"] = dtt.Rows[i]["UnitAmount"];
                    dt.Rows.Add(dr);
                    dgvDetailRentList.DataSource = dt;
                    dgvDetailRentList.Refresh();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome(); /// Go back to Admin Home Page ///
            ah.Show();
            this.Hide();
        }
    }
}

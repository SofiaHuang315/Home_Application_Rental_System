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
    public partial class CustomerHome : Form
    {
        HomeApplianceDataSetTableAdapters.RentalTableAdapter objRent = new HomeApplianceDataSetTableAdapters.RentalTableAdapter();
        HomeApplianceDataSetTableAdapters.ViewApplianceTableAdapter vapp = new HomeApplianceDataSetTableAdapters.ViewApplianceTableAdapter();
        HomeApplianceDataSetTableAdapters.RentalApplianceDetailsTableAdapter objRentDet = new HomeApplianceDataSetTableAdapters.RentalApplianceDetailsTableAdapter();
        HomeApplianceDataSetTableAdapters.AppliancesTableAdapter objapp = new HomeApplianceDataSetTableAdapters.AppliancesTableAdapter();
        String AppID, AppName, PUsage, TUsage, ECost, Model, Dimension, Color, MonthlyFee, ApplianceType;

        /// To form a table ///
        int ToalRentQuantity = 0;
        int totalRentAmount = 0;
        DataTable dtRentApp = new DataTable();
        DataRow drRentApp;

        public void ApplianceList()
        {
            /// Submitting data to database ///
            drRentApp = dtRentApp.NewRow();
            dtRentApp.Columns.Add("ApplianceID").ToString();
            dtRentApp.Columns.Add("ApplianceName").ToString();
            dtRentApp.Columns.Add("PowerUsage").ToString();
            dtRentApp.Columns.Add("TypicalUsage").ToString();
            dtRentApp.Columns.Add("EstimatedAnnualCosts").ToString();
            dtRentApp.Columns.Add("Model").ToString();
            dtRentApp.Columns.Add("Dimension").ToString();
            dtRentApp.Columns.Add("Colour").ToString();
            dtRentApp.Columns.Add("MonthlyFees").ToString();
            dtRentApp.Columns.Add("ApplianceType").ToString();
            dtRentApp.Columns.Add("RentQuantity").ToString();
            dtRentApp.Columns.Add("RentAmount").ToString();
            dgvRentAppliance.Refresh();
            dgvRentAppliance.DataSource = dtRentApp;
        }

        public CustomerHome()
        {
            InitializeComponent();
            AutoID(); /// Calling Auto ID function ///
        }

        public void AutoID() /// Creating Auto ID function ///
        {
            DataTable dt = new DataTable();
            dt = objRent.GetData();
            if (dt.Rows.Count == 0)
            {
                txtRentID.Text = "ID_001"; /// ID = ID_001 ///
            }
            else
            {
                int size = dt.Rows.Count - 1;
                string OldID = dt.Rows[size][0].ToString();
                int NewID = Convert.ToInt32(OldID.Substring(3, 3)) + 1;
                string formattedNewID = NewID.ToString("D3");
                txtRentID.Text = "ID_" + formattedNewID;
            }
        }


        private void CustomerHome_Load(object sender, EventArgs e)
        {
            lblName.Text = CustomerLogin.CustName;
            dgvViewAppliance.DataSource = vapp.GetData();
            dgvRentAppliance.Visible = false; /// Disabling visibility of datagridview of Rent appliance ///
            dgvViewAppliance.Visible = true;
            lblName.Text = CustomerLogin.CustName;
            mnuRentAppliance.Enabled = false; /// Disabling menustript of Rent appliance ///
            mnuViewRentalList.Enabled = true; 
            ApplianceList();
            txtRentDate.Text = DateTime.Now.ToString("dd/MM/yyyy"); /// Auto setting today date ///
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            try
            {
                int qty = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter number of quantity for Rent"));
                drRentApp = dtRentApp.NewRow();
                drRentApp["ApplianceID"] = AppID;
                drRentApp["ApplianceName"] = AppName;
                drRentApp["PowerUsage"] = PUsage;
                drRentApp["TypicalUsage"] = TUsage;
                drRentApp["EstimatedAnnualCosts"] = ECost;
                drRentApp["Model"] = Model;
                drRentApp["Dimension"] = Dimension;
                drRentApp["Colour"] = Color;
                drRentApp["MonthlyFees"] = MonthlyFee;
                drRentApp["ApplianceType"] = ApplianceType;
                drRentApp["RentQuantity"] = qty;
                ToalRentQuantity += qty;
                txtTotalRentQuantity.Text = ToalRentQuantity.ToString();
                drRentApp["RentAmount"] = Convert.ToInt32(MonthlyFee) * Convert.ToInt32(qty);
                totalRentAmount += Convert.ToInt32(drRentApp["RentAmount"]);
                txtTotalAmount.Text = totalRentAmount.ToString();
                dtRentApp.Rows.Add(drRentApp);
                dgvRentAppliance.Refresh();
                dgvRentAppliance.DataSource = dtRentApp;
                mnuRentAppliance.Enabled = true;

                if (dtRentApp.Rows.Count > 0)
                {
                    MessageBox.Show("One Record is Added", "Appliance Rent", MessageBoxButtons.OKCancel);
                }

                else
                {
                    MessageBox.Show("No Record is Added", "Appliance Rent", MessageBoxButtons.OKCancel);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Rented Appliance", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void dgvViewAppliance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /// Selecting the row if one cell of that row is clicked ///
            int Selected_Index = dgvViewAppliance.CurrentCell.RowIndex;
            AppID = dgvViewAppliance.Rows[Selected_Index].Cells["ApplianceID"].Value.ToString();
            AppName = dgvViewAppliance.Rows[Selected_Index].Cells["ApplianceName"].Value.ToString();
            PUsage = dgvViewAppliance.Rows[Selected_Index].Cells["PowerUsage"].Value.ToString();
            TUsage = dgvViewAppliance.Rows[Selected_Index].Cells["TypicalUsage"].Value.ToString();
            ECost = dgvViewAppliance.Rows[Selected_Index].Cells["EstimatedAnnualCosts"].Value.ToString();
            Model = dgvViewAppliance.Rows[Selected_Index].Cells["Model"].Value.ToString();
            Dimension = dgvViewAppliance.Rows[Selected_Index].Cells["Dimension"].Value.ToString();
            Color = dgvViewAppliance.Rows[Selected_Index].Cells["Colour"].Value.ToString();
            MonthlyFee = dgvViewAppliance.Rows[Selected_Index].Cells["MonthlyFees"].Value.ToString();
            ApplianceType = dgvViewAppliance.Rows[Selected_Index].Cells["ApplianceType"].Value.ToString();
        }

        private void mnuViewAppliance_Click(object sender, EventArgs e)
        {
            dgvViewAppliance.DataSource = vapp.GetData();
            dgvRentAppliance.Visible = false; /// Disabling visibility of rent appliance datagridview ///
            dgvViewAppliance.Visible = true;
            dgvViewRentList.Visible = false;
        }

        private void cboNumberOfMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTotalAmount.Text == "")
            {
                MessageBox.Show("Please choose appliances to rent!", "Appliance Entry");
            }
            else
            {
                /// Amount * Selected month = All total amount ///
                if (cboNumberOfMonth.SelectedIndex == 0)
                {
                    txtAllTotalAmount.Text = Convert.ToString(Convert.ToInt32(txtTotalAmount.Text) * 1);
                }
                else if (cboNumberOfMonth.SelectedIndex == 1)
                {
                    txtAllTotalAmount.Text = Convert.ToString(Convert.ToInt32(txtTotalAmount.Text) * 2);
                }
                else if (cboNumberOfMonth.SelectedIndex == 2)
                {
                    txtAllTotalAmount.Text = Convert.ToString(Convert.ToInt32(txtTotalAmount.Text) * 3);
                }
                else if (cboNumberOfMonth.SelectedIndex == 3)
                {
                    txtAllTotalAmount.Text = Convert.ToString(Convert.ToInt32(txtTotalAmount.Text) * 4);
                }
                else if (cboNumberOfMonth.SelectedIndex == 4)
                {
                    txtAllTotalAmount.Text = Convert.ToString(Convert.ToInt32(txtTotalAmount.Text) * 5);
                }
                else if (cboNumberOfMonth.SelectedIndex == 5)
                {
                    txtAllTotalAmount.Text = Convert.ToString(Convert.ToInt32(txtTotalAmount.Text) * 6);
                }
                else if (cboNumberOfMonth.SelectedIndex == 6)
                {
                    txtAllTotalAmount.Text = Convert.ToString(Convert.ToInt32(txtTotalAmount.Text) * 7);
                }
                else if (cboNumberOfMonth.SelectedIndex == 7)
                {
                    txtAllTotalAmount.Text = Convert.ToString(Convert.ToInt32(txtTotalAmount.Text) * 8);
                }
                else if (cboNumberOfMonth.SelectedIndex == 8)
                {
                    txtAllTotalAmount.Text = Convert.ToString(Convert.ToInt32(txtTotalAmount.Text) * 9);
                }
                else if (cboNumberOfMonth.SelectedIndex == 9)
                {
                    txtAllTotalAmount.Text = Convert.ToString(Convert.ToInt32(txtTotalAmount.Text) * 10);
                }
                else if (cboNumberOfMonth.SelectedIndex == 10)
                {
                    txtAllTotalAmount.Text = Convert.ToString(Convert.ToInt32(txtTotalAmount.Text) * 11);
                }
                else if (cboNumberOfMonth.SelectedIndex == 11)
                {
                    txtAllTotalAmount.Text = Convert.ToString(Convert.ToInt32(txtTotalAmount.Text) * 12);
                }
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (txtTotalAmount.Text == "")
            {
                MessageBox.Show("Please choose appliances to rent!", "Appliance Entry");
            }
            else
            {

                if (cboNumberOfMonth.SelectedIndex == -1) /// If the month is not selected ///
                {
                    MessageBox.Show("Please Select Rent Month", "Rent Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    cboNumberOfMonth.Focus();
                }
                else
                {
                    /// Preparing to submit data ///
                    clsRentalAppliance rapp = new clsRentalAppliance();
                    clsRentDetails rdet = new clsRentDetails();
                    rapp.RentID = txtRentID.Text;
                    rapp.RentDate = DateTime.Now.ToString("yyyy-MM-dd"); /// Setting today date automatically ///
                    rapp.TotalMonth = Convert.ToInt32(cboNumberOfMonth.SelectedItem);
                    rapp.RentPrice = Convert.ToInt32(txtTotalAmount.Text);
                    rapp.AllTotalAmount = Convert.ToInt32(txtAllTotalAmount.Text);
                    rapp.RentQuantity = Convert.ToInt32(txtTotalRentQuantity.Text);
                    rapp.RentStatus = "Rent";

                    int count = objRent.InsertRent(rapp.RentID, CustomerLogin.CustID, rapp.RentDate, Convert.ToInt32(rapp.TotalMonth), Convert.ToInt32(rapp.RentQuantity), Convert.ToInt32(rapp.RentPrice), rapp.AllTotalAmount, rapp.RentStatus);
                    if (count > 0)
                    {
                        /// Submitting data to database ///
                        for (int i = 0; i < dtRentApp.Rows.Count; i++)
                        {
                            rdet.RentID = txtRentID.Text;
                            rdet.ApplianceID = dtRentApp.Rows[i]["ApplianceID"].ToString();
                            rdet.MonthlyFees = Convert.ToInt32(dtRentApp.Rows[i]["MonthlyFees"]);
                            rdet.RentQuantity = Convert.ToInt32(dtRentApp.Rows[i]["RentQuantity"]);
                            rdet.RentPrice = Convert.ToInt32(dtRentApp.Rows[i]["RentAmount"]);
                            objRentDet.InsertRentAppliance(rdet.RentID, rdet.ApplianceID, Convert.ToInt32(rdet.MonthlyFees), Convert.ToInt32(rdet.RentQuantity), Convert.ToInt32(rdet.RentPrice));

                            objapp.UpdateAppQuantity(rdet.RentQuantity, rdet.ApplianceID);
                        }
                        MessageBox.Show("Successfully Recorded Rental Details", "Rent Appliance", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        AutoID();
                        txtTotalRentQuantity.Text = "";
                        txtTotalAmount.Text = "";
                        txtAllTotalAmount.Text = "";
                        cboNumberOfMonth.Text = "";
                        mnuViewRentalList.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Rent Record", "Rent Appliance", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    mnuViewRentalList.Enabled = true;
                }
            }
        }

        private void mnuRentAppliance_Click(object sender, EventArgs e)
        {
            dgvRentAppliance.Visible = true;
            dgvViewAppliance.Visible = false; /// Disabling datagridview of view appliance ///
            dgvRentAppliance.Refresh();
            dgvRentAppliance.DataSource = dtRentApp;
        }

        private void mnuViewRentalList_Click(object sender, EventArgs e)
        {
            dgvViewRentList.Visible = true;
            string CustomerID = CustomerLogin.CustID; /// Recording CustomerID that is logged in ///
            DataTable dtt = new DataTable();
            DataRow drr;
            dtt = objRent.CheckCustomerID(CustomerID); /// Checking CustomerID that is logged in and if same, all columns from datatable will be taken out ///

            drr = dtt.NewRow();
            for (int i = 0; i < dtt.Rows.Count; i++)
            {
                drr["RentID"] = dtt.Rows[i]["RentID"].ToString();
                drr["RentDate"] = dtt.Rows[i]["RentDate"].ToString();
                drr["Months"] = dtt.Rows[i]["Months"].ToString();
                drr["RentQuantity"] = dtt.Rows[i]["RentQuantity"].ToString();
                drr["RentPrice"] = dtt.Rows[i]["RentPrice"].ToString();
                dgvViewRentList.DataSource = dtt; /// Putting all information on datagridview ///
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            CustomerLogin cl = new CustomerLogin(); /// Return back to Customer login page ///
            cl.Show();
            this.Hide();
        }
    }
}

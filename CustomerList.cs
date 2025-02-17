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
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();
        }

        HomeApplianceDataSetTableAdapters.CustomerTableAdapter objCust = new HomeApplianceDataSetTableAdapters.CustomerTableAdapter();

        private void CustomerList_Load(object sender, EventArgs e)
        {
            dgvCustomerList.DataSource = objCust.GetData(); /// Get Customer data from database ///
            dgvCustomerList.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome(); /// Going back to Admin Home page ///
            ah.Show();
            this.Hide();
        }
    }
}

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
    public partial class AdminList : Form
    {
        public AdminList()
        {
            InitializeComponent();
        }

        HomeApplianceDataSetTableAdapters.AdminTableAdapter objAdm = new HomeApplianceDataSetTableAdapters.AdminTableAdapter();

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome(); /// Back to Admin Home page ///
            ah.Show();
            this.Hide();
        }

        private void AdminList_Load(object sender, EventArgs e)
        {
            dgvAdminList.DataSource = objAdm.GetData(); /// Show admin list ///
            dgvAdminList.Refresh();
        }
    }
}

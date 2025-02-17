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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void applianceEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplianceEntry app = new ApplianceEntry(); /// Open Appliance entry form ///
            app.Show();
            this.Hide();
        }

        private void administratorListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminList al = new AdminList(); /// Open Admin list form ///
            al.Show();
            this.Hide();
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerList cl = new CustomerList(); /// Open Customer list form ///
            cl.Show();
            this.Hide();
        }

        private void rentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentList rl = new RentList(); /// Open Rent list form ///
            rl.Show();
            this.Hide();
        }

        private void applianceTypeEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplianceType at = new ApplianceType(); /// Open Appliance type entry form ///
            at.Show();
            this.Hide();
        }

        private void applianceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplianceList apl = new ApplianceList(); /// Open Appliance list form /// 
            apl.Show();
            this.Hide();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuSearch_Click(object sender, EventArgs e)
        {
            RentalSearch rs = new RentalSearch(); /// Open Rental search form /// 
            rs.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

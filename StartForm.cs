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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        /// When the Admin picture was clicked, lead to Admin Login Form ///
        {
            AdminLogin al = new AdminLogin();
            al.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        /// When the Customer picture was clicked, lead to Customer Login Form ///
        {
            CustomerLogin cl = new CustomerLogin();
            cl.Show();
        }

        private void lblAdministrator_Click(object sender, EventArgs e)
        /// When the Administrator label was clicked, lead to Admin Login Form ///
        {
            AdminLogin al = new AdminLogin();
            al.Show();
        }

        private void lblCustomer_Click(object sender, EventArgs e)
        /// When the Customer label was clicked, lead to Customer Login Form ///
        {
            CustomerLogin cl = new CustomerLogin();
            cl.Show();
        }
    }
}

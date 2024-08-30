using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStoreManagement
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            ShowUserControl(new AddUsers());
        }

        private string adminName {  get; set; }
        public Admin(string adminName) : this() 
        {
            this.adminName = adminName;
            this.lblAdmin.Text = adminName;
        }
       

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Logout?","Confirmation Message",
                MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();

                this.Hide();

            }
        }



        private UserControl activeControl = null;
        private void ShowUserControl(UserControl childControl)
        {
            if (activeControl != null)
            {
                pnlDashAdmin.Controls.Remove(activeControl);
                activeControl.Dispose();
            }
            activeControl = childControl;
            childControl.Dock = DockStyle.Fill;
            pnlDashAdmin.Controls.Add(childControl);
            childControl.Visible = true;
        }
        





        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowUserControl(new AdminDashboard());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ShowUserControl(new AddUsers());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ShowUserControl(new AdminProduct());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ShowUserControl(new AdminCustomer());
        }
    }
}

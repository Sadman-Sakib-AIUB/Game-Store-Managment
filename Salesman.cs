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
    public partial class Salesman : Form
    {
        public Salesman()
        {
            InitializeComponent();
            ShowUserControl(new SalesmanProduct());
        }

        private string salesmanName { get; set; }
        public Salesman(string salesmanName) : this()
        {
            this.salesmanName = salesmanName;
            this.lblSalesMan.Text = salesmanName;
        }

        private void ShowUserControl(UserControl childControl)
        {
            if (activeControl != null)
            {
                pnlAdd.Controls.Remove(activeControl);
                activeControl.Dispose();
            }
            activeControl = childControl;
            childControl.Dock = DockStyle.Fill;
            pnlAdd.Controls.Add(childControl);
            childControl.Visible = true;
        }
        private UserControl activeControl = null;
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.ShowUserControl(new SalesmanDashboard());


        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.ShowUserControl(new SalesmanProduct());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Logout?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Login loginForm = new Login();
                    loginForm.Show();

                    this.Hide();

                }
            
        }

        private void Salesman_FormClosed(object sender, FormClosedEventArgs e)
        {
         
            Application.Exit();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStoreManagement
{
    public partial class Login : Form
    {
        private DataAccess da { get; set; }
       
        public Login()
        {
            InitializeComponent();

            da = new DataAccess();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            try 
            {
                var query = da.ExecuteQuery("select * from UserInfo where UserID = '" + this.txtUserId.Text + "' and Password = '" + txtPassword.Text + "';");

                if (!CheckBlankSpace())
                {
                    MessageBox.Show("Please Fill all the blank spaces");
                    return;
                }

                if (query.Tables[0].Rows.Count == 1)
                {

                    MessageBox.Show("Login Successful", "Confirmation Message");

                    var role = query.Tables[0].Rows[0][3].ToString();
                    var name = query.Tables[0].Rows[0][1].ToString();
                    var sId = query.Tables[0].Rows[0][0].ToString();
                    
                    if (role == "Admin" )
                    {
                        this.Hide();
                        new Admin(name).Show();
                    }

                    else if (role == "Salesman")
                    {
                        this.Hide();
                        new Salesman(name).Show();
                        new Salesman(sId);
                    }
                   
                }

                else 
                {

                    MessageBox.Show("Login Failed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch
            {
                MessageBox.Show("Error Has Occured", "Error Message");
            }
           
        }

        private bool CheckBlankSpace()
        {
            if (string.IsNullOrEmpty(this.txtPassword.Text) || string.IsNullOrEmpty(this.txtUserId.Text ))
            { 
                return false; 
            }

            else
            { 
                return true; 
            }
        }



        //Check Uncheck Password Show
        private bool checkChnange = true;

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            
             

            if (checkChnange) 
            {
                this.txtPassword.UseSystemPasswordChar = false;

                checkChnange = false;

             
            }

            else
            {

                this.txtPassword.UseSystemPasswordChar = true;

                checkChnange = true;

            }
        }





         
    }
}

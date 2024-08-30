using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStoreManagement
{
    public partial class AddUsers : UserControl
    {

        private DataAccess da {  get; set; }
        public AddUsers()
        {
            InitializeComponent();
            da = new DataAccess();
            PopulateGridView();
            AutoIdGenerate();
        }

        public void PopulateGridView(string sql = "select * from UserInfo;")
        {
            var query = da.ExecuteQuery(sql);

            this.dgvUserData.AutoGenerateColumns = false;
            this.dgvUserData.DataSource = query.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            try
            {
                if (!this.isExists())
                {
                    return;
                }

                
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

               

                var query = "insert into UserInfo values ('" + this.txtUserIdAdd.Text + "','" + this.txtUserNameAdd.Text + "','" + this.txtPasswordAdd.Text + "','" + this.cmbRoleAdd.Text + "','" + this.rtxtAddressAdd.Text + "','" + this.txtPhoneNumAdd.Text + "');";

                var count = this.da.ExecuteDMLQuery(query);

                if (count == 1)
                {
                    MessageBox.Show("Data Added Successfully", "Confirmation Message", MessageBoxButtons.OK);

                }

                else
                {
                    MessageBox.Show("Data insertion failed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                this.PopulateGridView();
                this.ClearAll();

            }

            catch
            {
                MessageBox.Show("Error Has Occured");
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }


        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtUserIdAdd.Text) || String.IsNullOrEmpty(this.txtUserNameAdd.Text) || String.IsNullOrEmpty(this.txtPasswordAdd.Text)
                || String.IsNullOrEmpty(this.cmbRoleAdd.Text) || String.IsNullOrEmpty(this.rtxtAddressAdd.Text) || String.IsNullOrEmpty(this.txtPhoneNumAdd.Text))
            {
                return false;
            }

            else
            {
                return true;
            }
        }


        private bool isExists()
        {
            try
            {
                var checkId = da.ExecuteQuery("select * from UserInfo where UserId = '" + this.txtUserIdAdd.Text + "';");
                var checkPhoneNum = da.ExecuteQuery("select * from UserInfo where PhoneNumber = '" + this.txtPhoneNumAdd.Text + "';");

                if (checkId.Tables[0].Rows.Count==1)
                {
                    MessageBox.Show("This Id is already exists","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return false;
                }

                else if (checkPhoneNum.Tables[0].Rows.Count==1)
                {
                    MessageBox.Show("This Phone Number is already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

            }
            catch  
            {
                MessageBox.Show ("Error has occured","Error Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }

            return true;
        }

        private void ClearAll()
        {
            this.txtUserIdAdd.Clear();
            this.txtUserNameAdd.Clear();
            this.txtPasswordAdd.Clear();
            this.cmbRoleAdd.SelectedIndex = -1;
            this.rtxtAddressAdd.Clear();
            this.txtPhoneNumAdd.Clear();

            this.dgvUserData.ClearSelection();
            this.AutoIdGenerate();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvUserData.SelectedRows.Count < 1)
                {

                    MessageBox.Show("Please select a row first", "error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to Delete?", "Alert Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                var id = this.dgvUserData.CurrentRow.Cells[0].Value.ToString();

                var query = "delete from UserInfo where UserId = '" + id + "';";
                var count = this.da.ExecuteDMLQuery(query);


                if (count == 1)
                {
                    MessageBox.Show("Data Deleted Successfully", "Confirmation Message", MessageBoxButtons.OK);
                }

                else
                {
                    MessageBox.Show("Data deletation failed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.PopulateGridView();


            }

            catch
            {
                MessageBox.Show("Error Has Occured");
            }


        }

        private void AddUsers_Load(object sender, EventArgs e)
        {
            this.dgvUserData.ClearSelection();
        }

        private void dgvUserData_DoubleClick(object sender, EventArgs e)
        {
            this.txtUserIdAdd.Text = this.dgvUserData.CurrentRow.Cells["UserId"].Value.ToString();
            this.txtUserNameAdd.Text = this.dgvUserData.CurrentRow.Cells["UserName"].Value.ToString();
            this.txtPasswordAdd.Text = this.dgvUserData.CurrentRow.Cells["Password"].Value.ToString();
            this.cmbRoleAdd.Text = this.dgvUserData.CurrentRow.Cells["Role"].Value.ToString();
            this.rtxtAddressAdd.Text = this.dgvUserData.CurrentRow.Cells["Address"].Value.ToString();
            this.txtPhoneNumAdd.Text = this.dgvUserData.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                
        
                var id = this.dgvUserData.CurrentRow.Cells[0].Value.ToString();
                var sql = "select * from UserInfo where UserId = '" + id + "';";
                var ds = this.da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {

                    var query = "UPDATE UserInfo SET UserId = '" + this.txtUserIdAdd.Text + "', UserName = '" + this.txtUserNameAdd.Text + "', Password = '" + this.txtPasswordAdd.Text + "', Role = '" + this.cmbRoleAdd.Text + "', Address = '" + this.rtxtAddressAdd.Text + "', PhoneNumber = '" + this.txtPhoneNumAdd.Text + "'  WHERE UserId = '" + id + "';";

                    var count = this.da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("User data has been updated properly");
                    else
                        MessageBox.Show("User data upgradation failed");

               
                this.PopulateGridView();
                this.ClearAll();
                }

            }

            catch
            {
                MessageBox.Show("Error Has Occured");
            }

        }



        private void AutoIdGenerate()
        {
            var sql = "select UserId from UserInfo order by UserId desc;";
            var dt = da.ExecuteQueryTable(sql);  
            var oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            int num = Convert.ToInt32(temp[1]);
            var newId = "G-" +(++num).ToString("d3");

            this.txtUserIdAdd.Text = newId;
        }

        //Auto Search by Id
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from UserInfo where UserId like '" + this.txtSearch.Text + "%';";
            this.PopulateGridView(sql);
        }
    }


    
}

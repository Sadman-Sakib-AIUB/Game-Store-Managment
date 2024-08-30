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
    public partial class AdminProduct : UserControl
    {
        private DataAccess da { get; set; }

        public AdminProduct()
        {
            InitializeComponent();
            da = new DataAccess();
            this.PopulateGridView();
            this.AutoIdGenerate();
        }

        public void PopulateGridView(string sql = "select * from Product p,Category c where p.CategoryID=c.ID ;")
        {
            var ds = this.da.ExecuteQuery(sql);

            this.dgvAdminProduct.AutoGenerateColumns = false;
            this.dgvAdminProduct.DataSource = ds.Tables[0];
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

                var a = da.ExecuteQuery( "select ID from Category where Category = '" + this.cmbCategory.Text + "'; "); 

                int categoryId = Convert.ToInt32( a.Tables[0].Rows[0][0].ToString());

               


                var query = "insert into Product values ('"+txtProductId.Text+"','"+txtProductName.Text+"',"+this.txtQuantity.Text+","+this.txtPrice.Text+","+categoryId+");";

                var count = this.da.ExecuteDMLQuery(query);

                if (count == 1)
                {
                    MessageBox.Show("Product Added Successfully", "Confirmation Message", MessageBoxButtons.OK);

                }

                else
                {
                    MessageBox.Show("Product insertion failed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                 this.PopulateGridView();
                 this.ClearAll();
            }

            catch 
            {
                MessageBox.Show("Error Has Occured");
                
            }
        }


        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtProductId.Text) || String.IsNullOrEmpty(this.txtProductName.Text) || String.IsNullOrEmpty(this.txtQuantity.Text)
                || String.IsNullOrEmpty(this.txtPrice.Text) || String.IsNullOrEmpty(this.cmbCategory.Text))
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
                var checkId = da.ExecuteQuery("select * from Product where ID = '" + this.txtProductId.Text + "';");
                

                if (checkId.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("This Id is already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

               

            }
            catch
            {
                MessageBox.Show("Error has occured", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return true;
        }


        private void ClearAll()
        {
            this.txtPrice.Clear();
            this.txtProductId.Clear();
            this.txtProductName.Clear();
            this.cmbCategory.SelectedIndex = -1;
            this.txtQuantity.Clear();
            

            this.dgvAdminProduct.ClearSelection();
            this.AutoIdGenerate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }


        private void AdminProduct_Load(object sender, EventArgs e)
        {
            this.dgvAdminProduct.ClearSelection();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvAdminProduct.SelectedRows.Count < 1)
                {

                    MessageBox.Show("Please select a row first", "error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to Delete?", "Alert Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                var id = this.dgvAdminProduct.CurrentRow.Cells[0].Value.ToString();

                var query = "delete from Product where ID = '" + id + "';";
                var count = this.da.ExecuteDMLQuery(query);


                if (count == 1)
                {
                    MessageBox.Show("Product Deleted Successfully", "Confirmation Message", MessageBoxButtons.OK);
                }

                else
                {
                    MessageBox.Show("Product deletation failed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.PopulateGridView();


            }

            catch
            {
                MessageBox.Show("Error Has Occured");
            }
        }



        private void AutoIdGenerate()
        {
            var sql = "select ID from Product order by ID desc;";
            var dt = da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            int num = Convert.ToInt32(temp[1]);
            var newId = "P-" + (++num).ToString("d3");

            this.txtProductId.Text = newId;
        }

        private void txtProdSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Product where ID like '" + this.txtProdSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void dgvAdminProduct_DoubleClick(object sender, EventArgs e)
        {
            this.cmbCategory.Text = this.dgvAdminProduct.CurrentRow.Cells[4].Value.ToString();
            this.txtProductId.Text = this.dgvAdminProduct.CurrentRow.Cells[0].Value.ToString();
            this.txtProductName.Text = this.dgvAdminProduct.CurrentRow.Cells[1].Value.ToString();
            this.txtQuantity.Text = this.dgvAdminProduct.CurrentRow.Cells[2].Value.ToString();
            this.txtPrice.Text = this.dgvAdminProduct.CurrentRow.Cells[3].Value.ToString();
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {


                var id = this.dgvAdminProduct.CurrentRow.Cells[0].Value.ToString();
                var sql = "select * from Product where ID = '" + id + "';";
                var ds = this.da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {

                    var a = da.ExecuteQuery("select ID from Category where Category = '" + this.cmbCategory.Text + "'; ");

                    int categoryId = Convert.ToInt32(a.Tables[0].Rows[0][0].ToString());

                    int quantity = Convert.ToInt32(this.txtQuantity);
                    int price = Convert.ToInt32(this.txtPrice);

                    var query = "UPDATE Product SET ID = '"+this.txtProductId.Text+"', Name = '"+this.txtProductName.Text+"', Quantity = "+quantity+", Price = "+price+", CategoryID = "+categoryId+" WHERE ID = '"+this.txtProductId.Text+"';";

                    var count = this.da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("User data has been updated properly");
                    else
                        MessageBox.Show("User data upgradation failed");


                    this.PopulateGridView();
                    this.ClearAll();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(" "+ex);
            }
        }
    }
    
}

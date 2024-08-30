using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStoreManagement
{
    public partial class SalesmanProduct : UserControl
    {
        private DataAccess da { get; set; }



        public SalesmanProduct()
        {
            InitializeComponent();
            da = new DataAccess();
            this.PopulateGridView();
        }

        private string salesmId;
        public SalesmanProduct(string salesmanId)
        {

            this.salesmId = salesmanId;
        }

        public void PopulateGridView(string sql = "select * from Product p,Category c where p.CategoryID=c.ID ;")
        {
            var ds = this.da.ExecuteQuery(sql);

            this.dgvAvailableProduct.AutoGenerateColumns = false;
            this.dgvAvailableProduct.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Product p inner join  Category c on p.CategoryID = c.ID where (p.ID like '" + this.txtSearchProduct.Text + "%')";
            this.PopulateGridView(sql);

        }

        private void dgvAvailableProduct_DoubleClick(object sender, EventArgs e)
        {
            this.txtProductId.Text = this.dgvAvailableProduct.CurrentRow.Cells[0].Value.ToString();
            this.txtProductName.Text = this.dgvAvailableProduct.CurrentRow.Cells[1].Value.ToString();

            this.txtPrice.Text = this.dgvAvailableProduct.CurrentRow.Cells[3].Value.ToString();
            this.txtCategory.Text = this.dgvAvailableProduct.CurrentRow.Cells[4].Value.ToString();

            this.nudQuantity.Value = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var productCategory = this.txtCategory.Text;
            var productName = this.txtProductName.Text;

            var productPrice = this.txtPrice.Text;
            var productQuantity = this.nudQuantity.Text;

            double pprice = Convert.ToDouble(productPrice);
            double pquantity = Convert.ToDouble(productQuantity);
            string totalprice = (pprice * pquantity).ToString();

            this.txtTotalPriceC.Text = totalprice;



            dgvOrderDetails.Rows.Add(productName, productQuantity, totalprice, productCategory);


            this.txtTotalPrice.Text = CartTotalPrice().ToString();

            this.ProductDecrement();
            this.ClearAll();
            



        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            dgvOrderDetails.Rows.Clear();
        }


        private void ClearAll()
        {
            this.txtProductId.Clear();
            this.txtProductName.Clear();
            this.txtCategory.Clear();
            this.txtPrice.Clear();
            this.nudQuantity.Value = 0;

        }


        private void ProductDecrement()
        {
            try
            {


                decimal valueMain = Convert.ToDecimal(this.dgvAvailableProduct.CurrentRow.Cells["quantity"].Value.ToString());
                decimal valueSelected = this.nudQuantity.Value;

                if (valueMain == 0)
                {
                    MessageBox.Show("Product not available");
                }


                decimal finalValue = valueMain - valueSelected;

                string productId = this.txtProductId.Text;

                var query = "update Product set Quantity = " + finalValue + " where ID = '" + productId + "'";
                da.ExecuteQuery(query);

                PopulateGridView();
            }

            catch
            {
                MessageBox.Show("Error has occured");
            }




        }




        private double CartTotalPrice()
        {
            double totalPrice = 0;

            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
            {
                double itemPrice = Convert.ToDouble(row.Cells["ProductPrice"].Value);
                totalPrice += itemPrice;
            }

            return totalPrice;

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            double totalPrice = Convert.ToDouble(this.txtTotalPrice.Text);
            double amount = Convert.ToDouble(this.txtAmount.Text);

            double chnage = amount - totalPrice;

            this.txtChange.Text = chnage.ToString();

        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            var productPrice = this.txtPrice.Text;
            var productQuantity = this.nudQuantity.Value;

            double pprice = Convert.ToDouble(productPrice);
            double pquantity = Convert.ToDouble(productQuantity);
            string totalprice = (pprice * pquantity).ToString();

            this.txtTotalPriceC.Text = totalprice;
        }



        DateTime date = DateTime.Now;
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtCname.Text) || string.IsNullOrEmpty(this.txtCphone.Text))
                {
                    MessageBox.Show("Please Fill Customer information");
                    return;
                }
                var query = "insert into OrderDetails values ('" + this.txtCname.Text + "','" + this.txtCphone.Text + "','" + this.txtTotalPrice.Text + "','" + date + "')";

                var count = da.ExecuteDMLQuery(query);
                if (count == 1)
                {
                    MessageBox.Show("Order data add properly");
                }
                else
                {
                    MessageBox.Show("Order data save faild");
                }
            }

            catch 
            {
                MessageBox.Show("Error has Occured");
            }
    }
    }
}

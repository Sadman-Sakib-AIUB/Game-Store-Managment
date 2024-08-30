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
    public partial class AdminCustomer : UserControl
    {

        private DataAccess da
        {  get; set; }
        public AdminCustomer()
        {
            InitializeComponent();
            da = new DataAccess();
            PopulateGridView();
        }
        public void PopulateGridView(string sql = "select * from OrderDetails;")
        {
            var ds = this.da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
                var sql = "select * from OrderDetails where ID like '" + this.txtSearchOder.Text + "%';";
                this.PopulateGridView(sql);
        }
        
    }
}

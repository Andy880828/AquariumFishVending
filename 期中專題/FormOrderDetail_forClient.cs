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

namespace 期中專題
{
    public partial class FormOrderDetail_forClient : Form
    {
        public int orderID = 0;
        private class OrderItem
        {
            public int productID = 0;
            public string productName = ""; //非同TABLE訊息，之後用JOIN抓
            public int quantity = 0;
            public long price = 0;
            public long total = 0;
        }
        List<OrderItem> orderItems = new List<OrderItem>();

        public FormOrderDetail_forClient()
        {
            InitializeComponent();
        }

        private void FormOrderDetail_forClient_Load(object sender, EventArgs e)
        {
            //初始化
            lvwOrderItem.Clear();
            SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
            con.Open();
            string strSQL = "SELECT o.產品編號, p.產品名稱, o.產品金額, o.產品數量, o.項目金額 FROM orderitems as o JOIN products as p ON o.產品編號 = p.產品編號 WHERE o.訂單編號 = @orderID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                OrderItem orderItem = new OrderItem();
                orderItem.productID = (int)rdr["產品編號"];
                orderItem.productName = (string)rdr["產品名稱"];
                orderItem.price = Convert.ToInt64(rdr["產品金額"]);
                orderItem.quantity = (int)rdr["產品數量"];
                orderItem.total = Convert.ToInt64(rdr["項目金額"]);
                orderItems.Add(orderItem);
            }
            rdr.Close();
            con.Close();
            lvwOrderItem.View = View.Details;
            lvwOrderItem.Columns.Add("產品編號", 100);
            lvwOrderItem.Columns.Add("產品名稱", 200);
            lvwOrderItem.Columns.Add("產品金額", 100);
            lvwOrderItem.Columns.Add("產品數量", 100);
            lvwOrderItem.Columns.Add("項目金額", 100);
            lvwOrderItem.GridLines = true; //顯示格線
            lvwOrderItem.FullRowSelect = true; //整列選取
            foreach (OrderItem orderItem in orderItems)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Text = orderItem.productID.ToString();
                item.SubItems.Add(orderItem.productName.ToString());
                item.SubItems.Add(orderItem.price.ToString());
                item.SubItems.Add(orderItem.quantity.ToString());
                item.SubItems.Add(orderItem.total.ToString());
                lvwOrderItem.Items.Add(item);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

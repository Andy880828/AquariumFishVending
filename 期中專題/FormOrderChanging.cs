using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace 期中專題
{

    public partial class FormOrderChanging : Form
    {
        private class Order
        {
            public int orderID = 0;
            public int clientID = 0;
            public string clientName = "";
            public int employeeID = 0;
            public DateTime orderTime = DateTime.MinValue;
            public long total = 0;
        }

        private class OrderItem
        {
            public int productID = 0;
            public string productName = ""; //非同TABLE訊息，之後用JOIN抓
            public int quantity = 0;
            public long price = 0;
            public long total = 0;
        }

        Order order = new Order();
        List<OrderItem> orderItems = new List<OrderItem>();

        private int orderID = 0;
        public int OrderID
        {
            get
            {
                return orderID;
            }
            set
            {
                orderID = value;
                tbxOrderID.Text = orderID.ToString();
            }
        }

        public FormOrderChanging()
        {
            InitializeComponent();
        }

        private void FormOrderChanging_Load(object sender, EventArgs e)
        {
            //初始化
            lvwOrderItem.Clear();
            //連線
            SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
            con.Open();
            string strSQL = "SELECT o.會員編號, c.姓名, o.員工編號, o.成立時間, o.總金額 FROM orders as o JOIN clients as c ON o.會員編號 = c.會員編號 WHERE o.訂單編號 = @orderID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@orderID", OrderID);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                order.clientID = (int)rdr["會員編號"];
                order.clientName = (string)rdr["姓名"];
                order.employeeID = (int)rdr["員工編號"];
                order.orderTime = (DateTime)rdr["成立時間"];
                order.total = Convert.ToInt64(rdr["總金額"]);
                tbxClientID.Text = order.clientID.ToString();
                tbxClientName.Text = order.clientName.ToString();
                tbxEmployeeID.Text = order.employeeID.ToString();
                dtpDate.Value = order.orderTime;
                tbxTotal.Text = order.total.ToString();
            }
            else { MessageBox.Show("錯誤，請重新操作一遍!"); }
            rdr.Close();
            strSQL = "SELECT o.產品編號, p.產品名稱, o.產品金額, o.產品數量, o.項目金額 FROM orderitems as o JOIN products as p ON o.產品編號 = p.產品編號 WHERE o.訂單編號 = @orderID";
            cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@orderID", OrderID);
            rdr = cmd.ExecuteReader();
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

        private void btnModify_Click(object sender, EventArgs e)
        {
            if ((OrderID > 0)&&(tbxClientID.Text != "")&&(tbxEmployeeID.Text !="")&&(tbxTotal.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
                con.Open();
                string strSQL = "UPDATE orders SET 會員編號 = @ClientID, 員工編號 = @EmployeeID, 成立時間 = @orderTime, 總金額 = @total WHERE 訂單編號 = @orderID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@orderID", OrderID);
                cmd.Parameters.AddWithValue("@ClientID", tbxClientID.Text.Trim());
                cmd.Parameters.AddWithValue("@EmployeeID", tbxEmployeeID.Text.Trim());
                cmd.Parameters.AddWithValue("@orderTime", dtpDate.Value);
                cmd.Parameters.AddWithValue("@total", tbxTotal.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("修改成功!");
                con.Close();
            }
            else { MessageBox.Show("訂單為空!"); }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace 期中專題
{
    public partial class FormOrderManaging : Form
    {
        private class Order //新增一個類別存訂單
        {
            public int orderID = 0;
            public int clientID = 0;
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
        List<OrderItem> orderItems = new List<OrderItem>();
        private List<Order> orders = new List<Order>();

        void initialize()
        {
            lvwOrder.Clear();
            orders.Clear();
        }

        void readDB()
        {
            //連線取得訂單資訊
            SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
            con.Open();
            //時間篩選抓取
            string strSQL = "SELECT * FROM orders WHERE 成立時間 >= @from AND 成立時間 <= @until;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@from", Convert.ToDateTime(dtpFrom.Value));
            cmd.Parameters.AddWithValue("@until", Convert.ToDateTime(dtpUntil.Value));
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                Order order = new Order();
                order.orderID = (int)rdr["訂單編號"];
                order.clientID = (int)rdr["會員編號"];
                order.employeeID = (int)rdr["員工編號"];
                order.orderTime = (DateTime)rdr["成立時間"];
                order.total = Convert.ToInt64(rdr["總金額"]);
                orders.Add(order);
            }
            rdr.Close();
            con.Close();
            //設置listview欄位
            lvwOrder.View = View.Details;
            lvwOrder.Columns.Add("訂單編號", 100);
            lvwOrder.Columns.Add("會員編號", 100);
            lvwOrder.Columns.Add("負責員工編號", 100);
            lvwOrder.Columns.Add("訂單成立時間", 300);
            lvwOrder.Columns.Add("總金額", 100);
            lvwOrder.GridLines = true; //顯示格線
            lvwOrder.FullRowSelect = true; //整列選取
            //將訂單輸出到listview
            if (orders.Count != 0)
            {
                foreach (Order order in orders)
                {
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                    item.Tag = order.orderID;
                    item.Text = order.orderID.ToString();
                    item.SubItems.Add(order.clientID.ToString());
                    item.SubItems.Add(order.employeeID.ToString());
                    item.SubItems.Add(order.orderTime.ToString("G"));
                    item.SubItems.Add(order.total.ToString());
                    lvwOrder.Items.Add(item); //加入items到listview
                }
            }
            lblOrder.Text = $"共{orders.Count}單";
        }
        void client_readDB()
        {
            //連線取得訂單資訊
            SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
            con.Open();
            //時間篩選抓取
            string strSQL = "SELECT * FROM orders WHERE 會員編號 = @clientID AND 成立時間 >= @from AND 成立時間 <= @until;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@clientID", GlobalVar.Current_ClientID);
            cmd.Parameters.AddWithValue("@from", Convert.ToDateTime(dtpFrom.Value));
            cmd.Parameters.AddWithValue("@until", Convert.ToDateTime(dtpUntil.Value));
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                Order order = new Order();
                order.orderID = (int)rdr["訂單編號"];
                order.orderTime = (DateTime)rdr["成立時間"];
                order.total = Convert.ToInt64(rdr["總金額"]);
                orders.Add(order);
            }
            rdr.Close();
            con.Close();
            //設置listview欄位
            lvwOrder.Clear();
            lvwOrder.View = View.Details;
            lvwOrder.Columns.Add("訂單編號", 100);
            lvwOrder.Columns.Add("訂單成立時間", 300);
            lvwOrder.Columns.Add("總金額", 100);
            lvwOrder.GridLines = true; //顯示格線
            lvwOrder.FullRowSelect = true; //整列選取
            //將訂單輸出到listview
            if (orders.Count != 0)
            {
                foreach (Order order in orders)
                {
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                    item.Tag = order.orderID;
                    item.Text = order.orderID.ToString();
                    item.SubItems.Add(order.orderTime.ToString("G"));
                    item.SubItems.Add(order.total.ToString());
                    lvwOrder.Items.Add(item); //加入items到listview
                }
            }
            lblOrder.Text = $"共{orders.Count}單";
        }

        public FormOrderManaging()
        {
            InitializeComponent();
        }

        private void FormOrderManaging_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = new DateTime(2019, 6, 28);
            dtpUntil.Value = DateTime.Now;
            btnDelete.Visible = false;
            if (GlobalVar.Current_EmployeeID != 0)
            {
                btnDelete.Visible = true;
                initialize();
                readDB();
            }
            else if (GlobalVar.Current_ClientID != 0)
            {
                initialize();
                client_readDB();
            }
        }

        private void FormOrderManaging_Activated(object sender, EventArgs e)
        {
            if ((GlobalVar.Current_EmployeeID != 0)) { initialize(); readDB(); }
            else if ((GlobalVar.Current_ClientID != 0)) { initialize(); client_readDB(); }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if ((GlobalVar.Current_EmployeeID != 0)) { initialize(); readDB(); }
            else if ((GlobalVar.Current_ClientID != 0)) { initialize(); client_readDB(); }
        }

        private void dtpUntil_ValueChanged(object sender, EventArgs e)
        {
            if ((GlobalVar.Current_EmployeeID != 0)) { initialize(); readDB(); }
            else if ((GlobalVar.Current_ClientID != 0)) { initialize(); client_readDB(); }
        }

        private void lvwOrder_ItemActivate(object sender, EventArgs e)
        {
            if (GlobalVar.Current_EmployeeID != 0)
            {
                FormOrderChanging formOrderChanging = new FormOrderChanging();
                formOrderChanging.OrderID = Convert.ToInt32(lvwOrder.SelectedItems[0].Tag);
                formOrderChanging.ShowDialog();
            }
            else if (GlobalVar.Current_ClientID != 0)
            { 
                FormOrderDetail_forClient formOrderDetail_ForClient = new FormOrderDetail_forClient();
                formOrderDetail_ForClient.orderID = Convert.ToInt32(lvwOrder.SelectedItems[0].Tag);
                formOrderDetail_ForClient.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwOrder.SelectedItems.Count != 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
                con.Open();
                //讀取訂單加回庫存
                string strSQL = "SELECT * FROM orderitems WHERE 訂單編號 = @orderID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@orderID", lvwOrder.SelectedItems[0].Tag);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read() == true)
                {
                    OrderItem orderitem = new OrderItem();
                    orderitem.productID = (int)rdr["產品編號"];
                    orderitem.quantity = (int)rdr["產品數量"];
                    orderItems.Add(orderitem);
                }
                rdr.Close();
                if (orderItems.Count != 0)
                {
                    foreach (OrderItem orderitem in orderItems)
                    {
                        strSQL = "UPDATE products SET 庫存量 = 庫存量 + @productQty WHERE 產品編號 = @productID;";
                        cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@productQty", orderitem.quantity);
                        cmd.Parameters.AddWithValue("@productID", orderitem.productID);
                        cmd.ExecuteNonQuery();
                    }
                }
                //移除訂單
                strSQL = "DELETE FROM orderitems WHERE 訂單編號 = @orderID;";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@orderID", lvwOrder.SelectedItems[0].Tag);
                cmd.ExecuteNonQuery();
                strSQL = "DELETE FROM orders WHERE 訂單編號 = @orderID;";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@orderID", lvwOrder.SelectedItems[0].Tag);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("訂單已成功刪除!");
                    initialize();
                    readDB();
                }
                else
                {
                    MessageBox.Show("刪除失敗，請再試一次。");
                }
                con.Close();
            }
            else { MessageBox.Show("請選取欲刪除之訂單!"); }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

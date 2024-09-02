using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace 期中專題
{
    public partial class FormCheckout : Form
    {
        long total = 0;
        long VIP_total = 0;
        int current_orderID = 0;
        public event EventHandler DataUpdated;

        void initialize()
        {
            lblTotal.ForeColor = Color.Black;
            lvwCart.Clear();
            lblTotal.Text = $"NTD 00000";
        }
        void cart_showing()
        {
            //設置listview欄位
            lvwCart.View = View.Details;
            lvwCart.Columns.Add("產品名稱", 200);
            lvwCart.Columns.Add("數量", 100);
            lvwCart.Columns.Add("金額", 100);
            lvwCart.Columns.Add("價格", 100);
            lvwCart.GridLines = true; //顯示格線
            lvwCart.FullRowSelect = true; //整列選取
            //輸出到listview
            if (GlobalVar.Cart.Count != 0)
            {

                foreach (Product product in GlobalVar.Cart)
                {
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                    item.Tag = product.productID;
                    item.Text = product.productName.ToString();
                    item.SubItems.Add(product.quantity.ToString());
                    item.SubItems.Add(product.price.ToString());
                    long item_total = product.price * product.quantity;
                    item.SubItems.Add(item_total.ToString());
                    total += item_total;
                    lvwCart.Items.Add(item); //加入items到listview
                }
                if (GlobalVar.Current_ClientLevel == "VIP會員")
                {
                    VIP_total = Convert.ToInt64(total * 0.8);
                    lblTotal.Text = $"NTD {VIP_total.ToString()}";
                    lblTotal.ForeColor = Color.Green;
                }
                else
                {
                    lblTotal.Text = $"NTD {total.ToString()}";
                    lblTotal.ForeColor = Color.White;
                }
            }
        }
        public FormCheckout()
        {
            InitializeComponent();
        }

        private void FormCheckout_Load(object sender, EventArgs e)
        {
            initialize();
            cart_showing();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("確定要購買嗎?", "確認購買", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                string strSQL = "";
                SqlCommand cmd;
                //更新商品資料庫
                SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
                con.Open();
                foreach (Product product in GlobalVar.Cart)
                {
                    strSQL = "UPDATE products SET 庫存量 = @stock WHERE 產品編號 = @productID;";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@productID", product.productID);
                    cmd.Parameters.AddWithValue("@stock", (product.stock - product.quantity));
                    cmd.ExecuteNonQuery();
                }
                //更新訂單資料庫
                //先抓取最新orderID
                strSQL = "SELECT TOP 1 訂單編號 FROM orders ORDER BY 訂單編號 desc;";
                cmd = new SqlCommand(strSQL, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                current_orderID = 1;
                if (rdr.Read())
                {
                    current_orderID = (int)rdr["訂單編號"] + 1;
                }
                rdr.Close();
                //再去更新訂單資料庫
                strSQL = "INSERT INTO orders VALUES(@orderID,@clientID,@employeeID,@datetime,@orderPrice);";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@orderID", current_orderID);
                cmd.Parameters.AddWithValue("@clientID", GlobalVar.Current_ClientID);
                cmd.Parameters.AddWithValue("@employeeID", GlobalVar.Current_Incharge_ID);
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now);
                if (GlobalVar.Current_ClientLevel == "VIP會員") { cmd.Parameters.AddWithValue("@orderPrice", VIP_total); }
                else { cmd.Parameters.AddWithValue("@orderPrice", total); }
                cmd.ExecuteNonQuery();
                //更新訂單編號資料庫
                int i = 1;
                foreach (Product product in GlobalVar.Cart)
                {
                    strSQL = "INSERT INTO orderitems VALUES(@orderID,@orderItemID,@productID,@productQuantity,@productPrice,@orderPrice);";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@orderID", current_orderID);
                    cmd.Parameters.AddWithValue("@orderItemID", i);
                    cmd.Parameters.AddWithValue("@productID", product.productID);
                    cmd.Parameters.AddWithValue("@productQuantity", product.quantity);
                    if (GlobalVar.Current_ClientLevel == "VIP會員")
                    {
                        cmd.Parameters.AddWithValue("@productPrice", Math.Round(product.price * 0.8));
                        cmd.Parameters.AddWithValue("@orderPrice", Convert.ToInt64(Math.Round(product.quantity * product.price * 0.8)));

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@productPrice", product.price);
                        cmd.Parameters.AddWithValue("@orderPrice", (product.quantity * product.price));
                    }
                    cmd.ExecuteNonQuery();
                    i++;
                }
                con.Close();
                //讀取魚類資料打單
                string str = $"總金額共{total}元，感謝惠顧!\n";
                str += "----------您已購買了----------\n";
                foreach (Product product in GlobalVar.Cart)
                {
                    if (GlobalVar.Current_ClientLevel == "VIP會員")
                    {
                        str += $"{product.productName} {product.quantity}隻 {Convert.ToInt64(Math.Round(product.quantity * product.price * 0.8))}元\n";
                    }
                    else { str += $"{product.productName} {product.quantity}隻 {product.quantity * product.price}元\n"; }
                }
                str += "--------以下為不可混養魚種--------\n";
                foreach (Product product in GlobalVar.Cart)
                {
                    if (product.mix == false)
                    {
                        str += $"{product.productName}\n";
                    }
                }
                str += "-----------謝謝惠顧-----------\n";
                MessageBox.Show(str);
                DataUpdated?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

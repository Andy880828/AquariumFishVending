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
    public partial class FormProductManaging : Form
    {
        private bool isSearching = false;

        List<Product> products = new List<Product>();
        void initialize()
        {
            products.Clear();
            lvwProduct.Clear();
        }
        void readDB()
        {
            //連線取得訂單資訊
            SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
            con.Open();
            string strSQL = "";
            SqlCommand cmd;
            if (isSearching == true && tbxSearch.Text.Trim() != "")
            {
                strSQL = "SELECT * FROM products WHERE 產品名稱 LIKE @productName;";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@productName", "%" + tbxSearch.Text.Trim() + "%");

            }
            else
            {
                strSQL = "SELECT * FROM products;";
                cmd = new SqlCommand(strSQL, con);
            }

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                Product product = new Product();
                product.productID = (int)rdr["產品編號"];
                product.productName = (string)rdr["產品名稱"];
                product.productSciName = (string)rdr["學名"];
                product.productComName = (string)rdr["俗名"];
                product.productEngName = (string)rdr["英文名"];
                product.Namer = (string)rdr["命名者"];
                product.family = (string)rdr["科別"];
                product.habitat = (string)rdr["淡鹹水"];
                product.brief = (string)rdr["簡介"];
                product.length = (string)rdr["體長"];
                product.origin = (string)rdr["原產地"];
                product.difficulty = (string)rdr["飼養難度"];
                product.mix = (bool)rdr["可混養"];
                product.price = Convert.ToInt64(rdr["產品金額"]);
                product.Inprice = Convert.ToInt64(rdr["進貨價格"]);
                product.quantity = (int)rdr["庫存量"];
                product.providing = (bool)rdr["供貨"];
                product.image = (string)rdr["圖片"];
                products.Add(product);
            }
            rdr.Close();
            con.Close();
            //設置listview欄位
            lvwProduct.View = View.Details;
            lvwProduct.Columns.Add("產品編號", 70);
            lvwProduct.Columns.Add("產品名稱", 100);
            lvwProduct.Columns.Add("俗名", 100);
            lvwProduct.Columns.Add("科別", 100);
            lvwProduct.Columns.Add("淡鹹水", 70);
            lvwProduct.Columns.Add("產品金額", 100);
            lvwProduct.Columns.Add("進貨價格", 100);
            lvwProduct.Columns.Add("庫存量", 70);
            lvwProduct.Columns.Add("供貨", 50);
            lvwProduct.GridLines = true; //顯示格線
            lvwProduct.FullRowSelect = true; //整列選取
            //輸出到listview
            if (products.Count != 0)
            {
                foreach (Product product in products)
                {
                    Dictionary<string, object> tag_dict = new Dictionary<string, object>();
                    tag_dict.Add("productID", product.productID);
                    tag_dict.Add("image", product.image);
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                    item.Tag = tag_dict;
                    item.Text = product.productID.ToString();
                    item.SubItems.Add(product.productName.ToString());
                    item.SubItems.Add(product.productComName.ToString());
                    item.SubItems.Add(product.family.ToString());
                    item.SubItems.Add(product.habitat.ToString());
                    item.SubItems.Add(product.price.ToString());
                    item.SubItems.Add(product.Inprice.ToString());
                    item.SubItems.Add(product.quantity.ToString());
                    string providing = "是";
                    if (product.providing == false)
                    { providing = "否"; }
                    item.SubItems.Add(providing.ToString());
                    lvwProduct.Items.Add(item); //加入items到listview
                }
            }
            lblProduct.Text = $"共{products.Count}樣";
        }

        public FormProductManaging()
        {
            InitializeComponent();
        }

        private void FormProductManaging_Load(object sender, EventArgs e)
        {
            GlobalVar.img_path = @"C:\Users\andy0\Desktop\全端工程師\期中專題\圖庫\";
            initialize();
            readDB();
        }

        private void FormProductManaging_Activated(object sender, EventArgs e)
        {
            initialize();
            readDB();
            tbxSearch.Clear();
        }

        private void lvwProduct_ItemActivate(object sender, EventArgs e)
        {
            FormProductChanging formProductChanging = new FormProductChanging();
            formProductChanging.AddorModify = 1;
            var tag = lvwProduct.SelectedItems[0].Tag as Dictionary<string, object>;
            formProductChanging.productID = Convert.ToInt32(tag["productID"]);
            formProductChanging.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormProductChanging formProductChanging = new FormProductChanging();
            formProductChanging.AddorModify = 0;
            formProductChanging.ShowDialog();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            timer_forSearch.Stop();
            timer_forSearch.Start();
        }
        private void timer_forSearch_Tick(object sender, EventArgs e)
        {
            timer_forSearch.Stop();
            isSearching = true;
            initialize();
            readDB();
            isSearching = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

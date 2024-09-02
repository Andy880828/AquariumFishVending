using System;
using System.Collections;
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
    public partial class FormClient : Form
    {
        Product current_product = new Product();
        List<Product> current_products = new List<Product>();
        List<Product> products = new List<Product>();
        private UserControlFish myFishControlForTimer;
        private string selectedFamily = "";

        internal void initialize()
        {
            products.Clear();
            flpItems.Controls.Clear();
            current_product = new Product();
            current_products.Clear();
            cbxFamily.Items.Clear();
            lbxItemlist.Items.Clear();
        }

        void refresh_cart()
        {
            SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
            con.Open();
            string strSQL = "SELECT * FROM products WHERE 產品編號 = @productID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@productID", current_product.productID);
            SqlDataReader rdr = cmd.ExecuteReader();
            string current_str = "";
            if ((rdr.Read() == true) && (current_product.quantity > 0)) //非指到零新增
            {
                Product product = new Product();
                product.productID = (int)rdr["產品編號"];
                product.productName = (string)rdr["產品名稱"];
                product.productComName = (string)rdr["俗名"];
                product.price = Convert.ToInt64(rdr["產品金額"]);
                product.mix = (bool)rdr["可混養"];
                product.stock = (int)rdr["庫存量"];
                product.quantity = current_product.quantity;
                current_products.RemoveAll(p => p.productID == product.productID); //先清空同名項目
                current_products.Add(product); //加入項目
            }
            else if (current_product.quantity == 0)//指到零移除
            {
                if (current_products.Count != 0)
                {
                    current_products.RemoveAll(p => p.productID == current_product.productID);
                }
            }
            rdr.Close();
            con.Close();
            long total = 0;
            lbxItemlist.Items.Clear();
            foreach (Product product in current_products)
            {
                current_str = $"{product.productName} x {product.quantity} {product.quantity * product.price}元";
                lbxItemlist.Items.Add(current_str);
                total += product.quantity * product.price;
            }
            lblTotal.Text = $"目前總金額: NTD {total}";
            GlobalVar.Cart = current_products;
        }

        internal void readDB()
        {
            //連線取得訂單資訊
            SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
            con.Open();
            string strSQL = "SELECT * FROM products;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
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
                product.stock = (int)rdr["庫存量"];
                product.providing = (bool)rdr["供貨"];
                product.image = (string)rdr["圖片"];
                products.Add(product);
            }
            rdr.Close();
            con.Close();

            List<string> families= new List<string>();
            if (products.Count != 0)
            {
                foreach (Product product in products)
                {
                    families.Add(product.family);
                    UserControlFish myFishControl = new UserControlFish();
                    myFishControl.Tag = product.productID;
                    myFishControl.fishID = product.productID;
                    myFishControl.Fish_name = product.productName;
                    myFishControl.ProductImage = Image.FromFile(GlobalVar.img_path + product.image);
                    myFishControl.Fish_count = 0;
                    myFishControl.stock = product.stock;
                    flpItems.Controls.Add(myFishControl);
                    myFishControl.InfoButtonClicked += UserControlFish_InfoButtonClicked; //物件event屬性加入自訂新方法(委派)
                    myFishControl.AddButtonClicked += UserControlFish_AddButtonClicked;
                    myFishControl.MinusButtonClicked += UserControlFish_MinusButtonClicked;
                    myFishControl.TbxChanged += UserControlFish_TbxChanged;
                    myFishControl.Margin = new Padding(10);
                }
            }
            families.Distinct().ToList();
            cbxFamily.Items.Add("全部科別");
            foreach (string family in families)
            { 
                cbxFamily.Items.Add(family);
            }
        }

        internal void readDB_forFamily()
        {
            selectedFamily = Convert.ToString(cbxFamily.SelectedItem);
            //連線取得訂單資訊
            SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
            con.Open();
            string strSQL = "";
            if (selectedFamily == "全部科別" )
            {
                strSQL = "SELECT * FROM products;";
            }
            else
            {
                strSQL = "SELECT * FROM products WHERE 科別 = @family;";
            }
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@family", selectedFamily);
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
                product.stock = (int)rdr["庫存量"]; 
                product.providing = (bool)rdr["供貨"];
                product.image = (string)rdr["圖片"];
                products.Add(product);
            }
            rdr.Close();
            con.Close();

            List<string> families = new List<string>();
            if (products.Count != 0)
            {
                foreach (Product product in products)
                {
                    families.Add(product.family);
                    UserControlFish myFishControl = new UserControlFish();
                    myFishControl.Tag = product.productID;
                    myFishControl.fishID = product.productID;
                    myFishControl.Fish_name = product.productName;
                    myFishControl.ProductImage = Image.FromFile(GlobalVar.img_path + product.image);
                    myFishControl.Fish_count = 0;
                    myFishControl.stock = product.stock;
                    if (myFishControl.stock == 0) { myFishControl.Enabled = false; }
                    flpItems.Controls.Add(myFishControl);
                    myFishControl.InfoButtonClicked += UserControlFish_InfoButtonClicked; //物件event屬性加入自訂新方法(委派)
                    myFishControl.AddButtonClicked += UserControlFish_AddButtonClicked;
                    myFishControl.MinusButtonClicked += UserControlFish_MinusButtonClicked;
                    myFishControl.TbxChanged += UserControlFish_TbxChanged;
                    myFishControl.Margin = new Padding(10);
                }
            }
        }

        public FormClient()
        {
            InitializeComponent();
        }
        private void FormClient_Load(object sender, EventArgs e)
        {
            lblusername.Text = GlobalVar.Current_ClientName;
            pbxUser.Image = Properties.Resources.Man;
            btnInfo.Image = Properties.Resources.Gear;
            GlobalVar.img_path = @"C:\Users\andy0\Desktop\全端工程師\期中專題\圖庫\";
            //處理FlowLayoutPanel
            flpItems.AutoScroll = true; //讓卷軸出現
            flpItems.FlowDirection = FlowDirection.LeftToRight; //讓物品可以橫向長
            flpItems.WrapContents = true; //讓物品碰到邊緣去下一行
            flpItems.Padding = new Padding(45, 0, 0, 0);
            //讀取資料庫
            initialize();
            readDB();
        }

        private void UserControlFish_InfoButtonClicked(object sender, EventArgs e) //自訂新方法
        {
            UserControlFish myFishControl = (UserControlFish)sender; //把物件還原，sender就是
            FormProductDetail formProductDetail = new FormProductDetail();
            formProductDetail.productID = myFishControl.fishID; // 使用內存的productID
            formProductDetail.ShowDialog(); // 顯示產品詳情
        }

        private void UserControlFish_AddButtonClicked(object sender, EventArgs e) //點加按鈕時
        {
            UserControlFish myFishControl = (UserControlFish)sender;
            myFishControl.TbxChanged -= UserControlFish_TbxChanged;
            current_product = new Product();
            current_product.productID = myFishControl.fishID;
            current_product.quantity = myFishControl.Fish_count;
            refresh_cart();
            myFishControl.TbxChanged += UserControlFish_TbxChanged;
        }

        private void UserControlFish_MinusButtonClicked(object sender, EventArgs e) //點減按鈕時
        {
            UserControlFish myFishControl = (UserControlFish)sender;
            myFishControl.TbxChanged -= UserControlFish_TbxChanged;
            current_product = new Product();
            current_product.productID = myFishControl.fishID;
            current_product.quantity = myFishControl.Fish_count;
            refresh_cart();
            myFishControl.TbxChanged += UserControlFish_TbxChanged;
        }

        private void UserControlFish_TbxChanged(object sender, EventArgs e) //改字時
        {
            myFishControlForTimer = (UserControlFish)sender;
            timer_for_text.Start();
        }
        private void timer_for_text_Tick(object sender, EventArgs e)
        {
            timer_for_text.Stop();
            if (myFishControlForTimer != null)
            {
                current_product = new Product();
                current_product.productID = myFishControlForTimer.fishID;
                current_product.quantity = myFishControlForTimer.Fish_count;
                refresh_cart();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            FormCheckout formCheckout = new FormCheckout();
            formCheckout.DataUpdated += FormProductDetail_DataUpdated;
            formCheckout.ShowDialog();

        }
        private void FormProductDetail_DataUpdated(object sender, EventArgs e)
        {
            initialize();
            readDB();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();
        }

        private void btnHistoryorders_Click(object sender, EventArgs e)
        {
            FormOrderManaging formOrderManaging = new FormOrderManaging();
            formOrderManaging.ShowDialog();
        }

        private void cbxFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            products.Clear();
            flpItems.Controls.Clear();
            readDB_forFamily();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

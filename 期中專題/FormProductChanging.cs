using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static 期中專題.FormClient;

namespace 期中專題
{
    public partial class FormProductChanging : Form
    {
        public int productID = 0;
        public int AddorModify = 0; //0是新增，1是修改
        string originalimage_name = "";
        string strChangedimage_name = "";
        bool Image_changed = false;

        void readDB()
        {
            SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
            con.Open();
            string strSQL = "SELECT * FROM products WHERE 產品編號 = @productID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@productID", productID);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
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
                tbxID.Text = product.productID.ToString();
                tbxName.Text = product.productName.ToString();
                tbxSciName.Text = product.productSciName.ToString();
                tbxCommonName.Text = product.productComName.ToString();
                tbxEnName.Text = product.productEngName.ToString();
                tbxNamer.Text = product.Namer.ToString();
                tbxFamily.Text = product.family.ToString();
                if (product.habitat == "淡水")
                { cbxHabitat.SelectedIndex = 0; }
                else if (product.habitat == "鹹水")
                { cbxHabitat.SelectedIndex = 1; }
                tbxBrief.Text = product.brief.ToString();
                tbxLength.Text = product.length.ToString();
                tbxOrigin.Text = product.origin.ToString();
                if (product.difficulty == "高")
                { cbxDifficulty.SelectedIndex = 0; }
                else if (product.difficulty == "中")
                { cbxDifficulty.SelectedIndex = 1; }
                else if (product.difficulty == "低")
                { cbxDifficulty.SelectedIndex = 2; }
                if (product.mix == true)
                { cbxMix.SelectedIndex = 0; }
                else if (product.mix == false)
                { cbxMix.SelectedIndex = 1; }
                tbxPrice.Text = product.price.ToString();
                tbxInPrice.Text = product.Inprice.ToString();
                tbxStock.Text = product.quantity.ToString();
                if (product.providing == true)
                { cbxProviding.SelectedIndex = 0; }
                else if (product.providing == false)
                { cbxProviding.SelectedIndex = 1; }
                Console.WriteLine(GlobalVar.img_path);
                pbx.Image = System.Drawing.Image.FromFile(GlobalVar.img_path + product.image);
                originalimage_name = product.image;
            }
            rdr.Close();
            con.Close();
        }

            public FormProductChanging()
        {
            InitializeComponent();
        }

        private void FormProductChanging_Load(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            btnModify.Visible = true;
            if (AddorModify == 0)
            {
                btnModify.Visible = false;
            }
            else if (AddorModify == 1)
            {
                btnAdd.Visible = false;
                readDB();
            }
        }

        private void pbx_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "檔案類型(PNG)|*.png";
            DialogResult R = ofd.ShowDialog(); //彈出詢問視窗
            if (R == DialogResult.OK) //按下OK的同時，ofd會存下該檔案完整路徑在FileName屬性裡
            {
                System.IO.FileStream fs = System.IO.File.OpenRead(ofd.FileName);
                pbx.Image = System.Drawing.Image.FromStream(fs);
                fs.Close();
                pbx.Tag = ofd.FileName;
                string strImageExtention = System.IO.Path.GetExtension(ofd.SafeFileName).ToLower(); //GetExtension可以直接抓副檔名(應該也可以用字串功能自己寫)，SafeFileName是FileName去掉前面路徑，再轉小寫
                Random Rnd = new Random();
                strChangedimage_name = DateTime.Now.ToString("yyMMddHHmmss") + Rnd.Next(1000, 10000).ToString() + strImageExtention; //做一個不會重複的檔名
                Image_changed = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ////判斷欄位值
            //給定預設且讀取
            string productname = "";
            productname = tbxName.Text.Trim();
            string sciname = "";
            sciname = tbxSciName.Text.Trim();
            string comname = "";
            comname = tbxCommonName.Text.Trim();
            string engname = "";
            engname = tbxEnName.Text.Trim();
            string namer = "";
            namer = tbxNamer.Text.Trim();
            string family = "";
            family = tbxFamily.Text.Trim();
            string habitat = "";
            if (cbxHabitat.SelectedIndex  == 0)
            { habitat = "淡水"; }
            else if (cbxHabitat.SelectedIndex  == 1)
            { habitat = "鹹水"; }
            string brief = "";
            brief = tbxBrief.Text.Trim();
            string length = "";
            length = tbxLength.Text.Trim();
            string origin = "";
            origin = tbxOrigin.Text.Trim();
            string difficulty = "";
            if (cbxDifficulty.SelectedIndex == 0)
            { difficulty = "高"; }
            else if (cbxDifficulty.SelectedIndex == 1)
            { difficulty = "中"; }
            else if (cbxDifficulty.SelectedIndex == 2)
            { difficulty = "低"; }
            string mix = "";
            if (cbxMix.SelectedIndex == 0)
            { mix = "是"; }
            else if (cbxMix.SelectedIndex == 1)
            { mix = "否"; }
            long price = 0;
            Int64.TryParse(tbxPrice.Text.Trim(),out price);
            long inprice = 0;
            Int64.TryParse(tbxInPrice.Text.Trim(), out inprice);
            int stock = 0;
            Int32.TryParse(tbxStock.Text.Trim(), out stock);
            string providing = "";
            if (cbxProviding.SelectedIndex == 0)
            { providing = "是"; }
            else if (cbxProviding.SelectedIndex == 1)
            { providing = "否"; }
            pbx.Tag = strChangedimage_name;



            if ((productname != "") && (sciname != "") && (comname != "") && (engname != "") && (namer != "") && (family != "") && (habitat != "") && (brief != "") && (length != "") && (habitat != "") && (origin != "") && (difficulty != "") && (mix != "") && (price != 0) && (inprice != 0) && (stock != 0) && (providing != "") && (pbx.Image != null))
            {
                ////連線
                SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
                con.Open();
                //檢查帳號是否已存在
                string strSQL = "SELECT * FROM products WHERE 學名 = @sciname;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@sciname", sciname);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read() != true)
                {
                    //要先關閉讀取器，等等才能繼續用
                    rdr.Close();
                    //抓最新產品編號
                    strSQL = "SELECT TOP 1 產品編號 FROM products ORDER BY 產品編號 desc;";
                    cmd = new SqlCommand(strSQL, con);
                    rdr = cmd.ExecuteReader();
                    int new_productID = 1;
                    if (rdr.Read())
                    {
                        new_productID = (int)rdr["產品編號"] + 1;
                    }
                    rdr.Close();
                    //更新產品資料庫
                    strSQL = "INSERT INTO products (產品編號,產品名稱,學名,俗名,英文名,命名者,科別,淡鹹水,簡介,體長,原產地,飼養難度,可混養,產品金額,進貨價格,庫存量,供貨,圖片) VALUES (@productID,@productName,@sciname,@comname,@engname,@namer,@family,@habitat,@brief,@length,@origin,@difficulty,@mix,@price,@inprice,@stock,@providing,@image);";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@productID", new_productID);
                    cmd.Parameters.AddWithValue("@productName", productname);
                    cmd.Parameters.AddWithValue("@sciname", sciname);
                    cmd.Parameters.AddWithValue("@comname", comname);
                    cmd.Parameters.AddWithValue("@engname", engname);
                    cmd.Parameters.AddWithValue("@namer", namer);
                    cmd.Parameters.AddWithValue("@family", family);
                    cmd.Parameters.AddWithValue("@habitat", habitat);
                    cmd.Parameters.AddWithValue("@brief", brief);
                    cmd.Parameters.AddWithValue("@length", length);
                    cmd.Parameters.AddWithValue("@origin", origin);
                    cmd.Parameters.AddWithValue("@difficulty", difficulty);
                    bool mix_bool = true;
                    if (mix == "否") { mix_bool = false; }
                    cmd.Parameters.AddWithValue("@mix", mix_bool);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@inprice", inprice);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    bool providing_bool = true;
                    if (mix == "否") { providing_bool = false; }
                    cmd.Parameters.AddWithValue("@providing", providing_bool);
                    cmd.Parameters.AddWithValue("@image", strChangedimage_name);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("建立產品成功!");
                    con.Close();
                    if (Image_changed == true)
                    {
                        string full_path = $"{GlobalVar.img_path + strChangedimage_name}";
                        pbx.Image.Save(full_path);
                        pbx.Image.Dispose();
                        Image_changed = false;
                    }
                    tbxID.Clear();
                    tbxName.Clear();
                    tbxSciName.Clear();
                    tbxCommonName.Clear();
                    tbxEnName.Clear();
                    tbxNamer.Clear();
                    tbxFamily.Clear();
                    cbxHabitat.SelectedIndex = 0;
                    tbxBrief.Clear();
                    tbxLength.Clear();
                    tbxOrigin.Clear();
                    cbxDifficulty.SelectedIndex = 0;
                    cbxMix.SelectedIndex = 0;
                    tbxPrice.Clear();
                    tbxInPrice.Clear();
                    tbxStock.Clear();
                    cbxProviding.SelectedIndex = 0;
                    pbx.Image = null;
                }
                else { MessageBox.Show("此產品已存在，請至上個頁面用學名搜索!"); }
                rdr.Close();
                con.Close();
            }
            else { MessageBox.Show("欄位不齊全!"); }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if ((productID > 0) && (tbxName.Text != "") && (tbxSciName.Text != "") && (tbxCommonName.Text != "") && (tbxEnName.Text != "") && (tbxNamer.Text != "") && (tbxLength.Text != "") && (tbxOrigin.Text != "") && (tbxStock.Text != "") && (tbxPrice.Text != "") && (tbxInPrice.Text != "") && (tbxBrief.Text != "") && (tbxFamily.Text != "") && (pbx.Image != null))
            {
                SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
                con.Open();
                string strSQL = "UPDATE products SET 產品名稱 = @productName, 學名 = @sciname, 俗名 = @comname, 英文名 = @engname, 命名者 = @namer, 科別 = @family, 淡鹹水 = @habitat, 簡介 = @brief, 體長 = @length, 原產地 = @origin, 飼養難度 = @difficulty, 可混養 = @mix, 產品金額 = @price, 進貨價格 = @inprice, 庫存量 = @stock, 供貨 = @providing, 圖片 = @image WHERE 產品編號 = @productID";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.Parameters.AddWithValue("@productName", tbxName.Text.Trim());
                cmd.Parameters.AddWithValue("@sciname", tbxSciName.Text.Trim());
                cmd.Parameters.AddWithValue("@comname", tbxCommonName.Text.Trim());
                cmd.Parameters.AddWithValue("@engname", tbxEnName.Text.Trim());
                cmd.Parameters.AddWithValue("@namer", tbxNamer.Text.Trim());
                cmd.Parameters.AddWithValue("@family", tbxFamily.Text.Trim());
                string habitat = "";
                if (cbxHabitat.SelectedIndex == 0)
                { habitat = "淡水"; }
                else if (cbxHabitat.SelectedIndex == 1)
                { habitat = "鹹水"; }
                cmd.Parameters.AddWithValue("@habitat", habitat);
                cmd.Parameters.AddWithValue("@brief", tbxBrief.Text.Trim());
                cmd.Parameters.AddWithValue("@length", tbxLength.Text.Trim());
                cmd.Parameters.AddWithValue("@origin", tbxOrigin.Text.Trim());
                string difficulty = "";
                if (cbxDifficulty.SelectedIndex == 0)
                { difficulty = "高"; }
                else if (cbxDifficulty.SelectedIndex == 1)
                { difficulty = "中"; }
                else if (cbxDifficulty.SelectedIndex == 2)
                { difficulty = "低"; }
                cmd.Parameters.AddWithValue("@difficulty", difficulty);
                bool mix = true;
                if (cbxMix.SelectedIndex == 0)
                { mix = true; }
                else if (cbxMix.SelectedIndex == 1)
                { mix = false; }
                cmd.Parameters.AddWithValue("@mix", mix);
                cmd.Parameters.AddWithValue("@price", tbxPrice.Text.Trim());
                cmd.Parameters.AddWithValue("@inprice", tbxInPrice.Text.Trim());
                cmd.Parameters.AddWithValue("@stock", tbxStock.Text.Trim());
                bool providing = true;
                if (cbxProviding.SelectedIndex == 0)
                { providing = true; }
                else if (cbxProviding.SelectedIndex == 1)
                { providing = false; }
                cmd.Parameters.AddWithValue("@providing", providing);
                if (Image_changed == true)
                {
                    cmd.Parameters.AddWithValue("@image", strChangedimage_name);
                    Image_changed = false;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@image", originalimage_name);
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show("修改成功!");
                con.Close();
            }
            else { MessageBox.Show("錯誤!"); }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

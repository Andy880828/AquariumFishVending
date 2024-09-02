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
    public partial class FormProductDetail : Form
    {
        public int productID = 0;

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
                tbxHabitat.Text = product.habitat.ToString();
                tbxBrief.Text = product.brief.ToString();
                tbxLength.Text = product.length.ToString();
                tbxOrigin.Text = product.origin.ToString();
                tbxDifficulty.Text = product.difficulty.ToString();
                tbxMix.Text = product.mix.ToString();
                Console.WriteLine(GlobalVar.img_path);
                pbx.Image = System.Drawing.Image.FromFile(GlobalVar.img_path + product.image);
            }
            rdr.Close();
            con.Close();
        }
        public FormProductDetail()
        {
            InitializeComponent();
        }

        private void FormProductDetail_Load(object sender, EventArgs e)
        {
            readDB();
        }
    }
}

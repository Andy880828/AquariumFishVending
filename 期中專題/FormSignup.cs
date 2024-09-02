using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中專題
{
    public partial class FormSignup : Form
    {
        public FormSignup()
        {
            InitializeComponent();
        }

        void initialize()
        { 
            tbxAccount.Clear();
            tbxPassword.Clear();
            tbxName.Clear();
            tbxEmail.Clear();
            tbxPhone.Clear();
            tbxAddress.Clear();
        }

        private void FormSignup_Load(object sender, EventArgs e)
        {
            initialize();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ////判斷欄位值
            //給定預設且讀取
            string account = "";
            account = tbxAccount.Text.Trim();
            string password = "";
            password = tbxPassword.Text.Trim();
            string name = "";
            name = tbxName.Text.Trim();
            string phone = "";
            phone = tbxPhone.Text.Trim();
            string email = "";
            email = tbxEmail.Text.Trim();
            string address = "";
            address = tbxAddress.Text.Trim();

            if ((account != "") && (password != "") && (name != "") && (phone != "") && (email != "") && (address != ""))
            {
                ////連線
                SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
                con.Open();
                //檢查帳號是否已存在
                string strSQL = "SELECT * FROM clients WHERE 帳號 = @account;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@account", account);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read() != true)
                {
                    //要先關閉讀取器，等等才能繼續用
                    rdr.Close();
                    //再抓取最新ID
                    strSQL = "SELECT TOP 1 會員編號 FROM clients ORDER BY 會員編號 desc;";
                    cmd = new SqlCommand(strSQL, con);
                    rdr = cmd.ExecuteReader();
                    int ID = 1;
                    if (rdr.Read())
                    {
                        ID = (int)rdr["會員編號"] + 1;
                    }
                    rdr.Close();

                    //更新資料庫
                    strSQL = "INSERT INTO clients (會員編號,帳號,密碼,姓名,電話,Email,地址,身分,會員階級,狀態) VALUES (@ID,@account,@password,@name,@phone,@email,@address,'顧客','一般會員','正常');";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@account", account);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("創建成功!");
                    initialize();
                }
                else {MessageBox.Show("此帳號已存在!");}
                rdr.Close();
                con.Close();
            }
            else { MessageBox.Show("欄位不齊全!"); }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
using System.Xml.Linq;

namespace 期中專題
{
    public partial class FormClientChanging : Form
    {

        private class Client
        {
            public int clientID = 0;
            public string clientAccount = "";
            public string clientName = "";
            public string clientPassword = "";
            public string clientPhone = "";
            public string clientEmail = "";
            public string clientAddress = "";
            public string clientLevel = "";
            public string status = "";
        }

        public int clientID = 0;
        public int AddorModify = 0; //0是新增，1是修改

        void readDB()
        {
            SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
            con.Open();
            string strSQL = "SELECT * FROM clients WHERE 會員編號 = @clientID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@clientID", clientID);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                Client client = new Client();
                client.clientID = (int)rdr["會員編號"];
                client.clientAccount = (string)rdr["帳號"];
                client.clientName = (string)rdr["姓名"];
                client.clientPassword = (string)rdr["密碼"];
                client.clientPhone = (string)rdr["電話"];
                client.clientEmail = (string)rdr["Email"];
                client.clientAddress = (string)rdr["地址"];
                client.clientLevel = (string)rdr["會員階級"];
                client.status = (string)rdr["狀態"];
                tbxClientID.Text = client.clientID.ToString();
                tbxAccount.Text = client.clientAccount.ToString();
                tbxName.Text = client.clientName.ToString();
                tbxPassword.Text = client.clientPassword.ToString();
                tbxPhone.Text = client.clientPhone.ToString();
                tbxEmail.Text = client.clientEmail.ToString();
                tbxAddress.Text = client.clientAddress.ToString();

                if (client.clientLevel == "VIP會員")
                { cbxLevel.SelectedIndex = 0; }
                else if (client.clientLevel == "一般會員")
                { cbxLevel.SelectedIndex = 1; }

                if (client.status == "正常")
                { cbxStatus.SelectedIndex = 0; }
                else if (client.status == "停權")
                { cbxStatus.SelectedIndex = 1; }
            }
            rdr.Close();
            con.Close();
        }

        public FormClientChanging()
        {
            InitializeComponent();
        }
        private void FormClientChanging_Load(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            btnModify.Visible = true;
            tbxAccount.ReadOnly = true;
            if (AddorModify == 0)
            {
                btnModify.Visible = false;
                tbxAccount.ReadOnly = false;
            }
            else if (AddorModify == 1)
            {
                btnAdd.Visible = false;
                readDB();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            string level = "";
            if (cbxStatus.SelectedIndex == 0)
            { level = "VIP會員"; }
            else if (cbxStatus.SelectedIndex == 1)
            { level = "一般會員"; }
            string status = "";
            if (cbxStatus.SelectedIndex == 0)
            { status = "正常"; }
            else if (cbxStatus.SelectedIndex == 1)
            { status = "停權"; }


            if ((account != "") && (password != "") && (name != "") && (phone != "") && (email != "") && (address != "") && (level != "") && (status != ""))
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
                    //抓最新會員編號
                    strSQL = "SELECT TOP 1 會員編號 FROM clients ORDER BY 會員編號 desc;";
                    cmd = new SqlCommand(strSQL, con);
                    rdr = cmd.ExecuteReader();
                    int new_clientID = 1;
                    if (rdr.Read())
                    {
                        new_clientID = (int)rdr["會員編號"] + 1;
                    }
                    rdr.Close();
                    //更新會員資料庫
                    strSQL = "INSERT INTO clients (會員編號,帳號,密碼,姓名,電話,Email,地址,身分,會員階級,狀態) VALUES (@ID,@account,@password,@name,@phone,@email,@address,'顧客',@level,@status);";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@ID", new_clientID);
                    cmd.Parameters.AddWithValue("@account", account);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@level", level);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("建立會員資料成功!");
                    con.Close();
                }
                else { MessageBox.Show("此帳號已存在，請輸入新的一組!"); }
                rdr.Close();
                con.Close();
            }
            else { MessageBox.Show("欄位不齊全!"); }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if ((clientID > 0) && (tbxAccount.Text != "") && (tbxName.Text != "") && (tbxPhone.Text != "") && (tbxPassword.Text != "") && (tbxEmail.Text != "") && (tbxAddress.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
                con.Open();
                //更改會員部分
                string strSQL = "UPDATE clients SET 帳號 = @account, 密碼 = @password, 姓名 = @name, 電話 = @phone,Email = @email ,地址 = @address, 會員階級 = @level, 狀態 = @status WHERE 會員編號 = @clientID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@account", tbxAccount.Text.Trim());
                cmd.Parameters.AddWithValue("@password", tbxPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@name", tbxName.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", tbxPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@email", tbxEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@address", tbxAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@clientID", tbxClientID.Text.Trim());
                string level = "";
                if (cbxStatus.SelectedIndex == 0)
                { level = "VIP會員"; }
                else if (cbxStatus.SelectedIndex == 1)
                { level = "一般會員"; }
                cmd.Parameters.AddWithValue("@level", level);
                string status = "";
                if (cbxStatus.SelectedIndex == 0)
                { status = "正常"; }
                else if (cbxStatus.SelectedIndex == 1)
                { status = "停權"; }
                cmd.Parameters.AddWithValue("@status", status);
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

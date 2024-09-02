using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 期中專題
{
    public partial class FormInfo : Form
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
        }
        public FormInfo()
        {
            InitializeComponent();
        }
        private void FormInfo_Load(object sender, EventArgs e)
        {
            //初始化
            btnLeveling.Visible = true;
            //
            SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
            con.Open();
            string strSQL = "SELECT * FROM clients WHERE 會員編號 = @clientID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@clientID", GlobalVar.Current_ClientID);
            SqlDataReader rdr = cmd.ExecuteReader();
            Client client = new Client();
            if (rdr.Read() == true)
            {
                client.clientID = GlobalVar.Current_ClientID;
                client.clientName = GlobalVar.Current_ClientName;
                client.clientAccount = (string)rdr["帳號"];
                client.clientPassword = (string)rdr["密碼"];
                client.clientPhone = (string)rdr["電話"];
                client.clientEmail = (string)rdr["Email"];
                client.clientAddress = (string)rdr["地址"];
                client.clientLevel = (string)rdr["會員階級"];
            }
            rdr.Close();
            con.Close();
            lblUser.Text = client.clientAccount.ToString();
            tbxID.Text = client.clientID.ToString();
            tbxName.Text = client.clientName.ToString();
            tbxPassword.Text = client.clientPassword.ToString();
            tbxPhone.Text = client.clientPhone.ToString();
            tbxEmail.Text = client.clientEmail.ToString();
            tbxAddress.Text = client.clientAddress.ToString();
            tbxLevel.Text = client.clientLevel.ToString();
            if (client.clientLevel.ToString() == "VIP會員")
            {
                btnLeveling.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //給定預設且讀取
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

            if ((password != "") && (name != "") && (phone != "") && (email != "") && (address != ""))
            {
                ////連線
                SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
                con.Open();
                //更新資料庫
                string strSQL = "UPDATE clients SET 密碼=@password,姓名=@name,電話=@phone,Email=@email,地址=@address WHERE 會員編號 = @id;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@id", GlobalVar.Current_ClientID);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.ExecuteNonQuery();
                MessageBox.Show("更新成功!");
                con.Close();
            }
            else { MessageBox.Show("欄位不齊全!"); }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLeveling_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("確定要升級成VIP會員嗎?", "VIP會員", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
                con.Open();
                //更新資料庫
                string strSQL = "UPDATE clients SET 會員階級='VIP會員' WHERE 會員編號 = @id;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@id", GlobalVar.Current_ClientID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("升級成功!");
                tbxLevel.Text = "VIP會員";
                GlobalVar.Current_ClientLevel = tbxLevel.Text;
            }
        }
    }
}

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
    public partial class FormClientManaging : Form
    {
        private bool isSearching = false;
        private class Client //新增一個類別存會員
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
        private List<Client> clients = new List<Client>();

        void initialize()
        {
            clients.Clear();
            lvwClient.Clear();
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
                strSQL = "SELECT * FROM clients WHERE 姓名 LIKE @ClientName;";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@ClientName", "%" + tbxSearch.Text.Trim() + "%");

            }
            else
            {
                strSQL = "SELECT * FROM clients;";
                cmd = new SqlCommand(strSQL, con);
            }

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
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
                clients.Add(client);
            }
            rdr.Close();
            con.Close();
            //設置listview欄位
            lvwClient.View = View.Details;
            lvwClient.Columns.Add("會員編號", 100);
            lvwClient.Columns.Add("姓名", 100);
            lvwClient.Columns.Add("帳號", 100);
            lvwClient.Columns.Add("電話", 100);
            lvwClient.Columns.Add("會員階級", 100);
            lvwClient.Columns.Add("狀態", 100);
            lvwClient.GridLines = true; //顯示格線
            lvwClient.FullRowSelect = true; //整列選取
            //輸出到listview
            if (clients.Count != 0)
            {
                foreach (Client client in clients)
                {
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                    item.Tag = client.clientID;
                    item.Text = client.clientID.ToString();
                    item.SubItems.Add(client.clientName.ToString());
                    item.SubItems.Add(client.clientAccount.ToString());
                    item.SubItems.Add(client.clientPhone.ToString());
                    item.SubItems.Add(client.clientLevel.ToString());
                    item.SubItems.Add(client.status.ToString());
                    lvwClient.Items.Add(item); //加入items到listview
                }
            }
            lblClient.Text = $"共{clients.Count}人";
        }

        public FormClientManaging()
        {
            InitializeComponent();
        }

        private void FormClientManaging_Load(object sender, EventArgs e)
        {
            initialize();
            readDB();
        }

        private void FormClientManaging_Activated(object sender, EventArgs e)
        {
            initialize();
            readDB();
            tbxSearch.Clear();
        }

        private void lvwClient_ItemActivate(object sender, EventArgs e)
        {
            FormClientChanging formClientChanging = new FormClientChanging();
            formClientChanging.AddorModify = 1;
            formClientChanging.clientID = Convert.ToInt32(lvwClient.SelectedItems[0].Tag);
            formClientChanging.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormClientChanging formClientChanging = new FormClientChanging();
            formClientChanging.AddorModify = 0;
            formClientChanging.ShowDialog();
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

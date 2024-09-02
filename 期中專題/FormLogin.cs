using System;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace 期中專題
{
    public partial class FormLogin : Form
    {
        void initialize()
        {
            tabControl1.SelectedIndex = 0;
            GlobalVar.Current_EmployeeID = 0;
            GlobalVar.Current_ClientID = 0;
            GlobalVar.Current_EmployeeName = "";
            GlobalVar.Current_ClientName = "";
            GlobalVar.Current_EmployeeLevel = "";
            GlobalVar.Current_ClientLevel = "";
            GlobalVar.img_path = "";
            tbxAccountC.Clear();
            tbxAccountE.Clear();
            tbxPasswordC.Clear();
            tbxPasswordE.Clear();
        }

        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            //初始化
            initialize();
            //建立資料庫連線字串
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = ".";
            scsb.InitialCatalog = "fish";
            scsb.IntegratedSecurity = true;
            GlobalVar.SqlConnectionString = scsb.ConnectionString;
        }

        private void FormLogin_Activated(object sender, EventArgs e)
        {
            //回到此畫面就初始化
            initialize();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //抓取文字框內容
            string account = "";
            string password = "";
            if ((tabControl1.SelectedIndex == 0) && (tbxAccountC.Text != "") && (tbxPasswordC.Text != ""))
            {
                account = tbxAccountC.Text;
                password = tbxPasswordC.Text;
            }
            else if ((tabControl1.SelectedIndex == 1) && ((tbxAccountE.Text != "") || (tbxPasswordE.Text != "")))
            {
                account = tbxAccountE.Text;
                password = tbxPasswordE.Text;
            }
            else { MessageBox.Show("請完整輸入帳號密碼!"); }

            //連線資料庫搜尋
            SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
            con.Open();
            string strSQL = "";
            if (tabControl1.SelectedIndex == 0)
            {
                strSQL = "SELECT 會員編號, 會員階級, 姓名, 狀態 FROM clients WHERE 帳號 = @account AND 密碼 = @password;";
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                strSQL = "SELECT e.員工編號, e.員工階級, e.姓名 FROM clients as c JOIN　employees as e ON c.帳號 = e.帳號 WHERE c.帳號 = @account AND c.密碼 = @password;";
            }
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@account", $"{account}");
            cmd.Parameters.AddWithValue("@password", $"{password}");
            SqlDataReader rdr = cmd.ExecuteReader();
            if ((tabControl1.SelectedIndex == 0) && (rdr.Read() == true))
            {
                GlobalVar.Current_ClientID = (int)rdr["會員編號"];
                GlobalVar.Current_ClientLevel = (string)rdr["會員階級"];
                GlobalVar.Current_ClientName = (string)rdr["姓名"];
                GlobalVar.Current_ClientStatus = (string)rdr["狀態"];
                if (GlobalVar.Current_ClientStatus == "正常")
                {
                    FormClient formClient = new FormClient();
                    formClient.ShowDialog();
                }
                else if (GlobalVar.Current_ClientStatus == "停權") { MessageBox.Show("此帳號已被停權。"); }
            }
            else if ((tabControl1.SelectedIndex == 1) && (rdr.Read() == true))
            {
                GlobalVar.Current_EmployeeID = (int)rdr["員工編號"];
                GlobalVar.Current_EmployeeLevel = (string)rdr["員工階級"];
                GlobalVar.Current_EmployeeName = (string)rdr["姓名"];
                ////紀錄員工打卡
                //抓取新編號
                rdr.Close();
                strSQL = "SELECT TOP 1 打卡編號 FROM punch ORDER BY 打卡編號 desc;";
                cmd = new SqlCommand(strSQL, con);
                rdr = cmd.ExecuteReader();
                int punchID = 1;
                if (rdr.Read())
                {
                    punchID = (int)rdr["打卡編號"] + 1;
                }
                rdr.Close();
                //更新資料庫
                strSQL = "INSERT INTO punch (打卡編號,員工編號,日期,上班時間) VALUES (@punchID,@employeeID,@date,@punchin);";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@punchID", punchID);
                cmd.Parameters.AddWithValue("@employeeID", GlobalVar.Current_EmployeeID);
                cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@punchin", DateTime.Now);
                cmd.ExecuteNonQuery();
                FormEmployee formEmployee = new FormEmployee();
                formEmployee.ShowDialog();
            }
            else { if (account != "" && password != "") { MessageBox.Show("帳號或密碼錯誤!"); } }
            con.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            FormSignup formSignup = new FormSignup();
            formSignup.ShowDialog();
        }
    }
}

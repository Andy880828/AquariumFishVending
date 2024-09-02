using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 期中專題
{

    public partial class FormEmployeeChanging : Form
    {
        private class Employee //新增一個類別存員工
        {
            public int clientID = 0;
            public string clientAccount = "";
            public string clientName = "";
            public string clientPassword = "";
            public string clientPhone = "";
            public string clientEmail = "";
            public string clientAddress = "";
            public string clientLevel = "";
            public int employeeID = 0;
            public int employeeSalary = 0;
            public DateTime hireTime = DateTime.MinValue;
            public DateTime unhireTime = DateTime.MinValue;
            public string status = "";
        }

        public int employeeID = 0;
        //給上一個Form傳遞操作是新增還是修改
        public int AddorModify = 0; //0是新增，1是修改

        void readDB()
        {
            SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
            con.Open();
            string strSQL = "SELECT c.會員編號, c.帳號, c.姓名, c.密碼, c.電話,c.Email,c.地址, c.會員階級, e.員工編號, e.薪水, e.入職日,e.離職日, e.狀態  FROM employees as e JOIN clients as c on e.帳號 = c.帳號 WHERE e.員工編號 = @employeeID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@employeeID", employeeID);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                Employee employee = new Employee();
                employee.clientID = (int)rdr["會員編號"];
                employee.clientAccount = (string)rdr["帳號"];
                employee.clientName = (string)rdr["姓名"];
                employee.clientPassword = (string)rdr["密碼"];
                employee.clientPhone = (string)rdr["電話"];
                employee.clientEmail = (string)rdr["Email"];
                employee.clientAddress = (string)rdr["地址"];
                employee.clientLevel = (string)rdr["會員階級"];
                employee.employeeID = (int)rdr["員工編號"];
                if (rdr["薪水"] != DBNull.Value)
                {
                    employee.employeeSalary = (int)rdr["薪水"];
                }
                employee.hireTime = (DateTime)rdr["入職日"];
                if (rdr["離職日"] != DBNull.Value)
                {
                    employee.unhireTime = (DateTime)rdr["離職日"];
                }
                employee.status = (string)rdr["狀態"];
                tbxEmployeeID.Text = employee.employeeID.ToString();
                tbxClientID.Text = employee.clientID.ToString();
                tbxAccount.Text = employee.clientAccount.ToString();
                tbxName.Text = employee.clientName.ToString();
                tbxPassword.Text = employee.clientPassword.ToString();
                tbxPhone.Text = employee.clientPhone.ToString();
                tbxEmail.Text = employee.clientEmail.ToString();
                tbxAddress.Text = employee.clientAddress.ToString();
                tbxSalary.Text = employee.employeeSalary.ToString();
                dtpHiredate.Value = employee.hireTime;
                if (employee.status == "正常")
                { cbxStatus.SelectedIndex = 0; }
                else if (employee.status == "留職停薪")
                { cbxStatus.SelectedIndex = 1; }
                else if (employee.status == "離職")
                { cbxStatus.SelectedIndex = 2; }
            }
            rdr.Close();
            con.Close();
        }

        public FormEmployeeChanging()
        {
            InitializeComponent();
        }

        private void FormEmployeeChanging_Load(object sender, EventArgs e)
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
            int salary = 0;
            Int32.TryParse(tbxSalary.Text.Trim(),out salary);
            DateTime hireDate = DateTime.MinValue;
            hireDate = dtpHiredate.Value;
            string status = "";
            if (cbxStatus.SelectedIndex == 0)
            { status = "正常"; }
            else if (cbxStatus.SelectedIndex == 1)
            { status = "留職停薪"; }
            else if (cbxStatus.SelectedIndex == 2)
            { status = "離職"; }

            if ((account != "") && (password != "") && (name != "") && (phone != "") && (email != "") && (address != "") && (salary != 0) && (hireDate != DateTime.MinValue) && (status != ""))
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
                    //抓最新員工編號
                    strSQL = "SELECT TOP 1 員工編號 FROM employees ORDER BY 員工編號 desc;";
                    cmd = new SqlCommand(strSQL, con);
                    rdr = cmd.ExecuteReader();
                    int new_employeeID = 1;
                    if (rdr.Read())
                    {
                        new_employeeID = (int)rdr["員工編號"] + 1;
                    }
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
                    strSQL = "INSERT INTO clients (會員編號,帳號,密碼,姓名,電話,Email,地址,身分,會員階級,狀態) VALUES (@ID,@account,@password,@name,@phone,@email,@address,'店員','一般會員','正常');";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@ID", new_clientID);
                    cmd.Parameters.AddWithValue("@account", account);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.ExecuteNonQuery();
                    //更新員工資料庫
                    strSQL = "INSERT INTO employees (員工編號,姓名,帳號,入職日,薪水,狀態,員工階級) VALUES (@employeeID,@name,@account,@hiredate,@salary,@status,'店員');";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@employeeID", new_employeeID);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@account", account);
                    cmd.Parameters.AddWithValue("@hiredate", hireDate);
                    cmd.Parameters.AddWithValue("@salary", salary);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("建立員工資料成功!");
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
            if ((employeeID > 0) && (tbxAccount.Text != "") && (tbxName.Text != "") && (tbxPhone.Text != "") && (tbxPassword.Text != "") && (tbxEmail.Text != "") && (tbxAddress.Text != "") && (tbxSalary.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
                con.Open();
                //更改會員部分
                string strSQL = "UPDATE clients SET 帳號 = @account, 密碼 = @password, 姓名 = @name, 電話 = @phone,Email = @email ,地址 = @address WHERE 會員編號 = @clientID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@account", tbxAccount.Text.Trim());
                cmd.Parameters.AddWithValue("@password", tbxPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@name", tbxName.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", tbxPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@email", tbxEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@address", tbxAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@clientID", tbxClientID.Text.Trim());
                cmd.ExecuteNonQuery();
                //更改員工部分
                strSQL = "UPDATE employees SET 姓名 = @name, 帳號 = @account,入職日 = @hiredate, 薪水= @salary, 狀態 = @status WHERE 員工編號 = @employeeID";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@name", tbxName.Text.Trim());
                cmd.Parameters.AddWithValue("@account", tbxAccount.Text.Trim());
                cmd.Parameters.AddWithValue("@hiredate", dtpHiredate.Value);
                cmd.Parameters.AddWithValue("@salary", tbxSalary.Text.Trim());
                string status = "";
                if (cbxStatus.SelectedIndex == 0)
                { status = "正常"; }
                else if (cbxStatus.SelectedIndex == 1)
                { status = "留職停薪"; }
                else if (cbxStatus.SelectedIndex == 2)
                { status = "離職"; }
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@employeeID", employeeID);
                cmd.ExecuteNonQuery();
                //如果更改為離職要把離職日記錄起來
                if (status == "離職")
                {
                    strSQL = "UPDATE employees SET 離職日 = @unhiredate WHERE 員工編號 = @employeeID";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@unhiredate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);
                    cmd.ExecuteNonQuery();
                }
                // 如果復職，將離職日設置為 NULL
                if (status == "正常")
                {
                    strSQL = "UPDATE employees SET 離職日 = NULL WHERE 員工編號 = @employeeID";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);
                    cmd.ExecuteNonQuery();
                }
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

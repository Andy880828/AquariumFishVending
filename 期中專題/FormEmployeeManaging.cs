using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace 期中專題
{
    public partial class FormEmployeeManaging : Form
    {
        private bool isSearching = false;
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
        private List<Employee> employees = new List<Employee>();

        void initialize()
        {
            employees.Clear();
            lvwEmployee.Clear();
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
                strSQL = "SELECT c.會員編號, c.帳號, c.姓名, c.密碼, c.電話,c.Email,c.地址, c.會員階級, e.員工編號, e.薪水, e.入職日, e.離職日, e.狀態  FROM employees as e JOIN clients as c on e.帳號 = c.帳號 WHERE c.姓名 LIKE @employeeName;";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@employeeName", "%" + tbxSearch.Text.Trim() + "%");

            }
            else {
                strSQL = "SELECT c.會員編號, c.帳號, c.姓名, c.密碼, c.電話,c.Email,c.地址, c.會員階級, e.員工編號, e.薪水, e.入職日, e.離職日, e.狀態  FROM employees as e JOIN clients as c on e.帳號 = c.帳號;";
                cmd = new SqlCommand(strSQL, con);
            }
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
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
                //有空值的都要判定
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
                employees.Add(employee);
            }
            rdr.Close();
            con.Close();
            //設置listview欄位
            lvwEmployee.View = View.Details;
            lvwEmployee.Columns.Add("員工編號", 90);
            lvwEmployee.Columns.Add("姓名", 90);
            lvwEmployee.Columns.Add("帳號", 100);
            lvwEmployee.Columns.Add("薪水", 90);
            lvwEmployee.Columns.Add("狀態", 100);
            lvwEmployee.Columns.Add("入職日", 120);
            lvwEmployee.Columns.Add("離職日", 120);
            lvwEmployee.GridLines = true; //顯示格線
            lvwEmployee.FullRowSelect = true; //整列選取
            //輸出到listview
            if (employees.Count != 0)
            {
                foreach (Employee employee in employees)
                {
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                    item.Tag = employee.employeeID;
                    item.Text = employee.employeeID.ToString();
                    item.SubItems.Add(employee.clientName.ToString());
                    item.SubItems.Add(employee.clientAccount.ToString());
                    item.SubItems.Add(employee.employeeSalary.ToString());
                    item.SubItems.Add(employee.status.ToString());
                    item.SubItems.Add(employee.hireTime.ToString("d"));
                    if (employee.unhireTime != DateTime.MinValue)
                    {
                        item.SubItems.Add(employee.unhireTime.ToString("d"));
                    }
                    lvwEmployee.Items.Add(item); //加入items到listview
                }
            }
            lblEmployee.Text = $"共{employees.Count}人";
        }

        public FormEmployeeManaging()
        {
            InitializeComponent();
        }
        private void FormEmployeeManaging_Load(object sender, EventArgs e)
        {
            initialize();
            readDB();
        }
        private void FormEmployeeManaging_Activated(object sender, EventArgs e)
        {
            initialize();
            readDB();
            tbxSearch.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormEmployeeChanging formEmployeeChanging = new FormEmployeeChanging();
            formEmployeeChanging.AddorModify = 0;
            formEmployeeChanging.ShowDialog();
        }
        private void lvwEmployee_ItemActivate(object sender, EventArgs e)
        {
            FormEmployeeChanging formEmployeeChanging = new FormEmployeeChanging();
            formEmployeeChanging.AddorModify = 1;
            formEmployeeChanging.employeeID = Convert.ToInt32(lvwEmployee.SelectedItems[0].Tag);
            formEmployeeChanging.ShowDialog();
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

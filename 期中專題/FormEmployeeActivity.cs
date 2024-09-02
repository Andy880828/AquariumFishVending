using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace 期中專題
{
    public partial class FormEmployeeActivity : Form
    {
        private class Employee
        {
            public string clientName = "";
            public int employeeID = 0;
        }
        private class Punch
        {
            public int punchID = 0;
            public int employeeID = 0;
            public string employeeName = "";
            public DateTime punchDate = DateTime.MinValue;
            public DateTime punchInTime = DateTime.MinValue;
            public DateTime punchOutTime = DateTime.MinValue;
            public bool punchout_isnotnull = false;

        }
        private List<Employee> employees = new List<Employee>();
        List<Punch> punches = new List<Punch>();

        void initialize()
        {
            employees.Clear();
            punches.Clear();
            lvwPresence.Clear();
        }

        public FormEmployeeActivity()
        {
            InitializeComponent();
        }

        private void FormEmployeeActivity_Load(object sender, EventArgs e)
        {
            initialize();
            List<string> employee_names = new List<string>();
            //連線取得訂單資訊
            SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
            con.Open();
            string strSQL = "SELECT * FROM employees;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                Employee employee = new Employee();
                employee.employeeID = (int)rdr["員工編號"];
                employee.clientName = (string)rdr["姓名"];
                employee_names.Add(employee.clientName);
                employees.Add(employee);
            }
            rdr.Close();
            //設定下拉選單
            cbxEmployee.Items.Clear();
            cbxEmployee.Items.Add("所有員工");
            foreach (string employee_name in employee_names)
            {
                cbxEmployee.Items.Add(employee_name);
            }
            con.Close();
            cbxEmployee.SelectedIndex = 0; // 默認為"所有員工"
        }

        private void cbxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            initialize();
            SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
            con.Open();
            string strSQL = "";
            SqlCommand cmd;
            if (cbxEmployee.SelectedItem.ToString() == "所有員工")
            {
                strSQL = "SELECT e.姓名,p.日期,p.上班時間,p.下班時間 FROM punch AS p JOIN employees AS e ON p.員工編號 = e.員工編號";
                cmd = new SqlCommand(strSQL, con);
            }
            else
            {
                strSQL = "SELECT 日期,上班時間,下班時間 FROM punch WHERE 員工編號 = (SELECT 員工編號 FROM employees WHERE 姓名 = @EmployeeName);";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@EmployeeName", cbxEmployee.SelectedItem.ToString());
            }
            SqlDataReader rdr = cmd.ExecuteReader();
            //因為下班時間可能為空(最新一筆)，需要檢測是否為空，否則後面會報錯
            while (rdr.Read() == true)
            {
                Punch punch = new Punch();
                if (cbxEmployee.SelectedItem.ToString() == "所有員工") { punch.employeeName = (string)rdr["姓名"]; }
                punch.punchDate = (DateTime)rdr["日期"];
                punch.punchInTime = (DateTime)rdr["上班時間"];
                if (rdr["下班時間"] != DBNull.Value)
                {
                    punch.punchOutTime = (DateTime)rdr["下班時間"];
                    punch.punchout_isnotnull = true;
                }
                punches.Add(punch);
            }
            rdr.Close();
            con.Close();
            //設置listview欄位
            lvwPresence.View = View.Details;
            lvwPresence.Columns.Add("打卡日期", 220);
            if (cbxEmployee.SelectedItem.ToString() == "所有員工") { lvwPresence.Columns.Add("員工姓名", 90); }
            lvwPresence.Columns.Add("上班打卡時間", 240);
            lvwPresence.Columns.Add("下班打卡時間", 240);
            lvwPresence.GridLines = true; //顯示格線
            lvwPresence.FullRowSelect = true; //整列選取
            //輸出到listview
            if (punches.Count != 0)
            {
                punches.Sort((x, y) => y.punchDate.CompareTo(x.punchDate));
                foreach (Punch punch in punches)
                {
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                    item.Text = punch.punchDate.ToString("d");
                    if (cbxEmployee.SelectedItem.ToString() == "所有員工") { item.SubItems.Add(punch.employeeName.ToString()); }
                    item.SubItems.Add(punch.punchInTime.ToString("G"));
                    if (punch.punchout_isnotnull == true)
                    {
                        item.SubItems.Add(punch.punchOutTime.ToString("G"));
                    }
                    lvwPresence.Items.Add(item); //加入items到listview
                }
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

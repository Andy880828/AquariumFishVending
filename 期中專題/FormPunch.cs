using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace 期中專題
{
    public partial class FormPunch : Form
    {
        private class Punch
        {
            public DateTime punchDate = DateTime.MinValue;
            public DateTime punchInTime = DateTime.MinValue;
            public DateTime punchOutTime = DateTime.MinValue;
            public bool punchout_isnotnull = false;
        }
        List<Punch> punches = new List<Punch>();

        public FormPunch()
        {
            InitializeComponent();
        }

        private void FormPunch_Load(object sender, EventArgs e)
        {
            lblEmployee.Text = GlobalVar.Current_EmployeeName;
            SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
            con.Open();
            //時間篩選抓取
            string strSQL = "SELECT 日期,上班時間,下班時間 FROM punch WHERE 員工編號 = @EmployeeID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@EmployeeID", GlobalVar.Current_EmployeeID);
            SqlDataReader rdr = cmd.ExecuteReader();
            //因為下班時間可能為空(最新一筆)，需要檢測是否為空，否則後面會報錯
            while (rdr.Read() == true)
            {
                Punch punch = new Punch();
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
            lvwPunch.Clear();
            lvwPunch.View = View.Details;
            lvwPunch.Columns.Add("打卡日期", 100);
            lvwPunch.Columns.Add("上班打卡時間", 250);
            lvwPunch.Columns.Add("下班打卡時間", 250);
            lvwPunch.GridLines = true; //顯示格線
            lvwPunch.FullRowSelect = true; //整列選取
            //紀錄累計時數
            int minMonth = 0;
            int minDay = 0;
            //將訂單輸出到listview
            if (punches.Count != 0)
            {
                punches.Sort((x, y) => y.punchDate.CompareTo(x.punchDate));
                foreach (Punch punch in punches)
                {
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                    item.Text = punch.punchDate.ToString("d");
                    item.SubItems.Add(punch.punchInTime.ToString("G"));
                    if (punch.punchout_isnotnull == true)
                    {
                        item.SubItems.Add(punch.punchOutTime.ToString("G"));
                    }
                    lvwPunch.Items.Add(item); //加入items到listview
                    //計算月累計時數
                    if (punch.punchout_isnotnull && punch.punchDate > new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1))
                    {
                        minMonth += (int)(punch.punchOutTime - punch.punchInTime).TotalMinutes;
                    }
                    else if (!punch.punchout_isnotnull)
                    {
                        minMonth += (int)(DateTime.Now - punch.punchInTime).TotalMinutes;
                    }
                    //計算日累計時數
                    if (punch.punchout_isnotnull && punch.punchDate.Date == DateTime.Now.Date)
                    {
                        minDay += (int)(punch.punchOutTime - punch.punchInTime).TotalMinutes;
                    }
                    else if (!punch.punchout_isnotnull && punch.punchDate.Date == DateTime.Now.Date)
                    {
                        minDay += (int)(DateTime.Now - punch.punchInTime).TotalMinutes;
                    }
                }
                Console.WriteLine($"{minMonth},{minDay}");
                double hourMonth = (double)minMonth / 60; //轉型
                double hourDay = (double)minDay / 60;
                lblMonthCum.Text = $"共 {hourMonth:F2} 小時";
                lblDayCum.Text = $"共 {hourDay:F2} 小時";
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

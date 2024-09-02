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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            btnEmployeeManaging.Visible = true;
            btnStatus.Visible = true;
            btnEmployeeActivity.Visible = true;
            if (GlobalVar.Current_EmployeeLevel == "店員")
            {
                btnEmployeeManaging.Visible = false;
                btnStatus.Visible = false;
                btnEmployeeActivity.Visible = false;
            }
            else 
            {
                btnPunchView.Visible = false;
            }
            timer1.Start();
        }

        private void btnOrderManaging_Click(object sender, EventArgs e)
        {
            FormOrderManaging formOrderManaging = new FormOrderManaging();
            formOrderManaging.ShowDialog();
        }

        private void btnProductManaging_Click(object sender, EventArgs e)
        {
            FormProductManaging formProductManaging = new FormProductManaging();
            formProductManaging.ShowDialog();
        }

        private void btnClientManaging_Click(object sender, EventArgs e)
        {
            FormClientManaging formClientManaging = new FormClientManaging();
            formClientManaging.ShowDialog();
        }

        private void btnPunchView_Click(object sender, EventArgs e)
        {
            FormPunch formPunch = new FormPunch();
            formPunch.ShowDialog();
        }

        private void btnEmployeeActivity_Click(object sender, EventArgs e)
        {
            FormEmployeeActivity formEmployeeActivity = new FormEmployeeActivity();
            formEmployeeActivity.ShowDialog();
        }

        private void btnEmployeeManaging_Click(object sender, EventArgs e)
        {
            FormEmployeeManaging formEmployeeManaging = new FormEmployeeManaging();
            formEmployeeManaging.ShowDialog();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            FormStatus formStatus = new FormStatus();
            formStatus.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("G");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            //打卡
            SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
            con.Open();
            string strSQL = "UPDATE punch SET 下班時間 = @punchout WHERE 打卡編號 = (SELECT TOP 1 打卡編號 FROM punch WHERE 員工編號 = @employeeID ORDER BY 上班時間 desc);";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@punchout", DateTime.Now);
            cmd.Parameters.AddWithValue("@employeeID", GlobalVar.Current_EmployeeID);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show($"{DateTime.Now.ToString("T")} 打卡時間已記錄!");
            }
            con.Close();
        }
    }
}

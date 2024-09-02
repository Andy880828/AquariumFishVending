using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中專題
{
    public partial class FormStatus : Form
    {
        private int Total_Client = 0;
        private int Total_Employee = 0;
        private int Total_Product = 0;
        private long Total_Sales = 0;
        private long Total_Profit = 0;

        public FormStatus()
        {
            InitializeComponent();
        }

        private void FormStatus_Load(object sender, EventArgs e)
        {
            //載入圖片
            pbxClient.Image = Properties.Resources.Fat_Man1;
            pbxEmployee.Image = Properties.Resources.Staff;
            pbxProduct.Image = Properties.Resources.Product;
            pbxSales.Image = Properties.Resources.Sales;
            pbxProfit.Image = Properties.Resources.Profit;
            //把圖塊與label點擊事件合併到Panel點擊事件
            pbxEmployee.Click += pnlEmployee_Click;
            lblEmployee.Click += pnlEmployee_Click;
            lblEmployee1.Click += pnlEmployee_Click;

            pbxClient.Click += pnlClient_Click;
            lblClient.Click += pnlClient_Click;
            lblClient1.Click += pnlClient_Click;

            pbxProduct.Click += pnlProduct_Click;
            lblProduct.Click += pnlProduct_Click;
            lblProduct1.Click += pnlProduct_Click;

            pbxSales.Click += pnlSales_Click;
            lblSales.Click += pnlSales_Click;
            lblSales1.Click += pnlSales_Click;

            pbxProfit.Click += pnlProfit_Click;
            lblProfit.Click += pnlProfit_Click;
            lblProfit1.Click += pnlProfit_Click;
            ////讀取資料並顯示
            SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString);
            con.Open();
            //Employee
            string strSQL = "SELECT COUNT(*) as Total_Employee FROM employees WHERE 狀態 = '正常' OR 狀態 = '留職停薪';";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read()) { Total_Employee = (int)rdr["Total_Employee"]; }
            rdr.Close();
            //Client
            strSQL = "SELECT COUNT(*) as Total_Client FROM clients WHERE 狀態 = '正常';";
            cmd = new SqlCommand(strSQL, con);
            rdr = cmd.ExecuteReader();
            if (rdr.Read()) { Total_Client = (int)rdr["Total_Client"]; }
            rdr.Close();
            //Product
            strSQL = "SELECT COUNT(*) as Total_Product FROM products;";
            cmd = new SqlCommand(strSQL, con);
            rdr = cmd.ExecuteReader();
            if (rdr.Read()) { Total_Product = (int)rdr["Total_Product"]; }
            rdr.Close();
            //Sales
            strSQL = "SELECT SUM(總金額) as Total_Sales FROM orders;";
            cmd = new SqlCommand(strSQL, con);
            rdr = cmd.ExecuteReader();
            if (rdr.Read()) { Total_Sales = Convert.ToInt64(rdr["Total_Sales"]); }
            rdr.Close();
            //Profit
            strSQL = "SELECT SUM((oi.產品金額-p.進貨價格)*oi.產品數量) as Total_Profit FROM orders as o JOIN orderitems as oi ON o.訂單編號 = oi.訂單編號 JOIN products as p ON oi.產品編號 = p.產品編號;";
            cmd = new SqlCommand(strSQL, con);
            rdr = cmd.ExecuteReader();
            if (rdr.Read()) { Total_Profit = Convert.ToInt64(rdr["Total_Profit"]); }
            rdr.Close();
            con.Close();
            lblClient.Text = $"共{Total_Client.ToString()}人";
            lblEmployee.Text = $"共{Total_Employee.ToString()}人";
            lblProduct.Text = $"共{Total_Product.ToString()}樣";
            lblSales.Text = $"NTD {Total_Sales.ToString()}";
            lblProfit.Text = $"NTD {Total_Profit.ToString()}";
        }

        private void pnlEmployee_Click(object sender, EventArgs e)
        {
            FormEmployeeManaging formEmployeeManaging = new FormEmployeeManaging();
            formEmployeeManaging.ShowDialog();
        }

        private void pnlClient_Click(object sender, EventArgs e)
        {
            FormClientManaging formClientManaging = new FormClientManaging();
            formClientManaging.ShowDialog();
        }

        private void pnlProduct_Click(object sender, EventArgs e)
        {
            FormProductManaging formProductManaging = new FormProductManaging();
            formProductManaging.ShowDialog();
        }

        private void pnlSales_Click(object sender, EventArgs e)
        {
            FormSalesProfit formSalesProfit = new FormSalesProfit();
            formSalesProfit.viewing = 0;
            formSalesProfit.ShowDialog();
        }

        private void pnlProfit_Click(object sender, EventArgs e)
        {
            FormSalesProfit formSalesProfit = new FormSalesProfit();
            formSalesProfit.viewing = 1;
            formSalesProfit.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

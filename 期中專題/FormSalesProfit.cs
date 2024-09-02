using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace 期中專題
{
    public partial class FormSalesProfit : Form
    {
        public int viewing = 0; //0代表銷售額，1代表獲利

        // 讀取產品資料至 ComboBox
        private void LoadProductsIntoComboBox()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT 產品編號, 產品名稱 FROM products", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataRow newRow = dt.NewRow();
                newRow["產品編號"] = DBNull.Value;
                newRow["產品名稱"] = "全部商品";
                dt.Rows.InsertAt(newRow, 0);

                cbxProduct.DataSource = dt;
                cbxProduct.DisplayMember = "產品名稱";
                cbxProduct.ValueMember = "產品編號"; //把產品編號變成該項次的Value
                cbxProduct.SelectedIndex = -1; // 預設不選擇任何產品
            }
        }

        // 更新圖表
        private void UpdateChart()
        {
            string strSQL = "";
            if (viewing == 0)
            {
                strSQL = @"
        SELECT 
            CONVERT(datetime, CONCAT(FORMAT(o.成立時間, 'yyyy-MM'), '-01')) AS 成立月份, 
            SUM(o.總金額) AS 總銷售額
        FROM orders AS o
        JOIN orderitems AS oi ON o.訂單編號 = oi.訂單編號
        WHERE o.成立時間 BETWEEN @dtpFrom AND @dtpUntil";
            }
            else if (viewing == 1)
            {
                strSQL = @"
        SELECT 
            CONVERT(datetime, CONCAT(FORMAT(o.成立時間, 'yyyy-MM'), '-01')) AS 成立月份, 
            SUM((oi.產品金額 - p.進貨價格) * oi.產品數量) AS 總獲利
        FROM orders AS o
        JOIN orderitems AS oi ON o.訂單編號 = oi.訂單編號
        JOIN products AS p ON oi.產品編號 = p.產品編號
        WHERE o.成立時間 BETWEEN @dtpFrom AND @dtpUntil";
            }

            if (cbxProduct.SelectedValue != null && cbxProduct.SelectedValue is int)
            {
                strSQL += " AND oi.產品編號 = @ProductID";
            }

            strSQL += " GROUP BY FORMAT(o.成立時間, 'yyyy-MM') ORDER BY 成立月份";

            using (SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@dtpFrom", dtpFrom.Value);
                cmd.Parameters.AddWithValue("@dtpUntil", dtpUntil.Value);

                if (cbxProduct.SelectedValue != null && cbxProduct.SelectedValue is int)
                {
                    cmd.Parameters.AddWithValue("@ProductID", (int)cbxProduct.SelectedValue);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt); // 讀到的資料填入資料表

                // 調試：輸出 DataTable 的內容
                if (dt.Rows.Count > 0)
                {
                    Console.WriteLine("DataTable Contents:");
                    foreach (DataRow row in dt.Rows)
                    {
                        Console.WriteLine($"{row["成立月份"]}: {row[viewing == 0 ? "總銷售額" : "總獲利"]}");
                    }
                }
                else
                {
                    Console.WriteLine("No data returned from the query.");
                }

                // 設定圖表
                cht.Series.Clear(); // 清空所有 Series
                cht.Legends.Clear(); // 刪掉 Legend
                cht.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy/MM"; // 設定 X 軸格式

                // 設定 X 軸的範圍
                DateTime minDate = new DateTime(dtpFrom.Value.Year, dtpFrom.Value.Month, 1).AddMonths(-1);
                DateTime maxDate = new DateTime(dtpUntil.Value.Year, dtpUntil.Value.Month, 1).AddMonths(1).AddDays(-1);

                cht.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                cht.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
                cht.ChartAreas[0].AxisY.Minimum = 0;

                Series series = new Series(); // 建構新的 Series
                series.ChartType = SeriesChartType.Column; // 設定圖表類型

                double Max_value = 0;
                foreach (DataRow row in dt.Rows)
                {
                    DateTime xValue = Convert.ToDateTime(row["成立月份"]);
                    double yValue = Convert.ToDouble(row[viewing == 0 ? "總銷售額" : "總獲利"]);
                    if (yValue > Max_value) { Max_value = yValue; }
                    series.Points.AddXY(xValue, yValue);
                }
                cht.ChartAreas[0].AxisY.Maximum = Max_value + 0.1* Max_value;
                cht.Series.Add(series); // Series 加入圖表的 Series 集
                cht.DataSource = dt; // 把剛剛讀的 dt 匯入
                cht.DataBind(); // 連接 XValueMember, YValueMembers 和 DataSource

                // 確認圖表是否有數據
                Console.WriteLine($"Chart updated. Points count: {cht.Series[0].Points.Count}");
                foreach (var point in cht.Series[0].Points)
                {
                    Console.WriteLine($"X: {point.XValue}, Y: {point.YValues[0]}");
                }
            }
            CalculateTotalSales();
        }

        // 計算該時間段該產品的總銷售額
        private void CalculateTotalSales()
        {
            string strSQL = "";
            if (viewing == 0) { strSQL = @"
        SELECT 
            SUM(oi.產品金額 * oi.產品數量) AS 總銷售額
        FROM orders o
        JOIN orderitems oi ON o.訂單編號 = oi.訂單編號
        WHERE o.成立時間 BETWEEN @dtpFrom AND @dtpUntil"; }
            else if (viewing == 1) { strSQL = @"
        SELECT 
            SUM((oi.產品金額-p.進貨價格)*oi.產品數量) AS 總獲利
        FROM orders o
        JOIN orderitems oi ON o.訂單編號 = oi.訂單編號
        JOIN products AS p ON oi.產品編號 = p.產品編號
        WHERE o.成立時間 BETWEEN @dtpFrom AND @dtpUntil"; }
            // 檢查是否選擇了產品並確保其值為正確的型別
            if (cbxProduct.SelectedValue != null && cbxProduct.SelectedValue is int)
            {
                strSQL += " AND oi.產品編號 = @ProductID";
            }

            using (SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@dtpFrom", dtpFrom.Value);
                cmd.Parameters.AddWithValue("@dtpUntil", dtpUntil.Value);

                // 設定產品編號參數
                if (cbxProduct.SelectedValue != null && cbxProduct.SelectedValue is int)
                {
                    cmd.Parameters.AddWithValue("@ProductID", (int)cbxProduct.SelectedValue);
                }

                con.Open();
                object result = cmd.ExecuteScalar();
                // 檢查結果是否為 DBNull，並設定適當的值
                decimal totalSales = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                lblTotal.Text = $"NTD {totalSales}";
            }
        }

        // 計算全時間段內銷售額最高的產品
        private void CalculateBestSellingProduct()
        {
            string strSQL = @"
                SELECT TOP 1
                    p.產品名稱, 
                    SUM(oi.項目金額) AS 總銷售額
                FROM products p
                JOIN orderitems oi ON p.產品編號 = oi.產品編號
                JOIN orders o ON o.訂單編號 = oi.訂單編號
                GROUP BY p.產品名稱
                ORDER BY 總銷售額 DESC";

            using (SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblBestseller.Text = reader["產品名稱"].ToString();
                }
            }
        }
        // 計算全時間段內獲利最高的產品
        private void CalculateBestProfitProduct()
        {
            string strSQL = @"
                SELECT TOP 1
                    p.產品名稱, 
                    SUM((oi.產品金額-p.進貨價格)*oi.產品數量) AS 總獲利
                FROM products p
                JOIN orderitems oi ON p.產品編號 = oi.產品編號
                JOIN orders o ON o.訂單編號 = oi.訂單編號
                GROUP BY p.產品名稱
                ORDER BY 總獲利 DESC";

            using (SqlConnection con = new SqlConnection(GlobalVar.SqlConnectionString))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblbestprofitter.Text = reader["產品名稱"].ToString();
                }
            }
        }

        public FormSalesProfit()
        {
            InitializeComponent();
        }

        private void FormSalesProfit_Load(object sender, EventArgs e)
        {
            if (viewing == 0)
            {
                cbxView.SelectedIndex = 0;
            }
            else if (viewing == 1) 
            {
                cbxView.SelectedIndex = 1;
            }
            LoadProductsIntoComboBox(); // 初始化產品選擇清單
            UpdateChart(); // 初始化圖表
            CalculateBestSellingProduct();
            CalculateBestProfitProduct();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }

        private void dtpUntil_ValueChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }

        private void cbxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }
        private void cbxView_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewing = cbxView.SelectedIndex;
            UpdateChart();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

namespace 期中專題
{
    partial class FormSalesProfit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblbestprofitter = new System.Windows.Forms.Label();
            this.cbxView = new System.Windows.Forms.ComboBox();
            this.lblBestseller = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpUntil = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cht = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(12, 12);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(279, 36);
            this.lblUser.TabIndex = 39;
            this.lblUser.Text = "銷售額/獲利檢視系統";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.btnReturn.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReturn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnReturn.Location = new System.Drawing.Point(742, 509);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(146, 49);
            this.btnReturn.TabIndex = 46;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(447, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "獲利最高產品";
            // 
            // lblbestprofitter
            // 
            this.lblbestprofitter.AutoSize = true;
            this.lblbestprofitter.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblbestprofitter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblbestprofitter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblbestprofitter.Location = new System.Drawing.Point(426, 530);
            this.lblbestprofitter.Name = "lblbestprofitter";
            this.lblbestprofitter.Size = new System.Drawing.Size(174, 29);
            this.lblbestprofitter.TabIndex = 46;
            this.lblbestprofitter.Text = "Product Name";
            // 
            // cbxView
            // 
            this.cbxView.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxView.FormattingEnabled = true;
            this.cbxView.Items.AddRange(new object[] {
            "銷售額",
            "獲利"});
            this.cbxView.Location = new System.Drawing.Point(776, 14);
            this.cbxView.Name = "cbxView";
            this.cbxView.Size = new System.Drawing.Size(112, 33);
            this.cbxView.TabIndex = 46;
            this.cbxView.SelectedIndexChanged += new System.EventHandler(this.cbxView_SelectedIndexChanged);
            // 
            // lblBestseller
            // 
            this.lblBestseller.AutoSize = true;
            this.lblBestseller.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblBestseller.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBestseller.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBestseller.Location = new System.Drawing.Point(169, 530);
            this.lblBestseller.Name = "lblBestseller";
            this.lblBestseller.Size = new System.Drawing.Size(174, 29);
            this.lblBestseller.TabIndex = 48;
            this.lblBestseller.Text = "Product Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(180, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "銷售額最高產品";
            // 
            // cbxProduct
            // 
            this.cbxProduct.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(23, 12);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(326, 33);
            this.cbxProduct.TabIndex = 50;
            this.cbxProduct.SelectedIndexChanged += new System.EventHandler(this.cbxProduct_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbxProduct);
            this.panel1.Controls.Add(this.dtpUntil);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.cht);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 426);
            this.panel1.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(511, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 29);
            this.label5.TabIndex = 64;
            this.label5.Text = "期間銷售額/獲利:";
            // 
            // dtpUntil
            // 
            this.dtpUntil.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dtpUntil.Location = new System.Drawing.Point(484, 378);
            this.dtpUntil.Name = "dtpUntil";
            this.dtpUntil.Size = new System.Drawing.Size(265, 34);
            this.dtpUntil.TabIndex = 63;
            this.dtpUntil.ValueChanged += new System.EventHandler(this.dtpUntil_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(436, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 29);
            this.label8.TabIndex = 62;
            this.label8.Text = "至";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFrom.Location = new System.Drawing.Point(156, 378);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(265, 34);
            this.dtpFrom.TabIndex = 61;
            this.dtpFrom.Value = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotal.Location = new System.Drawing.Point(707, 14);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(140, 29);
            this.lblTotal.TabIndex = 60;
            this.lblTotal.Text = "NTD 00000";
            // 
            // cht
            // 
            chartArea1.Name = "ChartArea1";
            this.cht.ChartAreas.Add(chartArea1);
            this.cht.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "lgdSales";
            legend1.TitleFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cht.Legends.Add(legend1);
            this.cht.Location = new System.Drawing.Point(23, 60);
            this.cht.Name = "cht";
            this.cht.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "lgdSales";
            series1.Name = "Series1";
            this.cht.Series.Add(series1);
            this.cht.Size = new System.Drawing.Size(824, 307);
            this.cht.TabIndex = 59;
            this.cht.Text = "銷售額";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(83, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 58;
            this.label1.Text = "日期";
            // 
            // FormSalesProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(120)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(900, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBestseller);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxView);
            this.Controls.Add(this.lblbestprofitter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblUser);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSalesProfit";
            this.Text = "銷售額及獲利";
            this.Load += new System.EventHandler(this.FormSalesProfit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblbestprofitter;
        private System.Windows.Forms.ComboBox cbxView;
        private System.Windows.Forms.Label lblBestseller;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpUntil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht;
        private System.Windows.Forms.Label label1;
    }
}
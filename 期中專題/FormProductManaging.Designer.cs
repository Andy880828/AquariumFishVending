namespace 期中專題
{
    partial class FormProductManaging
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
            this.components = new System.ComponentModel.Container();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lvwProduct = new System.Windows.Forms.ListView();
            this.lblUser = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.timer_forSearch = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(12, 567);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(104, 36);
            this.lblProduct.TabIndex = 57;
            this.lblProduct.Text = "共 X 項";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.Location = new System.Drawing.Point(842, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 59);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "新增商品";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.btnReturn.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReturn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnReturn.Location = new System.Drawing.Point(842, 580);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(146, 59);
            this.btnReturn.TabIndex = 53;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lvwProduct
            // 
            this.lvwProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.lvwProduct.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lvwProduct.HideSelection = false;
            this.lvwProduct.Location = new System.Drawing.Point(18, 70);
            this.lvwProduct.Name = "lvwProduct";
            this.lvwProduct.Size = new System.Drawing.Size(812, 494);
            this.lvwProduct.TabIndex = 52;
            this.lvwProduct.UseCompatibleStateImageBehavior = false;
            this.lvwProduct.ItemActivate += new System.EventHandler(this.lvwProduct_ItemActivate);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(12, 22);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(127, 36);
            this.lblUser.TabIndex = 51;
            this.lblUser.Text = "現有商品";
            // 
            // tbxSearch
            // 
            this.tbxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.tbxSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxSearch.Location = new System.Drawing.Point(554, 23);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(276, 34);
            this.tbxSearch.TabIndex = 58;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // timer_forSearch
            // 
            this.timer_forSearch.Interval = 500;
            this.timer_forSearch.Tick += new System.EventHandler(this.timer_forSearch_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(376, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 59;
            this.label1.Text = "依品名即時搜尋";
            // 
            // FormProductManaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lvwProduct);
            this.Controls.Add(this.lblUser);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProductManaging";
            this.Text = "商品管理";
            this.Activated += new System.EventHandler(this.FormProductManaging_Activated);
            this.Load += new System.EventHandler(this.FormProductManaging_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListView lvwProduct;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Timer timer_forSearch;
        private System.Windows.Forms.Label label1;
    }
}
namespace 期中專題
{
    partial class FormClientManaging
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
            this.lblClient = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lvwClient = new System.Windows.Forms.ListView();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.timer_forSearch = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Location = new System.Drawing.Point(12, 567);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(104, 36);
            this.lblClient.TabIndex = 50;
            this.lblClient.Text = "共 X 人";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.Location = new System.Drawing.Point(842, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 59);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "新增會員";
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
            this.btnReturn.TabIndex = 46;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lvwClient
            // 
            this.lvwClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.lvwClient.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lvwClient.HideSelection = false;
            this.lvwClient.Location = new System.Drawing.Point(18, 70);
            this.lvwClient.Name = "lvwClient";
            this.lvwClient.Size = new System.Drawing.Size(812, 494);
            this.lvwClient.TabIndex = 45;
            this.lvwClient.UseCompatibleStateImageBehavior = false;
            this.lvwClient.ItemActivate += new System.EventHandler(this.lvwClient_ItemActivate);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(12, 22);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(71, 36);
            this.lblUser.TabIndex = 44;
            this.lblUser.Text = "會員";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(376, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 52;
            this.label1.Text = "依姓名即時搜尋";
            // 
            // tbxSearch
            // 
            this.tbxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.tbxSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxSearch.Location = new System.Drawing.Point(554, 23);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(276, 34);
            this.tbxSearch.TabIndex = 51;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // timer_forSearch
            // 
            this.timer_forSearch.Interval = 500;
            this.timer_forSearch.Tick += new System.EventHandler(this.timer_forSearch_Tick);
            // 
            // FormClientManaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lvwClient);
            this.Controls.Add(this.lblUser);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormClientManaging";
            this.Text = "會員管理";
            this.Activated += new System.EventHandler(this.FormClientManaging_Activated);
            this.Load += new System.EventHandler(this.FormClientManaging_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListView lvwClient;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Timer timer_forSearch;
    }
}
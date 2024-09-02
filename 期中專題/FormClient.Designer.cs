namespace 期中專題
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lbxItemlist = new System.Windows.Forms.ListBox();
            this.cbxFamily = new System.Windows.Forms.ComboBox();
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHistoryorders = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timer_for_text = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(120)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblusername);
            this.panel1.Controls.Add(this.pbxUser);
            this.panel1.Controls.Add(this.btnCheckout);
            this.panel1.Controls.Add(this.lbxItemlist);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(776, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 660);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.btnLogout.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogout.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnLogout.Location = new System.Drawing.Point(16, 609);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(194, 39);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "登出";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(14, 535);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(198, 22);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "目前總金額: NTD 00000 ";
            // 
            // btnInfo
            // 
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(193, 66);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(30, 30);
            this.btnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInfo.TabIndex = 6;
            this.btnInfo.TabStop = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "購物清單";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblusername.ForeColor = System.Drawing.Color.White;
            this.lblusername.Location = new System.Drawing.Point(73, 18);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(102, 23);
            this.lblusername.TabIndex = 4;
            this.lblusername.Text = "UserName";
            // 
            // pbxUser
            // 
            this.pbxUser.Image = ((System.Drawing.Image)(resources.GetObject("pbxUser.Image")));
            this.pbxUser.Location = new System.Drawing.Point(3, 3);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(50, 50);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUser.TabIndex = 3;
            this.pbxUser.TabStop = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.btnCheckout.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheckout.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCheckout.Location = new System.Drawing.Point(16, 560);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(194, 39);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "結帳";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lbxItemlist
            // 
            this.lbxItemlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(120)))), ((int)(((byte)(140)))));
            this.lbxItemlist.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbxItemlist.ForeColor = System.Drawing.Color.White;
            this.lbxItemlist.FormattingEnabled = true;
            this.lbxItemlist.ItemHeight = 25;
            this.lbxItemlist.Location = new System.Drawing.Point(0, 99);
            this.lbxItemlist.Name = "lbxItemlist";
            this.lbxItemlist.Size = new System.Drawing.Size(226, 429);
            this.lbxItemlist.TabIndex = 0;
            // 
            // cbxFamily
            // 
            this.cbxFamily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.cbxFamily.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxFamily.FormattingEnabled = true;
            this.cbxFamily.Location = new System.Drawing.Point(132, 619);
            this.cbxFamily.Name = "cbxFamily";
            this.cbxFamily.Size = new System.Drawing.Size(494, 37);
            this.cbxFamily.TabIndex = 1;
            this.cbxFamily.SelectedIndexChanged += new System.EventHandler(this.cbxFamily_SelectedIndexChanged);
            // 
            // flpItems
            // 
            this.flpItems.AutoScroll = true;
            this.flpItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.flpItems.Location = new System.Drawing.Point(4, 53);
            this.flpItems.Name = "flpItems";
            this.flpItems.Size = new System.Drawing.Size(768, 560);
            this.flpItems.TabIndex = 2;
            // 
            // btnHistoryorders
            // 
            this.btnHistoryorders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.btnHistoryorders.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHistoryorders.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnHistoryorders.Location = new System.Drawing.Point(621, 14);
            this.btnHistoryorders.Name = "btnHistoryorders";
            this.btnHistoryorders.Size = new System.Drawing.Size(144, 35);
            this.btnHistoryorders.TabIndex = 9;
            this.btnHistoryorders.Text = "歷史訂單查詢";
            this.btnHistoryorders.UseVisualStyleBackColor = false;
            this.btnHistoryorders.Click += new System.EventHandler(this.btnHistoryorders_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "觀賞魚清單";
            // 
            // timer_for_text
            // 
            this.timer_for_text.Interval = 1000;
            this.timer_for_text.Tick += new System.EventHandler(this.timer_for_text_Tick);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHistoryorders);
            this.Controls.Add(this.flpItems);
            this.Controls.Add(this.cbxFamily);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormClient";
            this.Text = "觀賞魚販賣";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbxItemlist;
        private System.Windows.Forms.ComboBox cbxFamily;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.PictureBox btnInfo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel flpItems;
        private System.Windows.Forms.Button btnHistoryorders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer_for_text;
    }
}
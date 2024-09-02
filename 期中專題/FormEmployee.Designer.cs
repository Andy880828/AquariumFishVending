namespace 期中專題
{
    partial class FormEmployee
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
            this.lblTime = new System.Windows.Forms.Label();
            this.btnOrderManaging = new System.Windows.Forms.Button();
            this.btnProductManaging = new System.Windows.Forms.Button();
            this.btnClientManaging = new System.Windows.Forms.Button();
            this.btnPunchView = new System.Windows.Forms.Button();
            this.btnEmployeeManaging = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEmployeeActivity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(423, 8);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(154, 22);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "2024/08/06 10:06";
            // 
            // btnOrderManaging
            // 
            this.btnOrderManaging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnOrderManaging.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderManaging.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnOrderManaging.Location = new System.Drawing.Point(22, 96);
            this.btnOrderManaging.Name = "btnOrderManaging";
            this.btnOrderManaging.Size = new System.Drawing.Size(283, 155);
            this.btnOrderManaging.TabIndex = 1;
            this.btnOrderManaging.Text = "訂單管理";
            this.btnOrderManaging.UseVisualStyleBackColor = false;
            this.btnOrderManaging.Click += new System.EventHandler(this.btnOrderManaging_Click);
            // 
            // btnProductManaging
            // 
            this.btnProductManaging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnProductManaging.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProductManaging.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnProductManaging.Location = new System.Drawing.Point(355, 96);
            this.btnProductManaging.Name = "btnProductManaging";
            this.btnProductManaging.Size = new System.Drawing.Size(283, 155);
            this.btnProductManaging.TabIndex = 2;
            this.btnProductManaging.Text = "商品管理";
            this.btnProductManaging.UseVisualStyleBackColor = false;
            this.btnProductManaging.Click += new System.EventHandler(this.btnProductManaging_Click);
            // 
            // btnClientManaging
            // 
            this.btnClientManaging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnClientManaging.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClientManaging.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnClientManaging.Location = new System.Drawing.Point(695, 96);
            this.btnClientManaging.Name = "btnClientManaging";
            this.btnClientManaging.Size = new System.Drawing.Size(283, 155);
            this.btnClientManaging.TabIndex = 3;
            this.btnClientManaging.Text = "顧客管理";
            this.btnClientManaging.UseVisualStyleBackColor = false;
            this.btnClientManaging.Click += new System.EventHandler(this.btnClientManaging_Click);
            // 
            // btnPunchView
            // 
            this.btnPunchView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnPunchView.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPunchView.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPunchView.Location = new System.Drawing.Point(22, 320);
            this.btnPunchView.Name = "btnPunchView";
            this.btnPunchView.Size = new System.Drawing.Size(283, 155);
            this.btnPunchView.TabIndex = 4;
            this.btnPunchView.Text = "打卡時間";
            this.btnPunchView.UseVisualStyleBackColor = false;
            this.btnPunchView.Click += new System.EventHandler(this.btnPunchView_Click);
            // 
            // btnEmployeeManaging
            // 
            this.btnEmployeeManaging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnEmployeeManaging.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEmployeeManaging.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEmployeeManaging.Location = new System.Drawing.Point(355, 320);
            this.btnEmployeeManaging.Name = "btnEmployeeManaging";
            this.btnEmployeeManaging.Size = new System.Drawing.Size(283, 155);
            this.btnEmployeeManaging.TabIndex = 5;
            this.btnEmployeeManaging.Text = "員工管理";
            this.btnEmployeeManaging.UseVisualStyleBackColor = false;
            this.btnEmployeeManaging.Click += new System.EventHandler(this.btnEmployeeManaging_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnStatus.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStatus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnStatus.Location = new System.Drawing.Point(695, 320);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(283, 155);
            this.btnStatus.TabIndex = 6;
            this.btnStatus.Text = "營業狀態";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnLogout.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogout.Location = new System.Drawing.Point(833, 594);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(155, 54);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "登出";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnEmployeeActivity
            // 
            this.btnEmployeeActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnEmployeeActivity.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEmployeeActivity.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEmployeeActivity.Location = new System.Drawing.Point(22, 320);
            this.btnEmployeeActivity.Name = "btnEmployeeActivity";
            this.btnEmployeeActivity.Size = new System.Drawing.Size(283, 155);
            this.btnEmployeeActivity.TabIndex = 8;
            this.btnEmployeeActivity.Text = "員工活動";
            this.btnEmployeeActivity.UseVisualStyleBackColor = false;
            this.btnEmployeeActivity.Click += new System.EventHandler(this.btnEmployeeActivity_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.btnEmployeeActivity);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnEmployeeManaging);
            this.Controls.Add(this.btnPunchView);
            this.Controls.Add(this.btnClientManaging);
            this.Controls.Add(this.btnProductManaging);
            this.Controls.Add(this.btnOrderManaging);
            this.Controls.Add(this.lblTime);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEmployee";
            this.Text = "管理介面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmployee_FormClosing);
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnOrderManaging;
        private System.Windows.Forms.Button btnProductManaging;
        private System.Windows.Forms.Button btnClientManaging;
        private System.Windows.Forms.Button btnPunchView;
        private System.Windows.Forms.Button btnEmployeeManaging;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnEmployeeActivity;
    }
}
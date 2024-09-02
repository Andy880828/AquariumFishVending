namespace 期中專題
{
    partial class FormClientChanging
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
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxLevel = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxAccount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxClientID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.btnModify.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnModify.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnModify.Location = new System.Drawing.Point(17, 505);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(146, 49);
            this.btnModify.TabIndex = 47;
            this.btnModify.Text = "確認修改";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.Location = new System.Drawing.Point(578, 505);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 49);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "確認新增";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.btnReturn.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReturn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnReturn.Location = new System.Drawing.Point(741, 505);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(146, 49);
            this.btnReturn.TabIndex = 45;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(14, 17);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(307, 36);
            this.lblUser.TabIndex = 44;
            this.lblUser.Text = "歡迎新增/修改會員資料";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.groupBox1.Controls.Add(this.cbxStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxLevel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbxAccount);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbxAddress);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbxEmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbxPhone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxPassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxClientID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(17, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 423);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "會員資料";
            // 
            // cbxStatus
            // 
            this.cbxStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "正常",
            "停權"});
            this.cbxStatus.Location = new System.Drawing.Point(519, 342);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(207, 37);
            this.cbxStatus.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(428, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "狀態";
            // 
            // cbxLevel
            // 
            this.cbxLevel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxLevel.FormattingEnabled = true;
            this.cbxLevel.Items.AddRange(new object[] {
            "VIP會員",
            "一般會員"});
            this.cbxLevel.Location = new System.Drawing.Point(161, 342);
            this.cbxLevel.Name = "cbxLevel";
            this.cbxLevel.Size = new System.Drawing.Size(207, 37);
            this.cbxLevel.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(54, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 29);
            this.label10.TabIndex = 41;
            this.label10.Text = "階級";
            // 
            // tbxAccount
            // 
            this.tbxAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.tbxAccount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxAccount.Location = new System.Drawing.Point(519, 54);
            this.tbxAccount.Name = "tbxAccount";
            this.tbxAccount.ReadOnly = true;
            this.tbxAccount.Size = new System.Drawing.Size(188, 34);
            this.tbxAccount.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(428, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 29);
            this.label9.TabIndex = 34;
            this.label9.Text = "帳號";
            // 
            // tbxAddress
            // 
            this.tbxAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.tbxAddress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxAddress.Location = new System.Drawing.Point(161, 270);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(349, 34);
            this.tbxAddress.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(54, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 29);
            this.label8.TabIndex = 32;
            this.label8.Text = "地址";
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.tbxEmail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxEmail.Location = new System.Drawing.Point(519, 198);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(272, 34);
            this.tbxEmail.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(428, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "Email";
            // 
            // tbxPhone
            // 
            this.tbxPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.tbxPhone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxPhone.Location = new System.Drawing.Point(161, 198);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(207, 34);
            this.tbxPhone.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(54, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "電話";
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.tbxPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxPassword.Location = new System.Drawing.Point(519, 126);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(188, 34);
            this.tbxPassword.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(428, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "密碼";
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.tbxName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxName.Location = new System.Drawing.Point(161, 126);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(207, 34);
            this.tbxName.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(54, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "姓名";
            // 
            // tbxClientID
            // 
            this.tbxClientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.tbxClientID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxClientID.Location = new System.Drawing.Point(161, 54);
            this.tbxClientID.Name = "tbxClientID";
            this.tbxClientID.ReadOnly = true;
            this.tbxClientID.Size = new System.Drawing.Size(207, 34);
            this.tbxClientID.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(31, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "會員編號";
            // 
            // FormClientChanging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(900, 570);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormClientChanging";
            this.Text = "新增或修改會員資料";
            this.Load += new System.EventHandler(this.FormClientChanging_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxLevel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxAccount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxClientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label1;
    }
}
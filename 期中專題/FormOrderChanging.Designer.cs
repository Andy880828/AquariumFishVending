namespace 期中專題
{
    partial class FormOrderChanging
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwOrderItem = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxEmployeeID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxClientName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxClientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxOrderID = new System.Windows.Forms.TextBox();
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
            this.lblUser.Size = new System.Drawing.Size(183, 36);
            this.lblUser.TabIndex = 44;
            this.lblUser.Text = "歡迎修改訂單";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.groupBox1.Controls.Add(this.lvwOrderItem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxEmployeeID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbxTotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxClientName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxClientID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxOrderID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(17, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 423);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "訂單資料";
            // 
            // lvwOrderItem
            // 
            this.lvwOrderItem.HideSelection = false;
            this.lvwOrderItem.Location = new System.Drawing.Point(412, 148);
            this.lvwOrderItem.Name = "lvwOrderItem";
            this.lvwOrderItem.Size = new System.Drawing.Size(394, 245);
            this.lvwOrderItem.TabIndex = 44;
            this.lvwOrderItem.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(556, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 42;
            this.label4.Text = "訂單內容";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(161, 279);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(207, 38);
            this.dtpDate.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(31, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "成立時間";
            // 
            // tbxEmployeeID
            // 
            this.tbxEmployeeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.tbxEmployeeID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxEmployeeID.Location = new System.Drawing.Point(575, 51);
            this.tbxEmployeeID.Name = "tbxEmployeeID";
            this.tbxEmployeeID.ReadOnly = true;
            this.tbxEmployeeID.Size = new System.Drawing.Size(231, 34);
            this.tbxEmployeeID.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(407, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 29);
            this.label9.TabIndex = 34;
            this.label9.Text = "負責員工編號";
            // 
            // tbxTotal
            // 
            this.tbxTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.tbxTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxTotal.Location = new System.Drawing.Point(161, 359);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(207, 34);
            this.tbxTotal.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(42, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "總金額";
            // 
            // tbxClientName
            // 
            this.tbxClientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.tbxClientName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxClientName.Location = new System.Drawing.Point(161, 203);
            this.tbxClientName.Name = "tbxClientName";
            this.tbxClientName.Size = new System.Drawing.Size(207, 34);
            this.tbxClientName.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(31, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "會員姓名";
            // 
            // tbxClientID
            // 
            this.tbxClientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.tbxClientID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxClientID.Location = new System.Drawing.Point(161, 127);
            this.tbxClientID.Name = "tbxClientID";
            this.tbxClientID.Size = new System.Drawing.Size(207, 34);
            this.tbxClientID.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(8, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "下訂會員編號";
            // 
            // tbxOrderID
            // 
            this.tbxOrderID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.tbxOrderID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxOrderID.Location = new System.Drawing.Point(161, 51);
            this.tbxOrderID.Name = "tbxOrderID";
            this.tbxOrderID.ReadOnly = true;
            this.tbxOrderID.Size = new System.Drawing.Size(207, 34);
            this.tbxOrderID.TabIndex = 23;
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
            this.label2.Text = "訂單編號";
            // 
            // FormOrderChanging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(900, 570);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOrderChanging";
            this.Text = "修改訂單";
            this.Load += new System.EventHandler(this.FormOrderChanging_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEmployeeID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxClientName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxClientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvwOrderItem;
    }
}
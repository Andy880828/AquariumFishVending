namespace 期中專題
{
    partial class FormPunch
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lvwPunch = new System.Windows.Forms.ListView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDayCum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMonthCum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "打卡紀錄 for";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEmployee.ForeColor = System.Drawing.Color.White;
            this.lblEmployee.Location = new System.Drawing.Point(191, 9);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(231, 36);
            this.lblEmployee.TabIndex = 11;
            this.lblEmployee.Text = "EmployeeName";
            // 
            // lvwPunch
            // 
            this.lvwPunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.lvwPunch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lvwPunch.HideSelection = false;
            this.lvwPunch.Location = new System.Drawing.Point(12, 58);
            this.lvwPunch.Name = "lvwPunch";
            this.lvwPunch.Size = new System.Drawing.Size(678, 496);
            this.lvwPunch.TabIndex = 53;
            this.lvwPunch.UseCompatibleStateImageBehavior = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.btnReturn.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReturn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnReturn.Location = new System.Drawing.Point(724, 494);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(146, 59);
            this.btnReturn.TabIndex = 54;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(722, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 55;
            this.label2.Text = "本日累積時數";
            // 
            // lblDayCum
            // 
            this.lblDayCum.AutoSize = true;
            this.lblDayCum.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDayCum.ForeColor = System.Drawing.Color.White;
            this.lblDayCum.Location = new System.Drawing.Point(719, 129);
            this.lblDayCum.Name = "lblDayCum";
            this.lblDayCum.Size = new System.Drawing.Size(156, 29);
            this.lblDayCum.TabIndex = 56;
            this.lblDayCum.Text = "共 00.00 小時";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(722, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 29);
            this.label5.TabIndex = 57;
            this.label5.Text = "本月累積時數";
            // 
            // lblMonthCum
            // 
            this.lblMonthCum.AutoSize = true;
            this.lblMonthCum.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMonthCum.ForeColor = System.Drawing.Color.White;
            this.lblMonthCum.Location = new System.Drawing.Point(719, 347);
            this.lblMonthCum.Name = "lblMonthCum";
            this.lblMonthCum.Size = new System.Drawing.Size(156, 29);
            this.lblMonthCum.TabIndex = 58;
            this.lblMonthCum.Text = "共 00.00 小時";
            // 
            // FormPunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(900, 570);
            this.Controls.Add(this.lblMonthCum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDayCum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lvwPunch);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPunch";
            this.Text = "打卡時間確認";
            this.Load += new System.EventHandler(this.FormPunch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ListView lvwPunch;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDayCum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMonthCum;
    }
}
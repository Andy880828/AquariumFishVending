namespace 期中專題
{
    partial class FormLogin
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.顧客 = new System.Windows.Forms.TabPage();
            this.tbxPasswordC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAccountC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.員工 = new System.Windows.Forms.TabPage();
            this.tbxPasswordE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxAccountE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.顧客.SuspendLayout();
            this.員工.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnLogin.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.Location = new System.Drawing.Point(188, 444);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(157, 53);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.顧客);
            this.tabControl1.Controls.Add(this.員工);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(12, 135);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 201);
            this.tabControl1.TabIndex = 1;
            // 
            // 顧客
            // 
            this.顧客.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.顧客.Controls.Add(this.tbxPasswordC);
            this.顧客.Controls.Add(this.label2);
            this.顧客.Controls.Add(this.tbxAccountC);
            this.顧客.Controls.Add(this.label1);
            this.顧客.Location = new System.Drawing.Point(4, 31);
            this.顧客.Name = "顧客";
            this.顧客.Padding = new System.Windows.Forms.Padding(3);
            this.顧客.Size = new System.Drawing.Size(501, 166);
            this.顧客.TabIndex = 0;
            this.顧客.Text = "顧客";
            // 
            // tbxPasswordC
            // 
            this.tbxPasswordC.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxPasswordC.Location = new System.Drawing.Point(126, 98);
            this.tbxPasswordC.Name = "tbxPasswordC";
            this.tbxPasswordC.PasswordChar = '*';
            this.tbxPasswordC.Size = new System.Drawing.Size(304, 34);
            this.tbxPasswordC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "密碼";
            // 
            // tbxAccountC
            // 
            this.tbxAccountC.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxAccountC.Location = new System.Drawing.Point(126, 33);
            this.tbxAccountC.Name = "tbxAccountC";
            this.tbxAccountC.Size = new System.Drawing.Size(304, 34);
            this.tbxAccountC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號";
            // 
            // 員工
            // 
            this.員工.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.員工.Controls.Add(this.tbxPasswordE);
            this.員工.Controls.Add(this.label3);
            this.員工.Controls.Add(this.tbxAccountE);
            this.員工.Controls.Add(this.label4);
            this.員工.Location = new System.Drawing.Point(4, 31);
            this.員工.Name = "員工";
            this.員工.Padding = new System.Windows.Forms.Padding(3);
            this.員工.Size = new System.Drawing.Size(501, 166);
            this.員工.TabIndex = 1;
            this.員工.Text = "員工";
            // 
            // tbxPasswordE
            // 
            this.tbxPasswordE.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxPasswordE.Location = new System.Drawing.Point(126, 98);
            this.tbxPasswordE.Name = "tbxPasswordE";
            this.tbxPasswordE.PasswordChar = '*';
            this.tbxPasswordE.Size = new System.Drawing.Size(304, 34);
            this.tbxPasswordE.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(31, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "密碼";
            // 
            // tbxAccountE
            // 
            this.tbxAccountE.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxAccountE.Location = new System.Drawing.Point(126, 33);
            this.tbxAccountE.Name = "tbxAccountE";
            this.tbxAccountE.Size = new System.Drawing.Size(304, 34);
            this.tbxAccountE.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(31, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "帳號";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(164, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 47);
            this.label5.TabIndex = 8;
            this.label5.Text = "觀賞魚販賣\r\n";
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnSignup.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(409, 338);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(112, 34);
            this.btnSignup.TabIndex = 9;
            this.btnSignup.Text = "註冊會員";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(533, 533);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogin);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.FormLogin_Activated);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.tabControl1.ResumeLayout(false);
            this.顧客.ResumeLayout(false);
            this.顧客.PerformLayout();
            this.員工.ResumeLayout(false);
            this.員工.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 顧客;
        private System.Windows.Forms.TabPage 員工;
        private System.Windows.Forms.TextBox tbxPasswordC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAccountC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPasswordE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxAccountE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSignup;
    }
}


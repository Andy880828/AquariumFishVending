namespace 期中專題
{
    partial class UserControlFish
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlFish));
            this.pbxFish = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.btnMinus = new System.Windows.Forms.PictureBox();
            this.tbxCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxFish
            // 
            this.pbxFish.Location = new System.Drawing.Point(28, 28);
            this.pbxFish.Name = "pbxFish";
            this.pbxFish.Size = new System.Drawing.Size(125, 125);
            this.pbxFish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFish.TabIndex = 0;
            this.pbxFish.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(3, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "FishName";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInfo
            // 
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(152, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(25, 25);
            this.btnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInfo.TabIndex = 2;
            this.btnInfo.TabStop = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(152, 152);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 3;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Image = ((System.Drawing.Image)(resources.GetObject("btnMinus.Image")));
            this.btnMinus.Location = new System.Drawing.Point(3, 152);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(25, 25);
            this.btnMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinus.TabIndex = 4;
            this.btnMinus.TabStop = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // tbxCount
            // 
            this.tbxCount.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxCount.Location = new System.Drawing.Point(61, 154);
            this.tbxCount.Name = "tbxCount";
            this.tbxCount.Size = new System.Drawing.Size(59, 30);
            this.tbxCount.TabIndex = 5;
            this.tbxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxCount.TextChanged += new System.EventHandler(this.tbxCount_TextChanged);
            // 
            // UserControlFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.tbxCount);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbxFish);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "UserControlFish";
            this.Size = new System.Drawing.Size(180, 180);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbxFish;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox tbxCount;
        private System.Windows.Forms.PictureBox btnInfo;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.PictureBox btnMinus;
    }
}

namespace 期中專題
{
    partial class FormOrderManaging
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
            this.lblOrder = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lvwOrder = new System.Windows.Forms.ListView();
            this.lblUser = new System.Windows.Forms.Label();
            this.dtpUntil = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrder.ForeColor = System.Drawing.Color.White;
            this.lblOrder.Location = new System.Drawing.Point(12, 567);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(104, 36);
            this.lblOrder.TabIndex = 57;
            this.lblOrder.Text = "共 X 單";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelete.Location = new System.Drawing.Point(842, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 59);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "刪除訂單";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            // lvwOrder
            // 
            this.lvwOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.lvwOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lvwOrder.HideSelection = false;
            this.lvwOrder.Location = new System.Drawing.Point(18, 70);
            this.lvwOrder.Name = "lvwOrder";
            this.lvwOrder.Size = new System.Drawing.Size(812, 494);
            this.lvwOrder.TabIndex = 52;
            this.lvwOrder.UseCompatibleStateImageBehavior = false;
            this.lvwOrder.ItemActivate += new System.EventHandler(this.lvwOrder_ItemActivate);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(12, 22);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(71, 36);
            this.lblUser.TabIndex = 51;
            this.lblUser.Text = "訂單";
            // 
            // dtpUntil
            // 
            this.dtpUntil.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dtpUntil.Location = new System.Drawing.Point(543, 591);
            this.dtpUntil.Name = "dtpUntil";
            this.dtpUntil.Size = new System.Drawing.Size(265, 34);
            this.dtpUntil.TabIndex = 61;
            this.dtpUntil.ValueChanged += new System.EventHandler(this.dtpUntil_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(493, 594);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 29);
            this.label8.TabIndex = 60;
            this.label8.Text = "至";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFrom.Location = new System.Drawing.Point(215, 591);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(265, 34);
            this.dtpFrom.TabIndex = 59;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(142, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 58;
            this.label1.Text = "日期";
            // 
            // FormOrderManaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.dtpUntil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lvwOrder);
            this.Controls.Add(this.lblUser);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOrderManaging";
            this.Text = "訂單管理";
            this.Activated += new System.EventHandler(this.FormOrderManaging_Activated);
            this.Load += new System.EventHandler(this.FormOrderManaging_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListView lvwOrder;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DateTimePicker dtpUntil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
    }
}
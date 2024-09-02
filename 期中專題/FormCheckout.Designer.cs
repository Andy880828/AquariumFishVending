namespace 期中專題
{
    partial class FormCheckout
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
            this.lvwCart = new System.Windows.Forms.ListView();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "您的購物車";
            // 
            // lvwCart
            // 
            this.lvwCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.lvwCart.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lvwCart.HideSelection = false;
            this.lvwCart.Location = new System.Drawing.Point(18, 52);
            this.lvwCart.MultiSelect = false;
            this.lvwCart.Name = "lvwCart";
            this.lvwCart.Size = new System.Drawing.Size(718, 501);
            this.lvwCart.TabIndex = 11;
            this.lvwCart.UseCompatibleStateImageBehavior = false;
            this.lvwCart.View = System.Windows.Forms.View.Details;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.btnCheckout.Font = new System.Drawing.Font("微軟正黑體", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheckout.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCheckout.Location = new System.Drawing.Point(746, 478);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(146, 75);
            this.btnCheckout.TabIndex = 19;
            this.btnCheckout.Text = "確認結帳";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.btnReturn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReturn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnReturn.Location = new System.Drawing.Point(746, 52);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(146, 59);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "繼續選購";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(778, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "總金額";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(749, 446);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(140, 29);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "NTD 00000";
            // 
            // FormCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(900, 570);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lvwCart);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCheckout";
            this.Text = "結帳";
            this.Load += new System.EventHandler(this.FormCheckout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvwCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
    }
}
namespace 期中專題
{
    partial class FormEmployeeActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployeeActivity));
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxEmployee = new System.Windows.Forms.ComboBox();
            this.lvwPresence = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            resources.ApplyResources(this.btnReturn, "btnReturn");
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.btnReturn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblUser
            // 
            resources.ApplyResources(this.lblUser, "lblUser");
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Name = "lblUser";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // cbxEmployee
            // 
            resources.ApplyResources(this.cbxEmployee, "cbxEmployee");
            this.cbxEmployee.FormattingEnabled = true;
            this.cbxEmployee.Name = "cbxEmployee";
            this.cbxEmployee.SelectedIndexChanged += new System.EventHandler(this.cbxEmployee_SelectedIndexChanged);
            // 
            // lvwPresence
            // 
            resources.ApplyResources(this.lvwPresence, "lvwPresence");
            this.lvwPresence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.lvwPresence.HideSelection = false;
            this.lvwPresence.Name = "lvwPresence";
            this.lvwPresence.UseCompatibleStateImageBehavior = false;
            // 
            // FormEmployeeActivity
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.Controls.Add(this.lvwPresence);
            this.Controls.Add(this.cbxEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnReturn);
            this.Name = "FormEmployeeActivity";
            this.Load += new System.EventHandler(this.FormEmployeeActivity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxEmployee;
        private System.Windows.Forms.ListView lvwPresence;
    }
}
namespace Cafe_Management_System
{
    partial class Home
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
            this.AdminLog = new System.Windows.Forms.Button();
            this.ManagerLog = new System.Windows.Forms.Button();
            this.CustomerLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminLog
            // 
            this.AdminLog.Location = new System.Drawing.Point(83, 122);
            this.AdminLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AdminLog.Name = "AdminLog";
            this.AdminLog.Size = new System.Drawing.Size(100, 28);
            this.AdminLog.TabIndex = 0;
            this.AdminLog.Text = "Admin";
            this.AdminLog.UseVisualStyleBackColor = true;
            this.AdminLog.Click += new System.EventHandler(this.AdminLog_Click);
            // 
            // ManagerLog
            // 
            this.ManagerLog.Location = new System.Drawing.Point(83, 178);
            this.ManagerLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ManagerLog.Name = "ManagerLog";
            this.ManagerLog.Size = new System.Drawing.Size(100, 28);
            this.ManagerLog.TabIndex = 1;
            this.ManagerLog.Text = "Manager";
            this.ManagerLog.UseVisualStyleBackColor = true;
            this.ManagerLog.Click += new System.EventHandler(this.ManagerLog_Click);
            // 
            // CustomerLog
            // 
            this.CustomerLog.Location = new System.Drawing.Point(83, 241);
            this.CustomerLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerLog.Name = "CustomerLog";
            this.CustomerLog.Size = new System.Drawing.Size(100, 28);
            this.CustomerLog.TabIndex = 2;
            this.CustomerLog.Text = "Customer";
            this.CustomerLog.UseVisualStyleBackColor = true;
            this.CustomerLog.Click += new System.EventHandler(this.button3_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.CustomerLog);
            this.Controls.Add(this.ManagerLog);
            this.Controls.Add(this.AdminLog);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminLog;
        private System.Windows.Forms.Button ManagerLog;
        private System.Windows.Forms.Button CustomerLog;
    }
}
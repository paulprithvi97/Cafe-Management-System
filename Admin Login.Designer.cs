namespace Cafe_Management_System
{
    partial class Admin_Login
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
            this.AdminPass = new System.Windows.Forms.TextBox();
            this.AdminLogin = new System.Windows.Forms.Button();
            this.AdLogBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminPass
            // 
            this.AdminPass.Location = new System.Drawing.Point(79, 116);
            this.AdminPass.Name = "AdminPass";
            this.AdminPass.PasswordChar = '*';
            this.AdminPass.Size = new System.Drawing.Size(100, 20);
            this.AdminPass.TabIndex = 0;
            // 
            // AdminLogin
            // 
            this.AdminLogin.Location = new System.Drawing.Point(50, 142);
            this.AdminLogin.Name = "AdminLogin";
            this.AdminLogin.Size = new System.Drawing.Size(75, 23);
            this.AdminLogin.TabIndex = 1;
            this.AdminLogin.Text = "Sign In";
            this.AdminLogin.UseVisualStyleBackColor = true;
            this.AdminLogin.Click += new System.EventHandler(this.AdminLogin_Click);
            // 
            // AdLogBack
            // 
            this.AdLogBack.Location = new System.Drawing.Point(131, 142);
            this.AdLogBack.Name = "AdLogBack";
            this.AdLogBack.Size = new System.Drawing.Size(75, 23);
            this.AdLogBack.TabIndex = 2;
            this.AdLogBack.Text = "Back";
            this.AdLogBack.UseVisualStyleBackColor = true;
            this.AdLogBack.Click += new System.EventHandler(this.AdLogBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // Admin_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdLogBack);
            this.Controls.Add(this.AdminLogin);
            this.Controls.Add(this.AdminPass);
            this.Name = "Admin_Login";
            this.Text = "Admin_Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdminPass;
        private System.Windows.Forms.Button AdminLogin;
        private System.Windows.Forms.Button AdLogBack;
        private System.Windows.Forms.Label label1;
    }
}
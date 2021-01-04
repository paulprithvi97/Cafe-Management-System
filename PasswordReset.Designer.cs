namespace Cafe_Management_System
{
    partial class PasswordReset
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
            this.AdminCurrentPass = new System.Windows.Forms.TextBox();
            this.AdminNewPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassRes = new System.Windows.Forms.Button();
            this.PassResBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminCurrentPass
            // 
            this.AdminCurrentPass.Location = new System.Drawing.Point(78, 86);
            this.AdminCurrentPass.Name = "AdminCurrentPass";
            this.AdminCurrentPass.Size = new System.Drawing.Size(100, 20);
            this.AdminCurrentPass.TabIndex = 0;
            // 
            // AdminNewPass
            // 
            this.AdminNewPass.Location = new System.Drawing.Point(78, 129);
            this.AdminNewPass.Name = "AdminNewPass";
            this.AdminNewPass.Size = new System.Drawing.Size(100, 20);
            this.AdminNewPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Password";
            // 
            // PassRes
            // 
            this.PassRes.Location = new System.Drawing.Point(47, 155);
            this.PassRes.Name = "PassRes";
            this.PassRes.Size = new System.Drawing.Size(75, 23);
            this.PassRes.TabIndex = 4;
            this.PassRes.Text = "Reset";
            this.PassRes.UseVisualStyleBackColor = true;
            this.PassRes.Click += new System.EventHandler(this.PassRes_Click);
            // 
            // PassResBack
            // 
            this.PassResBack.Location = new System.Drawing.Point(128, 155);
            this.PassResBack.Name = "PassResBack";
            this.PassResBack.Size = new System.Drawing.Size(75, 23);
            this.PassResBack.TabIndex = 5;
            this.PassResBack.Text = "Back";
            this.PassResBack.UseVisualStyleBackColor = true;
            this.PassResBack.Click += new System.EventHandler(this.PassResBack_Click);
            // 
            // PasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PassResBack);
            this.Controls.Add(this.PassRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminNewPass);
            this.Controls.Add(this.AdminCurrentPass);
            this.Name = "PasswordReset";
            this.Text = "PasswordReset";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PasswordReset_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdminCurrentPass;
        private System.Windows.Forms.TextBox AdminNewPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PassRes;
        private System.Windows.Forms.Button PassResBack;
    }
}
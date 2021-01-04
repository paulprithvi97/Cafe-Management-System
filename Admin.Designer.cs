namespace Cafe_Management_System
{
    partial class Admin
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
            this.EmpReg = new System.Windows.Forms.Button();
            this.ManagerReg = new System.Windows.Forms.Button();
            this.CustomerInfo = new System.Windows.Forms.Button();
            this.AdminPassReset = new System.Windows.Forms.Button();
            this.AdminLogout = new System.Windows.Forms.Button();
            this.EmployeeList = new System.Windows.Forms.DataGridView();
            this.FoodList = new System.Windows.Forms.DataGridView();
            this.FoodView = new System.Windows.Forms.Button();
            this.EmployeeView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodList)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpReg
            // 
            this.EmpReg.Location = new System.Drawing.Point(24, 106);
            this.EmpReg.Name = "EmpReg";
            this.EmpReg.Size = new System.Drawing.Size(75, 23);
            this.EmpReg.TabIndex = 0;
            this.EmpReg.Text = "Employee";
            this.EmpReg.UseVisualStyleBackColor = true;
            this.EmpReg.Click += new System.EventHandler(this.EmpReg_Click);
            // 
            // ManagerReg
            // 
            this.ManagerReg.Location = new System.Drawing.Point(24, 171);
            this.ManagerReg.Name = "ManagerReg";
            this.ManagerReg.Size = new System.Drawing.Size(75, 23);
            this.ManagerReg.TabIndex = 1;
            this.ManagerReg.Text = "Manager";
            this.ManagerReg.UseVisualStyleBackColor = true;
            // 
            // CustomerInfo
            // 
            this.CustomerInfo.Location = new System.Drawing.Point(24, 233);
            this.CustomerInfo.Name = "CustomerInfo";
            this.CustomerInfo.Size = new System.Drawing.Size(75, 23);
            this.CustomerInfo.TabIndex = 2;
            this.CustomerInfo.Text = "Customer";
            this.CustomerInfo.UseVisualStyleBackColor = true;
            // 
            // AdminPassReset
            // 
            this.AdminPassReset.Location = new System.Drawing.Point(24, 303);
            this.AdminPassReset.Name = "AdminPassReset";
            this.AdminPassReset.Size = new System.Drawing.Size(75, 23);
            this.AdminPassReset.TabIndex = 3;
            this.AdminPassReset.Text = "Reset Password";
            this.AdminPassReset.UseVisualStyleBackColor = true;
            this.AdminPassReset.Click += new System.EventHandler(this.AdminPassReset_Click);
            // 
            // AdminLogout
            // 
            this.AdminLogout.Location = new System.Drawing.Point(24, 360);
            this.AdminLogout.Name = "AdminLogout";
            this.AdminLogout.Size = new System.Drawing.Size(75, 23);
            this.AdminLogout.TabIndex = 4;
            this.AdminLogout.Text = "Sign Out";
            this.AdminLogout.UseVisualStyleBackColor = true;
            // 
            // EmployeeList
            // 
            this.EmployeeList.AllowUserToAddRows = false;
            this.EmployeeList.AllowUserToDeleteRows = false;
            this.EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeList.Location = new System.Drawing.Point(258, 47);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.ReadOnly = true;
            this.EmployeeList.Size = new System.Drawing.Size(216, 378);
            this.EmployeeList.TabIndex = 5;
            this.EmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeList_CellContentClick);
            // 
            // FoodList
            // 
            this.FoodList.AllowUserToAddRows = false;
            this.FoodList.AllowUserToDeleteRows = false;
            this.FoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoodList.Location = new System.Drawing.Point(492, 47);
            this.FoodList.Name = "FoodList";
            this.FoodList.ReadOnly = true;
            this.FoodList.Size = new System.Drawing.Size(216, 378);
            this.FoodList.TabIndex = 6;
            // 
            // FoodView
            // 
            this.FoodView.Location = new System.Drawing.Point(633, 431);
            this.FoodView.Name = "FoodView";
            this.FoodView.Size = new System.Drawing.Size(75, 23);
            this.FoodView.TabIndex = 7;
            this.FoodView.Text = "View";
            this.FoodView.UseVisualStyleBackColor = true;
            // 
            // EmployeeView
            // 
            this.EmployeeView.Location = new System.Drawing.Point(399, 431);
            this.EmployeeView.Name = "EmployeeView";
            this.EmployeeView.Size = new System.Drawing.Size(75, 23);
            this.EmployeeView.TabIndex = 8;
            this.EmployeeView.Text = "View";
            this.EmployeeView.UseVisualStyleBackColor = true;
            this.EmployeeView.Click += new System.EventHandler(this.EmployeeView_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.EmployeeView);
            this.Controls.Add(this.FoodView);
            this.Controls.Add(this.FoodList);
            this.Controls.Add(this.EmployeeList);
            this.Controls.Add(this.AdminLogout);
            this.Controls.Add(this.AdminPassReset);
            this.Controls.Add(this.CustomerInfo);
            this.Controls.Add(this.ManagerReg);
            this.Controls.Add(this.EmpReg);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EmpReg;
        private System.Windows.Forms.Button ManagerReg;
        private System.Windows.Forms.Button CustomerInfo;
        private System.Windows.Forms.Button AdminPassReset;
        private System.Windows.Forms.Button AdminLogout;
        private System.Windows.Forms.DataGridView EmployeeList;
        private System.Windows.Forms.DataGridView FoodList;
        private System.Windows.Forms.Button FoodView;
        private System.Windows.Forms.Button EmployeeView;
    }
}
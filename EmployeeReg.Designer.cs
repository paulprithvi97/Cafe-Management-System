namespace Cafe_Management_System
{
    partial class EmployeeReg
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
            this.EmployeeList = new System.Windows.Forms.DataGridView();
            this.EmpPassword = new System.Windows.Forms.TextBox();
            this.EmpEmail = new System.Windows.Forms.TextBox();
            this.EmpPhone = new System.Windows.Forms.TextBox();
            this.EmpAddress = new System.Windows.Forms.TextBox();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.EmpGender = new System.Windows.Forms.ComboBox();
            this.EmpPosition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmpPhoto = new System.Windows.Forms.PictureBox();
            this.EmpAdd = new System.Windows.Forms.Button();
            this.EmpUpdate = new System.Windows.Forms.Button();
            this.EmpDelete = new System.Windows.Forms.Button();
            this.EmpBack = new System.Windows.Forms.Button();
            this.EmployeeView = new System.Windows.Forms.Button();
            this.ImgBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeList
            // 
            this.EmployeeList.AllowUserToAddRows = false;
            this.EmployeeList.AllowUserToDeleteRows = false;
            this.EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeList.Location = new System.Drawing.Point(26, 40);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.ReadOnly = true;
            this.EmployeeList.Size = new System.Drawing.Size(216, 378);
            this.EmployeeList.TabIndex = 6;
            this.EmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeList_CellContentClick);
            // 
            // EmpPassword
            // 
            this.EmpPassword.Location = new System.Drawing.Point(397, 229);
            this.EmpPassword.Name = "EmpPassword";
            this.EmpPassword.Size = new System.Drawing.Size(100, 20);
            this.EmpPassword.TabIndex = 7;
            // 
            // EmpEmail
            // 
            this.EmpEmail.Location = new System.Drawing.Point(397, 180);
            this.EmpEmail.Name = "EmpEmail";
            this.EmpEmail.Size = new System.Drawing.Size(100, 20);
            this.EmpEmail.TabIndex = 8;
            // 
            // EmpPhone
            // 
            this.EmpPhone.Location = new System.Drawing.Point(397, 132);
            this.EmpPhone.Name = "EmpPhone";
            this.EmpPhone.Size = new System.Drawing.Size(100, 20);
            this.EmpPhone.TabIndex = 9;
            // 
            // EmpAddress
            // 
            this.EmpAddress.Location = new System.Drawing.Point(397, 83);
            this.EmpAddress.Name = "EmpAddress";
            this.EmpAddress.Size = new System.Drawing.Size(100, 20);
            this.EmpAddress.TabIndex = 10;
            // 
            // EmpName
            // 
            this.EmpName.Location = new System.Drawing.Point(397, 40);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(100, 20);
            this.EmpName.TabIndex = 11;
            // 
            // EmpGender
            // 
            this.EmpGender.FormattingEnabled = true;
            this.EmpGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpGender.Location = new System.Drawing.Point(397, 280);
            this.EmpGender.Name = "EmpGender";
            this.EmpGender.Size = new System.Drawing.Size(121, 21);
            this.EmpGender.TabIndex = 12;
            // 
            // EmpPosition
            // 
            this.EmpPosition.FormattingEnabled = true;
            this.EmpPosition.Items.AddRange(new object[] {
            "Manager",
            "Staff"});
            this.EmpPosition.Location = new System.Drawing.Point(397, 334);
            this.EmpPosition.Name = "EmpPosition";
            this.EmpPosition.Size = new System.Drawing.Size(121, 21);
            this.EmpPosition.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Position";
            // 
            // EmpPhoto
            // 
            this.EmpPhoto.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.EmpPhoto.Location = new System.Drawing.Point(605, 96);
            this.EmpPhoto.Name = "EmpPhoto";
            this.EmpPhoto.Size = new System.Drawing.Size(110, 121);
            this.EmpPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmpPhoto.TabIndex = 21;
            this.EmpPhoto.TabStop = false;
            // 
            // EmpAdd
            // 
            this.EmpAdd.Location = new System.Drawing.Point(313, 395);
            this.EmpAdd.Name = "EmpAdd";
            this.EmpAdd.Size = new System.Drawing.Size(75, 23);
            this.EmpAdd.TabIndex = 23;
            this.EmpAdd.Text = "Add";
            this.EmpAdd.UseVisualStyleBackColor = true;
            this.EmpAdd.Click += new System.EventHandler(this.EmpAdd_Click);
            // 
            // EmpUpdate
            // 
            this.EmpUpdate.Location = new System.Drawing.Point(397, 395);
            this.EmpUpdate.Name = "EmpUpdate";
            this.EmpUpdate.Size = new System.Drawing.Size(75, 23);
            this.EmpUpdate.TabIndex = 24;
            this.EmpUpdate.Text = "Update";
            this.EmpUpdate.UseVisualStyleBackColor = true;
            this.EmpUpdate.Click += new System.EventHandler(this.EmpUpdate_Click);
            // 
            // EmpDelete
            // 
            this.EmpDelete.Location = new System.Drawing.Point(478, 395);
            this.EmpDelete.Name = "EmpDelete";
            this.EmpDelete.Size = new System.Drawing.Size(75, 23);
            this.EmpDelete.TabIndex = 25;
            this.EmpDelete.Text = "Delete";
            this.EmpDelete.UseVisualStyleBackColor = true;
            this.EmpDelete.Click += new System.EventHandler(this.EmpDelete_Click);
            // 
            // EmpBack
            // 
            this.EmpBack.Location = new System.Drawing.Point(640, 395);
            this.EmpBack.Name = "EmpBack";
            this.EmpBack.Size = new System.Drawing.Size(75, 23);
            this.EmpBack.TabIndex = 26;
            this.EmpBack.Text = "Back";
            this.EmpBack.UseVisualStyleBackColor = true;
            this.EmpBack.Click += new System.EventHandler(this.EmpBack_Click);
            // 
            // EmployeeView
            // 
            this.EmployeeView.Location = new System.Drawing.Point(559, 395);
            this.EmployeeView.Name = "EmployeeView";
            this.EmployeeView.Size = new System.Drawing.Size(75, 23);
            this.EmployeeView.TabIndex = 27;
            this.EmployeeView.Text = "View";
            this.EmployeeView.UseVisualStyleBackColor = true;
            this.EmployeeView.Click += new System.EventHandler(this.EmployeeView_Click);
            // 
            // ImgBrowse
            // 
            this.ImgBrowse.Location = new System.Drawing.Point(625, 232);
            this.ImgBrowse.Name = "ImgBrowse";
            this.ImgBrowse.Size = new System.Drawing.Size(75, 23);
            this.ImgBrowse.TabIndex = 28;
            this.ImgBrowse.Text = "Browse";
            this.ImgBrowse.UseVisualStyleBackColor = true;
            this.ImgBrowse.Click += new System.EventHandler(this.ImgBrowse_Click);
            // 
            // EmployeeReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.ImgBrowse);
            this.Controls.Add(this.EmployeeView);
            this.Controls.Add(this.EmpBack);
            this.Controls.Add(this.EmpDelete);
            this.Controls.Add(this.EmpUpdate);
            this.Controls.Add(this.EmpAdd);
            this.Controls.Add(this.EmpPhoto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmpPosition);
            this.Controls.Add(this.EmpGender);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.EmpAddress);
            this.Controls.Add(this.EmpPhone);
            this.Controls.Add(this.EmpEmail);
            this.Controls.Add(this.EmpPassword);
            this.Controls.Add(this.EmployeeList);
            this.Name = "EmployeeReg";
            this.Text = "EmployeeReg";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeReg_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeList;
        private System.Windows.Forms.TextBox EmpPassword;
        private System.Windows.Forms.TextBox EmpEmail;
        private System.Windows.Forms.TextBox EmpPhone;
        private System.Windows.Forms.TextBox EmpAddress;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.ComboBox EmpGender;
        private System.Windows.Forms.ComboBox EmpPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox EmpPhoto;
        private System.Windows.Forms.Button EmpAdd;
        private System.Windows.Forms.Button EmpUpdate;
        private System.Windows.Forms.Button EmpDelete;
        private System.Windows.Forms.Button EmpBack;
        private System.Windows.Forms.Button EmployeeView;
        private System.Windows.Forms.Button ImgBrowse;

    }
}
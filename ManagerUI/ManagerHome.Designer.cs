namespace Cafe_Management_System.ManagerUI
{
    partial class ManagerHome
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
            this.foodListGridView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.Label();
            this.foodDes = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.signOutButton = new System.Windows.Forms.Button();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foodListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // foodListGridView
            // 
            this.foodListGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.foodListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodListGridView.Location = new System.Drawing.Point(9, 10);
            this.foodListGridView.Margin = new System.Windows.Forms.Padding(2);
            this.foodListGridView.Name = "foodListGridView";
            this.foodListGridView.ReadOnly = true;
            this.foodListGridView.Size = new System.Drawing.Size(363, 513);
            this.foodListGridView.TabIndex = 1;
            this.foodListGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodListGridView_CellClick);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(256, 531);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(116, 40);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Green;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(594, 484);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 40);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(383, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Food Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price in taka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            // 
            // itemName
            // 
            this.itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(591, 127);
            this.itemName.Margin = new System.Windows.Forms.Padding(2);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(167, 26);
            this.itemName.TabIndex = 4;
            this.itemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(591, 178);
            this.price.Margin = new System.Windows.Forms.Padding(2);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(167, 26);
            this.price.TabIndex = 4;
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // textBox7
            // 
            this.textBox7.AutoSize = true;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(409, 332);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(115, 17);
            this.textBox7.TabIndex = 5;
            this.textBox7.Text = "Food Description";
            // 
            // foodDes
            // 
            this.foodDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodDes.Location = new System.Drawing.Point(591, 332);
            this.foodDes.Margin = new System.Windows.Forms.Padding(2);
            this.foodDes.Multiline = true;
            this.foodDes.Name = "foodDes";
            this.foodDes.Size = new System.Drawing.Size(279, 117);
            this.foodDes.TabIndex = 6;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(687, 484);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(88, 40);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(781, 483);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 40);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // signOutButton
            // 
            this.signOutButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.signOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutButton.Location = new System.Drawing.Point(896, 483);
            this.signOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(99, 40);
            this.signOutButton.TabIndex = 8;
            this.signOutButton.Text = "SIGN OUT";
            this.signOutButton.UseVisualStyleBackColor = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Fast food",
            "Beverage",
            "Drinks",
            "Dry food"});
            this.categoryBox.Location = new System.Drawing.Point(591, 235);
            this.categoryBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoryBox.Size = new System.Drawing.Size(167, 28);
            this.categoryBox.TabIndex = 13;
            this.categoryBox.Text = "Select";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Cafe_Management_System.Properties.Resources.icons8_Refresh_30px;
            this.button1.Location = new System.Drawing.Point(875, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 33);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1018, 587);
            this.ControlBox = false;
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.foodDes);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.price);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.foodListGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerHome";
            this.Click += new System.EventHandler(this.ManagerHome_Click);
            ((System.ComponentModel.ISupportInitialize)(this.foodListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView foodListGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label textBox7;
        private System.Windows.Forms.TextBox foodDes;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox categoryBox;
    }
}
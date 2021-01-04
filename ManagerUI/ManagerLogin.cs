using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.ManagerUI
{
    public partial class ManagerLogin : Form
    {
        DataAccess dataAccess;
        public ManagerLogin()
        {
            InitializeComponent();
            this.dataAccess = new DataAccess();
        }

        private void ManagerLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text.Equals("") || PasswordTxt.Text.Equals(""))
            {
                MessageBox.Show("Username or Password Empty!");
            }
            else
            {
                dataAccess = new DataAccess();
                string sql = "SELECT * FROM ManagerLogin WHERE username='" + usernameTxt.Text + "' AND password='" + PasswordTxt.Text + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                try
                {
                    int id = (int)reader["id"];
                    if (id > 0)
                    {
                        ManagerHome managerHome = new ManagerHome();
                        managerHome.Show();
                        this.Hide();
                        clearData();
                    }
                    else
                    {
                        MessageBox.Show("Login Faield");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Login Faield");
                }
            }
        }

        private void clearData()
        {
            this.usernameTxt.Text = PasswordTxt.Text = "";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

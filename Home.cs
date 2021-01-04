using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Dispose();
            Application.Exit();
        }

        private void AdminLog_Click(object sender, EventArgs e)
        {
            Admin_Login Al = new Admin_Login();
            Al.Show();
            this.Hide();
        }

        private void ManagerLog_Click(object sender, EventArgs e)
        {
            ManagerUI.ManagerLogin managerLogin = new ManagerUI.ManagerLogin();
            managerLogin.Show();
            this.Hide();
        }
    }
}

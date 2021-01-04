using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Cafe_Management_System
{
    public partial class Admin_Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RIAZ\SQLEXPRESS;Initial Catalog=Cafe-Management-System;Integrated Security=True");
        public Admin_Login()
        {
            InitializeComponent();

        }

        private void Admin_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            
        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM [dbo].[AdminLogin]where Password = '" + AdminPass.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (AdminPass.Text == "")
                MessageBox.Show("Please enter a valid password");

            else if (dtbl.Rows.Count == 1)
            {
                MessageBox.Show("Log In Successful!");
                Admin Ad = new Admin();
                Ad.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect Password!");
            }
            con.Close();
        }

        private void AdLogBack_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }
    }
}

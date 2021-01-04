using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cafe_Management_System
{
    public partial class PasswordReset : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RIAZ\SQLEXPRESS;Initial Catalog=Cafe-Management-System;Integrated Security=True");
        public PasswordReset()
        {
            InitializeComponent();
        }

        private void PasswordReset_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PassRes_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "update [dbo].[AdminLogin] set Password ='" + AdminNewPass.Text + "'where Password='" + AdminCurrentPass.Text + "'";

            SqlCommand command = new SqlCommand(sql, con);
            int result = command.ExecuteNonQuery();
            con.Close();

            if (result > 0)
            {
                MessageBox.Show("Password updated successfully");
                AdminNewPass.Text = string.Empty;
                AdminCurrentPass.Text = string.Empty;
              
            }
            else
                MessageBox.Show("Error in updating ");
        }

        private void PassResBack_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();

        }
    }
}

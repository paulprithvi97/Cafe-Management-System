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
using System.IO;
using System.Drawing.Imaging;

namespace Cafe_Management_System
{
    public partial class EmployeeReg : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RIAZ\SQLEXPRESS;Initial Catalog=Cafe-Management-System;Integrated Security=True");
        String ImgLoc = "";
        public EmployeeReg()
        {
            InitializeComponent();
        }

        private void EmployeeReg_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void EmpAdd_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream st = new FileStream(ImgLoc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(st);
            images = br.ReadBytes((int)st.Length);

            con.Open();

            string sql = "INSERT INTO [dbo].[EmployeeReg]([Name],[Address],[Phone],[Email],[Password],[Gender],[Position],[Photo])VALUES('" + EmpName.Text + "','" + EmpAddress.Text + "','" + EmpPhone.Text + "','" + EmpEmail.Text + "','" + EmpPassword.Text + "','" + EmpGender.Text + "','" + EmpPosition.Text + "',@images)";
           
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.Add(new SqlParameter("@images", images));
            int result = command.ExecuteNonQuery();
            if (EmpName.Text == "")
                MessageBox.Show("Please enter employee Name");
            else if (EmpAddress.Text == "")
                MessageBox.Show("Please enter Address");
            else if (EmpPhone.Text == "")
                MessageBox.Show("Please enter Phone No");
            else if (EmpEmail.Text == "")
                MessageBox.Show("Please enter Email Address");
            else if (EmpPassword.Text == "")
                MessageBox.Show("Please enter Password");
            else if (EmpGender.Text == "")
                MessageBox.Show("Please enter Gender");
            else if (EmpPosition.Text == "")
                MessageBox.Show("Please enter Position");
            else if (EmpPhoto.Image == null)
                MessageBox.Show("Please upload an image");
            if (result > 0)
            {
                MessageBox.Show("Employee added successfully");
                EmpName.Text = string.Empty;
                EmpAddress.Text = string.Empty;
                EmpPhone.Text = string.Empty;
                EmpEmail.Text = string.Empty;
                EmpPassword.Text = string.Empty;
                EmpGender.Text = string.Empty;
                EmpPosition.Text = string.Empty;
                EmpPhoto.Image = null;
            }
            else
                MessageBox.Show("Error in adding Event");
            
            con.Close();
         
        }

        private void ImgBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dl = new OpenFileDialog();
            dl.Filter = "png files(*.png)|*.png|jpg files (*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dl.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(dl.FileName))
            {
                
                ImgLoc = dl.FileName.ToString();
                EmpPhoto.ImageLocation = ImgLoc;
   
            }

        }

        private void EmpUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "update [dbo].[EmployeeReg] set Name='" + EmpName.Text + "' , Address= '" + EmpAddress.Text + "', Phone= '" + EmpPhone.Text + "', Email= '" + EmpEmail.Text + "', Password= '" + EmpPassword.Text + "' , Gender= '" + EmpGender.Text + "', Position= '" + EmpPosition.Text + "'where Name='" + EmpName.Text + "'";

            SqlCommand command = new SqlCommand(sql, con);
            int result = command.ExecuteNonQuery();
            con.Close();

            if (result > 0)
            {
                MessageBox.Show("Employee details updated successfully");
                EmpName.Text = string.Empty;
                EmpAddress.Text = string.Empty;
                EmpPhone.Text = string.Empty;
                EmpEmail.Text = string.Empty;
                EmpPassword.Text = string.Empty;
                EmpGender.Text = string.Empty;
                EmpPosition.Text = string.Empty;
                EmpPhoto.Image = null;
            }
            else
                MessageBox.Show("Error in updating ");
        }

        private void EmployeeView_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM [dbo].[EmployeeReg]";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            EmployeeList.DataSource = dt;
            con.Close();
        }

        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = EmployeeList.Rows[index];
            EmpName.Text = selectedRow.Cells[0].Value.ToString();
            EmpAddress.Text = selectedRow.Cells[1].Value.ToString();
            EmpPhone.Text = selectedRow.Cells[2].Value.ToString();
            EmpEmail.Text = selectedRow.Cells[3].Value.ToString();
            EmpPassword.Text = selectedRow.Cells[4].Value.ToString();
            EmpGender.Text = selectedRow.Cells[5].Value.ToString();
            EmpPosition.Text = selectedRow.Cells[6].Value.ToString();
            byte[] images = (byte[])selectedRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(images);
            EmpPhoto.Image = Image.FromStream(ms);
        }

        private void EmpDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "delete from [dbo].[EmployeeReg] where Name='" + EmpName.Text + "'";

            SqlCommand command = new SqlCommand(sql, con);
            int result = command.ExecuteNonQuery();
            con.Close();

            if (result > 0)
            {
                MessageBox.Show("Employee Deleted successfully");
                EmpName.Text = string.Empty;
                EmpAddress.Text = string.Empty;
                EmpPhone.Text = string.Empty;
                EmpEmail.Text = string.Empty;
                EmpPassword.Text = string.Empty;
                EmpGender.Text = string.Empty;
                EmpPosition.Text = string.Empty;
                EmpPhoto.Image = null;
            }
            else
                MessageBox.Show("Error in deleting Event");
        }

        private void EmpBack_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }
    }
}

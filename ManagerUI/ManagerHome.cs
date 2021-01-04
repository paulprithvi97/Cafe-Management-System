using Cafe_Management_System.Entities;
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
    public partial class ManagerHome : Form
    {
        DataAccess dataAccess;
        String foodid = "";
        public ManagerHome()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
            loadTable();
        }


        private void signOutButton_Click(object sender, EventArgs e)
        {
            ManagerLogin managerLogin = new ManagerLogin();
            managerLogin.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (isEmptyField())
            {
                MessageBox.Show("Empty Field!");
            }
            else
            {
                dataAccess = new DataAccess();
                string sql = "INSERT INTO FoodInformation(itemName,itemPrice,itemCategory,itemDescription) VALUES('" + itemName.Text + "','" + price.Text + "','" + categoryBox.SelectedItem.ToString() + "','" + foodDes.Text + "')";
                int result = dataAccess.ExecuteQuery(sql);
                dataAccess.Dispose();
                if(result > 0)
                {
                    MessageBox.Show("Success");
                    clearData();
                    loadTable();
                }
            }
        }

        private bool isEmptyField()
        {
            if (itemName.Text.Equals("") || price.Text.Equals("") || categoryBox.SelectedIndex == -1 || foodDes.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void loadTable()
        {
            
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM FoodInformation";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<foodItem> itemList = new List<foodItem>();

            while (reader.Read())
            {
                foodItem foodItem = new foodItem();
                foodItem.Id = Convert.ToInt32(reader["id"]);
                foodItem.Name = reader["itemName"].ToString();
                foodItem.Price = reader["itemPrice"].ToString();
                foodItem.Category = reader["itemCategory"].ToString();
                foodItem.Description = reader["itemDescription"].ToString();
                itemList.Add(foodItem);
            }
            dataAccess.Dispose();
            foodListGridView.DataSource = itemList;
        }

        private void clearData()
        {
            itemName.Text = price.Text = foodDes.Text = foodid = "";
            categoryBox.Text = "Select";
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            clearData();
            loadTable();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (isEmptyField() || foodid.Equals(""))
            {
                MessageBox.Show("Empty Field");
            }
            else
            {
                dataAccess = new DataAccess();
                string sql = "UPDATE FoodInformation SET itemName='" + itemName.Text + "',itemPrice='" + price.Text + "',itemCategory='" + categoryBox.SelectedItem.ToString() + "',itemDescription='" + foodDes.Text + "'  WHERE id='" + foodid + "'";
                int result = dataAccess.ExecuteQuery(sql);
                dataAccess.Dispose();

                if (result > 0)
                {
                    MessageBox.Show("Update Success!");
                    loadTable();
                    clearData();
                }
                else
                {
                    MessageBox.Show("Something Wrong ");
                }
            }
        }

        private void foodListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = foodListGridView.Rows[rowIndex];
                foodid = row.Cells[0].Value.ToString();
                itemName.Text = row.Cells[1].Value.ToString();
                price.Text = row.Cells[2].Value.ToString();
                categoryBox.SelectedItem = row.Cells[3].Value.ToString();
                foodDes.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                itemName.Text = price.Text = foodDes.Text = foodid= "";
                categoryBox.Text = "Select";
            }
        }

        private void ManagerHome_Click(object sender, EventArgs e)
        {
            //clearData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (foodid.Equals(""))
            {
                MessageBox.Show("Selelct Table Row First");
            }
            else
            {
                dataAccess = new DataAccess();
                string sql = "DELETE FROM FoodInformation WHERE Id=" + foodid;
                int result = dataAccess.ExecuteQuery(sql);
                dataAccess.Dispose();
                if (result > 0)
                {
                    MessageBox.Show("Delete Success!");
                    loadTable();
                    clearData();
                }
                else
                {
                    MessageBox.Show("Something Wrong ");
                }

            }
        }
    }
}

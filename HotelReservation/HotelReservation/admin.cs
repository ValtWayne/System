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

namespace HotelReservation
{
    public partial class admin : Form
    {
        
       
        
        public admin()
        {

            InitializeComponent();
        }
        
        private void admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRDataSet7.reserve_table' table. You can move, or remove it, as needed.
            this.reserve_tableTableAdapter2.Fill(this.hRDataSet7.reserve_table);
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NKHIKGR\SQLEXPRESS;Initial Catalog=HR;Integrated Security=True");
                conn.Open();

                string ClassType = string.Empty;
                if (Classic.Checked)
                {
                    ClassType = "Classic";
                }
                else if (Deluxe.Checked)
                {
                    ClassType = "Deluxe";
                }
                else
                {
                    ClassType = "Executive";
                }

                SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT reserve_table ON; INSERT INTO reserve_table (Room_ID, Room_Class, Available_Date, Price) VALUES (@Room_ID, @Room_Class, @Available_Date, @Price); SET IDENTITY_INSERT reserve_table OFF;", conn);
                cmd.Parameters.AddWithValue("@Room_ID", Room_ID.Text);
                cmd.Parameters.AddWithValue("@Room_Class", ClassType);
                cmd.Parameters.AddWithValue("@Available_Date", Avail.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Price", Price.Text);

                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Saved");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // SQL Server error number for primary key violation
                {
                    MessageBox.Show("Duplicate Room_ID. Please choose a different Room_ID.");
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Room_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deluxe_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void Classic_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Executive_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Avail_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int roomIDColumnIndex = 0; // Change this index based on the actual position of Room_ID in your DataGridView
                string roomIDToDelete = dataGridView1.Rows[selectedIndex].Cells[roomIDColumnIndex].Value.ToString();


                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NKHIKGR\SQLEXPRESS;Initial Catalog=HR;Integrated Security=True"))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM reserve_table WHERE Room_ID = @Room_ID";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Room_ID", roomIDToDelete);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Refresh the DataGridView or update your data source
                // dataGridView1.DataSource = ...; // Update your data source here
                MessageBox.Show("Item deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NKHIKGR\SQLEXPRESS;Initial Catalog=HR;Integrated Security=True");
            string sqlstm = "SELECT * FROM reserve_table";
            SqlDataAdapter SDA = new SqlDataAdapter(sqlstm, conn);
            DataSet DS = new DataSet();
            SDA.Fill(DS, "reserve_table");
            dataGridView1.DataSource = DS.Tables[0];


        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row index
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Extract the values from the selected row
                string roomIDToUpdate = dataGridView1.Rows[selectedIndex].Cells["Room_ID"].Value.ToString();
                string roomClassToUpdate = dataGridView1.Rows[selectedIndex].Cells["Room_Class"].Value.ToString();
                DateTime availableDateToUpdate = Convert.ToDateTime(dataGridView1.Rows[selectedIndex].Cells["Available_Date"].Value);
                decimal priceToUpdate = Convert.ToDecimal(dataGridView1.Rows[selectedIndex].Cells["Price"].Value);

                // Show a dialog to allow the user to edit the values
                UpdateForm updateForm = new UpdateForm(roomIDToUpdate, roomClassToUpdate, availableDateToUpdate, priceToUpdate);
                DialogResult result = updateForm.ShowDialog();

                // If the user clicks OK in the dialog, update the values in the DataGridView
                if (result == DialogResult.OK)
                {
                    // Get the updated values from the dialog
                    string updatedRoomID = updateForm.UpdatedRoomID;
                    string updatedRoomClass = updateForm.UpdatedRoomClass;
                    DateTime updatedAvailableDate = updateForm.UpdatedAvailableDate;
                    decimal updatedPrice = updateForm.UpdatedPrice;

                    // Update the values in the DataGridView
                    dataGridView1.Rows[selectedIndex].Cells["Room_ID"].Value = updatedRoomID;
                    dataGridView1.Rows[selectedIndex].Cells["Room_Class"].Value = updatedRoomClass;
                    dataGridView1.Rows[selectedIndex].Cells["Available_Date"].Value = updatedAvailableDate;
                    dataGridView1.Rows[selectedIndex].Cells["Price"].Value = updatedPrice;

                    // Update the values in the database
                    UpdateDataInDatabase(updatedRoomID, updatedRoomClass, updatedAvailableDate, updatedPrice);

                    MessageBox.Show("Item updated successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void UpdateDataInDatabase(string roomID, string roomClass, DateTime availableDate, decimal price)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NKHIKGR\SQLEXPRESS;Initial Catalog=HR;Integrated Security=True"))
            {
                conn.Open();
                string updateQuery = "UPDATE reserve_table SET Room_Class = @Room_Class, Available_Date = @Available_Date, Price = @Price WHERE Room_ID = @Room_ID";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Room_ID", roomID);
                    cmd.Parameters.AddWithValue("@Room_Class", roomClass);
                    cmd.Parameters.AddWithValue("@Available_Date", availableDate);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
        
    
}

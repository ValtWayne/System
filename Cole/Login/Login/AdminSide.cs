using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class AdminSide : Form
    {
        // Define an event for notifying about product addition
        public event EventHandler ProductAdded;

        public AdminSide()
        {
            InitializeComponent();
        }
        private string CONNECTION_STRING = @"Data Source=desktop-nkhikgr\sqlexpress;Initial Catalog=Register;Integrated Security=True;";
        private void AdminSide_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registerDataSet3.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.registerDataSet3.products);
            LoadProducts();
            // Call CheckColumnNames method to check column names
      

        }

        private void LoadProducts()
        {
             using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                string query = "SELECT product_ID, product_name, price FROM products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
     
        private void TBFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a row is clicked and it's not a header row
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                // Get the selected row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate textboxes with selected row's data
                TBFname.Text = row.Cells["product_name"].Value.ToString();
                TBPrice.Text = row.Cells["price"].Value.ToString();
            }
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            string name = TBFname.Text;
            decimal price = Convert.ToDecimal(TBPrice.Text);
            byte[] imageBytes = null;

            // Convert image to byte array
            if (Picture.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    Picture.Image.Save(ms, Picture.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }
            }
            else
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            try
            {
                // Insert data into database
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    string query = "INSERT INTO products (product_ID, product_name, price, image) VALUES (@ProductID, @ProductName, @Price, @Image)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductID", Guid.NewGuid().ToString());
                    command.Parameters.AddWithValue("@ProductName", name);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Image", imageBytes);
                    connection.Open();
                    command.ExecuteNonQuery();
                    OnProductAdded(EventArgs.Empty);
                }

                // Reload products
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }
        protected virtual void OnProductAdded(EventArgs e)
        {
            ProductAdded?.Invoke(this, e);
        }
        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            // Get the selected row
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            // Get the product ID of the selected row
            string productID = row.Cells["Product_ID"].Value.ToString(); // Use the correct column name

            // Get the updated name and price
            string name = TBFname.Text;
            decimal price = Convert.ToDecimal(TBPrice.Text);
            byte[] imageBytes = null;

            // Convert image to byte array
            if (Picture.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    Picture.Image.Save(ms, Picture.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }
            }
            else
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            try
            {
                // Update data in the database
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    string query = "UPDATE products SET product_name = @ProductName, price = @Price, image = @Image WHERE product_ID = @ProductID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", name);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Image", imageBytes);
                    command.Parameters.AddWithValue("@ProductID", productID);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Update successful");
                        // Refresh the data or update the UI with the latest information
                        LoadProducts(); // Call the method to refresh your data
                    }
                    else
                    {
                        MessageBox.Show("Product ID not found. No update performed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
            }
        }


        private void BTNDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Check the actual column name in your DataGridView and use it here
                string productIDToDelete = dataGridView1.SelectedRows[0].Cells["product_ID"].Value.ToString();

                try
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NKHIKGR\SQLEXPRESS;Initial Catalog=Register;Integrated Security=True;"))
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM products WHERE product_ID = @Product_ID";
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Product_ID", productIDToDelete);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Item deleted successfully.");
                                // Refresh the data or update the UI with the latest information
                                LoadProducts(); // Call the method to refresh your data
                            }
                            else
                            {
                                MessageBox.Show("Product_ID not found. No delete performed.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }




        private void BTNBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the selected image into the PictureBox
                    Picture.SizeMode = PictureBoxSizeMode.StretchImage; // Set SizeMode to StretchImage
                    Picture.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            admin admin1 = new admin();
            admin1.Show();
            this.Hide();
        }

        private void BTNManage_Click(object sender, EventArgs e)
        {

        }
    }
}

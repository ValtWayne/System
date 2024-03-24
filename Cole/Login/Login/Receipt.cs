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

namespace Login
{
    public partial class Receipt : Form
    {
        private string CONNECTION_STRING = @"Data Source=desktop-nkhikgr\sqlexpress;Initial Catalog=Register;Integrated Security=True;";
        private string username;
        public Receipt(string username)
        {
            InitializeComponent();
            this.username = username; // Store the username
            SetUsername(username); // Set the username in the UI


        }
        // Method to set the username in the UI
        private void SetUsername(string username)
        {
            // Set the username in the appropriate control (e.g., a label)
            labelUsername.Text = username;
        }
        // Method to set receipt text in the RichTextBox
        public void SetReceiptText(string text)
        {
            RTBReceipt.Text = text;
        }
        private void SaveReceiptToDatabase()
        {
            try
            {
                // Fetch cart items from the database
                DataTable cartData = new DataTable();
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    string query = "SELECT * FROM cart WHERE username = @Username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(cartData);
                }

                // Insert the cart items into the Receipt table
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    foreach (DataRow row in cartData.Rows)
                    {
                        string productID = row["product_ID"].ToString();
                        string productName = row["product_name"].ToString();
                        decimal price = Convert.ToDecimal(row["price"]);
                        int quantity = Convert.ToInt32(row["qty"]);
                        decimal total = Convert.ToDecimal(row["total"]);

                        string insertQuery = "INSERT INTO Receipt (username, product_ID, product_name, price, qty, total) VALUES (@Username, @ProductID, @ProductName, @Price, @Quantity, @Total)";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@Username", username);
                        insertCommand.Parameters.AddWithValue("@ProductID", productID);
                        insertCommand.Parameters.AddWithValue("@ProductName", productName);
                        insertCommand.Parameters.AddWithValue("@Price", price);
                        insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                        insertCommand.Parameters.AddWithValue("@Total", total);
                        insertCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Receipt saved to database successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving receipt to database: " + ex.Message);
            }
        }
        private void RTBReceipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNDone_Click(object sender, EventArgs e)
        {

            // Save the receipt to the database
            SaveReceiptToDatabase();

            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}

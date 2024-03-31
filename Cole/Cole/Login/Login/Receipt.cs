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
        // Add a field to store the cart items
        private DataTable cartItems;

        private string CONNECTION_STRING = @"Data Source=desktop-nkhikgr\sqlexpress;Initial Catalog=Register;Integrated Security=True;";

        public Receipt()
        {
            InitializeComponent();
        }

        // Method to set cart items from the Main form
        public void SetCartItems(DataTable items)
        {
            cartItems = items;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            // Generate and display the receipt
            GenerateReceipt();
        }

        // Method to generate and display the receipt
        private void GenerateReceipt()
        {
            // Clear any existing text in the RichTextBox
            RTBReceipt.Clear();

            // Add header
            RTBReceipt.AppendText("*********************************************************************\n");
            RTBReceipt.AppendText(DateTime.Now.ToString() + "\n");
            RTBReceipt.AppendText("*********************************************************************\n");

            // Add column headers
            RTBReceipt.AppendText("PRODUCT NAME           QTY            PRICE         TOTAL\n");
            RTBReceipt.AppendText("--------------------------------------------------------------------------------------------\n");

            // Add items from the cart
            foreach (DataRow row in cartItems.Rows)
            {
                string productName = row["product_name"].ToString();
                int quantity = Convert.ToInt32(row["qty"]);
                decimal price = Convert.ToDecimal(row["price"]);
                decimal total = Convert.ToDecimal(row["total"]);

                RTBReceipt.AppendText($"{productName,-25} {quantity,-15} {price,-15:C2} {total,-10:C2}\n");
            }

            // Add total
            decimal grandTotal = cartItems.AsEnumerable().Sum(row => row.Field<decimal>("total"));
            RTBReceipt.AppendText($"\nTOTAL: {grandTotal:C2}");
        }



        private void PName_Click(object sender, EventArgs e)
        {

        }

        private void QTY_Click(object sender, EventArgs e)
        {

        }

        private void Price_Click(object sender, EventArgs e)
        {

        }

        private void Total_Click(object sender, EventArgs e)
        {

        }

        private void BTNDone_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    // Insert or update each item from the cart into the Receipt table
                    foreach (DataRow row in cartItems.Rows)
                    {
                        string productName = row["product_name"].ToString();
                        int quantity = Convert.ToInt32(row["qty"]);
                        decimal price = Convert.ToDecimal(row["price"]);
                        decimal total = Convert.ToDecimal(row["total"]);

                        // Check if the product already exists in the Receipt table
                        string checkQuery = "SELECT COUNT(*) FROM Receipt WHERE product_name = @ProductName";
                        SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                        checkCommand.Parameters.AddWithValue("@ProductName", productName);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            // If the product already exists, update the quantity and total
                            string updateQuery = "UPDATE Receipt SET qty = qty + @Quantity, total = total + @Total WHERE product_name = @ProductName";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                            updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                            updateCommand.Parameters.AddWithValue("@Total", total);
                            updateCommand.Parameters.AddWithValue("@ProductName", productName);
                            updateCommand.ExecuteNonQuery();
                        }
                        else
                        {
                            // If the product does not exist, insert a new record
                            string insertQuery = "INSERT INTO Receipt (product_name, price, qty, total) VALUES (@ProductName, @Price, @Quantity, @Total)";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                            insertCommand.Parameters.AddWithValue("@ProductName", productName);
                            insertCommand.Parameters.AddWithValue("@Price", price);
                            insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                            insertCommand.Parameters.AddWithValue("@Total", total);
                            insertCommand.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Receipt data saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving receipt data: " + ex.Message);
            }

            this.Close(); // Close the form after saving data
        }

    }
}

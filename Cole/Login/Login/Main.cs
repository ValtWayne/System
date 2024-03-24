    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

    namespace Login
    {
        public partial class Main : Form
        {
        // Declare a variable to store the username
        private string username;
        public Main()
        {
                InitializeComponent();
            this.username = username; // Store the username
            LoadItems();
            }
            private string CONNECTION_STRING = @"Data Source=desktop-nkhikgr\sqlexpress;Initial Catalog=Register;Integrated Security=True;";

            // Store the selected GroupBox for highlighting
            private DataRow selectedProduct; // Store the selected product's DataRow
            private GroupBox selectedGroupBox;

            // PictureBox click event handler
            private void PictureBox_Click(object sender, EventArgs e)
            {
                PictureBox pictureBox = sender as PictureBox;
                if (pictureBox != null)
                {
                    GroupBox groupBox = pictureBox.Parent as GroupBox;
                    if (groupBox != null)
                    {
                        DataRow productDataRow = groupBox.Tag as DataRow;
                        if (productDataRow != null)
                        {
                            // Retrieve product information from the selected PictureBox
                            string productName = productDataRow["product_name"].ToString();

                            // Store the selected product's DataRow
                            selectedProduct = productDataRow;

                            // Show message indicating the selected product
                            MessageBox.Show(productName + " is selected.");
                        }
                    }
                }
            }
        // Modify the LoadItems method to populate items from the database and disable checkboxes once they are selected
        private void LoadItems()
        {
            // Clear existing items
            GBSnacks.Controls.Clear();

            // Load items from the database
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                string query = "SELECT product_ID, product_name, price, image FROM products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Create item controls for each row in the DataTable
                int itemIndex = 0; // Track the index of each item
                foreach (DataRow row in dataTable.Rows)
                {
                    if (itemIndex >= 4) break; // Limit to 4 items

                    // Create a GroupBox to contain each item
                    GroupBox groupBox = new GroupBox();
                    groupBox.Location = new Point(10 + itemIndex % 2 * 223, 15 + itemIndex / 2 * 183); // Adjusted location
                    groupBox.Margin = new Padding(3);
                    groupBox.Padding = new Padding(10); // Adjusted padding
                    groupBox.Size = new Size(219, 173); // Adjusted size
                    groupBox.Tag = row; // Store the DataRow for later use

                    // Create PictureBox for image
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new Point(59, 19);
                    pictureBox.Margin = new Padding(3);
                    pictureBox.Padding = new Padding(0);
                    pictureBox.Size = new Size(100, 91);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = ByteArrayToImage((byte[])row["image"]);
                    groupBox.Controls.Add(pictureBox);

                    // Create CheckBox for product selection
                    CheckBox checkBox = new CheckBox();
                    checkBox.AutoSize = true;
                    checkBox.Location = new Point(89, 113);
                    checkBox.Margin = new Padding(3, 5, 3, 0); // Adjusted margin
                    checkBox.Padding = new Padding(0);
                    checkBox.Size = new Size(100, 15); // Adjusted size
                    checkBox.Text = row["product_name"].ToString();
                    checkBox.CheckedChanged += (sender, e) =>
                    {
                        if (checkBox.Checked)
                        {
                            selectedProduct = row;
                            selectedGroupBox = groupBox;
                            checkBox.Enabled = false; // Disable the checkbox once selected
                        }
                        else
                        {
                            selectedProduct = null;
                            selectedGroupBox = null;
                        }
                    };
                    groupBox.Controls.Add(checkBox);

                    // Create Label for price
                    Label priceLabel = new Label();
                    priceLabel.Location = new Point(89, 137);
                    priceLabel.Margin = new Padding(3, 0, 3, 0);
                    priceLabel.Padding = new Padding(0);
                    priceLabel.Size = new Size(100, 15); // Adjusted size
                    priceLabel.Text = "P" + row["price"].ToString();
                    groupBox.Controls.Add(priceLabel);

                    // Add the GroupBox to the form
                    GBSnacks.Controls.Add(groupBox);

                    itemIndex++; // Increment the item index
                }
            }
        }

        private void AddItemToCart(string productID, string productName, decimal price, int quantity)
        {
            try
            {
                // Calculate total price
                decimal total = price * quantity;

                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    string query = "INSERT INTO cart (product_ID, product_name, price, qty, total) VALUES (@ProductID, @ProductName, @Price, @Quantity, @Total)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductID", productID);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Total", total); // Insert total price into the database
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Insert data into the Receipt table
                        string receiptQuery = "INSERT INTO Receipt (product_ID, product_name, price, qty, total) VALUES (@ProductID, @ProductName, @Price, @Quantity, @Total)";
                        SqlCommand receiptCommand = new SqlCommand(receiptQuery, connection);
                        receiptCommand.Parameters.AddWithValue("@ProductID", productID);
                        receiptCommand.Parameters.AddWithValue("@ProductName", productName);
                        receiptCommand.Parameters.AddWithValue("@Price", price);
                        receiptCommand.Parameters.AddWithValue("@Quantity", quantity);
                        receiptCommand.Parameters.AddWithValue("@Total", total);
                        receiptCommand.ExecuteNonQuery();

                        MessageBox.Show("Item added to cart.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add item to cart.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item to cart: " + ex.Message);
            }
        }
        private void AdminProductAdded(object sender, EventArgs e)
            {
                // Reload items when a new product is added
                LoadItems();
            }
            // Subscribe to the ProductAdded event when AdminSide form is opened
            private void OpenAdminSide()
            {
                AdminSide adminSide = new AdminSide();
                adminSide.ProductAdded += AdminProductAdded;
                adminSide.ShowDialog();
            }

            private Image ByteArrayToImage(byte[] byteArray)
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    return Image.FromStream(ms);
                }
            }
            private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
            {

            }

            private void Main_Load(object sender, EventArgs e)
            {
            // TODO: This line of code loads data into the 'registerDataSet.cart' table. You can move, or remove it, as needed.
            this.cartTableAdapter3.Fill(this.registerDataSet.cart);
            // TODO: This line of code loads data into the 'registerDataSet.cart' table. You can move, or remove it, as needed.
            this.cartTableAdapter3.Fill(this.registerDataSet.cart);



        }

        private void GBSnacks_Enter(object sender, EventArgs e)
            {

            }

            private void ProductPictureBox_Click(object sender, EventArgs e)
            {

            }

            private void ProductNameLabel_Click(object sender, EventArgs e)
            {

            }

            private void PriceLabel_Click(object sender, EventArgs e)
            {

            }

            private void Picture2_Click(object sender, EventArgs e)
            {

            }

            private void ProductNameLabel2_Click(object sender, EventArgs e)
            {

            }

            private void PriceLabel2_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox3_Click(object sender, EventArgs e)
            {

            }

            private void ProductNameLabel3_Click(object sender, EventArgs e)
            {

            }

            private void PriceLabel3_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox2_Click(object sender, EventArgs e)
            {

            }

            private void ProductNameLabel4_Click(object sender, EventArgs e)
            {

            }

            private void PriceLabel4_Click(object sender, EventArgs e)
            {

            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

        // Update the form to display the total dynamically
        private void LoadCartData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    string query = "SELECT * FROM cart";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataGridView to the DataTable
                    dataGridView1.DataSource = dataTable;

                    // Calculate and display the total dynamically
                    decimal total = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        total += Convert.ToDecimal(row["total"]);
                    }
                    TBTotal.Text = total.ToString(); // Assuming TBTotal is your TextBox for displaying the total
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cart data: " + ex.Message);
            }
        }

        // Modify the BTNAdd_Click event handler to load cart data after adding an item to the cart
        private void BTNAdd_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            // Retrieve product information from the selected product's DataRow
            string productID = selectedProduct["product_ID"].ToString();
            string productName = selectedProduct["product_name"].ToString();
            decimal price = Convert.ToDecimal(selectedProduct["price"]);

            // Prompt the user for the quantity
            int quantity;
            if (!int.TryParse(TBQTY.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            // Add the item to the cart
            AddItemToCart(productID, productName, price, quantity);

            // Clear the text box
            TBQTY.Text = string.Empty;

            // Refresh the cart data by calling the LoadCartData method
            LoadCartData();
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

            // Get the product name and current quantity of the selected row
            string productName = row.Cells["product_name"].Value.ToString();
            int currentQuantity = Convert.ToInt32(row.Cells["qtyDataGridViewTextBoxColumn"].Value);
            decimal price = Convert.ToDecimal(row.Cells["priceDataGridViewTextBoxColumn"].Value);

            // Get the updated quantity from the textbox
            int newQuantity;
            if (!int.TryParse(TBQTY.Text, out newQuantity) || newQuantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            try
            {
                // Calculate the new total based on the updated quantity
                decimal newTotal = price * newQuantity;

                // Update quantity and total in the database
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    string query = "UPDATE cart SET qty = @Quantity, total = @Total WHERE product_name = @ProductName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Quantity", newQuantity);
                    command.Parameters.AddWithValue("@Total", newTotal);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Quantity and total updated successfully.");
                        // Refresh the cart data by calling the LoadCartData method
                        LoadCartData();
                    }
                    else
                    {
                        MessageBox.Show("Product name not found. No update performed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating quantity and total: " + ex.Message);
            }
        }
        private void BTNRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to remove.");
                return;
            }

            // Get the selected row
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            // Get the product name of the selected row
            string productName = row.Cells["product_name"].Value.ToString();

            try
            {
                // Delete the selected row from the database
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    string query = "DELETE FROM cart WHERE product_name = @ProductName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item removed successfully.");
                        // Refresh the cart data by calling the LoadCartData method
                        LoadCartData();
                    }
                    else
                    {
                        MessageBox.Show("Product name not found. No removal performed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing item: " + ex.Message);
            }
        }

        private void TBQTY_TextChanged(object sender, EventArgs e)
            {

            }

        private void TBTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTNClear_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the database table
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    string query = "TRUNCATE TABLE cart"; // Assuming you're using SQL Server and want to delete all rows from the table
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                // Clear the total
                TBTotal.Text = "0";

                // Enable checkboxes
                foreach (Control control in GBSnacks.Controls)
                {
                    if (control is GroupBox groupBox)
                    {
                        foreach (Control innerControl in groupBox.Controls)
                        {
                            if (innerControl is CheckBox checkBox)
                            {
                                checkBox.Enabled = true;
                            }
                        }
                    }
                }

                // Clear the quantity textbox
                TBQTY.Text = string.Empty;

                // Reload items
                LoadItems();
                // Refresh the cart data by calling the LoadCartData method
                LoadCartData();

                MessageBox.Show("Database table cleared successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing database table: " + ex.Message);
            }
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void BTNPrint_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Receipt form
            Receipt receiptForm = new Receipt(username); // Pass the username

            // Pass the cart data to the Receipt form
            StringBuilder receiptText = new StringBuilder();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string productName = row.Cells["product_name"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["price"].Value);
                int quantity = Convert.ToInt32(row.Cells["qtyDataGridViewTextBoxColumn"].Value);
                decimal total = Convert.ToDecimal(row.Cells["totalDataGridViewTextBoxColumn"].Value);

                receiptText.AppendLine($"Product: {productName}, Price: {price}, Quantity: {quantity}, Total: {total}");
            }
            receiptForm.SetReceiptText(receiptText.ToString());

            // Show the Receipt form
            receiptForm.ShowDialog();
        }
    }
    }

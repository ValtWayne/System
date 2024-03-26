using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Manage : Form
    {
        private string CONNECTION_STRING = @"Data Source=desktop-nkhikgr\sqlexpress;Initial Catalog=Register;Integrated Security=True;";
        public Manage()
        {
            InitializeComponent();
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registerDataSet3.account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.registerDataSet3.account);

        }
        private void LoadAccountData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    string query = "SELECT * FROM account";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }


        private void TBFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBMname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBSname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBCPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string email = TBEmail.Text;
            string username = TBUsername.Text;
            string password = TBPass.Text;
            string confirmPassword = TBCPass.Text;

            string CONNECTION_STRING = @"Data Source=desktop-nkhikgr\sqlexpress;Initial Catalog=Register;Integrated Security=True;";

            if (password != confirmPassword)
            {
                MessageBox.Show("Password and confirm password do not match. Please make sure they are the same.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("The email provided is not supported. Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidPassword(password))
            {
                MessageBox.Show("The password must contain at least one uppercase letter, one lowercase letter, one symbol, and one number, and be at least 8 characters long.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = HashPassword(password);

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                string query = "SELECT COUNT(*) FROM account WHERE Email = @Email OR username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Username", username);

                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("An account with the provided email or username already exists.", "Account Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return;
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                string query = "INSERT INTO account (FirstName, LastName, MiddleInitial, Suffix, Email, username, Contact, password) " +
                               "VALUES (@FirstName, @LastName, @MiddleInitial, @Suffix, @Email, @username, @Contact, @password)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", TBFname.Text);
                    command.Parameters.AddWithValue("@LastName", TBLname.Text);
                    command.Parameters.AddWithValue("@MiddleInitial", TBMname.Text);
                    command.Parameters.AddWithValue("@Suffix", TBSname.Text);
                    command.Parameters.AddWithValue("@Email", TBEmail.Text);
                    command.Parameters.AddWithValue("@username", TBUsername.Text);
                    command.Parameters.AddWithValue("@Contact", TBContact.Text);
                    command.Parameters.AddWithValue("@password", hashedPassword);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Registration successful!");
                        // Refresh the cart data by calling the LoadCartData method
                        LoadAccountData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private bool IsValidEmail(string email)
        {

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        // Method to validate password format using regular expression
        private bool IsValidPassword(string password)
        {

            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            // Get the selected row
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            // Get the username of the selected row
            string username = row.Cells["usernameDataGridViewTextBoxColumn"].Value.ToString();

            // Get the updated values from the textboxes
            string newFirstName = TBFname.Text;
            string newLastName = TBLname.Text;
            string newMiddleInitial = TBMname.Text;
            string newSuffix = TBSname.Text;
            string newEmail = TBEmail.Text;
            string newContact = TBContact.Text;

            try
            {
                // Update account information in the database
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    string query = "UPDATE account SET FirstName = @FirstName, LastName = @LastName, MiddleInitial = @MiddleInitial, Suffix = @Suffix, Email = @Email, Contact = @Contact WHERE username = @Username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstName", newFirstName);
                    command.Parameters.AddWithValue("@LastName", newLastName);
                    command.Parameters.AddWithValue("@MiddleInitial", newMiddleInitial);
                    command.Parameters.AddWithValue("@Suffix", newSuffix);
                    command.Parameters.AddWithValue("@Email", newEmail);
                    command.Parameters.AddWithValue("@Contact", newContact);
                    command.Parameters.AddWithValue("@Username", username);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account updated successfully.");
                        // Refresh the account data by calling the LoadAccountData method
                        LoadAccountData();
                    }
                    else
                    {
                        MessageBox.Show("Username not found. No update performed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating account: " + ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to remove.");
                return;
            }

            // Get the selected row
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            // Get the username of the selected row
            string username = row.Cells["usernameDataGridViewTextBoxColumn"].Value.ToString();

            try
            {
                // Delete the selected row from the database
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    string query = "DELETE FROM account WHERE username = @Username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account removed successfully.");
                        // Refresh the account data by calling the LoadAccountData method
                        LoadAccountData();
                    }
                    else
                    {
                        MessageBox.Show("Username not found. No removal performed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing account: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminSide AdminSide1 = new AdminSide();
            AdminSide1.Show();
            this.Hide();
        }
    }
}

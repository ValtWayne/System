using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string CONNECTION_STRING = @"Data Source=desktop-nkhikgr\sqlexpress;Initial Catalog=Register;Integrated Security=True;";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string username = TBUsername.Text;
            string password = TBPass.Text;

            AuthenticateUser(username, password);   
        }
        private void AuthenticateUser(string username, string enteredPassword)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                string query = "SELECT password FROM account WHERE username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    try
                    {
                        connection.Open();
                        string hashedPasswordFromDatabase = (string)command.ExecuteScalar();

                        if (hashedPasswordFromDatabase != null)
                        {
                            // Hash the entered password for comparison
                            string hashedEnteredPassword = HashPassword(enteredPassword);

                            // Compare the hashed entered password with the hash from the database
                            if (hashedEnteredPassword == hashedPasswordFromDatabase)
                            {
                                Main loginForm = new Main();
                                loginForm.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username or password.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
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

        private void CBShowPass_CheckedChanged(object sender, EventArgs e)
        {
            TBPass.UseSystemPasswordChar = !CBShowPass.Checked;
        }

        private void BTNAdmin_Click(object sender, EventArgs e)
        {
            admin back = new admin();
            back.Show();
            this.Hide();
        }
    }

}

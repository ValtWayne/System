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
    public partial class Form2 : Form
    {
        private string CONNECTION_STRING = @"Data Source=DESKTOP-NKHIKGR\SQLEXPRESS;Initial Catalog = HR; Integrated Security = True";
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new LOGIN();
            myForm.Show();
            Hide();
        }

        private void BTNLOGIN_Click(object sender, EventArgs e)
        {
            string username = TFUSER.Text.ToString();
            string password = TFPASS.Text.ToString();
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                DialogResult dialogResult = MessageBox.Show("Enter Username and Password", "ERROR", MessageBoxButtons.OK);
            }
            else {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM user_table WHERE username ='" + username + "' AND password = '" + password + "'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    admin adm = new admin();
                    adm.Show();
                    Hide();
                }
                else {
                    MessageBox.Show("Username or Password incorrect");
                
                }

                conn.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

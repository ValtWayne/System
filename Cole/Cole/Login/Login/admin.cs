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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        private string CONNECTION_STRING = @"Data Source=desktop-nkhikgr\sqlexpress;Initial Catalog=Register;Integrated Security=True;";
        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string username = TBUsername.Text.ToString();
            string password = TBPass.Text.ToString();
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                DialogResult dialogResult = MessageBox.Show("Enter Username and Password", "ERROR", MessageBoxButtons.OK);
            }
            else
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM admin_table WHERE username ='" + username + "' AND password = '" + password + "'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    AdminSide adm = new AdminSide();
                    adm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password incorrect");

                }

                conn.Close();
            }
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
            this.Hide();
        }

        private void TBUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBShowPass_CheckedChanged(object sender, EventArgs e)
        {
            TBPass.UseSystemPasswordChar = !CBShowPass.Checked;
        }
    }
}

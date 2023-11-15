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

namespace HotelReservation
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRDataSet7.reserve_table' table. You can move, or remove it, as needed.
            this.reserve_tableTableAdapter1.Fill(this.hRDataSet7.reserve_table);

            dataGridView1.DataSource = null;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var myForm = new Form4();
            myForm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NKHIKGR\SQLEXPRESS;Initial Catalog=HR;Integrated Security=True"))
            {
                conn.Open();

                // Check availability
                string availabilityQuery = "SELECT Room_ID, Room_Class, Available_Date, Price FROM reserve_table WHERE Room_Class = @Room_Class AND Available_Date = @Available_Date";
                using (SqlCommand availabilityCmd = new SqlCommand(availabilityQuery, conn))
                {
                    availabilityCmd.Parameters.AddWithValue("@Room_Class", ClassType);
                    availabilityCmd.Parameters.AddWithValue("@Available_Date", Avail.Value.ToString("yyyy-MM-dd"));

                    using (SqlDataReader reader = availabilityCmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Room is available, display the results
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            // Room is not available, show a message
                            MessageBox.Show("Room not available for the selected date and type.");

                            dataGridView1.DataSource = null;
                        }
                    }
                }
            }
        }
        private void Form_Load(object sender, EventArgs e)
        {
            // Set the DataGridView DataSource to null when the form is loaded
            dataGridView1.DataSource = null;
        }
    }
}

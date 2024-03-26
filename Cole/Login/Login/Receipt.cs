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

        public Receipt(string username)
        {
            InitializeComponent();
 


        }


        private void Receipt_Load(object sender, EventArgs e)
        {

        }
    }
}

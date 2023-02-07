using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace mainhun
{
    public partial class voting : Form
    {
        SqlConnection con = new SqlConnection("Data source = sqlserver.dynamicdna .co.za; initial catalog= voting-thendo; password=zxchvf ");
        public voting()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }

        private void voting_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO vote values(@fullname,@email,@vote)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@fullname", button1.Text);
                cmd.Parameters.AddWithValue("@email", button1.Text);
                cmd.Parameters.AddWithValue("@vote",button1.Text);
                SqlCommand sda = new SqlCommand();
                MessageBox.Show("Vote add");
                con.Close();
                MessageBox.Show("Vote add");
            }
            catch (Exception) { MessageBox.Show("failed to vote"); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

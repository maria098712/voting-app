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

namespace mainhun
{
    public partial class Form1 : Form

    {
    
        SqlConnection con = new SqlConnection("Data source = sqlserver.dynamicdna .co.za; initial catalog= voting-thendo; password=zxchvf ");

        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Register rf = new Register();
            this.Hide();
            rf.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text != "" || textBox2.Text !="")
            {
                // voting mainForm = new voting();
                //ainForm.ShowDialog();
                MessageBox.Show("login successfully");
                Register rf = new Register();
                rf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Full name and email are required.");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
